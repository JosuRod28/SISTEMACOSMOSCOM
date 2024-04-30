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
    }
}
