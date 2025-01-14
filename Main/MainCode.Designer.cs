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
            label30 = new Label();
            label24 = new Label();
            button5 = new Button();
            label11 = new Label();
            label6 = new Label();
            tabPage2 = new TabPage();
            label26 = new Label();
            button7 = new Button();
            button1 = new Button();
            label25 = new Label();
            label15 = new Label();
            panel4 = new Panel();
            comboBoxNivel5 = new ComboBox();
            comboBoxNivel4 = new ComboBox();
            comboBoxNivel3 = new ComboBox();
            comboBoxNivel2 = new ComboBox();
            label23 = new Label();
            label34 = new Label();
            label1 = new Label();
            label33 = new Label();
            label32 = new Label();
            comboBoxCostoEstandar = new ComboBox();
            label29 = new Label();
            comboBoxPrecio = new ComboBox();
            label18 = new Label();
            panel1 = new Panel();
            label21 = new Label();
            label20 = new Label();
            label17 = new Label();
            label14 = new Label();
            label13 = new Label();
            label22 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBoxUPC = new ComboBox();
            comboBox10 = new ComboBox();
            comboBoxAtrib = new ComboBox();
            comboBoxTalla = new ComboBox();
            comboBoxDetalle_item = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBoxCab = new ComboBox();
            label19 = new Label();
            dataGridView2 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            btnCargarExcel.Location = new Point(133, 69);
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(89, 29);
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
            dataGridView.Location = new Point(17, 124);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(366, 271);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnSubirBD
            // 
            btnSubirBD.BackColor = Color.White;
            btnSubirBD.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnSubirBD.Image = (Image)resources.GetObject("btnSubirBD.Image");
            btnSubirBD.Location = new Point(191, 405);
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
            panel3.Location = new Point(82, 309);
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
            panel2.Size = new Size(388, 360);
            panel2.TabIndex = 21;
            // 
            // comboBoxImpuestoventas
            // 
            comboBoxImpuestoventas.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxImpuestoventas.FormattingEnabled = true;
            comboBoxImpuestoventas.Location = new Point(224, 191);
            comboBoxImpuestoventas.Margin = new Padding(3, 2, 3, 2);
            comboBoxImpuestoventas.Name = "comboBoxImpuestoventas";
            comboBoxImpuestoventas.Size = new Size(157, 25);
            comboBoxImpuestoventas.TabIndex = 27;
            comboBoxImpuestoventas.SelectedIndexChanged += comboBoxImpuestoventas_SelectedIndexChanged;
            // 
            // comboBoxImpuestoCompra
            // 
            comboBoxImpuestoCompra.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxImpuestoCompra.FormattingEnabled = true;
            comboBoxImpuestoCompra.Location = new Point(224, 240);
            comboBoxImpuestoCompra.Margin = new Padding(3, 2, 3, 2);
            comboBoxImpuestoCompra.Name = "comboBoxImpuestoCompra";
            comboBoxImpuestoCompra.Size = new Size(157, 25);
            comboBoxImpuestoCompra.TabIndex = 26;
            comboBoxImpuestoCompra.SelectedIndexChanged += comboBoxImpuestoCompra_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(-2, 194);
            label10.Name = "label10";
            label10.Size = new Size(167, 24);
            label10.TabIndex = 25;
            label10.Text = "Impuesto de ventas*";
            // 
            // label9
            // 
            label9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(-2, 243);
            label9.Name = "label9";
            label9.Size = new Size(146, 24);
            label9.TabIndex = 24;
            label9.Text = "Impuesto de Compra*";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(224, 101);
            comboBoxLocalidad.Margin = new Padding(3, 2, 3, 2);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(157, 25);
            comboBoxLocalidad.TabIndex = 23;
            comboBoxLocalidad.SelectedIndexChanged += comboBoxLocalidad_SelectedIndexChanged;
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Location = new Point(224, 149);
            comboBoxUnidad.Margin = new Padding(3, 2, 3, 2);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(157, 25);
            comboBoxUnidad.TabIndex = 22;
            comboBoxUnidad.SelectedIndexChanged += comboBoxUnidad_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(-2, 104);
            label8.Name = "label8";
            label8.Size = new Size(88, 24);
            label8.TabIndex = 21;
            label8.Text = "Localidad*";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(-2, 152);
            label7.Name = "label7";
            label7.Size = new Size(91, 24);
            label7.TabIndex = 20;
            label7.Text = "Unidad*";
            // 
            // TextDepartamento
            // 
            TextDepartamento.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextDepartamento.Location = new Point(-2, 18);
            TextDepartamento.Name = "TextDepartamento";
            TextDepartamento.Size = new Size(103, 24);
            TextDepartamento.TabIndex = 15;
            TextDepartamento.Text = "Departamento\r\n";
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(224, 18);
            comboBoxDepartamento.Margin = new Padding(3, 2, 3, 2);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(157, 25);
            comboBoxDepartamento.TabIndex = 16;
            comboBoxDepartamento.SelectedIndexChanged += comboBoxDepartamento_SelectedIndexChanged;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(224, 56);
            comboBoxProveedor.Margin = new Padding(3, 2, 3, 2);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(157, 25);
            comboBoxProveedor.TabIndex = 18;
            comboBoxProveedor.SelectedIndexChanged += comboBoxProveedor_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(-2, 59);
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
            pictureBox1.Location = new Point(228, 69);
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
            tabControl1.Location = new Point(23, 93);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(412, 496);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(label30);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnCargarExcel);
            tabPage1.Controls.Add(dataGridView);
            tabPage1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(404, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cargar el excel";
            tabPage1.Click += tabPage1_Click;
            // 
            // label30
            // 
            label30.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(160, 451);
            label30.Name = "label30";
            label30.Size = new Size(72, 26);
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
            button5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = Properties.Resources.Right_64px;
            button5.Location = new Point(160, 400);
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
            label11.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(61, 22);
            label11.Name = "label11";
            label11.Size = new Size(286, 28);
            label11.TabIndex = 11;
            label11.Text = "Carga un archivo Excel (.xlsx o .xls) haciendo clic en 'Subir Excel' y verifica los datos en la tabla de vista previa.\r\n";
            label11.Click += label11_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(113, 101);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 10;
            label6.Text = "Formato soportado: .xlsx, .xls";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(label26);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(404, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Columnas a insertar";
            tabPage2.Click += tabPage2_Click;
            // 
            // label26
            // 
            label26.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(129, 461);
            label26.Name = "label26";
            label26.Size = new Size(42, 26);
            label26.TabIndex = 26;
            label26.Text = "Atrás";
            label26.Click += label26_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(118, 410);
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
            button1.Location = new Point(186, 410);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(62, 49);
            button1.TabIndex = 24;
            button1.Text = "                \r\n                 ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label25
            // 
            label25.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(186, 461);
            label25.Name = "label25";
            label25.Size = new Size(72, 26);
            label25.TabIndex = 23;
            label25.Text = "Siguiente";
            label25.Click += label25_Click;
            // 
            // label15
            // 
            label15.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(42, 2);
            label15.Name = "label15";
            label15.Size = new Size(302, 29);
            label15.TabIndex = 16;
            label15.Text = "Selecciona las columnas del Excel que deseas enviar a la base de datos. Marca las que contienen la información que quieres importar y luego confirma";
            label15.Click += label15_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(comboBoxNivel5);
            panel4.Controls.Add(comboBoxNivel4);
            panel4.Controls.Add(comboBoxNivel3);
            panel4.Controls.Add(comboBoxNivel2);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(label34);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label33);
            panel4.Controls.Add(label32);
            panel4.Controls.Add(comboBoxCostoEstandar);
            panel4.Controls.Add(label29);
            panel4.Controls.Add(comboBoxPrecio);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(dataGridView2);
            panel4.Location = new Point(11, 46);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(374, 360);
            panel4.TabIndex = 18;
            panel4.Paint += panel4_Paint;
            // 
            // comboBoxNivel5
            // 
            comboBoxNivel5.FormattingEnabled = true;
            comboBoxNivel5.Location = new Point(169, 331);
            comboBoxNivel5.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel5.Name = "comboBoxNivel5";
            comboBoxNivel5.Size = new Size(203, 25);
            comboBoxNivel5.TabIndex = 60;
            // 
            // comboBoxNivel4
            // 
            comboBoxNivel4.FormattingEnabled = true;
            comboBoxNivel4.Location = new Point(169, 309);
            comboBoxNivel4.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel4.Name = "comboBoxNivel4";
            comboBoxNivel4.Size = new Size(203, 25);
            comboBoxNivel4.TabIndex = 59;
            // 
            // comboBoxNivel3
            // 
            comboBoxNivel3.FormattingEnabled = true;
            comboBoxNivel3.Location = new Point(169, 284);
            comboBoxNivel3.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel3.Name = "comboBoxNivel3";
            comboBoxNivel3.Size = new Size(203, 25);
            comboBoxNivel3.TabIndex = 58;
            // 
            // comboBoxNivel2
            // 
            comboBoxNivel2.FormattingEnabled = true;
            comboBoxNivel2.Location = new Point(169, 259);
            comboBoxNivel2.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivel2.Name = "comboBoxNivel2";
            comboBoxNivel2.Size = new Size(203, 25);
            comboBoxNivel2.TabIndex = 57;
            // 
            // label23
            // 
            label23.BackColor = Color.White;
            label23.BorderStyle = BorderStyle.FixedSingle;
            label23.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(-3, 334);
            label23.Name = "label23";
            label23.Size = new Size(175, 22);
            label23.TabIndex = 56;
            label23.Text = "Nivel 5";
            // 
            // label34
            // 
            label34.BackColor = Color.White;
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(-2, 309);
            label34.Name = "label34";
            label34.Size = new Size(174, 25);
            label34.TabIndex = 55;
            label34.Text = "Nivel 4";
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 21;
            label1.Text = "            Campos\r\n";
            label1.Click += label1_Click_1;
            // 
            // label33
            // 
            label33.BackColor = Color.White;
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.Black;
            label33.Location = new Point(-2, 284);
            label33.Name = "label33";
            label33.Size = new Size(174, 25);
            label33.TabIndex = 54;
            label33.Text = "Nivel 3";
            // 
            // label32
            // 
            label32.BackColor = Color.White;
            label32.BorderStyle = BorderStyle.FixedSingle;
            label32.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(-2, 259);
            label32.Name = "label32";
            label32.Size = new Size(174, 25);
            label32.TabIndex = 53;
            label32.Text = "Nivel 2";
            // 
            // comboBoxCostoEstandar
            // 
            comboBoxCostoEstandar.FormattingEnabled = true;
            comboBoxCostoEstandar.Location = new Point(169, 234);
            comboBoxCostoEstandar.Margin = new Padding(3, 2, 3, 2);
            comboBoxCostoEstandar.Name = "comboBoxCostoEstandar";
            comboBoxCostoEstandar.Size = new Size(203, 25);
            comboBoxCostoEstandar.TabIndex = 50;
            comboBoxCostoEstandar.SelectedIndexChanged += comboBoxCostoEstandar_SelectedIndexChanged;
            // 
            // label29
            // 
            label29.BackColor = Color.White;
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(-1, 234);
            label29.Name = "label29";
            label29.Size = new Size(173, 25);
            label29.TabIndex = 47;
            label29.Text = "Costo Est.$";
            // 
            // comboBoxPrecio
            // 
            comboBoxPrecio.FormattingEnabled = true;
            comboBoxPrecio.Location = new Point(169, 209);
            comboBoxPrecio.Margin = new Padding(3, 2, 3, 2);
            comboBoxPrecio.Name = "comboBoxPrecio";
            comboBoxPrecio.Size = new Size(203, 25);
            comboBoxPrecio.TabIndex = 46;
            comboBoxPrecio.SelectedIndexChanged += comboBoxPrecio_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(-2, 209);
            label18.Name = "label18";
            label18.Size = new Size(174, 25);
            label18.TabIndex = 45;
            label18.Text = "Precio estandar";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxUPC);
            panel1.Controls.Add(comboBox10);
            panel1.Controls.Add(comboBoxAtrib);
            panel1.Controls.Add(comboBoxTalla);
            panel1.Controls.Add(comboBoxDetalle_item);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(comboBoxCab);
            panel1.Location = new Point(-2, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 176);
            panel1.TabIndex = 39;
            // 
            // label21
            // 
            label21.BackColor = Color.White;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(-2, 124);
            label21.Name = "label21";
            label21.Size = new Size(169, 24);
            label21.TabIndex = 40;
            label21.Text = "Cod. Cab";
            // 
            // label20
            // 
            label20.BackColor = Color.White;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(-2, 104);
            label20.Name = "label20";
            label20.Size = new Size(169, 20);
            label20.TabIndex = 40;
            label20.Text = "Cod. Barra (UPC) ";
            // 
            // label17
            // 
            label17.BackColor = Color.White;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(-2, 84);
            label17.Name = "label17";
            label17.Size = new Size(169, 20);
            label17.TabIndex = 40;
            label17.Text = "Talla";
            // 
            // label14
            // 
            label14.BackColor = Color.White;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(-1, 64);
            label14.Name = "label14";
            label14.Size = new Size(168, 20);
            label14.TabIndex = 25;
            label14.Text = "Color/Atrip";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(-1, 44);
            label13.Name = "label13";
            label13.Size = new Size(168, 20);
            label13.TabIndex = 24;
            label13.Text = "Nombre corto";
            // 
            // label22
            // 
            label22.BackColor = Color.White;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(-2, 148);
            label22.Name = "label22";
            label22.Size = new Size(169, 21);
            label22.TabIndex = 41;
            label22.Text = "Descripcion extensa";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(-2, 24);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 23;
            label4.Text = "Departamento*";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 23);
            label3.TabIndex = 22;
            label3.Text = "Proveedor*";
            // 
            // comboBoxUPC
            // 
            comboBoxUPC.BackColor = Color.White;
            comboBoxUPC.FormattingEnabled = true;
            comboBoxUPC.Location = new Point(164, 19);
            comboBoxUPC.Margin = new Padding(3, 2, 3, 2);
            comboBoxUPC.Name = "comboBoxUPC";
            comboBoxUPC.Size = new Size(208, 25);
            comboBoxUPC.TabIndex = 0;
            comboBoxUPC.SelectedIndexChanged += comboBoxUPC_SelectedIndexChanged;
            // 
            // comboBox10
            // 
            comboBox10.BackColor = Color.White;
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(164, -2);
            comboBox10.Margin = new Padding(3, 2, 3, 2);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(208, 25);
            comboBox10.TabIndex = 37;
            comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // comboBoxAtrib
            // 
            comboBoxAtrib.FormattingEnabled = true;
            comboBoxAtrib.Location = new Point(164, 44);
            comboBoxAtrib.Margin = new Padding(3, 2, 3, 2);
            comboBoxAtrib.Name = "comboBoxAtrib";
            comboBoxAtrib.Size = new Size(208, 25);
            comboBoxAtrib.TabIndex = 20;
            comboBoxAtrib.SelectedIndexChanged += comboBoxAtrib_SelectedIndexChanged;
            // 
            // comboBoxTalla
            // 
            comboBoxTalla.FormattingEnabled = true;
            comboBoxTalla.Location = new Point(164, 64);
            comboBoxTalla.Margin = new Padding(3, 2, 3, 2);
            comboBoxTalla.Name = "comboBoxTalla";
            comboBoxTalla.Size = new Size(208, 25);
            comboBoxTalla.TabIndex = 23;
            comboBoxTalla.SelectedIndexChanged += comboBoxTalla_SelectedIndexChanged;
            // 
            // comboBoxDetalle_item
            // 
            comboBoxDetalle_item.FormattingEnabled = true;
            comboBoxDetalle_item.Location = new Point(164, 149);
            comboBoxDetalle_item.Margin = new Padding(3, 2, 3, 2);
            comboBoxDetalle_item.Name = "comboBoxDetalle_item";
            comboBoxDetalle_item.Size = new Size(208, 25);
            comboBoxDetalle_item.TabIndex = 42;
            comboBoxDetalle_item.SelectedIndexChanged += comboBoxDetalle_item_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(164, 84);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(208, 25);
            comboBox4.TabIndex = 25;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(164, 104);
            comboBox6.Margin = new Padding(3, 2, 3, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(208, 25);
            comboBox6.TabIndex = 32;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // comboBoxCab
            // 
            comboBoxCab.FormattingEnabled = true;
            comboBoxCab.Location = new Point(164, 124);
            comboBoxCab.Margin = new Padding(3, 2, 3, 2);
            comboBoxCab.Name = "comboBoxCab";
            comboBoxCab.Size = new Size(208, 25);
            comboBoxCab.TabIndex = 27;
            comboBoxCab.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.BackColor = Color.Gainsboro;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font("Tahoma", 8F, FontStyle.Bold);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(169, -2);
            label19.Name = "label19";
            label19.Size = new Size(203, 42);
            label19.TabIndex = 19;
            label19.Text = "     Seleccionar campos del excel";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 38);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(307, 176);
            dataGridView2.TabIndex = 38;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            tabPage3.Size = new Size(404, 455);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Enviar posteo ";
            tabPage3.Click += tabPage3_Click;
            // 
            // label28
            // 
            label28.Font = new Font("Tahoma", 8.8F);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(200, 458);
            label28.Name = "label28";
            label28.Size = new Size(53, 26);
            label28.TabIndex = 36;
            label28.Text = "Cargar";
            // 
            // label27
            // 
            label27.Font = new Font("Tahoma", 8.8F);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(134, 456);
            label27.Name = "label27";
            label27.Size = new Size(51, 26);
            label27.TabIndex = 35;
            label27.Text = "Atrás";
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(123, 405);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(62, 49);
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
            tabPage4.Size = new Size(404, 455);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Historial de Actividades";
            tabPage4.Click += tabPage4_Click;
            // 
            // label35
            // 
            label35.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(167, 462);
            label35.Name = "label35";
            label35.Size = new Size(42, 26);
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
            button3.Location = new Point(156, 409);
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
            richTextBoxLogs.Location = new Point(7, 10);
            richTextBoxLogs.Margin = new Padding(3, 2, 3, 2);
            richTextBoxLogs.Name = "richTextBoxLogs";
            richTextBoxLogs.Size = new Size(391, 395);
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
            label2.Size = new Size(352, 56);
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
            ClientSize = new Size(452, 611);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label label6;
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
        private DataGridView dataGridView2;
        private ComboBox comboBoxTalla;
        private Label label19;
        private Button button5;
        private Panel panel1;
        private Label label1;
        private Label label21;
        private Label label20;
        private Label label17;
        private Label label14;
        private Label label13;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxDetalle_item;
        private Label label22;
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
        private Label label18;
        private Label label29;
        private ComboBox comboBoxCostoEstandar;
        private Label label34;
        private Label label33;
        private Label label32;
        private ComboBox comboBoxNivel5;
        private ComboBox comboBoxNivel4;
        private ComboBox comboBoxNivel3;
        private ComboBox comboBoxNivel2;
        private Label label23;
        private Label label30;
        private Label label31;
        private Button button3;
        private Label label35;
    }
}
