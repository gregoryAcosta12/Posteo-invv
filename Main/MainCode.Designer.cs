namespace InventarioExcel
{
    partial class MainCode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCode));
            btnCargarExcel = new Button();
            dataGridView = new DataGridView();
            btnSubirBD = new Button();
            rbArticulo = new RadioButton();
            rbServicio = new RadioButton();
            panel3 = new Panel();
            panel2 = new Panel();
            comboBoxImpuestoventas = new ComboBox();
            comboBoxImpuestoCompra = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            comboBoxLocalidad = new ComboBox();
            comboBoxUnidad = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            TextDepartamento = new Label();
            comboBoxDepartamento = new ComboBox();
            comboBoxProveedor = new ComboBox();
            label5 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label13 = new Label();
            label6 = new Label();
            labelFileName = new Label();
            label30 = new Label();
            label24 = new Label();
            button5 = new Button();
            label11 = new Label();
            tabPage2 = new TabPage();
            label26 = new Label();
            label25 = new Label();
            label15 = new Label();
            panel4 = new Panel();
            label19 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label48 = new Label();
            label47 = new Label();
            label46 = new Label();
            label45 = new Label();
            label43 = new Label();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            comboBoxNivel5 = new ComboBox();
            label37 = new Label();
            label36 = new Label();
            label3 = new Label();
            comboBox10 = new ComboBox();
            comboBoxNivel4 = new ComboBox();
            comboBoxUPC = new ComboBox();
            comboBoxAtrib = new ComboBox();
            comboBoxTalla = new ComboBox();
            comboBox4 = new ComboBox();
            comboBoxNivel3 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBoxCab = new ComboBox();
            comboBoxDetalle_item = new ComboBox();
            comboBoxNivel2 = new ComboBox();
            comboBoxPrecio = new ComboBox();
            comboBoxCostoEstandar = new ComboBox();
            button7 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            label28 = new Label();
            label27 = new Label();
            button2 = new Button();
            tabPage4 = new TabPage();
            label35 = new Label();
            label31 = new Label();
            button3 = new Button();
            richTextBoxLogs = new RichTextBox();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.BackColor = Color.White;
            btnCargarExcel.FlatStyle = FlatStyle.Popup;
            btnCargarExcel.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarExcel.Location = new Point(135, 43);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(190, 29);
            btnCargarExcel.TabIndex = 0;
            btnCargarExcel.Text = "Seleccionar archivo Excel";
            btnCargarExcel.UseVisualStyleBackColor = false;
            btnCargarExcel.Click += button1_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowDrop = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.Location = new Point(7, 134);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(527, 274);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnSubirBD
            // 
            btnSubirBD.BackColor = Color.White;
            btnSubirBD.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnSubirBD.Image = (Image)resources.GetObject("btnSubirBD.Image");
            btnSubirBD.Location = new Point(467, 408);
            btnSubirBD.Name = "btnSubirBD";
            btnSubirBD.Size = new Size(62, 51);
            btnSubirBD.TabIndex = 3;
            btnSubirBD.UseVisualStyleBackColor = false;
            btnSubirBD.Click += btnSubirBD_Click;
            // 
            // rbArticulo
            // 
            rbArticulo.AutoSize = true;
            rbArticulo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbArticulo.Location = new Point(3, 3);
            rbArticulo.Name = "rbArticulo";
            rbArticulo.Size = new Size(71, 21);
            rbArticulo.TabIndex = 5;
            rbArticulo.TabStop = true;
            rbArticulo.Text = "Articulo";
            rbArticulo.UseVisualStyleBackColor = true;
            rbArticulo.CheckedChanged += rbArticulo_CheckedChanged;
            // 
            // rbServicio
            // 
            rbServicio.AutoSize = true;
            rbServicio.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbServicio.Location = new Point(113, 3);
            rbServicio.Name = "rbServicio";
            rbServicio.Size = new Size(73, 21);
            rbServicio.TabIndex = 6;
            rbServicio.TabStop = true;
            rbServicio.Text = "Servicio";
            rbServicio.UseVisualStyleBackColor = true;
            rbServicio.CheckedChanged += rbServicio_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rbArticulo);
            panel3.Controls.Add(rbServicio);
            panel3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(146, 308);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 35);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBoxImpuestoventas);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(comboBoxImpuestoCompra);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxLocalidad);
            panel2.Controls.Add(comboBoxUnidad);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TextDepartamento);
            panel2.Controls.Add(comboBoxDepartamento);
            panel2.Controls.Add(comboBoxProveedor);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(6, 43);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 360);
            panel2.TabIndex = 21;
            // 
            // comboBoxImpuestoventas
            // 
            comboBoxImpuestoventas.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxImpuestoventas.FormattingEnabled = true;
            comboBoxImpuestoventas.Location = new Point(273, 192);
            comboBoxImpuestoventas.Margin = new Padding(3, 2, 3, 2);
            comboBoxImpuestoventas.Name = "comboBoxImpuestoventas";
            comboBoxImpuestoventas.Size = new Size(189, 25);
            comboBoxImpuestoventas.TabIndex = 27;
            comboBoxImpuestoventas.SelectedIndexChanged += comboBoxImpuestoventas_SelectedIndexChanged;
            // 
            // comboBoxImpuestoCompra
            // 
            comboBoxImpuestoCompra.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxImpuestoCompra.FormattingEnabled = true;
            comboBoxImpuestoCompra.Location = new Point(273, 237);
            comboBoxImpuestoCompra.Margin = new Padding(3, 2, 3, 2);
            comboBoxImpuestoCompra.Name = "comboBoxImpuestoCompra";
            comboBoxImpuestoCompra.Size = new Size(189, 25);
            comboBoxImpuestoCompra.TabIndex = 26;
            comboBoxImpuestoCompra.SelectedIndexChanged += comboBoxImpuestoCompra_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(60, 193);
            label10.Name = "label10";
            label10.Size = new Size(167, 24);
            label10.TabIndex = 25;
            label10.Text = "Impuesto de ventas*";
            // 
            // label9
            // 
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(64, 240);
            label9.Name = "label9";
            label9.Size = new Size(146, 24);
            label9.TabIndex = 24;
            label9.Text = "Impuesto de Compra*";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(273, 101);
            comboBoxLocalidad.Margin = new Padding(3, 2, 3, 2);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(189, 25);
            comboBoxLocalidad.TabIndex = 23;
            comboBoxLocalidad.SelectedIndexChanged += comboBoxLocalidad_SelectedIndexChanged;
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Location = new Point(273, 146);
            comboBoxUnidad.Margin = new Padding(3, 2, 3, 2);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(189, 25);
            comboBoxUnidad.TabIndex = 22;
            comboBoxUnidad.SelectedIndexChanged += comboBoxUnidad_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 104);
            label8.Name = "label8";
            label8.Size = new Size(88, 24);
            label8.TabIndex = 21;
            label8.Text = "Localidad*";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 149);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 20;
            label7.Text = "Unidad*";
            // 
            // TextDepartamento
            // 
            TextDepartamento.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextDepartamento.Location = new Point(60, 18);
            TextDepartamento.Name = "TextDepartamento";
            TextDepartamento.Size = new Size(103, 24);
            TextDepartamento.TabIndex = 15;
            TextDepartamento.Text = "Departamento\r\n";
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(273, 18);
            comboBoxDepartamento.Margin = new Padding(3, 2, 3, 2);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(189, 25);
            comboBoxDepartamento.TabIndex = 16;
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(273, 58);
            comboBoxProveedor.Margin = new Padding(3, 2, 3, 2);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(189, 25);
            comboBoxProveedor.TabIndex = 18;
            comboBoxProveedor.SelectedIndexChanged += comboBoxProveedor_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 59);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 19;
            label5.Text = "Proveedor ";
            // 
            // label16
            // 
            label16.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(45, 8);
            label16.Name = "label16";
            label16.Size = new Size(315, 33);
            label16.TabIndex = 29;
            label16.Text = "Elige departamentos, proveedores, unidad, impuesto de compra y de venta antes de enviar.";
            label16.Click += label16_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.excel_removebg_preview;
            pictureBox1.Location = new Point(331, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 82);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(552, 496);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(labelFileName);
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnCargarExcel);
            tabPage1.Controls.Add(dataGridView);
            tabPage1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(544, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cargar el excel";
            tabPage1.Click += tabPage1_Click;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Tahoma", 7F);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(80, 75);
            label13.Name = "label13";
            label13.Size = new Size(379, 28);
            label13.TabIndex = 27;
            label13.Text = "Carga un archivo Excel (.xlsx o .xls) haciendo clic en 'Seleccionar archivo Excel' y verifica los datos en la tabla de vista previa. ";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(55, 112);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 26;
            label6.Text = "Archivo:";
            // 
            // labelFileName
            // 
            labelFileName.Font = new Font("Tahoma", 7.8F);
            labelFileName.Location = new Point(144, 112);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(215, 19);
            labelFileName.TabIndex = 25;
            // 
            // label30
            // 
            label30.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(470, 464);
            label30.Name = "label30";
            label30.Size = new Size(62, 26);
            label30.TabIndex = 24;
            label30.Text = "Siguiente";
            label30.Click += label30_Click_1;
            // 
            // label24
            // 
            label24.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(498, 588);
            label24.Name = "label24";
            label24.Size = new Size(72, 26);
            label24.TabIndex = 22;
            label24.Text = "Siguiente";
            // 
            // button5
            // 
            button5.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            button5.Image = Properties.Resources.Right_64px;
            button5.Location = new Point(467, 413);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(62, 49);
            button5.TabIndex = 20;
            button5.Text = "                \r\n                 ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Tahoma", 7F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(3, 2);
            label11.Name = "label11";
            label11.Size = new Size(539, 28);
            label11.TabIndex = 11;
            label11.Text = resources.GetString("label11.Text");
            label11.Click += label11_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(544, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Columnas a insertar";
            tabPage2.Click += tabPage2_Click;
            // 
            // label26
            // 
            label26.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(405, 467);
            label26.Name = "label26";
            label26.Size = new Size(42, 22);
            label26.TabIndex = 26;
            label26.Text = "Atrás";
            label26.Click += label26_Click;
            // 
            // label25
            // 
            label25.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(462, 467);
            label25.Name = "label25";
            label25.Size = new Size(58, 21);
            label25.TabIndex = 23;
            label25.Text = "Siguiente";
            label25.Click += label25_Click;
            // 
            // label15
            // 
            label15.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(12, 2);
            label15.Name = "label15";
            label15.Size = new Size(490, 29);
            label15.TabIndex = 16;
            label15.Text = "Selecciona las columnas del Excel que deseas enviar a la base de datos. Marca las que contienen la información que quieres importar y luego confirma";
            label15.Click += label15_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(1, 46);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 367);
            panel4.TabIndex = 18;
            panel4.Paint += panel4_Paint;
            // 
            // label19
            // 
            label19.BackColor = Color.Gainsboro;
            label19.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(251, -2);
            label19.Name = "label19";
            label19.Size = new Size(278, 42);
            label19.TabIndex = 40;
            label19.Text = "                          \r\n     Campos del excel\r\n ";
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 40);
            label1.TabIndex = 21;
            label1.Text = "                           \r\n   Campos\r\n";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label48);
            panel1.Controls.Add(label47);
            panel1.Controls.Add(label46);
            panel1.Controls.Add(label45);
            panel1.Controls.Add(label43);
            panel1.Controls.Add(label42);
            panel1.Controls.Add(label41);
            panel1.Controls.Add(label40);
            panel1.Controls.Add(label39);
            panel1.Controls.Add(label38);
            panel1.Controls.Add(comboBoxNivel5);
            panel1.Controls.Add(label37);
            panel1.Controls.Add(label36);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox10);
            panel1.Controls.Add(comboBoxNivel4);
            panel1.Controls.Add(comboBoxUPC);
            panel1.Controls.Add(comboBoxAtrib);
            panel1.Controls.Add(comboBoxTalla);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBoxNivel3);
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(comboBoxCab);
            panel1.Controls.Add(comboBoxDetalle_item);
            panel1.Controls.Add(comboBoxNivel2);
            panel1.Controls.Add(comboBoxPrecio);
            panel1.Controls.Add(comboBoxCostoEstandar);
            panel1.Location = new Point(0, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 328);
            panel1.TabIndex = 39;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(-2, 298);
            label4.Name = "label4";
            label4.Size = new Size(267, 25);
            label4.TabIndex = 64;
            label4.Text = "   Nivel 5";
            // 
            // label48
            // 
            label48.BackColor = Color.White;
            label48.BorderStyle = BorderStyle.FixedSingle;
            label48.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label48.ForeColor = Color.Black;
            label48.Location = new Point(-2, 274);
            label48.Name = "label48";
            label48.Size = new Size(267, 24);
            label48.TabIndex = 63;
            label48.Text = "   Nivel 4\r\n";
            // 
            // label47
            // 
            label47.BackColor = Color.White;
            label47.BorderStyle = BorderStyle.FixedSingle;
            label47.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label47.ForeColor = Color.Black;
            label47.Location = new Point(-2, 253);
            label47.Name = "label47";
            label47.Size = new Size(267, 23);
            label47.TabIndex = 62;
            label47.Text = "   Nivel 3\r\n";
            // 
            // label46
            // 
            label46.BackColor = Color.White;
            label46.BorderStyle = BorderStyle.FixedSingle;
            label46.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label46.ForeColor = Color.Black;
            label46.Location = new Point(-2, 230);
            label46.Name = "label46";
            label46.Size = new Size(267, 23);
            label46.TabIndex = 61;
            label46.Text = "   Nivel 2\r\n";
            // 
            // label45
            // 
            label45.BackColor = Color.White;
            label45.BorderStyle = BorderStyle.FixedSingle;
            label45.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.Black;
            label45.Location = new Point(-2, 207);
            label45.Name = "label45";
            label45.Size = new Size(267, 23);
            label45.TabIndex = 47;
            label45.Text = "  Costo Est.$";
            // 
            // label43
            // 
            label43.BackColor = Color.White;
            label43.BorderStyle = BorderStyle.FixedSingle;
            label43.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label43.ForeColor = Color.Black;
            label43.Location = new Point(-2, 184);
            label43.Name = "label43";
            label43.Size = new Size(267, 23);
            label43.TabIndex = 45;
            label43.Text = "   Precio estandar";
            label43.UseWaitCursor = true;
            // 
            // label42
            // 
            label42.BackColor = Color.White;
            label42.BorderStyle = BorderStyle.FixedSingle;
            label42.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label42.ForeColor = Color.Black;
            label42.Location = new Point(-1, 161);
            label42.Name = "label42";
            label42.Size = new Size(266, 23);
            label42.TabIndex = 44;
            label42.Text = "   Descripcion extensa";
            // 
            // label41
            // 
            label41.BackColor = Color.White;
            label41.BorderStyle = BorderStyle.FixedSingle;
            label41.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label41.ForeColor = Color.Black;
            label41.Location = new Point(-1, 138);
            label41.Name = "label41";
            label41.Size = new Size(266, 23);
            label41.TabIndex = 43;
            label41.Text = "   Cod. Cab";
            // 
            // label40
            // 
            label40.BackColor = Color.White;
            label40.BorderStyle = BorderStyle.FixedSingle;
            label40.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.ForeColor = Color.Black;
            label40.Location = new Point(-1, 115);
            label40.Name = "label40";
            label40.Size = new Size(266, 27);
            label40.TabIndex = 42;
            label40.Text = "   Cod. Barra (UPC) ";
            // 
            // label39
            // 
            label39.BackColor = Color.White;
            label39.BorderStyle = BorderStyle.FixedSingle;
            label39.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label39.ForeColor = Color.Black;
            label39.Location = new Point(-2, 94);
            label39.Name = "label39";
            label39.Size = new Size(267, 21);
            label39.TabIndex = 41;
            label39.Text = "   Talla*";
            // 
            // label38
            // 
            label38.BackColor = Color.White;
            label38.BorderStyle = BorderStyle.FixedSingle;
            label38.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(-2, 69);
            label38.Name = "label38";
            label38.Size = new Size(267, 27);
            label38.TabIndex = 40;
            label38.Text = "   Color/Atrip";
            // 
            // comboBoxNivel5
            // 
            comboBoxNivel5.FormattingEnabled = true;
            comboBoxNivel5.Location = new Point(263, 301);
            comboBoxNivel5.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel5.Name = "comboBoxNivel5";
            comboBoxNivel5.Size = new Size(261, 25);
            comboBoxNivel5.TabIndex = 60;
            // 
            // label37
            // 
            label37.BackColor = Color.White;
            label37.BorderStyle = BorderStyle.FixedSingle;
            label37.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(-1, 46);
            label37.Name = "label37";
            label37.Size = new Size(266, 25);
            label37.TabIndex = 39;
            label37.Text = "   Nombre corto*\r\n";
            // 
            // label36
            // 
            label36.BackColor = Color.White;
            label36.BorderStyle = BorderStyle.FixedSingle;
            label36.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(-2, 21);
            label36.Name = "label36";
            label36.Size = new Size(267, 25);
            label36.TabIndex = 38;
            label36.Text = "   Departamento*";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(266, 21);
            label3.TabIndex = 22;
            label3.Text = "   Proveedor*";
            label3.Click += label3_Click_1;
            // 
            // comboBox10
            // 
            comboBox10.BackColor = Color.White;
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(263, -2);
            comboBox10.Margin = new Padding(3, 0, 3, 0);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(260, 25);
            comboBox10.TabIndex = 37;
            comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // comboBoxNivel4
            // 
            comboBoxNivel4.FormattingEnabled = true;
            comboBoxNivel4.Location = new Point(263, 276);
            comboBoxNivel4.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel4.Name = "comboBoxNivel4";
            comboBoxNivel4.Size = new Size(261, 25);
            comboBoxNivel4.TabIndex = 59;
            // 
            // comboBoxUPC
            // 
            comboBoxUPC.BackColor = Color.White;
            comboBoxUPC.FormattingEnabled = true;
            comboBoxUPC.Location = new Point(263, 21);
            comboBoxUPC.Margin = new Padding(3, 0, 3, 0);
            comboBoxUPC.Name = "comboBoxUPC";
            comboBoxUPC.Size = new Size(260, 25);
            comboBoxUPC.TabIndex = 0;
            comboBoxUPC.SelectedIndexChanged += comboBoxUPC_SelectedIndexChanged;
            // 
            // comboBoxAtrib
            // 
            comboBoxAtrib.FormattingEnabled = true;
            comboBoxAtrib.Location = new Point(263, 46);
            comboBoxAtrib.Margin = new Padding(3, 0, 3, 0);
            comboBoxAtrib.Name = "comboBoxAtrib";
            comboBoxAtrib.Size = new Size(260, 25);
            comboBoxAtrib.TabIndex = 20;
            comboBoxAtrib.SelectedIndexChanged += comboBoxAtrib_SelectedIndexChanged;
            // 
            // comboBoxTalla
            // 
            comboBoxTalla.FormattingEnabled = true;
            comboBoxTalla.Location = new Point(263, 71);
            comboBoxTalla.Margin = new Padding(3, 0, 3, 0);
            comboBoxTalla.Name = "comboBoxTalla";
            comboBoxTalla.Size = new Size(260, 25);
            comboBoxTalla.TabIndex = 23;
            comboBoxTalla.SelectedIndexChanged += comboBoxTalla_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(263, 94);
            comboBox4.Margin = new Padding(3, 0, 3, 0);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(260, 25);
            comboBox4.TabIndex = 25;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBoxNivel3
            // 
            comboBoxNivel3.FormattingEnabled = true;
            comboBoxNivel3.Location = new Point(263, 255);
            comboBoxNivel3.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel3.Name = "comboBoxNivel3";
            comboBoxNivel3.Size = new Size(261, 25);
            comboBoxNivel3.TabIndex = 58;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(263, 117);
            comboBox6.Margin = new Padding(3, 0, 3, 0);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(260, 25);
            comboBox6.TabIndex = 32;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // comboBoxCab
            // 
            comboBoxCab.FormattingEnabled = true;
            comboBoxCab.Location = new Point(263, 136);
            comboBoxCab.Margin = new Padding(3, 0, 3, 0);
            comboBoxCab.Name = "comboBoxCab";
            comboBoxCab.Size = new Size(260, 25);
            comboBoxCab.TabIndex = 27;
            comboBoxCab.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBoxDetalle_item
            // 
            comboBoxDetalle_item.FormattingEnabled = true;
            comboBoxDetalle_item.Location = new Point(263, 161);
            comboBoxDetalle_item.Margin = new Padding(3, 0, 3, 0);
            comboBoxDetalle_item.Name = "comboBoxDetalle_item";
            comboBoxDetalle_item.Size = new Size(260, 25);
            comboBoxDetalle_item.TabIndex = 42;
            comboBoxDetalle_item.SelectedIndexChanged += comboBoxDetalle_item_SelectedIndexChanged;
            // 
            // comboBoxNivel2
            // 
            comboBoxNivel2.FormattingEnabled = true;
            comboBoxNivel2.Location = new Point(263, 232);
            comboBoxNivel2.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel2.Name = "comboBoxNivel2";
            comboBoxNivel2.Size = new Size(261, 25);
            comboBoxNivel2.TabIndex = 57;
            // 
            // comboBoxPrecio
            // 
            comboBoxPrecio.FormattingEnabled = true;
            comboBoxPrecio.Location = new Point(263, 184);
            comboBoxPrecio.Margin = new Padding(3, 0, 3, 0);
            comboBoxPrecio.Name = "comboBoxPrecio";
            comboBoxPrecio.Size = new Size(261, 25);
            comboBoxPrecio.TabIndex = 46;
            comboBoxPrecio.SelectedIndexChanged += comboBoxPrecio_SelectedIndexChanged;
            // 
            // comboBoxCostoEstandar
            // 
            comboBoxCostoEstandar.FormattingEnabled = true;
            comboBoxCostoEstandar.Location = new Point(263, 207);
            comboBoxCostoEstandar.Margin = new Padding(3, 0, 3, 0);
            comboBoxCostoEstandar.Name = "comboBoxCostoEstandar";
            comboBoxCostoEstandar.Size = new Size(261, 25);
            comboBoxCostoEstandar.TabIndex = 50;
            comboBoxCostoEstandar.SelectedIndexChanged += comboBoxCostoEstandar_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(394, 418);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(62, 49);
            button7.TabIndex = 25;
            button7.Text = "                \r\n                 ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Right_64px;
            button1.Location = new Point(462, 418);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(58, 49);
            button1.TabIndex = 24;
            button1.Text = "                \r\n                 ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gainsboro;
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(btnSubirBD);
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(544, 466);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Enviar posteo ";
            tabPage3.Click += tabPage3_Click;
            // 
            // label28
            // 
            label28.Font = new Font("Tahoma", 8.8F);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(476, 462);
            label28.Name = "label28";
            label28.Size = new Size(53, 26);
            label28.TabIndex = 36;
            label28.Text = "Cargar";
            // 
            // label27
            // 
            label27.Font = new Font("Tahoma", 8.8F);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(410, 462);
            label27.Name = "label27";
            label27.Size = new Size(51, 26);
            label27.TabIndex = 35;
            label27.Text = "Atrás";
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(399, 407);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(62, 53);
            button2.TabIndex = 34;
            button2.Text = "                \r\n                 ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gainsboro;
            tabPage4.Controls.Add(label35);
            tabPage4.Controls.Add(label31);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(richTextBoxLogs);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(544, 466);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Historial de Actividades";
            tabPage4.Click += tabPage4_Click;
            // 
            // label35
            // 
            label35.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(482, 462);
            label35.Name = "label35";
            label35.Size = new Size(42, 22);
            label35.TabIndex = 36;
            label35.Text = "Atrás";
            // 
            // label31
            // 
            label31.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(182, 528);
            label31.Name = "label31";
            label31.Size = new Size(72, 26);
            label31.TabIndex = 35;
            label31.Text = "Atrás";
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(471, 409);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(62, 51);
            button3.TabIndex = 34;
            button3.Text = "                \r\n                 ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // richTextBoxLogs
            // 
            richTextBoxLogs.Location = new Point(3, 0);
            richTextBoxLogs.Margin = new Padding(3, 2, 3, 2);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new Size(533, 405);
            richTextBoxLogs.TabIndex = 0;
            richTextBoxLogs.Text = "";
            richTextBoxLogs.TextChanged += richTextBoxLogs_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(108, 11);
            label12.Name = "label12";
            label12.Size = new Size(331, 24);
            label12.TabIndex = 12;
            label12.Text = "Importar Catálogo de Productos";
            label12.Click += label12_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 35);
            label2.Name = "label2";
            label2.Size = new Size(452, 45);
            label2.TabIndex = 27;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click_1;
            // 
            // MainCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(582, 610);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarExcel;
        private DataGridView dataGridView;
        private Button btnSubirBD;
        private RadioButton rbArticulo;
        private RadioButton rbServicio;
        private PictureBox pictureBox1;
        private ComboBox comboBoxProveedor;
        private ComboBox comboBoxDepartamento;
        private Label TextDepartamento;
        private Label label5;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private ComboBox comboBoxLocalidad;
        private ComboBox comboBoxUnidad;
        private ComboBox comboBoxImpuestoventas;
        private ComboBox comboBoxImpuestoCompra;
        private Label label10;
        private Label label9;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label12;
        private Panel panel4;
        private Label label15;
        private Label label16;
        private ComboBox comboBoxUPC;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxAtrib;
        private ComboBox comboBoxCab;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private ComboBox comboBox10;
        private ComboBox comboBoxTalla;
        private Button button5;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxDetalle_item;
        private TabPage tabPage4;
        private RichTextBox richTextBoxLogs;
        private Label label24;
        private Button button1;
        private Label label25;
        private Label label26;
        private Button button7;
        private Button button2;
        private Label label27;
        private Label label28;
        private Label label2;
        private ComboBox comboBoxPrecio;
        private ComboBox comboBoxCostoEstandar;
        private ComboBox comboBoxNivel5;
        private ComboBox comboBoxNivel4;
        private ComboBox comboBoxNivel3;
        private ComboBox comboBoxNivel2;
        private Label label30;
        private Label label31;
        private Button button3;
        private Label label35;
        private Panel panel1;
        private Label label19;
        private Label label36;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label45;
        private Label label43;
        private Label label42;
        private Label label48;
        private Label label47;
        private Label label46;
        private Label label4;
        private Label labelFileName;
        private Label label6;
        private Label label13;
    }
}
