using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMOSCOM.Logica
{
    public  class UsuariosLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static UsuariosLogica _instancia = null;
        public UsuariosLogica()
        {


        }

        public static UsuariosLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsuariosLogica();
                }
                return _instancia;
            }


        }


        public List<Usuarios> ListUsuarios()
        {

            List<Usuarios> olista = new List<Usuarios>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Usuarios()
                        {
                            id_usuario = int.Parse(dataReader["id_usuario"].ToString()),
                            Usuario = dataReader["usuario"].ToString(),
                            Clave = dataReader["clave"].ToString(),
                            id_Rol = int.Parse(dataReader["id_Rol"].ToString()),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool IngresarNuevoUsuario(Usuarios obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (usuario,clave,id_Rol) values (@nuevoUsuario,@nuevaClave,@id_rol)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nuevoUsuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@nuevaClave", obj.Clave);
                cmd.Parameters.AddWithValue("@id_rol", obj.id_Rol);
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {

                    respuesta = false;

                }

            }

            return respuesta;

        }




        public bool Eliminar(int idUsuario)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Usuarios WHERE id_usuario = @id_usuario";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                int filasAfectadas = cmd.ExecuteNonQuery(); // Obtiene el número de filas afectadas por la operación

                if (filasAfectadas > 0)
                {
                    respuesta = true; // Si se eliminó al menos una fila, establece la respuesta como true
                }
                conn.Close();
            }
            return respuesta;
        }
    }
}
