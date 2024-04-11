namespace COSMOSCOM
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            gbCliente = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_Telefono2 = new TextBox();
            label11 = new Label();
            txt_Folio = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txt_Nombre = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txt_Apellido_P = new TextBox();
            label4 = new Label();
            txt_Apellido_M = new TextBox();
            txt_Telefono1 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            txt_Total = new TextBox();
            label13 = new Label();
            btn_Quitar = new Button();
            DataGrid_Formato = new DataGridView();
            Formato = new DataGridViewTextBoxColumn();
            Duración = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            btn_Agregar = new Button();
            txt_Monto = new TextBox();
            label12 = new Label();
            nUpDown = new NumericUpDown();
            cb_Formatos = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            gbOpciones = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_Guardar = new Button();
            btn_salir = new Button();
            btn_Cancelar = new Button();
            btn_ConsultarC = new Button();
            btn_ConsultarV = new Button();
            gbFormato = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbCliente.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Formato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpDown).BeginInit();
            gbOpciones.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gbFormato.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(665, 29);
            label1.Name = "label1";
            label1.Size = new Size(256, 31);
            label1.TabIndex = 1;
            label1.Text = "Transferencia de Video";
            // 
            // gbCliente
            // 
            gbCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCliente.AutoSize = true;
            gbCliente.Controls.Add(tableLayoutPanel2);
            gbCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCliente.ForeColor = Color.Orange;
            gbCliente.Location = new Point(3, 3);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(398, 436);
            gbCliente.TabIndex = 2;
            gbCliente.TabStop = false;
            gbCliente.Text = "Datos del cliente";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 6);
            tableLayoutPanel2.Controls.Add(txt_Telefono2, 1, 5);
            tableLayoutPanel2.Controls.Add(label11, 0, 6);
            tableLayoutPanel2.Controls.Add(txt_Folio, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(txt_Nombre, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txt_Apellido_P, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(txt_Apellido_M, 1, 3);
            tableLayoutPanel2.Controls.Add(txt_Telefono1, 1, 4);
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel2.Size = new Size(383, 400);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(185, 46);
            label7.TabIndex = 5;
            label7.Text = "Folio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(194, 323);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // txt_Telefono2
            // 
            txt_Telefono2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Telefono2.Location = new Point(194, 260);
            txt_Telefono2.Name = "txt_Telefono2";
            txt_Telefono2.Size = new Size(186, 30);
            txt_Telefono2.TabIndex = 10;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(3, 320);
            label11.Name = "label11";
            label11.Size = new Size(185, 80);
            label11.TabIndex = 11;
            label11.Text = "Fecha de Entrega";
            // 
            // txt_Folio
            // 
            txt_Folio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Folio.Location = new Point(194, 3);
            txt_Folio.Name = "txt_Folio";
            txt_Folio.Size = new Size(186, 30);
            txt_Folio.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(185, 45);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 257);
            label6.Name = "label6";
            label6.Size = new Size(185, 23);
            label6.TabIndex = 4;
            label6.Text = "Teléfono2";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Nombre.Location = new Point(194, 49);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(186, 30);
            txt_Nombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 195);
            label5.Name = "label5";
            label5.Size = new Size(185, 62);
            label5.TabIndex = 3;
            label5.Text = "Teléfono1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(185, 45);
            label3.TabIndex = 1;
            label3.Text = "Apellido_P";
            // 
            // txt_Apellido_P
            // 
            txt_Apellido_P.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Apellido_P.Location = new Point(194, 94);
            txt_Apellido_P.Name = "txt_Apellido_P";
            txt_Apellido_P.Size = new Size(186, 30);
            txt_Apellido_P.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 136);
            label4.Name = "label4";
            label4.Size = new Size(185, 59);
            label4.TabIndex = 2;
            label4.Text = "Apellido_M";
            label4.Click += label4_Click;
            // 
            // txt_Apellido_M
            // 
            txt_Apellido_M.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Apellido_M.Location = new Point(194, 139);
            txt_Apellido_M.Name = "txt_Apellido_M";
            txt_Apellido_M.Size = new Size(186, 30);
            txt_Apellido_M.TabIndex = 8;
            // 
            // txt_Telefono1
            // 
            txt_Telefono1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Telefono1.Location = new Point(194, 198);
            txt_Telefono1.Name = "txt_Telefono1";
            txt_Telefono1.Size = new Size(186, 30);
            txt_Telefono1.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(189, 0);
            label15.Name = "label15";
            label15.Size = new Size(20, 23);
            label15.TabIndex = 17;
            label15.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 16;
            label14.Text = "Total de Formatos:";
            // 
            // txt_Total
            // 
            txt_Total.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Total.Location = new Point(382, 10);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(296, 30);
            txt_Total.TabIndex = 15;
            txt_Total.TextChanged += textBox1_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(253, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 6;
            label13.Text = "Total:";
            // 
            // btn_Quitar
            // 
            btn_Quitar.BackColor = SystemColors.HighlightText;
            btn_Quitar.Dock = DockStyle.Fill;
            btn_Quitar.Location = new Point(3, 65);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(103, 57);
            btn_Quitar.TabIndex = 11;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.UseVisualStyleBackColor = false;
            btn_Quitar.Click += btn_Quitar_Click;
            // 
            // DataGrid_Formato
            // 
            DataGrid_Formato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Formato.Columns.AddRange(new DataGridViewColumn[] { Formato, Duración, Monto });
            DataGrid_Formato.Dock = DockStyle.Fill;
            DataGrid_Formato.Location = new Point(3, 3);
            DataGrid_Formato.Name = "DataGrid_Formato";
            DataGrid_Formato.RowHeadersWidth = 51;
            DataGrid_Formato.Size = new Size(559, 255);
            DataGrid_Formato.TabIndex = 3;
            DataGrid_Formato.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Formato
            // 
            Formato.HeaderText = "Formato de Video";
            Formato.MinimumWidth = 6;
            Formato.Name = "Formato";
            Formato.Width = 125;
            // 
            // Duración
            // 
            Duración.HeaderText = "Duración";
            Duración.MinimumWidth = 6;
            Duración.Name = "Duración";
            Duración.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = SystemColors.HighlightText;
            btn_Agregar.Dock = DockStyle.Fill;
            btn_Agregar.Location = new Point(3, 3);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(103, 56);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // txt_Monto
            // 
            txt_Monto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Monto.Location = new Point(382, 22);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(112, 30);
            txt_Monto.TabIndex = 14;
            txt_Monto.Text = "170";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(360, 19);
            label12.Name = "label12";
            label12.Size = new Size(16, 23);
            label12.TabIndex = 13;
            label12.Text = "$";
            // 
            // nUpDown
            // 
            nUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nUpDown.Location = new Point(204, 22);
            nUpDown.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nUpDown.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            nUpDown.Name = "nUpDown";
            nUpDown.Size = new Size(150, 30);
            nUpDown.TabIndex = 12;
            nUpDown.Value = new decimal(new int[] { 120, 0, 0, 0 });
            nUpDown.ValueChanged += nUpDown_ValueChanged;
            // 
            // cb_Formatos
            // 
            cb_Formatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Formatos.FormattingEnabled = true;
            cb_Formatos.Items.AddRange(new object[] { "VHS", "Beta", "MiniDV", "8mm", "Super8", "DVD" });
            cb_Formatos.Location = new Point(3, 22);
            cb_Formatos.Name = "cb_Formatos";
            cb_Formatos.Size = new Size(195, 31);
            cb_Formatos.TabIndex = 4;
            cb_Formatos.Text = "Selecciona Formato";
            cb_Formatos.SelectedIndexChanged += cb_Formatos_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(382, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 2;
            label10.Text = "Monto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 1;
            label9.Text = "Duración";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 19);
            label8.TabIndex = 0;
            label8.Text = "Formato de Video";
            // 
            // gbOpciones
            // 
            gbOpciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbOpciones.AutoSize = true;
            gbOpciones.Controls.Add(tableLayoutPanel3);
            gbOpciones.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbOpciones.ForeColor = Color.Orange;
            gbOpciones.Location = new Point(3, 445);
            gbOpciones.Name = "gbOpciones";
            gbOpciones.Size = new Size(398, 280);
            gbOpciones.TabIndex = 4;
            gbOpciones.TabStop = false;
            gbOpciones.Text = "Opciones";
            gbOpciones.Enter += groupBox3_Enter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            tableLayoutPanel3.Controls.Add(btn_Guardar, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_salir, 2, 0);
            tableLayoutPanel3.Controls.Add(btn_Cancelar, 1, 0);
            tableLayoutPanel3.Controls.Add(btn_ConsultarC, 0, 1);
            tableLayoutPanel3.Controls.Add(btn_ConsultarV, 1, 1);
            tableLayoutPanel3.Location = new Point(21, 44);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2822952F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7177048F));
            tableLayoutPanel3.Size = new Size(356, 209);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.HighlightText;
            btn_Guardar.Dock = DockStyle.Fill;
            btn_Guardar.Location = new Point(3, 3);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(113, 97);
            btn_Guardar.TabIndex = 9;
            btn_Guardar.Text = "Guardar Registro";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = SystemColors.HighlightText;
            btn_salir.Dock = DockStyle.Fill;
            btn_salir.Location = new Point(241, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(112, 97);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = SystemColors.HighlightText;
            btn_Cancelar.Dock = DockStyle.Fill;
            btn_Cancelar.Location = new Point(122, 3);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(113, 97);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_ConsultarC
            // 
            btn_ConsultarC.BackColor = SystemColors.HighlightText;
            btn_ConsultarC.Dock = DockStyle.Fill;
            btn_ConsultarC.Location = new Point(3, 106);
            btn_ConsultarC.Name = "btn_ConsultarC";
            btn_ConsultarC.Size = new Size(113, 100);
            btn_ConsultarC.TabIndex = 6;
            btn_ConsultarC.Text = "Consultar Clientes";
            btn_ConsultarC.UseVisualStyleBackColor = false;
            btn_ConsultarC.Click += btn_ConsultarC_Click;
            // 
            // btn_ConsultarV
            // 
            btn_ConsultarV.BackColor = SystemColors.HighlightText;
            btn_ConsultarV.Dock = DockStyle.Fill;
            btn_ConsultarV.Location = new Point(122, 106);
            btn_ConsultarV.Name = "btn_ConsultarV";
            btn_ConsultarV.Size = new Size(113, 100);
            btn_ConsultarV.TabIndex = 7;
            btn_ConsultarV.Text = "Consultar Ventas";
            btn_ConsultarV.UseVisualStyleBackColor = false;
            btn_ConsultarV.Click += btn_ConsultarV_Click;
            // 
            // gbFormato
            // 
            gbFormato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbFormato.AutoSize = true;
            gbFormato.Controls.Add(tableLayoutPanel8);
            gbFormato.Controls.Add(tableLayoutPanel5);
            gbFormato.Controls.Add(tableLayoutPanel4);
            gbFormato.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFormato.ForeColor = Color.Orange;
            gbFormato.Location = new Point(407, 3);
            gbFormato.Name = "gbFormato";
            gbFormato.Size = new Size(687, 436);
            gbFormato.TabIndex = 5;
            gbFormato.TabStop = false;
            gbFormato.Text = "Formato";
            gbFormato.Enter += groupBox4_Enter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 302F));
            tableLayoutPanel8.Controls.Add(label14, 0, 0);
            tableLayoutPanel8.Controls.Add(label15, 1, 0);
            tableLayoutPanel8.Controls.Add(label13, 2, 0);
            tableLayoutPanel8.Controls.Add(txt_Total, 3, 0);
            tableLayoutPanel8.Dock = DockStyle.Top;
            tableLayoutPanel8.Location = new Point(3, 375);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(681, 51);
            tableLayoutPanel8.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.10078F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.8992252F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Controls.Add(DataGrid_Formato, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(3, 114);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(681, 261);
            tableLayoutPanel5.TabIndex = 19;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(btn_Agregar, 0, 0);
            tableLayoutPanel6.Controls.Add(btn_Quitar, 0, 1);
            tableLayoutPanel6.Location = new Point(568, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(109, 125);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.41711F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.58289F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tableLayoutPanel4.Controls.Add(label8, 0, 0);
            tableLayoutPanel4.Controls.Add(label9, 1, 0);
            tableLayoutPanel4.Controls.Add(cb_Formatos, 0, 1);
            tableLayoutPanel4.Controls.Add(nUpDown, 1, 1);
            tableLayoutPanel4.Controls.Add(label10, 3, 0);
            tableLayoutPanel4.Controls.Add(txt_Monto, 3, 1);
            tableLayoutPanel4.Controls.Add(label12, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 26);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 21.6F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 78.4F));
            tableLayoutPanel4.Size = new Size(681, 88);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.67698F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.32302F));
            tableLayoutPanel7.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(label1, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(1097, 90);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.827713F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.172287F));
            tableLayoutPanel1.Controls.Add(gbCliente, 0, 0);
            tableLayoutPanel1.Controls.Add(gbOpciones, 0, 1);
            tableLayoutPanel1.Controls.Add(gbFormato, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.7142868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.2857132F));
            tableLayoutPanel1.Size = new Size(1097, 728);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1097, 818);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel7);
            MaximumSize = new Size(1215, 965);
            MinimumSize = new Size(1115, 865);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            Resize += Registro_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbCliente.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Formato).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpDown).EndInit();
            gbOpciones.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            gbFormato.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox gbCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox gbOpciones;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private Button btn_ConsultarV;
        private Button btn_ConsultarC;
        private Button btn_Agregar;
        private ComboBox cb_Formatos;
        private DataGridView DataGrid_Formato;
        private NumericUpDown nUpDown;
        private Button btn_Quitar;
        private TextBox txt_Monto;
        private Label label12;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Duración;
        private DataGridViewTextBoxColumn Monto;
        private TextBox txt_Total;
        private Label label13;
        private Label label15;
        private Label label14;
        private GroupBox gbFormato;
        private Button btn_salir;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox txt_Telefono2;
        private TextBox txt_Folio;
        private Label label7;
        private TextBox txt_Apellido_M;
        private TextBox txt_Telefono1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label11;
        private Label label4;
        private TextBox txt_Apellido_P;
        private Label label2;
        private TextBox txt_Nombre;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
    }
}