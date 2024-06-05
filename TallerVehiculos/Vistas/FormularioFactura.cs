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
    public partial class FormularioFactura : Form
    {
        ControladorCliente clienteController;
        ControladorMantenimiento mantenimientoController;
        BindingList<Servicio> serviciosSelecinados;
        ControladorRepuesto repuestoController;
        int indice;
        int indiceMantenimiento;
        int IVA;
        internal FormularioFactura(ControladorCliente clienteController, ControladorMantenimiento mantenimientoController,
            int indice, int indiceMantenimiento, BindingList<Servicio> serviciosSelecinados, ControladorRepuesto repuestoController, int IVA)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            this.mantenimientoController = mantenimientoController;
            this.indice = indice;
            this.indiceMantenimiento = indiceMantenimiento;
            this.serviciosSelecinados = serviciosSelecinados;
            this.repuestoController = repuestoController;
            this.IVA=IVA;
            
            asignarDatosCliente();
            asignarDatosMantenimiento();
            asignarDatosServicios();
            asignarDatosRepuestos();
        }

        public void asignarDatosCliente()
        {
            try
            {
                string valor = mantenimientoController.Lista_Mantenimientos[indice].ReferenciaCliente;
                textCedula.Text = clienteController.buscarCliente(valor).Cedula1;
                textNombre.Text = clienteController.buscarCliente(valor).Nombre1;
                textApellido.Text = clienteController.buscarCliente(valor).Appelido1;
                textCorreo.Text = clienteController.buscarCliente(valor).Correo_Electronico1;
            }
            catch(Exception ex){ MessageBox.Show("Error durante La asignacion de Datos" + ex.Message); }
            
        }

        public void asignarDatosMantenimiento()
        {
            try
            {
                dateTimePickerF.Value = mantenimientoController.buscarMantenimiento(indiceMantenimiento).Fecha_mantenimiento;
                textTipoMantenimiento.Text = mantenimientoController.buscarMantenimiento(indiceMantenimiento).Tipo_mantenimiento;
                rtbTrabajos.Text = mantenimientoController.buscarMantenimiento(indiceMantenimiento).Trabajos_realizados;
                textDiagnostico.Text = mantenimientoController.buscarMantenimiento(indiceMantenimiento).Diagnostico;
                textTotalM.Text = CalculoRepuesto().ToString();
                textSubTotal.Text = (calculoServicios() + CalculoRepuesto()).ToString();
                textTotal.Text = calculoTotal().ToString();
                textIVA.Text = IVA.ToString();
            }
            catch(ArgumentOutOfRangeException ex){ MessageBox.Show("Error durante La asignacion de Datos" + ex.Message); }     
        }

        public void asignarDatosServicios()
        {
            if (serviciosSelecinados == null)
            {
                dgvServicio.DataSource = null;
                nombreColumnasDataGridServicios();
            }
            else {
                dgvServicio.DataSource = serviciosSelecinados;
                nombreColumnasDataGridServicios();
            }

        }

        public void asignarDatosRepuestos() {
            if (repuestoController.Lista_Repuestos == null)
            {
                dgvTipoMantenimiento.DataSource = null;
                nombreColumnasDataGridRepuestos();
            }
            else {
                dgvTipoMantenimiento.DataSource = repuestoController.Lista_Repuestos;
                nombreColumnasDataGridRepuestos();
            }
        
        }

        private void nombreColumnasDataGridRepuestos()
        {
            dgvTipoMantenimiento.Columns["ID_Repuesto1"].HeaderText = "ID";
            dgvTipoMantenimiento.Columns["Nombre_Respuesto1"].HeaderText = "Descripcion";
            dgvTipoMantenimiento.Columns["Precio1"].HeaderText = "Precio";
        }
        private void nombreColumnasDataGridServicios()
        {
            dgvServicio.Columns["ID_Servicio1"].HeaderText = "ID";
            dgvServicio.Columns["Nombre_Servicio1"].HeaderText = "Descripcion";
            dgvServicio.Columns["Precio1"].HeaderText = "Precio";
        }
        public double calculoTotal()
        {
            double total = 0;
            if (IVA==0) {
                IVA = 14;
            }

            total = (calculoServicios() + CalculoRepuesto()) * (IVA/100);
            total += (calculoServicios() + CalculoRepuesto());

            return  total;

        }
        public double calculoServicios()
        {
            double sumaServicios = 0;
            if (serviciosSelecinados == null)
            {
                sumaServicios = 0;
            }
            else {
                for (int i = 0; i < serviciosSelecinados.Count; i++)
                {
                    sumaServicios += serviciosSelecinados[i].Precio1;
                }
            }
            return sumaServicios;
        }

        public double CalculoRepuesto()
        {     
            double sumaRepuestos = 0;
            if (repuestoController.Lista_Repuestos == null)
            {
                sumaRepuestos = 150;
            }
            else
            {
                for (int i = 0; i < repuestoController.Lista_Repuestos.Count; i++)
                {
                    sumaRepuestos += repuestoController.Lista_Repuestos[i].Precio1;
                }
            }        
            return sumaRepuestos;
        }

        private void dgvServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
