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

namespace TallerVehiculos.Vistas
{
    public partial class FormularioFactura : Form
    {
        ControladorCliente clienteController;
        ControladorMantenimiento mantenimientoController;
        int indice;
        internal FormularioFactura(ControladorCliente clienteController,ControladorMantenimiento mantenimientoController,
            int indice)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            this.mantenimientoController = mantenimientoController;
            this.indice = indice;   
            asignarDatosCliente();
        }

        public void asignarDatosCliente()
        {
          //  for (int i = 0; i < clienteController.Lista_Clientes.Count; i++) { }
            textCedula.Text = mantenimientoController.Lista_Mantenimientos[indice].ReferenciaCliente;
            textNombre.Text = clienteController.buscarCliente(mantenimientoController.Lista_Mantenimientos[indice].ReferenciaCliente).Nombre1;


            
            
            
        }


        public void asignarDatosMantenimiento()
        {
            

        }
    }
}
