using COSMOSCOM.Modelo;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace COSMOSCOM
{
    public partial class Autenticacion : Form

    {
        
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public Autenticacion()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
            txtClave.PasswordChar = '*';
        }

        public ComboBox ComboBoxAutenticaion
        {
            get { return cbUsuarios; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuarios usuarios = new Usuarios()
            {
                Usuario = cbUsuarios.Text,
                Clave = txtClave.Text,
            };

            if (ValidarUsuario(usuarios))
            {

                if (RolAdmin(cbUsuarios.Text))
                {
                    Registro_admin_ registroAdmin = new Registro_admin_();
                    registroAdmin.Show();
                    this.Hide();
                    MessageBox.Show("Login Exitoso");

                }

                if (RolUser(cbUsuarios.Text))
                {
                    Registro_user_ registroUser = new Registro_user_();
                    registroUser.Show();
                    this.Hide();
                    MessageBox.Show("Login Exitoso");

                }


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool RolAdmin(string usuario)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                int id_Rol=1;
                conn.Open();
                string query = "SELECT count(*) from Usuarios where usuario=@usuario AND id_Rol=@id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@id_rol", id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool RolUser(string usuario)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                int id_Rol = 2;
                conn.Open();
                string query = "SELECT count(*) from Usuarios where usuario=@usuario AND id_Rol=@id_rol";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@id_rol", id_Rol);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private bool ValidarUsuario(Usuarios obj)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND clave = @clave";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@clave", obj.Clave);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }



        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                // Consulta SQL para obtener los nombres de la tabla TablaDatos
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
                    // Verificar si el ítem ya está en el ComboBox antes de agregarlo
                    if (!cbUsuarios.Items.Contains(reader["usuario"].ToString()))
                    {
                        cbUsuarios.Items.Add(reader["usuario"].ToString());
                    }
                }
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
