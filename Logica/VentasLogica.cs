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
    public class VentasLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private static VentasLogica _instancia = null;
        public VentasLogica()
        {

        }

        public static VentasLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new VentasLogica();
                }
                return _instancia;
            }


        }

        public bool Guardar(Ventas obj)
        {
            bool respuesta = true;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string queryInsert = "INSERT INTO Venta_Total(Folio,id_Cliente,Fecha_de_atencion,Fecha_de_entrega,Total) values (@folio,(SELECT MAX(id_Cliente) FROM Clientes),@fecha_de_atencion,@fecha_de_entrega,@total)";
                SQLiteCommand cmdInsert = new SQLiteCommand(queryInsert,conn);
                cmdInsert.Parameters.Add( new SQLiteParameter("@folio",obj.Folio));
                cmdInsert.Parameters.Add( new SQLiteParameter("@fecha_de_atencion", obj.Fecha_atencion));
                cmdInsert.Parameters.Add( new SQLiteParameter("@fecha_de_entrega", obj.Fecha_entrega));
                cmdInsert.Parameters.Add( new SQLiteParameter("@total", obj.Total));
                cmdInsert.CommandType = System.Data.CommandType.Text;

                if (cmdInsert.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }


            return respuesta;

        }

        public bool BuscarFechasEntrega(string Fecha_entrega)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conexion)) 
            {

                conn.Open();
                string querySelectFecha = "select * from Venta_Total where Fecha_de_entrega=@fecha_de_entrega";
                SQLiteCommand cmdSelectFecha = new SQLiteCommand(querySelectFecha, conn);
                cmdSelectFecha.Parameters.AddWithValue("@fecha_de_entrega", Fecha_entrega);
                cmdSelectFecha.CommandType = System.Data.CommandType.Text;
                int count = Convert.ToInt32(cmdSelectFecha.ExecuteScalar());

                // Si count es mayor que 0, significa que hay al menos un registro con la fecha de entrega proporcionada
                return count > 0;

            }
        }

        public List<Ventas> consultar_todo()
        {
            List<Ventas> olista = new List<Ventas>();
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "select * from Venta_Total";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente= int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega= dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                }
            }

            return olista;

        }

        public List<Ventas> consulta_folio(int folio)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Folio = @folio ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio", folio);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }


        public List<Ventas> consulta_idCliente(int idCliente)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE id_Cliente = @id_cliente ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_cliente", idCliente);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> consultaFechaAtencion(string fecha_atencion)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Fecha_de_atencion = @fecha_de_atencion";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha_de_atencion", fecha_atencion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> consultaFechaEntrega(string fecha_entrega)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Fecha_de_entrega = @fecha_de_entrega";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha_de_entrega", fecha_entrega);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public List<Ventas> consultarTotal(string total)
        {

            List<Ventas> olista = new List<Ventas>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Venta_Total WHERE Total = @total";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@total", total);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new Ventas()
                        {
                            Folio = int.Parse(dataReader["Folio"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            Fecha_atencion = dataReader["Fecha_de_atencion"].ToString(),
                            Fecha_entrega = dataReader["Fecha_de_entrega"].ToString(),
                            Total = dataReader["Total"].ToString(),

                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }

        public bool Eliminar(int folio)
        {

            bool respuesta = false;
            using (SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Venta_Total WHERE Folio = @folio";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio", folio);
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
