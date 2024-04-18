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
using COSMOSCOM.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace COSMOSCOM
{
    public partial class Registro : Form
    {
        private string ultimoValorIngresado="" ;
        public Registro()
        {

            InitializeComponent();
            // El valor de la duracion se cambian con el componente numericUpDown
            nUpDown.ValueChanged += UpDown_ValueChanged;
            //Se asigna un valor inicial en el campo monto
            txt_Monto.Text = "170";

        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            // Obtener el valor actual de la duracion
            int valor = (int)nUpDown.Value;

            //Calculo del monto
            int monto;
            monto = valor * 170 / 120;
            // Asignar el monto dependiendo de la duracion
            txt_Monto.Text = monto.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmación para salir del sistema
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto Clientes que hace referencia a la clase Clientes
            Clientes objetoClientes = new Clientes()
            {
                //Se inicializan las propiedades con los valores ingresados en os campos de texto.
                Nombre = txt_Nombre.Text,
                Apellido_P = txt_Apellido_P.Text,
                Apellido_M = txt_Apellido_M.Text,
                Telefono1 = txt_Telefono1.Text,
                Telefono2 = txt_Telefono2.Text,

            };

            Ventas objetoVentas = new Ventas()
            {
                //Se inicializan las propiedades con los valores ingresados en los campos de texto.
                Folio = int.Parse(txt_Folio.Text),
                Fecha_atencion = dtp_Fecha_atencion.Text,
                Fecha_entrega =dtp_Fecha_entrega.Text,
                Total=txt_Total.Text,

            };
            // Llamamos al metodo Guardar de l clase ClientesLogica y lo  aginamos a una variable de tipo boleano.
            //Se utiliza la propiedad Instancia de la clase ClientesLogica.
            bool resClientes = ClientesLogica.Instancia.Guardar(objetoClientes);
            //Se utiliza la propiedad Instancia de la clase VentasLogica.
            bool resVentas =VentasLogica.Instancia.Guardar(objetoVentas);
            //Verificar si la respuesta fue exitosa mostrando un mensaje de confirmación
            if (resClientes)
            {
                MessageBox.Show("Registro de clientes guardado", "Confirmación", MessageBoxButtons.OK);
            }
            if (resVentas)
            {
                MessageBox.Show("Registro de ventas guardado", "Confirmación", MessageBoxButtons.OK);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Muestra un cuadro de dialogo que pregunta si deseamos cancelar el registro
            DialogResult confirma = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Condicion que verifica si la respuesta fue confirmada si se cancela.
            if (confirma == DialogResult.Yes)
            {
                //Si se confirma la condicion se limpian los campos y se eliminan las filas del DataGridView
                txt_Folio.Text = "";
                txt_Nombre.Text = "";
                txt_Apellido_P.Text = "";
                txt_Apellido_M.Text = "";
                txt_Telefono1.Text = "";
                txt_Telefono1.Text = "";
                txt_Telefono2.Text = "";
                DataGrid_Formato.Rows.Clear();

            }



        }

        private void cb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // Cargar el último valor ingresado desde la configuración de la aplicación
            ultimoValorIngresado = Properties.Settings.Default.UltimoValorIngresado;
            // Mostrar el último valor ingresado en el TextBox
            txt_Folio.Text = ultimoValorIngresado;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Captura de los datos ingresados de en los campos 
            string formato = cb_Formatos.Text;
            string duracion = nUpDown.Value.ToString();
            string monto = txt_Monto.Text;

            //Estos valores capturados se agregan como una nueva fila al DataGridView.
            DataGrid_Formato.Rows.Add(formato, duracion, monto);

            //Se itera sobre todas las filas del DataGridView para calcular la suma de los montos de las filas que tienen un valor en la tercera columna. 

            int total = 0; //Inicializar el total en 0

            for (int i = 0; i < DataGrid_Formato.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = DataGrid_Formato.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null) //se verifica si la fila actual no es una fila nueva
                {
                    total += Convert.ToInt32(fila.Cells[2].Value); //Se itera los valores sumados y se guardan en la variable total
                }
            }
            txt_Total.Text = total.ToString(); //La suma se cuarda en el campo del total

            //Se actualiza el número de formatos mostrado en un control de etiqueta, excluyendo la última fila.
            int numFormatos = DataGrid_Formato.Rows.Count - 1;
            label15.Text = numFormatos.ToString();


        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (DataGrid_Formato.SelectedRows.Count > 0) // se verifica que la fila esta seleccionada
            {

                DataGrid_Formato.Rows.Remove(DataGrid_Formato.SelectedRows[0]);//Se Elimina la fila seleccionada

                //Llama el metodo para actualizar el valor del total.
                ActualizarTotal();

            }
        }

        private void ActualizarTotal()
        {
            int total = 0;
            for (int i = 0; i < DataGrid_Formato.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = DataGrid_Formato.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null)
                {
                    total += Convert.ToInt32(fila.Cells[2].Value);
                }
            }

            txt_Total.Text = total.ToString();
            int numFormatos = DataGrid_Formato.Rows.Count - 1;
            label15.Text = numFormatos.ToString();
        }

        private void btn_ConsultarC_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Resize(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Resize(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultimoValorIngresado = txt_Folio.Text;
            // Actualiza el TextBox con el último valor ingresado
            txt_Folio.Text = ultimoValorIngresado;

            Properties.Settings.Default.UltimoValorIngresado = ultimoValorIngresado;
            Properties.Settings.Default.Save();
        }
    }
}
