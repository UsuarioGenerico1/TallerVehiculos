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
        internal FormularioFactura(ControladorCliente clienteController,ControladorMantenimiento mantenimientoController)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            this.mantenimientoController = mantenimientoController;
        }

        public void asignarDatosCliente()
        {
            textCedula.Text = mantenimientoController.Lista_Mantenimientos[0].ReferenciaCliente;
            textNombre.Text = clienteController.buscarCliente(mantenimientoController.Lista_Mantenimientos[0].ReferenciaCliente).Nombre1;
        }


        public void asignarDatosMantenimiento()
        {
            

        }
    }
}
