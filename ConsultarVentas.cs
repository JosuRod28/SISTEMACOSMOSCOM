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

namespace COSMOSCOM
{
    public partial class ConsultarVentas : Form
    {
        private BindingList<Ventas> ventas = new BindingList<Ventas>();
        public ConsultarVentas()
        {
            InitializeComponent();
            DataGrid_Ventas.DataSource = ventas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Ventas.SelectedCells.Count > 0)
                {
                    // Obtener la celda seleccionada
                    DataGridViewCell selectedCell = DataGrid_Ventas.SelectedCells[0];

                    // Obtener el ID del cliente
                    int folio = Convert.ToInt32(DataGrid_Ventas.Rows[selectedCell.RowIndex].Cells["Folio"].Value);

                    string nombreColumna = DataGrid_Ventas.Columns[selectedCell.ColumnIndex].Name;

                    string nuevoValor = selectedCell.Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreColumna) && nuevoValor != null)
                    {
                        // Construir la consulta de actualización
                        string consulta = $"UPDATE Venta_Total SET {nombreColumna} = '{nuevoValor}' WHERE Folio = {folio}";
                        // Actualizar los datos en la base de dato

                        if (VentasLogica.Instancia.ActualizarVentas(consulta))
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Actualizar el DataGridView
                            DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo determinar la celda seleccionada o el valor de la celda es nulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("No se pudo determinar la celda seleccionada o el valor de la celda es nulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Inicializar el origen de datos del DataGridView
            DataGrid_Ventas.DataSource = null;
            // Obtener la filtración seleccionada en el ComboBox
            string filtracion = cb_filtro.SelectedItem?.ToString(); ;
            // Verificar si se ha seleccionado una opción de filtración

            if (!string.IsNullOrEmpty(filtracion))
            {
                // Obtener el texto de búsqueda del TextBox
                string textoBuscar = txt_buscar.Text;

                switch (filtracion)
                {

                    case "Folio":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFolio(int.Parse(textoBuscar));
                        break;

                    case "id_Cliente":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultaPorCliente(int.Parse(textoBuscar));
                        break;
                    case "Fecha de atención":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFechaAtencion(textoBuscar);
                        break;
                    case "Fecha de entrega":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarPorFechaEntrega(textoBuscar);
                        break;
                    case "Todos":
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();
                        break;
                    default:
                        // En caso de que el valor seleccionado no coincida con ninguno de los casos anteriores
                        txt_buscar.Text = ""; // o cualquier otra acción que desees realizar
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGrid_Ventas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];
                if (selectedRow != null)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = DataGrid_Ventas.SelectedRows[0].Index;
                    // Obtener el objeto Venta correspondiente a la fila seleccionada
                    Ventas ventaSeleccionada = (Ventas)DataGrid_Ventas.Rows[rowIndex].DataBoundItem;
                    // Obtener el Folio seleccionado
                    int folio = ventaSeleccionada.Folio;
                    // Eliminar el registro de la base de datos
                    bool deleteRegistro = VentasLogica.Instancia.Eliminar(folio);
                    //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación
                    if (deleteRegistro)
                    {
                        // // Remover la fila de la fuente de datos
                        VentasLogica.Instancia.ConsultarTodos().Remove(ventaSeleccionada);

                        // Actualizar el DataGridView
                        DataGrid_Ventas.DataSource = null;
                        DataGrid_Ventas.DataSource = VentasLogica.Instancia.ConsultarTodos();

                        //Mensaje de confirmación
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una opción en el ComboBox
            if (cb_filtro.SelectedItem.ToString() == "Todos")
            {
                // Bloquear el TextBox
                txt_buscar.Enabled = false;
            }
            else
            {
                txt_buscar.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DataGrid_Ventas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid_Ventas.SelectedRows[0];
                if (selectedRow != null)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = DataGrid_Ventas.SelectedRows[0].Index;
                    // Obtener el Folio seleccionado
                    int folio = (int)DataGrid_Ventas.Rows[rowIndex].Cells[0].Value;

                    DataGrid_Ventas.DataSource = null;
                    DataGrid_Ventas.DataSource = DetalleVentaLogica.Instancia.ListarDetalleVenta(folio);
            

                }
            }
        }
    }
}
