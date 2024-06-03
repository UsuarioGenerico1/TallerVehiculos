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
        ControladorMecanico mecanicoController;
        ControladorServicio servicios;
        internal Mantenimiento(ControladorCliente Controller, ControladorMecanico mecanicoController ,ControladorServicio servicios)
        {
            InitializeComponent();
            clienteController = Controller;
            this.mecanicoController = mecanicoController;
            this.servicios = servicios;
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
            for (int i = 0; i < clienteController.Lista_Clientes.Count; i++)
            {
                if (cbCedula.SelectedItem.ToString() == clienteController.Lista_Clientes[i].Cedula1)
                {
                    txtNombreCliente.Text = clienteController.Lista_Clientes[i].Nombre1;
                    txtCorreoCliente.Text = clienteController.Lista_Clientes[i].Correo_Electronico1;
                }
            }


        }
        private void cbCedulaMecanico_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < mecanicoController.Lista_Mecanico.Count; i++)
            {
                if (cbCedulaMecanico.SelectedItem.ToString() == mecanicoController.Lista_Mecanico[i].Cedula1)
                {
                    txtNombreMecanico.Text = mecanicoController.Lista_Mecanico[i].Nombre1;
                    txtEspecialidad.Text = mecanicoController.Lista_Mecanico[i].Especialidad1;
                }
            }
        }

        public void llenarDatos()
        {
            if (clienteController.Lista_Clientes != null)
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
            //datos del mecanico
            if (mecanicoController.Lista_Mecanico != null)
            {
                for (int i = 0; i < mecanicoController.Lista_Mecanico.Count; i++)
                {
                    cbCedulaMecanico.Items.Add(mecanicoController.Lista_Mecanico[i].Cedula1);
                }
            }
            else
            {
                Console.WriteLine("no hay datos");
            }

            if (servicios.Lista_Servicio!=null)
            {
                for (int i = 0; i < servicios.Lista_Servicio.Count; i++)
                {
                    checkedListBox1.Items.Add(servicios.Lista_Servicio[i].Nombre_Servicio1);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
