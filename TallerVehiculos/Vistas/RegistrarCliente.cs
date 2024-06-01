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
    public partial class RegistrarCliente : Form
    {
        ControladorCliente clienteController = new ControladorCliente();
        private bool banderaNuevo = true;
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();

            nuevoCliente.ID_Cliente1 = clienteController.Lista_Clientes.Count + 1;

            nuevoCliente.Cedula1 = textCedula.Text;
            nuevoCliente.Nombre1 = textNombre.Text;
            nuevoCliente.Appelido1 = textApellido.Text;
            nuevoCliente.Correo_Electronico1 = textCorreo.Text;
            nuevoCliente.Fecha_Registro1 = dateTimePicker1.Value;

            if (banderaNuevo){
                clienteController.agregarCliente(nuevoCliente);
            }
            else {
                clienteController.modificarCliente(nuevoCliente);
            }

            MessageBox.Show("datos registrados");

            GetDataCliente();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                textCedula.Text = string.Empty;
                textApellido.Text = string.Empty;
                textCorreo.Text = string.Empty;
                textNombre.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;

                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = false;


                btnNuevo.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex.Message);
            }
        }


        private void GetDataCliente()
        {
            try
            {
                dataGridView1.DataSource = clienteController.Lista_Clientes;

            }catch(Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }
    }
}
