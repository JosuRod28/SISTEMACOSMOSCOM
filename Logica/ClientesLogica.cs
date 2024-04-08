using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COSMOSCOM.Modelo;

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

        public bool Guardar(Clientes obj)
        {
            bool respuesta = true;

            using(SQLiteConnection conn = new SQLiteConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Clientes(Nombre,Apellido_P,Apellido_M,Telefono1,Telefono2) values (@nombre,@apellido_p,@apellido_m,@telefono1,@telefono2)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add(new SQLiteParameter("@nombre",obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido_p",obj.Apellido_P));
                cmd.Parameters.Add(new SQLiteParameter("@apellido_m",obj.Apellido_M));
                cmd.Parameters.Add(new SQLiteParameter("@telefono1",obj.Telefono1));
                cmd.Parameters.Add(new SQLiteParameter("@telefono2",obj.Telefono2));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }
            return respuesta;

        }

        public List<Clientes> Listar()
        {
            List<Clientes> olista = new List<Clientes>();
            using (SQLiteConnection conn = new SQLiteConnection(conexion)) 
            {
                conn.Open();
                string query = "select * from Clientes";
                SQLiteCommand cmd = new SQLiteCommand(query, conn); 
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
                }
            }

            return olista;

         }



       

    }
}
