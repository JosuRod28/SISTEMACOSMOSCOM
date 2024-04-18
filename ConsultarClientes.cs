using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COSMOSCOM
{
    public partial class ConsultarClientes : Form
    {
        private BindingList<Clientes> clientes = new BindingList<Clientes>();
        public ConsultarClientes()
        {
            InitializeComponent();
            DataGrid_Clientes.DataSource = clientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Inicializar el origen de datos del DataGridView
            DataGrid_Clientes.DataSource = null;
            // Obtener la filtración seleccionada en el ComboBox
            string filtracion = cb_filtro.SelectedItem?.ToString(); ;
            // Verificar si se ha seleccionado una opción de filtración
            if (!string.IsNullOrEmpty(filtracion))
            {
                // Obtener el texto de búsqueda del TextBox
                string textoBuscar = txt_buscar.Text;
                switch (filtracion)
                {   
                    case "Nombre":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consulta_nombre(textoBuscar);
                        break;

                    case "Apellido_P":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consulta_apellido_p(textoBuscar);
                        break;
                    case "Apellido_M":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consulta_apellido_m(textoBuscar);
                        break;
                    case "Teléfono 1":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consulta_telefono1(textoBuscar);
                        break;
                    case "Teléfono 2":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consulta_telefono2(textoBuscar);
                        break;

                    case "Cualquiera":
                        DataGrid_Clientes.DataSource = ClientesLogica.Instancia.consultarCualquiera();
                        break;
                    default:
                        // En caso de que el valor seleccionado no coincida con ninguno de los casos anteriores
                        txt_buscar.Text = ""; // o cualquier otra acción que desees realizar
                        break;
                }

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGrid_Clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid_Clientes.SelectedRows[0];
                if (selectedRow != null)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = DataGrid_Clientes.SelectedRows[0].Index;

                    // Obtener el objeto Cliente correspondiente a la fila seleccionada
                    Clientes clienteSeleccionado = (Clientes)DataGrid_Clientes.Rows[rowIndex].DataBoundItem;

                    // Obtener el ID del cliente seleccionado
                    int id_Cliente = clienteSeleccionado.id_Cliente;

                    // Verificar si el cliente está siendo referenciado en otra tabla
                    bool estaReferenciado = ClientesLogica.Instancia.refFK(id_Cliente);

                    // Si está referenciado, mostrar un mensaje de advertencia y no eliminar el registro
                    if (estaReferenciado)
                    {
                        MessageBox.Show("No se puede eliminar el cliente porque tiene registros relacionados en la tabla de Ventas. Elimine primero los registros de las ventas asociados a este cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método sin eliminar el registro
                    }


                    // Eliminar el registro de la base de datos
                    bool deleteRegistro = ClientesLogica.Instancia.Eliminar(id_Cliente);
                    //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación
                    if (deleteRegistro)
                    {
                        // Eliminar la fila seleccionada del DataGridView

                        MessageBox.Show("Registro eliminado", "Confirmación", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una opción en el ComboBox
            if (cb_filtro.SelectedItem.ToString() == "Cualquiera")
            {
                // Bloquear el TextBox
                txt_buscar.Enabled = false;
            }
            else
            {
                txt_buscar.Enabled = true;
            }
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
