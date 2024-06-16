using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Repuesto nuevoRepuesto = new Repuesto();
            nuevoRepuesto.ID_Repuesto1 = repuestoController.getRepuesto().Count + 1;
            nuevoRepuesto.Nombre_Respuesto1 = textRepuesto.Text;
            nuevoRepuesto.Precio1 = Convert.ToDouble(textPrecio.Text);
            repuestoController.agregarRepuesto(nuevoRepuesto);
            GetDataRepuesto();
           
            textRepuesto.Text=string.Empty;
            textPrecio.Text=string.Empty;   
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
    }
}
