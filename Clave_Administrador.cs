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
    public partial class Clave_Administrador : Form
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public Clave_Administrador()
        {
            InitializeComponent();
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

        private void SetBackgroundImage(Clave_Administrador clave_Administrador, Image backgroundImage)
        {
            clave_Administrador.BackgroundImage = backgroundImage;
            clave_Administrador.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RemoveBackgroundImage(Clave_Administrador clave_Administrador)
        {
            clave_Administrador.BackgroundImage = null;
        }

        private void SetBackgroundColor(Clave_Administrador clave_Administrador, Color backgroundColor)
        {
            clave_Administrador.BackColor = backgroundColor;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Registro_admin_ registroAdmin = new Registro_admin_();
            Bienvenido campo = Application.OpenForms.OfType<Bienvenido>().FirstOrDefault();

            int idRol = 1;
            Usuarios admin = new Usuarios()
            {
                Clave = txt_claveAdmin.Text,
                id_Rol = idRol,
            };

            Usuarios nuevoUsuario = new Usuarios()
            {
                Usuario = campo.TextBox_Usuario.Text,
                Clave = campo.Textbox_Clave.Text,
                id_Rol = idRol,
            };

            if (VerificarClaveAdmin(admin))
            {
                if (!VerificarUsuarioExistente(nuevoUsuario))
                {

                    bool respuesta = UsuariosLogica.Instancia.IngresarNuevoUsuario(nuevoUsuario);

                    if (respuesta)
                    {
                      
                        registroAdmin.Show();
                        this.Close();
                        MessageBox.Show("¡Usuario creado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        campo.Hide();
                        SeleccionarUsuario();
                    }

                }
                else
                {
                    MessageBox.Show("Usuario ya existente, por favor ingrese uno nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    campo.TextBox_Usuario.Focus();
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

        private bool VerificarUsuarioExistente(Usuarios nuevoUsuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios where usuario =@usuario AND clave =@clave";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", nuevoUsuario.Usuario);
                cmd.Parameters.AddWithValue("@clave", nuevoUsuario.Clave);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool VerificarClaveAdmin(Usuarios admin)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE  clave = @clave and id_Rol=@id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@clave", admin.Clave);
                cmd.Parameters.AddWithValue("@id_rol", admin.id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private void Clave_Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
