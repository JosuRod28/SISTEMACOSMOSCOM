namespace COSMOSCOM
{
    partial class ConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVentas));
            pictureBox1 = new PictureBox();
            DataGrid_Ventas = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            btn_Regresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Ventas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(173, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DataGrid_Ventas
            // 
            DataGrid_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Ventas.Location = new Point(36, 92);
            DataGrid_Ventas.Name = "DataGrid_Ventas";
            DataGrid_Ventas.RowHeadersWidth = 51;
            DataGrid_Ventas.Size = new Size(591, 278);
            DataGrid_Ventas.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(410, 386);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 8;
            button1.Text = "Modificar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(DataGrid_Ventas);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Orange;
            groupBox1.Location = new Point(45, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 439);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 30);
            textBox1.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.HighlightText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(500, 47);
            button3.Name = "button3";
            button3.Size = new Size(110, 39);
            button3.TabIndex = 10;
            button3.Text = "Buscar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(528, 386);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_Regresar
            // 
            btn_Regresar.BackColor = SystemColors.HighlightText;
            btn_Regresar.FlatStyle = FlatStyle.Popup;
            btn_Regresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Regresar.ForeColor = Color.Orange;
            btn_Regresar.Location = new Point(573, 587);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(99, 38);
            btn_Regresar.TabIndex = 14;
            btn_Regresar.Text = "Regresar";
            btn_Regresar.UseVisualStyleBackColor = false;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // ConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(762, 653);
            Controls.Add(btn_Regresar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "ConsultarVentas";
            Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Ventas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView DataGrid_Ventas;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button btn_Regresar;
    }
}