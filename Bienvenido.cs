using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class Bienvenido : Form
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private AdministraUsuarios _administraUsuarios;
        public Bienvenido()
        {
            InitializeComponent();
            txt_clave.UseSystemPasswordChar = true;
            txt_clave.PasswordChar = '*';

            ApplyBgImage();


        }

        private void ApplyBgImage()
        {
            string backgroundImagePath = Properties.Settings.Default.BackgroundImagePath;
            if (!string.IsNullOrEmpty(backgroundImagePath) && System.IO.File.Exists(backgroundImagePath))
            {
                Image backgroundImage = Image.FromFile(backgroundImagePath);
                SetBackgroundImage(this, backgroundImage);
            }
            else
            {
                Color backgroundColor = Properties.Settings.Default.BackgroundColor;
                SetBackgroundColor(this, backgroundColor);
                RemoveBackgroundImage(this);
            }
        }

        private void SetBackgroundImage(Bienvenido bienvenido, Image backgroundImage)
        {
            bienvenido.BackgroundImage = backgroundImage;
            bienvenido.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RemoveBackgroundImage(Bienvenido bienvenido)
        {
            bienvenido.BackgroundImage = null;
        }

        private void SetBackgroundColor(Bienvenido bienvenido, Color backgroundColor)
        {
            bienvenido.BackColor = backgroundColor;
        }


        public TextBox TextBox_Usuario
        {
            get { return txt_usuario; }
        }
        public TextBox Textbox_Clave
        {
            get { return txt_clave; }
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_clave.Text) && string.IsNullOrWhiteSpace(txt_usuario.Text))
            {

                MessageBox.Show("Por favor ingrese un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txt_clave.Text))
            {
                MessageBox.Show("Por favor ingrese un una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_clave.Focus();

                return;
            }


            int idRol = 1;
            Usuarios nuevoUsuario = new Usuarios()
            {
                Usuario = txt_usuario.Text,
                Clave = txt_clave.Text,
                Correo = txt_email.Text,
                id_Rol = idRol,
            };

            if (VerificarAdminExistente(nuevoUsuario))
            {
                Clave_Administrador clave_Administrador = new Clave_Administrador();
                clave_Administrador.ShowDialog();

            }
            else
            {
                bool respuesta = UsuariosLogica.Instancia.IngresarNuevoUsuario(nuevoUsuario);

                if (respuesta)
                {
                    Registro_admin_ registroAdmin = new Registro_admin_();
                    registroAdmin.Show();
                    this.Hide();
                    MessageBox.Show("¡Usuario creado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SeleccionarUsuario();
                }
            }

        }

        private void SeleccionarUsuario()
        {
            Autenticacion nuevoitem = Application.OpenForms.OfType<Autenticacion>().FirstOrDefault();
            if (nuevoitem != null) // Verificar si nuevoitem no es nulo)
            {
                using (SQLiteConnection connection = new SQLiteConnection(conexion))
                {
                    // Consulta SQL para obtener los nombres de la tabla Usuarios
                    string query = "SELECT usuario FROM Usuarios";
                    // Crear un comando SQL con la consulta y la conexión
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    // Abrir la conexión
                    connection.Open();
                    // Ejecutar la consulta y obtener los resultados
                    SQLiteDataReader reader = command.ExecuteReader();
                    // Recorrer los resultados y agregar cada nombre al ComboBox
                    while (reader.Read())
                    {
                        // Verificar si nuevoitem.ComboBoxAutenticaion no es nulo antes de intentar acceder a él
                        if (nuevoitem.ComboBoxAutenticaion != null)
                        {
                            // Verificar si el ítem ya está en el ComboBox antes de agregarlo
                            if (!nuevoitem.ComboBoxAutenticaion.Items.Contains(reader["usuario"].ToString()))
                            {
                                nuevoitem.ComboBoxAutenticaion.Items.Add(reader["usuario"].ToString());
                            }
                        }
                    }
                }

            }
        }

        private bool VerificarAdminExistente(Usuarios admin)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios where id_Rol = @id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_rol", admin.id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            Autenticacion autenticacion = new Autenticacion();
            autenticacion.Show();
            this.Hide();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
