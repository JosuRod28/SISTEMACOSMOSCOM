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
    public partial class AdministraUsuarios : Form
    {
        public AdministraUsuarios()
        {
            InitializeComponent();
        }

        private void AdministraUsuarios_Load(object sender, EventArgs e)
        {
            dGVUsuarios.DataSource = null;
            dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();

        }

        private void dGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dGVUsuarios.SelectedRows[0];
                    if (selectedRow != null)
                    {
                        // Obtener el índice de la fila seleccionada
                        int rowIndex = dGVUsuarios.SelectedRows[0].Index;

                        // Obtener el objeto Cliente correspondiente a la fila seleccionada
                        Usuarios usuarioSeleccionado = (Usuarios)dGVUsuarios.Rows[rowIndex].DataBoundItem;

                        // Obtener el ID del cliente seleccionado
                        int id_usuario = usuarioSeleccionado.id_usuario;

                        // Eliminar el registro de la base de datos
                        bool deleteRegistro = UsuariosLogica.Instancia.Eliminar(id_usuario);
                        //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación
                        if (deleteRegistro)
                        {

                            // Remover la fila de la fuente de datos
                            UsuariosLogica.Instancia.ListUsuarios().Remove(usuarioSeleccionado);
                            // Actualizar el DataGridView
                            dGVUsuarios.DataSource = null;
                            dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVUsuarios.SelectedCells.Count > 0)
                {
                    // Obtener la celda seleccionada
                    DataGridViewCell selectedCell = dGVUsuarios.SelectedCells[0];

                    // Obtener el ID del usuario
                    int idUsuario = Convert.ToInt32(dGVUsuarios.Rows[selectedCell.RowIndex].Cells["id_usuario"].Value);

                    string nombreColumna = dGVUsuarios.Columns[selectedCell.ColumnIndex].Name;

                    string nuevoValor = selectedCell.Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreColumna) && nuevoValor != null)
                    {
                        // Construir la consulta de actualización
                        string consulta = $"UPDATE Usuarios SET {nombreColumna} = '{nuevoValor}' WHERE id_usuario = {idUsuario}";
                        // Actualizar los datos en la base de datos

                        if (UsuariosLogica.Instancia.ActualizarUsuario(consulta))
                        {
                            MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Actualizar el DataGridView
                            dGVUsuarios.DataSource = UsuariosLogica.Instancia.ListUsuarios();
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
        
    }
}
