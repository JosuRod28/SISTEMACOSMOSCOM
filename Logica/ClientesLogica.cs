using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COSMOSCOM.Modelo;
using Microsoft.VisualBasic.Devices;

namespace COSMOSCOM.Logica
{
    public class ClientesLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static ClientesLogica _instancia = null;
        public ClientesLogica()
        {


        }

        public static ClientesLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ClientesLogica();
                }
                return _instancia;
            }


        }


        public int idCliente()
        {
            int idCliente = -1;
            string query = "SELECT max(id_Cliente)+1 From Clientes;";
            using (SQLiteConnection connection = new SQLiteConnection(conexion))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Ejecutar la consulta y obtener el resultado
                    object result = cmd.ExecuteScalar();

                    // Verificar si se obtuvo un resultado no nulo
                    if (result != null && result != DBNull.Value)
                    {
                        idCliente = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                }
            }
            return idCliente;
        }
        public bool Guardar(Clientes obj)
        {
            bool respuesta = true;
            
            using(SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                    string queryInsertar = "INSERT INTO Clientes(id_Cliente,Nombre, Apellido_P, Apellido_M, Telefono1, Telefono2) VALUES (@id_cliente,@nombre, @apellido_p, @apellido_m, @telefono1, @telefono2)";
                    SQLiteCommand cmdInsertar = new SQLiteCommand(queryInsertar, conn);
                cmdInsertar.Parameters.AddWithValue("@id_cliente",obj.id_Cliente);
                    cmdInsertar.Parameters.AddWithValue("@nombre", obj.Nombre);
                    cmdInsertar.Parameters.AddWithValue("@apellido_p", obj.Apellido_P);
                    cmdInsertar.Parameters.AddWithValue("@apellido_m", obj.Apellido_M);
                    cmdInsertar.Parameters.AddWithValue("@telefono1", obj.Telefono1);
                    cmdInsertar.Parameters.AddWithValue("@telefono2", obj.Telefono2);

                    if (cmdInsertar.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                

            }
            return respuesta;

        }



        public bool ver_idCliente(int idCliente)
        {
            bool respuesta = false;

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                // Verificar si ya existe un registro con la misma clave primaria
                string queryVerificacion = "SELECT COUNT(*) FROM Clientes WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmdVerificacion = new SQLiteCommand(queryVerificacion, conn);
                cmdVerificacion.Parameters.AddWithValue("@id_cliente",idCliente );
                int cantidadRegistros = Convert.ToInt32(cmdVerificacion.ExecuteScalar());
                // Si ya existe un registro con la misma clave primaria, abortar la inserción
                if (cantidadRegistros > 0)
                {
                    
                    respuesta = true;
                }
            }
            return respuesta;
        }
        

        public List<Clientes> consultarTodos()
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Clientes> consulta_nombre(string nombre)
        {
            
            List<Clientes> olista = new List<Clientes>();
            
            using (SQLiteConnection conn = new SQLiteConnection(conexion)) 
        
            {
                
                conn.Open();
                string query= "select * from Clientes WHERE Nombre = @nombre ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre",nombre);

                cmd.CommandType=System.Data.CommandType.Text;

                using(SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });
                            
                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

         }

        public List<Clientes> consulta_apellido_p(string apellido_p)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Apellido_P = @apellido_p ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@apellido_p", apellido_p);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }


        public List<Clientes> consulta_apellido_m(string apellido_m)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Apellido_M = @apellido_m";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@apellido_m", apellido_m);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Clientes> consulta_telefono1(string telefono1)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Telefono1 = @telefono1 ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefono1", telefono1);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Clientes> consulta_telefono2(string telefono2)
        {

            List<Clientes> olista = new List<Clientes>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Clientes WHERE Telefono2 = @telefono2 ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@telefono2", telefono2);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Clientes()
                        {
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Nombre = dataReader["Nombre"].ToString(),
                            Apellido_P = dataReader["Apellido_P"].ToString(),
                            Apellido_M = dataReader["Apellido_M"].ToString(),
                            Telefono1 = dataReader["Telefono1"].ToString(),
                            Telefono2 = dataReader["Telefono2"].ToString(),


                        });
                       


                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool Eliminar(int id)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Clientes WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", id);
                int filasAfectadas = cmd.ExecuteNonQuery(); // Obtiene el número de filas afectadas por la operación
              
                if (filasAfectadas> 0)
                {
                    respuesta = true; // Si se eliminó al menos una fila, establece la respuesta como true
                }
                conn.Close ();
            }
            return respuesta; 
        }

        public bool refFKVentas(int idCliente)
        {
          
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query1 = "SELECT COUNT(*) FROM Venta_Total WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;

            }

        }

        public bool refFKDetalleVentas(int idCliente)
        {

            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query1 = "SELECT COUNT(*) FROM Detalle_Venta WHERE id_Cliente = @id_cliente";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;

            }

        }

        public bool ActualizarCliente(string queryActualiza)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();

                    SQLiteCommand cmd = new SQLiteCommand(queryActualiza, conn);

                    // Ejecutar la consulta de actualización
                    int filasActualizadas = cmd.ExecuteNonQuery();
                    // Verificar si se actualizaron filas
                    return filasActualizadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }
            
        }












    }
}
