using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace COSMOSCOM.Logica
{
    public class DetalleVentaLogica
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        private static DetalleVentaLogica _instancia = null;

        public DetalleVentaLogica()
        {

        }

        public static DetalleVentaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DetalleVentaLogica();
                }
                return _instancia;
            }


        }

        public bool InsertarDetalleVenta(string formato, string duracion, string monto)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(conexion))
                {
                    conn.Open();
                    string InsertDetalleVenta = "INSERT INTO Detalle_Venta(Folio_Venta,id_Cliente,id_Formato,Duracion,Monto) values ((SELECT MAX(Folio) FROM Venta_Total),(SELECT MAX(id_Cliente) FROM Clientes),(SELECT id_Formato  from Formatos where Formato=@formato),@duracion,@monto)";
                    SQLiteCommand cmdDetalleVenta = new SQLiteCommand(InsertDetalleVenta, conn);
                    cmdDetalleVenta.Parameters.AddWithValue("@formato", formato);
                    cmdDetalleVenta.Parameters.AddWithValue("@duracion", duracion);
                    cmdDetalleVenta.Parameters.AddWithValue("@monto", monto);

                    // Ejecutar el comando para realizar la inserción de datos
                    int filasInsertadas = cmdDetalleVenta.ExecuteNonQuery();

                    // Devolver true si se insertaron filas correctamente, de lo contrario, devolver false
                    return filasInsertadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la actualización
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }

        }

        public List<DetalleVenta> ListarDetalleVenta(int folio  )
        {

            List<DetalleVenta> olista = new List<DetalleVenta>();

            using (SQLiteConnection conn = new SQLiteConnection(conexion))

            {

                conn.Open();
                string query = "select * from Detalle_Venta WHERE Folio_Venta=@folio_venta" ;
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@folio_venta", folio);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        olista.Add(new DetalleVenta()
                        {
                           Folio_Venta= int.Parse(dataReader["Folio_Venta"].ToString()),
                            id_Cliente = int.Parse(dataReader["id_Cliente"].ToString()),
                            id_Formato = int.Parse(dataReader["id_Formato"].ToString()),
                            Duracion = dataReader["Duracion"].ToString(),
                            Monto = dataReader["Monto"].ToString(),


                        });

                    }
                    dataReader.Close();
                }
                conn.Close();
            }

            return olista;

        }
    }
}
