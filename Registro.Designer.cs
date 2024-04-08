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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            txt_Telefono2 = new TextBox();
            txt_Telefono1 = new TextBox();
            txt_Apellido_M = new TextBox();
            txt_Apellido_P = new TextBox();
            txt_Nombre = new TextBox();
            txt_Folio = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txt_Total = new TextBox();
            label13 = new Label();
            txt_Monto = new TextBox();
            label12 = new Label();
            nUpDown = new NumericUpDown();
            btn_Quitar = new Button();
            btn_Agregar = new Button();
            cb_Formatos = new ComboBox();
            DataGrid_Formato = new DataGridView();
            Formato = new DataGridViewTextBoxColumn();
            Duración = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btn_Guardar = new Button();
            btn_Cancelar = new Button();
            btn_ConsultarV = new Button();
            btn_ConsultarC = new Button();
            btn_salir = new Button();
            Alerta = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Formato).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(470, 21);
            label1.Name = "label1";
            label1.Size = new Size(256, 31);
            label1.TabIndex = 1;
            label1.Text = "Transferencia de Video";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_Telefono2);
            groupBox1.Controls.Add(txt_Telefono1);
            groupBox1.Controls.Add(txt_Apellido_M);
            groupBox1.Controls.Add(txt_Apellido_P);
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(txt_Folio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(31, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 367);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 316);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 323);
            label11.Name = "label11";
            label11.Size = new Size(147, 23);
            label11.TabIndex = 11;
            label11.Text = "Fecha de Entrega";
            // 
            // txt_Telefono2
            // 
            txt_Telefono2.Location = new Point(127, 260);
            txt_Telefono2.Name = "txt_Telefono2";
            txt_Telefono2.Size = new Size(205, 30);
            txt_Telefono2.TabIndex = 10;
            // 
            // txt_Telefono1
            // 
            txt_Telefono1.Location = new Point(127, 208);
            txt_Telefono1.Name = "txt_Telefono1";
            txt_Telefono1.Size = new Size(205, 30);
            txt_Telefono1.TabIndex = 9;
            // 
            // txt_Apellido_M
            // 
            txt_Apellido_M.Location = new Point(127, 161);
            txt_Apellido_M.Name = "txt_Apellido_M";
            txt_Apellido_M.Size = new Size(205, 30);
            txt_Apellido_M.TabIndex = 8;
            // 
            // txt_Apellido_P
            // 
            txt_Apellido_P.Location = new Point(127, 117);
            txt_Apellido_P.Name = "txt_Apellido_P";
            txt_Apellido_P.Size = new Size(205, 30);
            txt_Apellido_P.TabIndex = 7;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(127, 74);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(205, 30);
            txt_Nombre.TabIndex = 6;
            // 
            // txt_Folio
            // 
            txt_Folio.Location = new Point(127, 32);
            txt_Folio.Name = "txt_Folio";
            txt_Folio.Size = new Size(205, 30);
            txt_Folio.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 32);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 5;
            label7.Text = "Folio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 264);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 4;
            label6.Text = "Teléfono2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 208);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 3;
            label5.Text = "Teléfono1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 162);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 2;
            label4.Text = "Apellido_M";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 115);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 1;
            label3.Text = "Apellido_P";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_Total);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txt_Monto);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(nUpDown);
            groupBox2.Controls.Add(btn_Quitar);
            groupBox2.Controls.Add(btn_Agregar);
            groupBox2.Controls.Add(cb_Formatos);
            groupBox2.Controls.Add(DataGrid_Formato);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Orange;
            groupBox2.Location = new Point(413, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(634, 392);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formato";
            // 
            // txt_Total
            // 
            txt_Total.Location = new Point(334, 344);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(125, 30);
            txt_Total.TabIndex = 15;
            txt_Total.TextChanged += textBox1_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(265, 351);
            label13.Name = "label13";
            label13.Size = new Size(54, 23);
            label13.TabIndex = 6;
            label13.Text = "Total:";
            // 
            // txt_Monto
            // 
            txt_Monto.Location = new Point(417, 64);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(125, 30);
            txt_Monto.TabIndex = 14;
            txt_Monto.Text = "170";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(380, 67);
            label12.Name = "label12";
            label12.Size = new Size(20, 23);
            label12.TabIndex = 13;
            label12.Text = "$";
            // 
            // nUpDown
            // 
            nUpDown.Location = new Point(237, 65);
            nUpDown.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nUpDown.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            nUpDown.Name = "nUpDown";
            nUpDown.Size = new Size(118, 30);
            nUpDown.TabIndex = 12;
            nUpDown.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // btn_Quitar
            // 
            btn_Quitar.BackColor = SystemColors.HighlightText;
            btn_Quitar.Location = new Point(511, 161);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(99, 47);
            btn_Quitar.TabIndex = 11;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.UseVisualStyleBackColor = false;
            btn_Quitar.Click += btn_Quitar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = SystemColors.HighlightText;
            btn_Agregar.Location = new Point(511, 100);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(99, 47);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // cb_Formatos
            // 
            cb_Formatos.FormattingEnabled = true;
            cb_Formatos.Items.AddRange(new object[] { "VHS", "Beta", "MiniDV", "8mm", "Super8", "DVD" });
            cb_Formatos.Location = new Point(18, 65);
            cb_Formatos.Name = "cb_Formatos";
            cb_Formatos.Size = new Size(189, 31);
            cb_Formatos.TabIndex = 4;
            cb_Formatos.Text = "Selecciona Formato";
            cb_Formatos.SelectedIndexChanged += cb_Formatos_SelectedIndexChanged;
            // 
            // DataGrid_Formato
            // 
            DataGrid_Formato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Formato.Columns.AddRange(new DataGridViewColumn[] { Formato, Duración, Monto });
            DataGrid_Formato.Location = new Point(15, 102);
            DataGrid_Formato.Name = "DataGrid_Formato";
            DataGrid_Formato.RowHeadersWidth = 51;
            DataGrid_Formato.Size = new Size(490, 229);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(417, 35);
            label10.Name = "label10";
            label10.Size = new Size(63, 23);
            label10.TabIndex = 2;
            label10.Text = "Monto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(237, 36);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 1;
            label9.Text = "Duración";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 36);
            label8.Name = "label8";
            label8.Size = new Size(154, 23);
            label8.TabIndex = 0;
            label8.Text = "Formato de Video";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_Guardar);
            groupBox3.Controls.Add(btn_Cancelar);
            groupBox3.Controls.Add(btn_ConsultarV);
            groupBox3.Controls.Add(btn_ConsultarC);
            groupBox3.Controls.Add(btn_salir);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Orange;
            groupBox3.Location = new Point(31, 489);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 223);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones";
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.HighlightText;
            btn_Guardar.Location = new Point(15, 40);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(99, 80);
            btn_Guardar.TabIndex = 9;
            btn_Guardar.Text = "Guardar Registro";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = SystemColors.HighlightText;
            btn_Cancelar.Location = new Point(127, 40);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(99, 80);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_ConsultarV
            // 
            btn_ConsultarV.BackColor = SystemColors.HighlightText;
            btn_ConsultarV.Location = new Point(127, 137);
            btn_ConsultarV.Name = "btn_ConsultarV";
            btn_ConsultarV.Size = new Size(99, 80);
            btn_ConsultarV.TabIndex = 7;
            btn_ConsultarV.Text = "Consultar Ventas";
            btn_ConsultarV.UseVisualStyleBackColor = false;
            btn_ConsultarV.Click += btn_ConsultarV_Click;
            // 
            // btn_ConsultarC
            // 
            btn_ConsultarC.BackColor = SystemColors.HighlightText;
            btn_ConsultarC.Location = new Point(15, 137);
            btn_ConsultarC.Name = "btn_ConsultarC";
            btn_ConsultarC.Size = new Size(99, 80);
            btn_ConsultarC.TabIndex = 6;
            btn_ConsultarC.Text = "Consultar Clientes";
            btn_ConsultarC.UseVisualStyleBackColor = false;
            btn_ConsultarC.Click += btn_ConsultarC_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = SystemColors.HighlightText;
            btn_salir.Location = new Point(237, 40);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(95, 80);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // Alerta
            // 
            Alerta.AutoSize = true;
            Alerta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alerta.Location = new Point(431, 626);
            Alerta.Name = "Alerta";
            Alerta.Size = new Size(161, 23);
            Alerta.TabIndex = 5;
            Alerta.Text = "Registro Guardado";
            Alerta.Visible = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1122, 718);
            Controls.Add(Alerta);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Formato).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_Telefono2;
        private TextBox txt_Telefono1;
        private TextBox txt_Apellido_M;
        private TextBox txt_Apellido_P;
        private TextBox txt_Nombre;
        private TextBox txt_Folio;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox groupBox3;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private Button btn_ConsultarV;
        private Button btn_ConsultarC;
        private Button btn_salir;
        private DateTimePicker dateTimePicker1;
        private Label label11;
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
        private Label Alerta;
        private TextBox txt_Total;
        private Label label13;
    }
}