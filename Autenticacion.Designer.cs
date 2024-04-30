namespace COSMOSCOM
{
    partial class Autenticacion
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
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();
            cbUsuarios = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.usuario1;
            pictureBox1.Location = new Point(223, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.00655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9869061F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.006546F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(txtClave, 1, 4);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 5);
            tableLayoutPanel1.Controls.Add(btnSalir, 2, 5);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(cbUsuarios, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 129);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.4402046F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.669211F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9949112F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.905852F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4681931F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5216284F));
            tableLayoutPanel1.Size = new Size(611, 395);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(223, 155);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(223, 248);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(223, 286);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(165, 27);
            txtClave.TabIndex = 4;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.GhostWhite;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Orange;
            btnLogin.Location = new Point(258, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top;
            btnSalir.BackColor = Color.GhostWhite;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Orange;
            btnSalir.Location = new Point(454, 335);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 39);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button2_Click;
            // 
            // cbUsuarios
            // 
            cbUsuarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUsuarios.ForeColor = SystemColors.Desktop;
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(223, 206);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(165, 28);
            cbUsuarios.TabIndex = 7;
            cbUsuarios.Text = "Elige un usuario";
            cbUsuarios.SelectedIndexChanged += txtUsuario_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(611, 101);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(605, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Autenticacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(611, 524);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(629, 571);
            MinimumSize = new Size(629, 571);
            Name = "Autenticacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Autenticacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox txtClave;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Button btnSalir;
        private ComboBox cbUsuarios;
    }
}
