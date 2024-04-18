namespace COSMOSCOM
{
    partial class ConsultarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarClientes));
            groupBox1 = new GroupBox();
            btn_Regresar = new Button();
            button4 = new Button();
            btn_Eliminar = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            DataGrid_Clientes = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            cb_filtro = new ComboBox();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Clientes).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Regresar);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btn_Eliminar);
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 518);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Clientes";
            // 
            // btn_Regresar
            // 
            btn_Regresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Regresar.BackColor = SystemColors.HighlightText;
            btn_Regresar.FlatStyle = FlatStyle.Popup;
            btn_Regresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Regresar.ForeColor = Color.Orange;
            btn_Regresar.Location = new Point(609, 444);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(96, 46);
            btn_Regresar.TabIndex = 13;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = false;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = SystemColors.HighlightText;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(612, 351);
            button4.Name = "button4";
            button4.Size = new Size(96, 46);
            button4.TabIndex = 8;
            button4.Text = "Modificar ";
            button4.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Eliminar.BackColor = SystemColors.HighlightText;
            btn_Eliminar.FlatStyle = FlatStyle.Popup;
            btn_Eliminar.Location = new Point(493, 351);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(95, 46);
            btn_Eliminar.TabIndex = 9;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += button2_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(DataGrid_Clientes, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel5.Location = new Point(127, 29);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 264F));
            tableLayoutPanel5.Size = new Size(584, 316);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // DataGrid_Clientes
            // 
            DataGrid_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Clientes.Dock = DockStyle.Fill;
            DataGrid_Clientes.Location = new Point(3, 55);
            DataGrid_Clientes.Name = "DataGrid_Clientes";
            DataGrid_Clientes.RowHeadersWidth = 51;
            DataGrid_Clientes.Size = new Size(578, 258);
            DataGrid_Clientes.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.16263F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4429054F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3944645F));
            tableLayoutPanel3.Controls.Add(cb_filtro, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_buscar, 2, 0);
            tableLayoutPanel3.Controls.Add(txt_buscar, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(578, 45);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // cb_filtro
            // 
            cb_filtro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_filtro.FormattingEnabled = true;
            cb_filtro.Items.AddRange(new object[] { "Cualquiera", "Nombre", "Apellido_P", "Apellido_M", "Teléfono 1", "Teléfono 2" });
            cb_filtro.Location = new Point(3, 8);
            cb_filtro.Name = "cb_filtro";
            cb_filtro.Size = new Size(151, 31);
            cb_filtro.TabIndex = 17;
            cb_filtro.Text = "Filtrar Por ";
            cb_filtro.SelectedIndexChanged += cb_filtro_SelectedIndexChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_buscar.BackColor = Color.MediumBlue;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.ForeColor = SystemColors.HighlightText;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buscar.Location = new Point(440, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(135, 39);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar";
            btn_buscar.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += button3_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_buscar.Location = new Point(160, 7);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(274, 30);
            txt_buscar.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(1, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(759, 544);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 460F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Location = new Point(-8, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(777, 108);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(173, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(762, 653);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            MaximumSize = new Size(780, 700);
            MinimumSize = new Size(780, 700);
            Name = "ConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarClientes";
            Load += ConsultarClientes_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid_Clientes).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_buscar;
        private Button btn_Eliminar;
        private DataGridView DataGrid_Clientes;
        private TextBox txt_buscar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button btn_Regresar;
        private ComboBox cb_filtro;
    }
}