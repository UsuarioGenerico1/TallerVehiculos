using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerVehiculos.Controlador;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Vistas
{
    public partial class FormularioRepuesto : Form
    {
        ControladorRepuesto repuestoController;
        int indice = -1;
        internal FormularioRepuesto(ControladorRepuesto repuestoController)
        {
            InitializeComponent();
            
            this.repuestoController = repuestoController;

            if (repuestoController.getRepuesto() != null)
            {
                dataGridViewR.DataSource = repuestoController.getRepuesto();
            }
            else
            {
                Console.WriteLine("no hay nada");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Repuesto nuevoRepuesto = new Repuesto();
                nuevoRepuesto.ID_Repuesto1 = repuestoController.getRepuesto().Count + 1;
                nuevoRepuesto.Nombre_Respuesto1 = textRepuesto.Text;
                nuevoRepuesto.Precio1 = Convert.ToDouble(textPrecio.Text);
                repuestoController.agregarRepuesto(nuevoRepuesto);
                GetDataRepuesto();

                textRepuesto.Text = string.Empty;
                textPrecio.Text = string.Empty;

            } catch(Exception ex){
                MessageBox.Show("error en la asignacion de datos");
            }
           
        }

        private void GetDataRepuesto()
        {
            try
            {
                dataGridViewR.DataSource = repuestoController.getRepuesto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice>=0)
            {
                repuestoController.eliminarRepuesto(indice);
                textRepuesto.Text = string.Empty;
                textPrecio.Text = string.Empty;
            }
            
        }

        private void dataGridViewR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indice = e.RowIndex;
                DataGridViewRow row = dataGridViewR.Rows[indice];
                textRepuesto.Text = row.Cells[1].Value.ToString();
                textPrecio.Text = row.Cells[0].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay datos");
            }
        }
    }
}
