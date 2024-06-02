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

namespace TallerVehiculos
{
    public partial class Mantenimiento : Form
    {
        ControladorCliente clienteController;
        internal Mantenimiento(ControladorCliente Controller)
        {
            InitializeComponent();
            clienteController = Controller;
            llenarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }


        public void llenarDatos() {
            if (clienteController.Lista_Clientes!=null)
            {
                for (int i = 0; i < clienteController.Lista_Clientes.Count; i++)
                {
                    cbCedula.Items.Add(clienteController.Lista_Clientes[i].Cedula1);
                }
            }
            else
            {
                Console.WriteLine("no hay datos");
            }
            
        
        }
    }
}
