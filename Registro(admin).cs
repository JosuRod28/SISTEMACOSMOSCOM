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
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Forms = System.Windows.Forms;
using System.Configuration;



namespace COSMOSCOM
{
    public partial class Registro_admin_ : Form
    {


        private string folioActual = "";
        private string montoActual = CambiarTarifa.PrecioFormato.ToString();
        public Registro_admin_()
        {

            InitializeComponent();
            // El valor de la duracion se cambian con el componente numericUpDown
            nUpDown.ValueChanged += UpDown_ValueChanged;
            txt_Monto.Text = CambiarTarifa.PrecioFormato.ToString();


        }




        private void UpDown_ValueChanged(object sender, EventArgs e)
        {

            // Obtener el valor actual del NumericUpDown
            int valor = (int)nUpDown.Value;
            int precio = CambiarTarifa.PrecioFormato;
            // Calcular el monto utilizando el precio y el valor del NumericUpDown
            int monto = (int)(valor * precio / 120);
            // Asignar el monto calculado al TextBox txt_Monto
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
                this.Hide();
                folioActual = txt_Folio.Text;
                // Actualiza el TextBox con el último valor ingresado
                txt_Folio.Text = folioActual;
                txt_Monto.Text =montoActual;

                Properties.Settings.Default.FolioActual = folioActual;
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
                Apellido_P = txt_Apellido_P.Text,
                Apellido_M = txt_Apellido_M.Text,
                Telefono1 = txt_Telefono1.Text,
                Telefono2 = txt_Telefono2.Text,

            };

            Ventas objetoVentas = new Ventas()
            {
                //Se inicializan las propiedades con los valores ingresados en los campos de texto.
                Folio = int.Parse(txt_Folio.Text),  
                id_Cliente = VentasLogica.Instancia.idCliente(),
                Fecha_atencion = dtp_Fecha_atencion.Text,
                Fecha_entrega = dtp_Fecha_entrega.Text,
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

                int folioVenta = int.Parse(txt_Folio.Text);
                int idCliente = DetalleVentaLogica.Instancia.idCliente();

                List<DetalleVenta>detalleVentas = new List<DetalleVenta>();
                foreach (DataGridViewRow fila in dgv_Formatos.Rows)
                {
                    // Verificar si la fila es una fila nueva
                    if (!fila.IsNewRow)
                    {
                        DetalleVenta detalle = new DetalleVenta();
                        detalle.Formato = fila.Cells["Formato"].Value.ToString();
                        detalle.Duracion = fila.Cells["Duracion"].Value.ToString();
                        detalle.Monto = fila.Cells["Monto"].Value.ToString();
                        detalleVentas.Add(detalle);

                    }
                }


                bool resDetalle = DetalleVentaLogica.Instancia.InsertarDetalleVenta(folioVenta,idCliente ,detalleVentas);

                if (resDetalle)
                {
                    MessageBox.Show("Detalles de venta insertados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al insertar detalles de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                numFolio++;

                txt_Folio.Text = numFolio.ToString();

                LimpiarDatos();


            }




        }

        private void LimpiarDatos()
        {
            txt_Nombre.Text = "";
            txt_Apellido_P.Text = "";
            txt_Apellido_M.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono1.Text = "";
            txt_Telefono2.Text = "";
            dgv_Formatos.Rows.Clear();

        }

        private bool ValidarCampos()
        {

            // Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Apellido_P.Text))
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

            if (VentasLogica.Instancia.BuscarFechasEntrega(dtp_Fecha_entrega.Text))
            {
                MessageBox.Show($"Ya existe un registro para la fecha de entrega {dtp_Fecha_entrega.Value.ToShortDateString()}, selecciona otra fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!FormatosAgregados(dgv_Formatos))
            {
                MessageBox.Show("Por favor, agregue elementos a la tabla de formatos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }

            if (!int.TryParse(txt_Telefono1.Text,out _))
            {
                MessageBox.Show("El campo Teléfono1 solo acepta números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!int.TryParse(txt_Telefono2.Text, out _))
            {
                MessageBox.Show("El campo Teléfono2 solo acepta números", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!txt_Nombre.Text.All(char.IsLetter) ) 
            {
                MessageBox.Show("El campo Nombre debe ser de tipo texto", "MEnsaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            if (!txt_Apellido_P.Text.All(char.IsLetter))
            {
                MessageBox.Show("El campo Apellido_P debe ser de tipo texto", "MEnsaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            if (!txt_Apellido_M.Text.All(char.IsLetter))
            {
                MessageBox.Show("El campo Apellido_M debe ser de tipo texto", "MEnsaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // Cargar el último valor ingresado desde la configuración de la aplicación
            folioActual = Properties.Settings.Default.FolioActual;
            montoActual = Properties.Settings.Default.MontoActual;
            // Mostrar el último valor ingresado en el TextBox
            txt_Folio.Text = folioActual;
            folioActual = txt_Folio.Text;
            txt_Monto.Text = montoActual;

            CargarFormatos();

        }

        private void CargarFormatos()
        {

            // Asignar la lista de formatos al ComboBox
            cb_Formatos.DataSource = Formatos.Instancia.ObtenerFormatos();

            // Especificar la propiedad que se mostrará en el ComboBox
            cb_Formatos.DisplayMember = "TipoFormato";
        }

        // Declara una variable para almacenar el estado de si se agregó un formato
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
            dgv_Formatos.Rows.Add(formato, duracion, monto);

            //Se itera sobre todas las filas del DataGridView para calcular la suma de los montos de las filas que tienen un valor en la tercera columna. 

            int total = 0; //Inicializar el total en 0

            for (int i = 0; i < dgv_Formatos.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = dgv_Formatos.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null) //se verifica si la fila actual no es una fila nueva
                {
                    total += Convert.ToInt32(fila.Cells[2].Value); //Se itera los valores sumados y se guardan en la variable total
                }
            }
            txt_Total.Text = total.ToString(); //La suma se cuarda en el campo del total

            //Se actualiza el número de formatos mostrado en un control de etiqueta, excluyendo la última fila.
            int numFormatos = dgv_Formatos.Rows.Count - 1;
            label15.Text = numFormatos.ToString();

            // Establece la bandera como verdadera para indicar que se agregó un formato
            seAgregoFila = true;
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (dgv_Formatos.SelectedRows.Count > 0) // se verifica que la fila esta seleccionada
            {

                dgv_Formatos.Rows.Remove(dgv_Formatos.SelectedRows[0]);//Se Elimina la fila seleccionada

                //Llama el metodo para actualizar el valor del total.
                ActualizarTotal();

            }
        }

        private void ActualizarTotal()
        {
            int total = 0;
            for (int i = 0; i < dgv_Formatos.Rows.Count - 1; i++) // Iterar hasta la penúltima fila
            {
                DataGridViewRow fila = dgv_Formatos.Rows[i];
                if (!fila.IsNewRow && fila.Cells[2].Value != null)
                {
                    total += Convert.ToInt32(fila.Cells[2].Value);
                }
            }

            txt_Total.Text = total.ToString();
            int numFormatos = dgv_Formatos.Rows.Count - 1;
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NuevoUsuario nuevoUsuarioForm = new NuevoUsuario();

            nuevoUsuarioForm.ShowDialog();



        }

        private void modificarUsuarioYContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministraUsuarios administraUsuarios = new AdministraUsuarios();

            administraUsuarios.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cambiarTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarTarifa form = new CambiarTarifa();
            form.ShowDialog();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
