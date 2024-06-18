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
        int indice = 0;
        int indiceMantenimiento = 0;
        int IVA = 0;
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
            textIVA.Text = "15";
            cbTipoMantenimiento.Items.Add("Preventivo");//su coste es de $250
            cbTipoMantenimiento.Items.Add("Correctivo");
            cbTipoMantenimiento.Items.Add("(vacio)");

        }

        private void cbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < clienteController.getCliente().Count; i++)
            {
                if (cbCedula.SelectedItem.ToString() == clienteController.getCliente()[i].Cedula1)
                {
                    txtNombreCliente.Text = clienteController.getCliente()[i].Nombre1;
                    txtCorreoCliente.Text = clienteController.getCliente()[i].Correo_Electronico1;
                    indice = i;
                }
            }

        }
        private void cbCedulaMecanico_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < mecanicoController.getMecanico().Count; i++)
            {
                if (cbCedulaMecanico.SelectedItem.ToString() == mecanicoController.getMecanico()[i].Cedula1)
                {
                    txtNombreMecanico.Text = mecanicoController.getMecanico()[i].Nombre1;
                    txtEspecialidad.Text = mecanicoController.getMecanico()[i].Especialidad1;
                }
            }
        }

        public void llenarDatos()
        {
            if (clienteController.getCliente() != null)
            {
                for (int i = 0; i < clienteController.getCliente().Count; i++)
                {
                    cbCedula.Items.Add(clienteController.getCliente()[i].Cedula1);
                }
            }
            else
            {
                Console.WriteLine("no hay datos");
            }
            //datos del mecanico
            if (mecanicoController.getMecanico() != null)
            {
                for (int i = 0; i < mecanicoController.getMecanico().Count; i++)
                {
                    cbCedulaMecanico.Items.Add(mecanicoController.getMecanico()[i].Cedula1);
                }
            }
            else
            {
                Console.WriteLine("no hay datos");
            }
            //Datos Servicios
            if (servicios.getServicios() != null)
            {
                for (int i = 0; i < servicios.getServicios().Count; i++)
                {
                    checkedListBox1.Items.Add(servicios.getServicios()[i].Nombre_Servicio1);

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbCedula.Text)
                || string.IsNullOrEmpty(cbCedulaMecanico.Text)
                || string.IsNullOrEmpty(cbTipoMantenimiento.Text))
            {
                MessageBox.Show("Ingrese Los datos antes de continuar");
                return;
            }

            guardarDatosMantenimiento();
            //guardarDatosServicios();
            guardarDatosVehiculo();
            IVA = Convert.ToInt32(textIVA.Text);
            FormularioFactura nuevaFactura = new FormularioFactura(clienteController, mantenimientoController, indice, indiceMantenimiento
                , repuestoController, IVA, vehiculoController, servicios);
            nuevaFactura.ShowDialog();
        }

        public void guardarDatosMantenimiento()
        {
            try
            {
                DatosMantenimiento nuevoMantenimiento = new DatosMantenimiento();
                nuevoMantenimiento.Codigo_mantenimiento = mantenimientoController.getMantenimiento().Count;
                indiceMantenimiento = nuevoMantenimiento.Codigo_mantenimiento;
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
                MessageBox.Show("Los campos de cedula o tipo de mantenimiento no han sido " +
                    "llenados por favor ingrese datos" + ex.Message);
                return;

            }
        }

        public void guardarDatosVehiculo()
        {
            Vehiculo nuevoVehiculo = new Vehiculo();
            nuevoVehiculo.ID_Vehiculo1 = vehiculoController.GetVehiculos().Count;
            nuevoVehiculo.Placa1 = textPlaca.Text;
            nuevoVehiculo.Marca1 = textMarca.Text;
            nuevoVehiculo.Modelo1 = textModelo.Text;
            nuevoVehiculo.Color1 = textColor.Text;
            vehiculoController.agregarVehiculo(nuevoVehiculo);
        }

        private void cbTipoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMantenimiento.Text == "Preventivo")
            {
                Console.WriteLine("nada");
            }
            if (cbTipoMantenimiento.Text == "Correctivo")
            {
                FormularioRepuesto frmRepuestos = new FormularioRepuesto(repuestoController);
                frmRepuestos.ShowDialog();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                servicios.agregarServicioSeleccionado(servicios.buscarServicio2(e.Index));

            }
            if (e.NewValue == CheckState.Unchecked)
            {
                servicios.eliminarServicioSeleccionado(e.Index);
            }
        }

        private void textIVA_KeyPress(object sender, KeyPressEventArgs e)
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
            if (textIVA.Text.Length>=2)
            {
                e.Handled= true;
                return;
            }
        }
    }
}
