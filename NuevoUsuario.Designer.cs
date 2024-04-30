namespace COSMOSCOM
{
    partial class NuevoUsuario
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
            btnAgregarNuevo = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNuevoUsuario = new TextBox();
            txtNuevoPasswd = new TextBox();
            cbRoles = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarNuevo
            // 
            btnAgregarNuevo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarNuevo.Location = new Point(4, 11);
            btnAgregarNuevo.Margin = new Padding(4);
            btnAgregarNuevo.Name = "btnAgregarNuevo";
            btnAgregarNuevo.Size = new Size(304, 36);
            btnAgregarNuevo.TabIndex = 1;
            btnAgregarNuevo.Text = "Agregar";
            btnAgregarNuevo.UseVisualStyleBackColor = true;
            btnAgregarNuevo.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(316, 11);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(304, 36);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarNuevo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 292);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(624, 59);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6410255F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3589745F));
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(txtNuevoUsuario, 1, 0);
            tableLayoutPanel2.Controls.Add(txtNuevoPasswd, 1, 1);
            tableLayoutPanel2.Controls.Add(cbRoles, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(624, 292);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 228);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 30);
            label3.TabIndex = 4;
            label3.Text = "Rol";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(308, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(308, 30);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNuevoUsuario
            // 
            txtNuevoUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNuevoUsuario.Location = new Point(320, 33);
            txtNuevoUsuario.Margin = new Padding(4);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(300, 31);
            txtNuevoUsuario.TabIndex = 2;
            txtNuevoUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNuevoPasswd
            // 
            txtNuevoPasswd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNuevoPasswd.Location = new Point(320, 130);
            txtNuevoPasswd.Margin = new Padding(4);
            txtNuevoPasswd.Name = "txtNuevoPasswd";
            txtNuevoPasswd.Size = new Size(300, 31);
            txtNuevoPasswd.TabIndex = 3;
            txtNuevoPasswd.TextAlign = HorizontalAlignment.Center;
            // 
            // cbRoles
            // 
            cbRoles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbRoles.FormattingEnabled = true;
            cbRoles.Items.AddRange(new object[] { "admin", "user" });
            cbRoles.Location = new Point(319, 226);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(302, 33);
            cbRoles.TabIndex = 5;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(624, 351);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            MaximumSize = new Size(646, 407);
            MinimumSize = new Size(646, 407);
            Name = "NuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoUsuario";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Button btnAgregarNuevo;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TextBox txtNuevoUsuario;
        private TextBox txtNuevoPasswd;
        private Label label3;
        private ComboBox cbRoles;
    }
}