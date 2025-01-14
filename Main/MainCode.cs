using ClosedXML.Excel;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.IO;
using System.Globalization;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using BorderStyle = System.Windows.Forms.BorderStyle;
namespace InventarioExcel
{
    public partial class MainCode : Form
    {
        public MainCode()
        {
            InitializeComponent();
        }
        // Configurar el StatusBar


        

        // Métodos para abrir el archivo
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls",
                Title = "Seleccionar archivo Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Validar extensión del archivo para asegurar que es soportado
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".xlsx" || extension == ".xls")
                {
                    await Task.Run(() => ShowExcelColumns(filePath)); // Cargar Excel en segundo plano
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es un formato Excel válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        // Método para cargar a la vista y limpiar caracteres no deseados
        private void ShowExcelColumns(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); // Primera hoja del Excel
                    DataTable dataTable = new DataTable();
                    var firstRow = worksheet.Row(1); // Fila de encabezados

                    // Lista de ComboBox
                    var comboBoxes = new List<ComboBox>
            {
                comboBoxUPC, comboBox10, comboBoxAtrib, comboBoxTalla,
                comboBox4, comboBoxCab, comboBox6, comboBoxDetalle_item, comboBoxPrecio, comboBoxCostoEstandar, comboBoxNivel2, comboBoxNivel3, comboBoxNivel4, comboBoxNivel5
            };

                    this.Invoke(new Action(() =>
                    {
                        // Limpiar los ComboBox
                        foreach (var comboBox in comboBoxes)
                        {
                            comboBox.Items.Clear();
                        }
                    }));

                    // Agregar columnas al DataTable y a los ComboBox
                    foreach (var cell in firstRow.CellsUsed())
                    {
                        string columnName = CleanString(cell.GetValue<string>()); // Limpiar caracteres
                        if (!string.IsNullOrEmpty(columnName))
                        {
                            dataTable.Columns.Add(columnName);

                            this.Invoke(new Action(() =>
                            {
                                foreach (var comboBox in comboBoxes)
                                {
                                    comboBox.Items.Add(columnName);
                                }
                            }));
                        }
                    }

                    // Cargar datos al DataTable
                    foreach (var row in worksheet.RowsUsed().Skip(1)) // Saltar encabezado
                    {
                        DataRow dataRow = dataTable.NewRow();
                        int columnIndex = 0;

                        foreach (var cell in row.Cells(1, dataTable.Columns.Count))
                        {
                            string cellValue = CleanString(cell.GetValue<string>()); // Limpiar caracteres
                            dataRow[columnIndex] = string.IsNullOrEmpty(cellValue) ? DBNull.Value : cellValue;
                            columnIndex++;
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    this.Invoke(new Action(() =>
                    {
                        dataGridView.DataSource = dataTable;
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show($"Error al procesar el archivo Excel: {ex.Message}", "Error");
                }));
                RegistrarLog($"Error al cargar el archivo Excel: {ex.Message}", true);
            }
        }

        // Método para limpiar caracteres no deseados
        private string CleanString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Normalizar el texto eliminando acentos y tildes
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            char[] buffer = normalizedString
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark) // Remover marcas diacríticas
                .ToArray();
            string cleanString = new string(buffer);

            // Conservar caracteres específicos como ñ, Ñ, paréntesis y espacios
            cleanString = Regex.Replace(cleanString, @"[^a-zA-Z0-9\sñÑ\(\)]", ""); // Remover caracteres no deseados excepto paréntesis, ñ, y espacios

