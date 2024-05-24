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
    public partial class Modificar_Registros_Ventas : Form
    {
        private int folio;
        public Modificar_Registros_Ventas(int folio, int idCliente, string fechaAtencion, string fechaEntrega, string Total)
        {
            InitializeComponent();

            // Inicializar los controles con los datos del registro seleccionado
            this.folio = folio;
            txt_Folio.Text = folio.ToString();
            txt_id_Cliente.Text = idCliente.ToString();
            txt_fecha_de_atencion.Text = fechaAtencion;
            txt_fecha_de_entrega.Text = fechaEntrega;
            txt_Total.Text = Total;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Registros_Ventas_Load(object sender, EventArgs e)
        {
            txt_Folio.ReadOnly = true;
            txt_id_Cliente.ReadOnly = true;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // Obtener los datos modificados

                    string nuevaFechaAtencion = txt_fecha_de_atencion.Text;
                    string nuevaFechaEntrega = txt_fecha_de_entrega.Text;
                    string nuevoTotal = txt_Total.Text;
                    // Construir la consulta de actualización
                    string consulta = $"UPDATE Venta_Total SET Fecha_de_atencion = '{nuevaFechaAtencion}', Fecha_de_entrega = '{nuevaFechaAtencion}', Total = '{nuevoTotal}' WHERE Folio = {folio}";

                    // Actualizar los datos en la base de datos
                    if (VentasLogica.Instancia.ActualizarVentas(consulta))
                    {
                        MessageBox.Show("Datos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
