using COSMOSCOM.Logica;
using COSMOSCOM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOSCOM
{
    public partial class Registro_user_ : Form
    {
        private string ultimoValorIngresado = "";
        public Registro_user_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes permisos de administrador para realizar esta acción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No tienes permisos de administrador para realizar esta acción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmación para salir del sistema
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                this.Hide();
                ultimoValorIngresado = txt_Folio.Text;
                // Actualiza el TextBox con el último valor ingresado
                txt_Folio.Text = ultimoValorIngresado;

                Properties.Settings.Default.UltimoValorIngresado = ultimoValorIngresado;
                Properties.Settings.Default.Save();
                Autenticacion form = new Autenticacion();
                form.Show();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto Clientes que hace referencia a la clase Clientes
            Clientes objetoClientes = new Clientes()
            {
                //Se inicializan las propiedades con los valores ingresados en os campos de texto.
                Nombre = txt_Nombre.Text,
                Apellido_P = txt_ApellidoP.Text,
                Apellido_M = txt_ApellidoM.Text,
                Telefono1 = txt_Telefono1.Text,
                Telefono2 = txt_Telefono2.Text,

            };

            Ventas objetoVentas = new Ventas()
            {
                //Se inicializan las propiedades con los valores ingresados en los campos de texto.
                Folio = int.Parse(txt_Folio.Text),
                Fecha_atencion = dtp_Fecha_atencion.Text,
                Fecha_entrega = dtp_Fecha_Entrega.Text,
                Total = txt_Total.Text,

            };


            if (ValidarCampos())
            {
                int.TryParse(txt_Folio.Text, out int numFolio); //Variable para actualizar el número de folio

                // Llamamos al metodo Guardar del clase ClientesLogica y lo  aginamos a una variable de tipo boleano.
                //Se utiliza la propiedad Instancia de la clase ClientesLogica.
                bool resClientes = ClientesLogica.Instancia.Guardar(objetoClientes);
                //Se utiliza la propiedad Instancia de la clase VentasLogica.
                bool resVentas = VentasLogica.Instancia.Guardar(objetoVentas);
                //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación

                if (resClientes)
                {
                    MessageBox.Show("Registro de clientes guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (resVentas)
                {
                    MessageBox.Show("Registro de ventas guardado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                numFolio++;

                txt_Folio.Text = numFolio.ToString();

                LimpiarDatos();


            }

        }

        private bool ValidarCampos()
        {
            // Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_ApellidoP.Text))
            {
                MessageBox.Show("Se necesita al menos un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Telefono1.Text))
            {
                MessageBox.Show("Se necesita al menos un número telefónico ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_Telefono1.TextLength != 10)
            {
                MessageBox.Show("El número de teléfono requiere de máximo 10 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txt_Telefono2.Text) && txt_Telefono2.TextLength < 10)
            {
                MessageBox.Show("Por favor, complete el segundo número de teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            //Verificar si existen fechas de entrega ya  registradas

            if (VentasLogica.Instancia.BuscarFechasEntrega(dtp_Fecha_Entrega.Text))
            {
                MessageBox.Show($"Ya existe un registro para la fecha de entrega {dtp_Fecha_Entrega.Value.ToShortDateString()}, selecciona otra fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!FormatosAgregados(dgvFormatos))
            {
                MessageBox.Show("Por favor, agregue elementos a la tabla de formatos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            



            return true;
        }

        private bool FormatosAgregados(DataGridView filaFormatos)
        {
            // Verifica si el DataGridView tiene al menos una fila
            return filaFormatos.Rows.Count > 0;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Muestra un cuadro de dialogo que pregunta si deseamos cancelar el registro
            DialogResult confirma = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Condicion que verifica si la respuesta fue confirmada si se cancela.
            if (confirma == DialogResult.Yes)
            {
                //Si se confirma la condicion se limpian los campos y se eliminan las filas del DataGridView
                LimpiarDatos();

            }
        }

        private void LimpiarDatos()
        {
            txt_Nombre.Text = "";
            txt_ApellidoP.Text = "";
            txt_ApellidoM.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono2.Text = "";
            dgvFormatos.Rows.Clear();
        }
        private bool seAgregoFila = false;
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un ítem en el ComboBox
            if (cb_Formatos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un formato antes de agregar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Captura de los datos ingresados de en los campos 
            string formato = cb_Formatos.Text;
            string duracion = nUpDown.Value.ToString();
            string monto = txt_Monto.Text;

            //Estos valores capturados se agregan como una nueva fila al DataGridView.
            dgvFormatos.Rows.Add(formato, duracion, monto);

            //Se itera sobre todas las filas del DataGridView para calcular la suma de los montos de las filas que tienen un valor en la tercera columna. 

            int total = 0; //Inicializar el total en 0

            for (int i = 0; i < dgvFormatos.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = dgvFormatos.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null) //se verifica si la fila actual no es una fila nueva
                {
                    total += Convert.ToInt32(fila.Cells[2].Value); //Se itera los valores sumados y se guardan en la variable total
                }
            }
            txt_Total.Text = total.ToString(); //La suma se guarda en el campo del total

            //Se actualiza el número de formatos mostrado en un control de etiqueta, excluyendo la última fila.
            int numFormatos = dgvFormatos.Rows.Count - 1;
            label16.Text = numFormatos.ToString();

        }

        private void btn_concultarC_Click(object sender, EventArgs e)
        {
            ConsultarClientes formularioExistente = Application.OpenForms.OfType<ConsultarClientes>().FirstOrDefault();


            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();

            }
            else
            {
                ConsultarClientes ventana = new ConsultarClientes();
                ventana.ShowDialog();
            }
        }

        private void btn_ConsultarV_Click(object sender, EventArgs e)
        {
            ConsultarVentas formularioExistente = Application.OpenForms.OfType<ConsultarVentas>().FirstOrDefault();


            if (formularioExistente != null)
            {
                formularioExistente.BringToFront();

            }
            else
            {
                ConsultarVentas ventana = new ConsultarVentas();
                ventana.ShowDialog();
            }
        }
    }
}
