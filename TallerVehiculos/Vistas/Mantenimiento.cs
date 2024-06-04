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
using TallerVehiculos.Vistas;

namespace TallerVehiculos
{
    public partial class Mantenimiento : Form
    {
        ControladorCliente clienteController;
        ControladorMecanico mecanicoController;
        ControladorServicio servicios;
        ControladorMantenimiento mantenimientoController;
        ControladorVehiculo vehiculoController;
        ControladorRepuesto repuestoController;
        internal Mantenimiento(ControladorCliente Controller, ControladorMecanico mecanicoController,
            ControladorServicio servicios, ControladorMantenimiento mantenimiento1, ControladorVehiculo vehiculoController)
        {
            InitializeComponent();
            clienteController = Controller;
            this.mecanicoController = mecanicoController;
            this.servicios = servicios;
            this.mantenimientoController = mantenimiento1;
            this.vehiculoController = vehiculoController;
            repuestoController = new ControladorRepuesto();
            llenarDatos();
            cbTipoMantenimiento.Items.Add("Preventivo");
            cbTipoMantenimiento.Items.Add("Correctivo");
            cbTipoMantenimiento.Items.Add("(vacio)");

        }

        private void cbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < clienteController.Lista_Clientes.Count; i++)
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
            //Datos Servicios
            if (servicios.Lista_Servicio != null)
            {
                for (int i = 0; i < servicios.Lista_Servicio.Count; i++)
                {
                    checkedListBox1.Items.Add(servicios.Lista_Servicio[i].Nombre_Servicio1);
                
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarDatosMantenimiento();
            guardarDatosServicios();
            guardarDatosVehiculo();
            FormularioFactura nuevaFactura = new FormularioFactura(clienteController,mantenimientoController);
            nuevaFactura.ShowDialog();
        }

        public void guardarDatosMantenimiento()
        {
            try
            {
                DatosMantenimiento nuevoMantenimiento = new DatosMantenimiento();
                nuevoMantenimiento.Codigo_mantenimiento = mantenimientoController.Lista_Mantenimientos.Count + 1;
                nuevoMantenimiento.Fecha_mantenimiento = dateTimePickerM.Value;
                nuevoMantenimiento.Trabajos_realizados = richTextTrabajos.Text;
                nuevoMantenimiento.Diagnostico = textDiagnostico.Text;
                nuevoMantenimiento.Tipo_mantenimiento = cbTipoMantenimiento.SelectedItem.ToString();
                nuevoMantenimiento.ReferenciaCliente = cbCedula.SelectedItem.ToString();
                nuevoMantenimiento.ReferenciaMecanico = cbCedulaMecanico.SelectedItem.ToString();
                mantenimientoController.agrearMantenimiento(nuevoMantenimiento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error valores no pueden ser null" + ex.Message);
            }
        }

        public void guardarDatosServicios()
        {
            try
            {
                BindingList<Servicio> serviciosSelecinados = new BindingList<Servicio>();

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.CheckedItems[i] != null)
                    {
                        serviciosSelecinados.Add(servicios.buscarServicio(checkedListBox1.CheckedItems[i].ToString()));
                        
                    }
                    else
                    {
                        Console.WriteLine("no hay valores");
                    }

                    //MessageBox.Show(serviciosSelecinados[i].Nombre_Servicio1+ " " + serviciosSelecinados[i].Precio1.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error valores no pueden ser null " + ex.Message);
            }

        }

        public void guardarDatosVehiculo()
        {
            Vehiculo nuevoVehiculo = new Vehiculo();
            nuevoVehiculo.ID_Vehiculo1 = vehiculoController.Lista_vehiculo.Count + 1;
            nuevoVehiculo.Placa1 = textPlaca.Text;
            nuevoVehiculo.Marca1 = textMarca.Text;
            nuevoVehiculo.Modelo1 = textModelo.Text;
            nuevoVehiculo.Color1 = textColor.Text;
            vehiculoController.agregarVehiculo(nuevoVehiculo);
        }

        private void cbTipoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMantenimiento.Text== "Preventivo") {
                Console.WriteLine("nada");
            }
            if (cbTipoMantenimiento.Text== "Correctivo") { 
                FormularioRepuesto frmRepuestos = new FormularioRepuesto(repuestoController);
                frmRepuestos.ShowDialog();
            }
        }
    }
}
