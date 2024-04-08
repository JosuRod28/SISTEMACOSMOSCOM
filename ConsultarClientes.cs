using COSMOSCOM.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGrid_Clientes.DataSource = null;
            DataGrid_Clientes.DataSource = ClientesLogica.Instancia.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();

            ventana.Show();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
