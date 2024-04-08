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
using COSMOSCOM.Modelo;
using COSMOSCOM.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace COSMOSCOM
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            nUpDown.ValueChanged += UpDown_ValueChanged;
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
            DialogResult confirma = MessageBox.Show("¿Estas Seguro de salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Clientes objeto = new Clientes()
            {
                Nombre = txt_Nombre.Text,
                Apellido_P = txt_Apellido_P.Text,
                Apellido_M = txt_Apellido_M.Text,
                Telefono1 = txt_Telefono1.Text,
                Telefono2 = txt_Telefono2.Text,


            };
            bool respuesta = ClientesLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                MessageBox.Show("Registro Guardado", "Confirmación", MessageBoxButtons.OK);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Desea cancelar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma == DialogResult.Yes)
            {
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

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string formato = cb_Formatos.Text;
            string duracion = nUpDown.Value.ToString();
            string monto = txt_Monto.Text;


            DataGrid_Formato.Rows.Add(formato, duracion, monto);

            int suma = 0;

            foreach(DataGridViewRow fila in DataGrid_Formato.Rows)
            {
                if (!fila.IsNewRow)
                {
                    // Intenta sumar el valor de la celda de la columna 1
                    if (fila.Cells[2].Value != null)
                    {
                        suma += Convert.ToInt16(fila.Cells[2].Value);
                    }
                }
            }
            txt_Total.Text=suma.ToString();


        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (DataGrid_Formato.SelectedRows.Count > 0)
            {
                DataGrid_Formato.Rows.Remove(DataGrid_Formato.SelectedRows[0]);

            }
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
    }
}
