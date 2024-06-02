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
        ControladorCliente clienteController;
        private bool banderaNuevo = true;
        int index = -1;
        internal RegistrarCliente(ControladorCliente Controller)
        {
            InitializeComponent();
            this.clienteController = Controller;
            if (clienteController.Lista_Clientes != null)
            {
                dataGridView1.DataSource = clienteController.Lista_Clientes;
            }
            else
            {
                Console.WriteLine("no hay nada");
            }
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

            clienteController.agregarCliente(nuevoCliente);

            MessageBox.Show("datos registrados");

            GetDataCliente();
            limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            textCedula.Text = row.Cells[3].Value.ToString();
            textNombre.Text = row.Cells[4].Value.ToString();
            textApellido.Text = row.Cells[5].Value.ToString();
            textCorreo.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (index >= 0)
            {
                Cliente selectCliente = clienteController.Lista_Clientes[index];
                selectCliente.Cedula1 = textCedula.Text;
                selectCliente.Nombre1 = textNombre.Text;
                selectCliente.Appelido1 = textApellido.Text;
                selectCliente.Correo_Electronico1 = textCorreo.Text;
                selectCliente.Fecha_Registro1 = dateTimePicker1.Value;
                clienteController.Lista_Clientes.ResetItem(index);
            }
            MessageBox.Show("los datos se han actualizado");
            limpiar();
        }
        private void GetDataCliente()
        {
            try
            {
                dataGridView1.DataSource = clienteController.Lista_Clientes;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }
        public void limpiar()
        {
            textCedula.Text = string.Empty;
            textNombre.Text = string.Empty;
            textApellido.Text = string.Empty;
            textCorreo.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Esta seguro que quiere eliminar los datos","Eliminar Datos",MessageBoxButtons.YesNo);
            if (r==DialogResult.Yes) {
                if (index >= 0)
                {

                    clienteController.Lista_Clientes.RemoveAt(index);
                    index = -1;
                    limpiar();
                }
                MessageBox.Show("los datos se han borrado");
            }
            
        }
    }
}