            // Retornar texto limpio y sin espacios innecesarios
            return cleanString.Trim();
        }

        private void btnSubirBD_Click(object sender, EventArgs e)
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";
            string tipoInventario = rbArticulo.Checked ? "ARTICULO" : "SERVICIO";
            string cantidadDefault = "0";
            string localidad = "ALM1";
            string undVentaDefault = "UND";
            int compVentaDefault = 1;
            string undCompraDefault = "UND";
            int compCompraDefault = 1;
            string undAlmacenamientoDefault = "UND";
            int compAlmacenamientoDefault = 1;

            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
                RegistrarLog("Se avanzó a la siguiente pestaña Historial de actividades ");

            }

            // Definir los valores predeterminados de CANT_MAX y CANT_MIN
            int cantMaxDefault = 100;
            int cantMinDefault = 0;

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Contar la cantidad de registros a insertar
                    int cantidadRegistros = dataGridView.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow);

                    // Generar códigos consecutivos a partir de SECUENCIAS
                    List<int> codigosItem = GenerateNewCodigoItems(connection, cantidadRegistros);
                    int codigoIndex = 0;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Obtener valores de las columnas seleccionadas
                           
                         
                            string atrib = GetCellValue(row, comboBoxTalla.SelectedItem?.ToString());
                            string talla = GetCellValue(row, comboBox4.SelectedItem?.ToString());
                            string upc = GetCellValue(row, comboBox6.SelectedItem?.ToString());

                            string proveedor = GetCellValue(row, comboBox10.SelectedItem?.ToString());
                            string departamento = GetCellValue(row, comboBoxUPC.SelectedItem?.ToString());
                            string desc1 = GetCellValue(row, comboBoxAtrib.SelectedItem?.ToString());

                            string detalleItem = GetCellValue(row, comboBoxDetalle_item.SelectedItem?.ToString());
                            string cab = GetCellValue(row, comboBoxCab.SelectedItem?.ToString());


                            string precioStr = GetCellValue(row, comboBoxPrecio.SelectedItem?.ToString());
                            decimal precio = decimal.TryParse(precioStr, out decimal parsedPrecio) ? parsedPrecio : 0;

                            string costoStr = GetCellValue(row, comboBoxCostoEstandar.SelectedItem?.ToString());
                            decimal costo = decimal.TryParse(costoStr, out decimal parsedcostoStr) ? parsedcostoStr : 0;


                            string Nivel1Str = GetCellValue(row, comboBoxNivel2.SelectedItem?.ToString());
                            decimal nivel_1 = decimal.TryParse(Nivel1Str, out decimal parsednivel_1Str) ? parsednivel_1Str : 0;

                            string Nivel3Str = GetCellValue(row, comboBoxNivel3.SelectedItem?.ToString());
                            decimal nivel_3 = decimal.TryParse(Nivel3Str, out decimal parsednivel_3Str) ? parsednivel_3Str : 0;

                            string Nivel4Str = GetCellValue(row, comboBoxNivel4.SelectedItem?.ToString());
                            decimal nivel_4 = decimal.TryParse(Nivel4Str, out decimal parsednivel_4Str) ? parsednivel_4Str : 0;

                            string Nivel5Str = GetCellValue(row, comboBoxNivel5.SelectedItem?.ToString());
                            decimal nivel_5 = decimal.TryParse(Nivel5Str, out decimal parsednivel_5Str) ? parsednivel_5Str : 0;






                            // Obtener IDs para proveedor y departamento
                            int proveedorId = !string.IsNullOrEmpty(proveedor)
                                ? GetOrCreateProveedorId(connection, proveedor)
                                : Convert.ToInt32(comboBoxProveedor.SelectedValue);

                            int departamentoId = !string.IsNullOrEmpty(departamento)
                                ? GetOrCreateDepartamentoId(connection, departamento)
                                : Convert.ToInt32(comboBoxDepartamento.SelectedValue);

                            // Obtener el siguiente código único generado
                            int codigoItem = codigosItem[codigoIndex++];

                            // Obtener impuestos
                            DataRowView impuestoVentaSeleccionado = comboBoxImpuestoventas.SelectedItem as DataRowView;
                            DataRowView impuestoCompraSeleccionado = comboBoxImpuestoCompra.SelectedItem as DataRowView;

                            int impuestoVentaId = Convert.ToInt32(impuestoVentaSeleccionado?["ID"] ?? 0);
                            int impuestoCompraId = Convert.ToInt32(impuestoCompraSeleccionado?["ID"] ?? 0);

                            decimal impuestoCompraPorc = GetImpuestoPorc(connection, impuestoCompraId);

                            FbCommand cmdInventarioCompleto = new FbCommand(
   "INSERT INTO INVENTARIO (CODIGO_ITEM, PROVEEDOR_ID, DEPARTAMENTO_ID, DESC1, ATRIB, TALLA, UPC, LOCALIDAD, TIPO, " +
   "UND_MEDIDA, IMPUESTO_ID, IMPUESTO_COMPRA_ID, IMPUESTO_PORC, IIMPUESTO_COMPRA_PORC, DETALLE_ITEM, TIPO_ART, ESTATUS_DEL, FECHA_REG, CONTROL_LOTE, USUARIO, MOSTRAR_EN_COLOR, ACOMPANAMIENTO, " +
   "CANT_MAX, CANT_MIN, ALU, FECHA_PRIM_RECEP, MARGEN_PORC, MARGEN_PESO, ONDETAIL, FECHA_ULT_RECEP, CANT_CAJA2, CANT_CAJA3, CANT_CAJA4, CANT_CAJA5, " +
   "CANT_CAJA6, CANT_CAJA7, CANT_CAJA8, CANT_CAJA9, CANT_CAJA10, DIAS_AVISO_VENCIMIENTO, SELEC_ELIMINAR, PRECIO_IMP, COSTO_PROMEDIO, COSTO_ULTIMO, IMPRIMIR_EN_COMANDA, LOTE_REQ_FECHA_VENCIMIENTO, PRECIO,COSTO, PRECIO_NIVEL2, PRECIO_NIVEL3, PRECIO_NIVEL4, PRECIO_NIVEL5) " +
   "VALUES (@CodigoItem, @ProveedorId, @DepartamentoId, @Desc1, @Atrib, @Talla, @UPC, @Localidad, @Tipo, " +
   "@UnidadMedida, @ImpuestoVentaId, @ImpuestoCompraId, @ImpuestoPorc, @ImpuestoCompraPorc, @DetalleItem, @TipoArt, @EstatusDel, CURRENT_DATE, @ControlLote, @Usuario, @MostrarEnColor, @Acompanamiento, " +
   "@CantMax, @CantMin, @Alu, @FechaPrimRecep, @MargenPorc, @MargenPeso, @OnDetail, @FechaUltRecep, @CantCaja2, @CantCaja3, @CantCaja4, @CantCaja5, " +
   "@CantCaja6, @CantCaja7, @CantCaja8, @CantCaja9, @CantCaja10, @DiasAvisoVencimiento, @SelecEliminar, @PrecioImp, @CostoPromedio, @CostoUltimo, @ImprimirEnComanda, @LoteReqFechaVencimiento,@Precio, @Costo, @Precio_nivel2,@Precio_nivel3, @Precio_nivel4, @Precio_nivel5)",
   connection);

                            // Parámetros para el comando (ajustados)
                            cmdInventarioCompleto.Parameters.AddWithValue("@CodigoItem", codigoItem);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ProveedorId", proveedorId);
                            cmdInventarioCompleto.Parameters.AddWithValue("@DepartamentoId", departamentoId);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Desc1", (object)desc1 ?? DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Atrib", (object)atrib ?? DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Talla", (object)talla ?? DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@UPC", (object)upc ?? DBNull.Value);

                            cmdInventarioCompleto.Parameters.AddWithValue("@Localidad", localidad);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Tipo", tipoInventario);
                            cmdInventarioCompleto.Parameters.AddWithValue("@UnidadMedida", comboBoxUnidad.SelectedItem?.ToString() ?? "UND");
                            cmdInventarioCompleto.Parameters.AddWithValue("@ImpuestoVentaId", impuestoVentaId);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ImpuestoCompraId", impuestoCompraId);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ImpuestoPorc", impuestoCompraPorc);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ImpuestoCompraPorc", impuestoCompraPorc);
                            cmdInventarioCompleto.Parameters.AddWithValue("@DetalleItem", (object)detalleItem ?? DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@TipoArt", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@EstatusDel", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ControlLote", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Usuario", 1);
                            cmdInventarioCompleto.Parameters.AddWithValue("@MostrarEnColor", "clWindow");
                            cmdInventarioCompleto.Parameters.AddWithValue("@Acompanamiento", "NO");
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantMax", cantMaxDefault);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantMin", cantMinDefault);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Alu", (object)cab ?? DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Precio", precio);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Costo", costo);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Precio_nivel2", nivel_1);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Precio_nivel3", nivel_3);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Precio_nivel4", nivel_4);
                            cmdInventarioCompleto.Parameters.AddWithValue("@Precio_nivel5", nivel_5);
                            cmdInventarioCompleto.Parameters.AddWithValue("@FechaPrimRecep", DateTime.Now);
                            cmdInventarioCompleto.Parameters.AddWithValue("@MargenPorc", 0); // Asegurado en 0
                            cmdInventarioCompleto.Parameters.AddWithValue("@MargenPeso", 0); // Asegurado en 0
                            cmdInventarioCompleto.Parameters.AddWithValue("@OnDetail", 0); // Asegurado en 0

                            cmdInventarioCompleto.Parameters.AddWithValue("@FechaUltRecep", DateTime.Now);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja2", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja3", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja4", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja5", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja6", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja7", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja8", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja9", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@CantCaja10", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@DiasAvisoVencimiento", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@SelecEliminar", "N");
                            cmdInventarioCompleto.Parameters.AddWithValue("@PrecioImp", 0);  // Asegurado en 0
                            cmdInventarioCompleto.Parameters.AddWithValue("@CostoPromedio", 0);  // Asegurado en 0
                            cmdInventarioCompleto.Parameters.AddWithValue("@CostoUltimo", 0);
                            cmdInventarioCompleto.Parameters.AddWithValue("@ImprimirEnComanda", DBNull.Value);
                            cmdInventarioCompleto.Parameters.AddWithValue("@LoteReqFechaVencimiento", DBNull.Value);





                            cmdInventarioCompleto.ExecuteNonQuery();

                            // Insertar en EXISTENCIAS
                            FbCommand cmdExistencias = new FbCommand(
                                "INSERT INTO EXISTENCIAS (ITEM_ID, LOCALIDAD, CANTIDAD) " +
                                "VALUES (@CodigoItem, @Localidad, @Cantidad)", connection);
                            cmdExistencias.Parameters.AddWithValue("@CodigoItem", codigoItem);
                            cmdExistencias.Parameters.AddWithValue("@Localidad", "ALM1");
                            cmdExistencias.Parameters.AddWithValue("@Cantidad", cantidadDefault);
                            cmdExistencias.ExecuteNonQuery();

                            // Insertar en INVENTARIO_UND_MEDIDAS
                            FbCommand cmdUndMedidas = new FbCommand(
                                "INSERT INTO INVENTARIO_UND_MEDIDAS (ITEM_ID, UND_VENTA, COMP_VENTA, UND_COMPRA, COMP_COMPRA, UND_ALMACENAMIENTO, COMP_ALMACENAMIENTO) " +
                                "VALUES (@CodigoItem, @UndVenta, @CompVenta, @UndCompra, @CompCompra, @UndAlmacenamiento, @CompAlmacenamiento)", connection);
                            cmdUndMedidas.Parameters.AddWithValue("@CodigoItem", codigoItem);
                            cmdUndMedidas.Parameters.AddWithValue("@UndVenta", undVentaDefault);
                            cmdUndMedidas.Parameters.AddWithValue("@CompVenta", compVentaDefault);
                            cmdUndMedidas.Parameters.AddWithValue("@UndCompra", undCompraDefault);
                            cmdUndMedidas.Parameters.AddWithValue("@CompCompra", compCompraDefault);
                            cmdUndMedidas.Parameters.AddWithValue("@UndAlmacenamiento", undAlmacenamientoDefault);
                            cmdUndMedidas.Parameters.AddWithValue("@CompAlmacenamiento", compAlmacenamientoDefault);
                            cmdUndMedidas.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos subidos exitosamente ", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RegistrarLog("Se envio el posteo'.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al subir datos a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarLog("Error al subir datos a la base de datos. fallo el posteo'.");

            }
        }



        private string GetCellValue(DataGridViewRow row, string column)
        {
            return string.IsNullOrEmpty(column) ? null : row.Cells[column]?.Value?.ToString()?.Trim();

        }




        // Método para obtener el porcentaje de impuesto de la tabla IMPUESTOS
        private decimal GetImpuestoPorc(FbConnection connection, int impuestoId)
        {
            decimal porcentaje = 0;
            string query = "SELECT RAZON FROM IMPUESTOS WHERE ID = @ImpuestoId";

            using (FbCommand cmd = new FbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ImpuestoId", impuestoId);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Intentar convertir el resultado a decimal
                    if (decimal.TryParse(result.ToString(), out decimal impPorc))
                    {
                        porcentaje = impPorc;

                    }
                    else
                    {
                        // Manejar el caso en que la conversión falle
                        Console.WriteLine($"Error de conversión: El valor de RAZON '{result}' no es un número válido.");
                        RegistrarLog("$Error de conversión: El valor de RAZON '{result}' no es un número válido.");
                    }
                }
            }
            return porcentaje;
        }



        /// <summary>
        /// Verifica si un proveedor existe, y si no, lo crea con los valores predeterminados.
        /// </summary>
        private int GetOrCreateProveedorId(FbConnection connection, string nombreProveedor)
        {
            if (string.IsNullOrEmpty(nombreProveedor))
                throw new Exception("El nombre del proveedor no puede estar vacío.");

            // Verificar si el proveedor ya existe
            FbCommand cmdCheckProveedor = new FbCommand("SELECT ID FROM PROVEEDOR WHERE EMPRESA = @EMPRESA", connection);
            cmdCheckProveedor.Parameters.AddWithValue("@EMPRESA", nombreProveedor);
            object result = cmdCheckProveedor.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int proveedorId))
            {
                RegistrarLog("El proveedor ya existe.");
                return proveedorId; // El proveedor ya existe
            }

            // Obtener el valor de MONEDA_BASE de la tabla CONFIG
            FbCommand cmdGetMonedaBase = new FbCommand("SELECT MONEDA_BASE FROM CONFIG ROWS 1", connection);
            object monedaBaseResult = cmdGetMonedaBase.ExecuteScalar();
            string monedaBase = monedaBaseResult?.ToString();

            if (string.IsNullOrEmpty(monedaBase))
                throw new Exception("No se encontró un valor válido para MONEDA_BASE en la tabla CONFIG.");

            // Crear el proveedor con los valores predeterminados
            FbCommand cmdInsertProveedor = new FbCommand(
                "INSERT INTO PROVEEDOR (EMPRESA, ACTIVO, MONEDA, FECHA) VALUES (@EMPRESA, @Activo, @Moneda, @Fecha) RETURNING ID", connection);
            cmdInsertProveedor.Parameters.AddWithValue("@EMPRESA", nombreProveedor);
            cmdInsertProveedor.Parameters.AddWithValue("@Activo", "SI"); // Valor predeterminado
            cmdInsertProveedor.Parameters.AddWithValue("@Moneda", monedaBase);
            cmdInsertProveedor.Parameters.AddWithValue("@Fecha", DateTime.Now); // Fecha actual

            object newProveedorId = cmdInsertProveedor.ExecuteScalar();

            if (newProveedorId == null || !int.TryParse(newProveedorId.ToString(), out proveedorId))
                throw new Exception("Error al crear el proveedor.");

            RegistrarLog("Proveedor creado exitosamente.");
            return proveedorId; // Retorna el ID del proveedor creado
        }

        /// <summary>
        /// Verifica si un departamento existe, y si no, lo crea y devuelve su ID.
        /// </summary>
        private int GetOrCreateDepartamentoId(FbConnection connection, string departamentoNombre)
        {
            if (string.IsNullOrEmpty(departamentoNombre))
                throw new Exception("El nombre del departamento no puede estar vacío.");

            RegistrarLog("El nombre del departamento no puede estar vacío.");

            try
            {
                // Verificar si el departamento ya existe
                FbCommand checkCmd = new FbCommand("SELECT ID FROM DEPARTAMENTO WHERE NOMBRE_DEPARTAMENTO = @Nombre", connection);
                checkCmd.Parameters.AddWithValue("@Nombre", departamentoNombre);
                object result = checkCmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int departamentoId))
                {
                    return departamentoId; // El departamento ya existe
                }

                // Obtener el valor máximo actual de NO_DEPART
                FbCommand getMaxNoDepartCmd = new FbCommand("SELECT MAX(NO_DEPART) FROM DEPARTAMENTO", connection);
                object maxNoDepartResult = getMaxNoDepartCmd.ExecuteScalar();

                int nextNoDepart = 100; // Valor inicial por defecto
                if (maxNoDepartResult != DBNull.Value && maxNoDepartResult != null && int.TryParse(maxNoDepartResult.ToString(), out int maxNoDepart))
                {
                    nextNoDepart = maxNoDepart + 1; // Incrementar el valor máximo
                }

                // Crear el departamento si no existe
                FbCommand insertCmd = new FbCommand(
                    "INSERT INTO DEPARTAMENTO (NOMBRE_DEPARTAMENTO, ACTIVO, MOSTRAR_EN_COLOR, NO_DEPART) " +
                    "VALUES (@Nombre, @Activo, @MostrarEnColor, @NoDepart) RETURNING ID",
                    connection);
                insertCmd.Parameters.AddWithValue("@Nombre", departamentoNombre);
                insertCmd.Parameters.AddWithValue("@Activo", "SI");
                insertCmd.Parameters.AddWithValue("@MostrarEnColor", "clWindow");
                insertCmd.Parameters.AddWithValue("@NoDepart", nextNoDepart);

                object newDepartamentoId = insertCmd.ExecuteScalar();

                if (newDepartamentoId == null || !int.TryParse(newDepartamentoId.ToString(), out departamentoId))
                    throw new Exception("Error al crear el departamento. ID no generado.");

                // Verificar que el ID generado es válido
                if (departamentoId <= 0)
                    throw new Exception("El ID del departamento generado es inválido.");

                return departamentoId; // Retorna el ID del departamento creado
            }
            catch (Exception ex)
            {
                RegistrarLog($"Error en GetOrCreateDepartamentoId: {ex.Message}");
                throw new Exception($"Error en GetOrCreateDepartamentoId: {ex.Message}");
            }
        }


        /// <summary>
        /// Genera y asigna códigos únicos para CODIGO_ITEM a partir de la tabla SECUENCIAS.
        /// </summary>
        /// <param name="connection">Conexión activa a la base de datos.</param>
        /// <param name="cantidadRegistros">Cantidad de registros a insertar.</param>
        /// <returns>Lista de códigos generados secuenciales.</returns>
        private List<int> GenerateNewCodigoItems(FbConnection connection, int cantidadRegistros)
        {
            List<int> codigosGenerados = new List<int>();
            int inicioCodigo;

            // Consultas para SECUENCIAS
            string selectQuery = "SELECT INV FROM SECUENCIAS FOR UPDATE";
            string updateQuery = "UPDATE SECUENCIAS SET INV = @NuevoValor";

            using (FbTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    // 1. Obtener el valor actual de INV
                    using (FbCommand selectCmd = new FbCommand(selectQuery, connection, transaction))
                    {
                        object result = selectCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int currentINV))
                        {
                            inicioCodigo = currentINV; // Valor inicial para los nuevos registros
                        }
                        else
                        {
                            RegistrarLog("Error al obtener el valor actual de INV en SECUENCIAS.");
                            throw new Exception("Error al obtener el valor actual de INV en SECUENCIAS.");

                        }
                    }

                    // 2. Generar los códigos secuenciales y agregar a la lista
                    for (int i = 0; i < cantidadRegistros; i++)
                    {
                        codigosGenerados.Add(inicioCodigo + i);
                    }

                    // 3. Actualizar la tabla SECUENCIAS con el último valor + 1
                    using (FbCommand updateCmd = new FbCommand(updateQuery, connection, transaction))
                    {
                        int nuevoValorINV = inicioCodigo + cantidadRegistros;
                        updateCmd.Parameters.AddWithValue("@NuevoValor", nuevoValorINV);
                        updateCmd.ExecuteNonQuery();
                    }

                    // 4. Confirmar la transacción
                    transaction.Commit();

                    return codigosGenerados;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    RegistrarLog("Error al generar nuevos CODIGO_ITEM: " + ex.Message);
                    throw new Exception("Error al generar nuevos CODIGO_ITEM: " + ex.Message);
                }
            }
        }






        // Método auxiliar para obtener el valor de una celda





        private void rbServicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbArticulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxColumnas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarCamposDesdeBaseDeDatos()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener los nombres de las columnas de la tabla deseada
                    string query = @"
                SELECT FIRST 1 
                    PROVEEDOR_ID, 
                    DEPARTAMENTO_ID, 
                    DESC1, 
                    ATRIB, 
                    TALLA, 
                    UPC,
                 CODIGO_BARRA1
                FROM INVENTARIO";

                    FbCommand command = new FbCommand(query, connection);
                    FbDataAdapter adapter = new FbDataAdapter(command);

                    // Crear un DataTable para cargar los datos
                    DataTable schemaTable = new DataTable();

                    // Llenar el DataTable con los nombres de las columnas
                    adapter.FillSchema(schemaTable, SchemaType.Source);

                    // Crear un nuevo DataTable con los nombres de las columnas
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Columna", typeof(string));

                    // Agregar los nombres de las columnas al DataTable
                    foreach (DataColumn column in schemaTable.Columns)
                    {
                        dt.Rows.Add(column.ColumnName);
                    }

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dataGridView2.DataSource = dt;

                    // Configurar la visualización
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.Columns["Columna"].HeaderText = "Campos de la Base de Datos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar campos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // Estilo general del DataGridView
            dataGridView2.BorderStyle = (BorderStyle)NPOI.SS.UserModel.BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;

            // Estilo para las celdas
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightBlue;  // Color de fondo cuando está seleccionado
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;     // Color de texto cuando está seleccionado
            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 10);      // Fuente legible y moderna

            // Estilo para el encabezado
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar líneas horizontales y verticales
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.GridColor = Color.LightGray;

            // Ajustar el tamaño de las columnas para que se adapten al contenido
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Añadir padding a las celdas para que el contenido no se pegue a los bordes
            dataGridView2.DefaultCellStyle.Padding = new Padding(5);

            // Alternar colores de las filas (como se ve en la imagen)
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }




        private void ConfigurarComboBoxes()
        {
            // Lista de los ComboBoxes que deseas estilizar
            ComboBox[] comboBoxes = { comboBoxUPC, comboBox10, comboBoxAtrib, comboBoxTalla, comboBox4, comboBoxCab, comboBox6, comboBoxDetalle_item, comboBoxPrecio, comboBoxCostoEstandar, comboBoxNivel2, comboBoxNivel3, comboBoxNivel4, comboBoxNivel5 };

            foreach (var comboBox in comboBoxes)
            {
                comboBox.FlatStyle = FlatStyle.Flat;         // Estilo plano
                comboBox.BackColor = Color.White;            // Fondo blanco
                comboBox.ForeColor = Color.Black;            // Texto negro
                comboBox.Font = new Font("Segoe UI", 10);    // Fuente moderna y clara
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Solo selección (no editable)
                comboBox.Height = 30;                        // Altura de los comboBoxes (ajustar según necesidad)
                comboBox.Margin = new Padding(5);
                // Espaciado interno

                // Modificar bordes y color cuando el ComboBox esté seleccionado
                // Color de borde
            }
        }

        private void RegistrarLog(string mensaje, bool esError = false)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string logMensaje = $"{timestamp} - {(esError ? "ERROR" : "INFO")}: {mensaje}";

                // Mostrar en RichTextBox
                richTextBoxLogs.AppendText(logMensaje + Environment.NewLine);

                // Determinar la ruta del archivo de log
                string logFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyAppLogs");
                if (!Directory.Exists(logFolder))
                {
                    Directory.CreateDirectory(logFolder);
                }

                string logFilePath = Path.Combine(logFolder, "logs.txt");

                // Guardar en archivo de texto
                File.AppendAllText(logFilePath, logMensaje + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción al intentar guardar el log
                richTextBoxLogs.AppendText($"No se pudo guardar el log: {ex.Message}{Environment.NewLine}");
            }
        }

        private void ConfigurarStatusBar()
        {
            // Crear un StatusStrip
            StatusStrip statusStrip = new StatusStrip();

            // Crear la primera etiqueta (JamenSoft)
            ToolStripStatusLabel labelIzquierda = new ToolStripStatusLabel
            {
                Text = "JamenSoft",
                TextAlign = ContentAlignment.MiddleLeft,
                Spring = true // Ocupa el espacio restante
            };

            // Crear la segunda etiqueta (Versión 1.0)
            ToolStripStatusLabel labelDerecha = new ToolStripStatusLabel
            {
                Text = "Versión 1.0",
                TextAlign = ContentAlignment.MiddleRight
            };

            // Agregar las etiquetas al StatusStrip
            statusStrip.Items.Add(labelIzquierda);
            statusStrip.Items.Add(labelDerecha);

            // Agregar el StatusStrip al formulario
            this.Controls.Add(statusStrip);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistrarLog("Aplicación iniciada y logs cargados.");
            CargarCamposDesdeBaseDeDatos();
            CargarProveedores();
            CargarLocalidades();
            ActualizarComboBoxDepartamentos();
            CargarUnidadesMedida();
            ActualizarComboBoxProveedores();
            CustomizeDataGridView();
            ConfigurarStatusBar();
            // Ocultar las pestañas visibles en la parte superior
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1); // Reduce el tamaño de las pestañas a 0
            tabControl1.SizeMode = TabSizeMode.Fixed; // Fija el tamaño para que aplique

            // Mostrar directamente el contenido de la pestaña 1
            tabControl1.SelectedTab = tabPage1;

            // Registrar log de inicio
            RegistrarLog("La aplicación se inició mostrando solo el contenido de la pestaña 1.");

            // Configuración del DataGridView
            ConfigurarDataGridView();

            // Configuración de los ComboBox
            ConfigurarComboBoxes();


            string logFilePath = "logs.txt";
            if (File.Exists(logFilePath))
            {
                string[] logs = File.ReadAllLines(logFilePath);
                foreach (string log in logs)
                {
                    richTextBoxLogs.AppendText(log + Environment.NewLine);
                }
            }
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Cargar datos de la tabla IMPUESTOS
                    FbCommand cmdSelectImpuestos = new FbCommand("SELECT ID, IMPUESTO FROM IMPUESTOS", connection);
                    FbDataAdapter adapter = new FbDataAdapter(cmdSelectImpuestos);
                    DataTable impuestos = new DataTable();
                    adapter.Fill(impuestos);

                    // Asignar datos al comboBoxImpuestoventas
                    comboBoxImpuestoventas.DataSource = impuestos.Copy();
                    comboBoxImpuestoventas.DisplayMember = "IMPUESTO";
                    comboBoxImpuestoventas.ValueMember = "ID";

                    // Asignar datos al comboBoxImpuestoCompra
                    comboBoxImpuestoCompra.DataSource = impuestos.Copy();
                    comboBoxImpuestoCompra.DisplayMember = "IMPUESTO";
                    comboBoxImpuestoCompra.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los impuestos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Ajuste en la consulta para incluir tanto 'SI' como '1' en el campo ACTIVO
                    string query = "SELECT ID, NOMBRE_DEPARTAMENTO FROM DEPARTAMENTO WHERE ACTIVO IN ('SI', '1')";
                    FbCommand cmd = new FbCommand(query, connection);
                    FbDataReader reader = cmd.ExecuteReader();

                    var departamentos = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        departamentos.Add(reader.GetInt32(0), reader.GetString(1)); // Cargar ID y NOMBRE_DEPARTAMENTO
                    }

                    // Configurar el comboBox
                    comboBoxDepartamento.DataSource = new BindingSource(departamentos, null);
                    comboBoxDepartamento.DisplayMember = "Value"; // Mostrar nombres
                    comboBoxDepartamento.ValueMember = "Key";     // Usar IDs como valor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar departamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarProveedores()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, EMPRESA FROM PROVEEDOR WHERE ACTIVO IN ('SI', '1')";
                    FbCommand cmd = new FbCommand(query, connection);
                    FbDataReader reader = cmd.ExecuteReader();

                    var proveedores = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string empresa = reader.IsDBNull(1) ? string.Empty : reader.GetString(1); // Manejo de posibles valores NULL
                        proveedores.Add(id, empresa);
                    }

                    Console.WriteLine($"Número de proveedores encontrados: {proveedores.Count}"); // Para depuración

                    if (proveedores.Count > 0)
                    {
                        // Asignar la fuente de datos al comboBox
                        comboBoxProveedor.Items.Clear();
                        comboBoxProveedor.DataSource = new BindingSource(proveedores, null);
                        comboBoxProveedor.DisplayMember = "Value"; // Mostrar el campo EMPRESA
                        comboBoxProveedor.ValueMember = "Key";     // Usar ID como valor
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron proveedores en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {ex.Message}"); // Para depuración
            }
        }


        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomizeDataGridView()
        {
            // Quitar bordes
            dataGridView.BorderStyle = BorderStyle.None;

            // Cambiar el estilo de las celdas
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Modificar el fondo
            dataGridView.BackgroundColor = Color.White;

            // Quitar el marco de la fila seleccionada
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Estilizar las filas
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer color de las cabeceras
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Establecer el tamaño de las celdas
            dataGridView.RowTemplate.Height = 35;
            dataGridView.ColumnHeadersHeight = 40;

            // Desactivar la edición y la selección
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarLocalidades()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";
            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID, LOCALIDADNOMBRE FROM LOCALIDAD";
                    FbDataAdapter adapter = new FbDataAdapter(query, connection);
                    DataTable localidades = new DataTable();
                    adapter.Fill(localidades);

                    // Enlazar los datos al ComboBox
                    comboBoxLocalidad.DataSource = localidades;
                    comboBoxLocalidad.DisplayMember = "LOCALIDADNOMBRE";
                    comboBoxLocalidad.ValueMember = "ID";

                    // Seleccionar ALM1 si existe
                    DataRow[] foundRows = localidades.Select("LOCALIDADNOMBRE = 'ALM1'");
                    if (foundRows.Length > 0)
                    {
                        int selectedIndex = localidades.Rows.IndexOf(foundRows[0]);
                        comboBoxLocalidad.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        comboBoxLocalidad.SelectedIndex = -1; // Deseleccionar si ALM1 no existe
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las localidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ActualizarComboBoxDepartamentos()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Cargar datos de la tabla DEPARTAMENTO
                    FbCommand cmdSelectDepartamentos = new FbCommand(
                        "SELECT ID, NOMBRE_DEPARTAMENTO FROM DEPARTAMENTO", connection);
                    FbDataAdapter adapter = new FbDataAdapter(cmdSelectDepartamentos);
                    DataTable departamentos = new DataTable();
                    adapter.Fill(departamentos);

                    // Asignar los datos al comboBoxDepartamento
                    comboBoxDepartamento.DataSource = departamentos;
                    comboBoxDepartamento.DisplayMember = "NOMBRE_DEPARTAMENTO";
                    comboBoxDepartamento.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los departamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textCrearDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void ActualizarComboBoxProveedores()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Ajustar la consulta para filtrar por ACTIVO como texto "SI"
                    FbCommand cmdSelectProveedores = new FbCommand(
                        "SELECT ID, EMPRESA FROM PROVEEDOR WHERE ACTIVO = 'SI'", connection);
                    FbDataAdapter adapter = new FbDataAdapter(cmdSelectProveedores);
                    DataTable proveedores = new DataTable();
                    adapter.Fill(proveedores);

                    // Asignar los datos al ComboBox
                    comboBoxProveedor.DataSource = proveedores;
                    comboBoxProveedor.DisplayMember = "EMPRESA";
                    comboBoxProveedor.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBoxUnidad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(seleccion))
            {

            }
        }

        private void CargarUnidadesMedida()
        {
            string connectionString = "User=SYSDBA;Password=masterkey;Database=C:\\NemeSys\\Database\\NEMESYSDB.IB;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;";

            try
            {
                using (FbConnection connection = new FbConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener las SIGLAS
                    FbCommand cmd = new FbCommand("SELECT SIGLAS FROM UNIDADES_MEDIDAS", connection);

                    using (FbDataReader reader = cmd.ExecuteReader())
                    {
                        comboBoxUnidad.Items.Clear(); // Limpiar el ComboBox antes de llenarlo

                        while (reader.Read())
                        {
                            string sigla = reader["SIGLAS"].ToString();
                            comboBoxUnidad.Items.Add(sigla);
                        }
                    }
                }

                // Seleccionar "UND" por defecto si existe
                if (comboBoxUnidad.Items.Contains("UND"))
                {
                    comboBoxUnidad.SelectedItem = "UND";
                }
                else
                {
                    comboBoxUnidad.SelectedIndex = -1; // Deseleccionar si "UND" no existe
                }

                RegistrarLog("Unidades de medida cargadas exitosamente.");
            }
            catch (FbException ex)
            {
                MessageBox.Show($"Error al cargar las unidades de medida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarLog($"Error al cargar las unidades de medida: {ex.Message}", true);
            }
        }


        private void comboBoxImpuestoventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImpuestoventas.SelectedValue != null && comboBoxImpuestoventas.SelectedValue is int)
            {
                int selectedId = (int)comboBoxImpuestoventas.SelectedValue;
                string selectedImpuesto = comboBoxImpuestoventas.Text;


                RegistrarLog($"Impuesto de ventas seleccionado: ID={selectedId}, Impuesto={selectedImpuesto}");
            }
        }

        private void comboBoxImpuestoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImpuestoCompra.SelectedValue != null && comboBoxImpuestoCompra.SelectedValue is int)
            {
                int selectedId = (int)comboBoxImpuestoCompra.SelectedValue;
                string selectedImpuesto = comboBoxImpuestoCompra.Text;


                RegistrarLog($"Impuesto de Compras seleccionado: ID={selectedId}, Impuesto={selectedImpuesto}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Efecto visual al hacer clic en la primera pestaña
            ChangeTabAppearance(tabPage1);
            RegistrarLog("Se abrió la pestaña 1: 'Cargar el Excel'.");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Efecto visual al hacer clic en la segunda pestaña
            ChangeTabAppearance(tabPage2);
            RegistrarLog("Se abrió la pestaña 2: 'Columnas a insertar'.");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            // Efecto visual al hacer clic en la tercera pestaña
            ChangeTabAppearance(tabPage3);
            RegistrarLog("Se abrió la pestaña 3: 'Enviar posteo'.");
        }

        private void ChangeTabAppearance(TabPage tabPage)
        {


        }

        private void listBoxIzquierdoDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }



        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
                RegistrarLog("Se avanzó a la siguiente pestaña Insertar ");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
                RegistrarLog("Se retrocedió a la pestaña anterior de insertar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
                RegistrarLog("Se avanzó a la siguiente pestaña del cargar excel");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
            }
            RegistrarLog("Se retrocedió a la pestaña anterior ");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void comboBoxDetalle_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void comboBoxCab_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUPC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAtrib_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void comboBoxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void richTextBoxLogs_TextChanged(object sender, EventArgs e)
        {
            // Evitar que el evento se dispare innecesariamente cuando se cambia el texto desde el código
            richTextBoxLogs.SelectionChanged -= richTextBoxLogs_TextChanged;

            // Configura el color y tipo de letra general para los logs
            richTextBoxLogs.Font = new Font("Arial", 10, FontStyle.Regular);
            richTextBoxLogs.ForeColor = Color.Black;

            // Establece un comportamiento de desplazamiento automático
            richTextBoxLogs.ScrollToCaret();

            // Ejemplo de formato para un mensaje de error
            string logMessage = "Error: Hubo un problema al cargar el archivo.";
            AppendLog(logMessage, Color.Red, FontStyle.Bold);

            // Ejemplo de formato para un mensaje de advertencia
            logMessage = "Advertencia: El archivo está vacío.";
            AppendLog(logMessage, Color.Orange, FontStyle.Italic);

            // Ejemplo de formato para un mensaje informativo
            logMessage = "Información: El proceso se completó exitosamente.";
            AppendLog(logMessage, Color.Green, FontStyle.Regular);

            // Reactivar el evento de selección
            richTextBoxLogs.SelectionChanged += richTextBoxLogs_TextChanged;
        }

        // Método para agregar logs con formato personalizado
        private void AppendLog(string message, Color textColor, FontStyle fontStyle)
        {
            // Guardar la posición actual del cursor
            int currentPos = richTextBoxLogs.SelectionStart;

            // Establecer el color y estilo de la fuente
            richTextBoxLogs.SelectionColor = textColor;
            richTextBoxLogs.SelectionFont = new Font(richTextBoxLogs.Font, fontStyle);

            // Insertar el mensaje en el RichTextBox


            // Volver a la posición original del cursor
            richTextBoxLogs.SelectionStart = currentPos;
            richTextBoxLogs.SelectionLength = 0; // Limpiar la selección actual
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
                RegistrarLog("Se avanzó a la siguiente pestaña Historial de actividades ");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
            }
            RegistrarLog("Se retrocedió a la pestaña anterior ");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex += 1;
                RegistrarLog("Se avanzó a la siguiente pestaña Historial de actividades ");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
            }
            RegistrarLog("Se retrocedió a la pestaña anterior ");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
            }
            RegistrarLog("Se retrocedió a la pestaña anterior ");
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrarLog("se escogio la columna a subir del excel");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCostoProm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCostoEstandar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCostoProm_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex -= 1;
            }
            RegistrarLog("Se retrocedió a la pestaña anterior ");
        }

        private void label30_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

