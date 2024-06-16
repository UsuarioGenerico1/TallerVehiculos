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
        int index = -1;
        internal RegistrarCliente(ControladorCliente Controller)
        {
            InitializeComponent();
            this.clienteController = Controller;
            if (clienteController.getCliente() != null)
            {
                dataGridView1.DataSource = clienteController.getCliente();
                NombreColumnasDataGrid();
            }
            else
            {
                Console.WriteLine("no hay nada");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();


            if (string.IsNullOrEmpty(textCedula.Text)
                || string.IsNullOrEmpty(textNombre.Text)
                || string.IsNullOrEmpty(textApellido.Text)
                || string.IsNullOrEmpty(textCorreo.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }

            nuevoCliente.ID_Cliente1 = clienteController.getCliente().Count + 1;
            nuevoCliente.Cedula1 = textCedula.Text;
            nuevoCliente.Nombre1 = textNombre.Text;
            nuevoCliente.Appelido1 = textApellido.Text;
            nuevoCliente.Correo_Electronico1 = textCorreo.Text;
            nuevoCliente.Fecha_Registro1 = dateTimePicker1.Value;
            clienteController.agregarCliente(nuevoCliente);

            MessageBox.Show("Datos registrados");

            GetDataCliente();
            limpiar();
        }

        private void dataGridView1_CelltClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];

                textCedula.Text = row.Cells[3].Value.ToString();
                textNombre.Text = row.Cells[4].Value.ToString();
                textApellido.Text = row.Cells[5].Value.ToString();
                textCorreo.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay datos " + ex.Message);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (index >= 0)
            {
                Cliente selectCliente = clienteController.getCliente()[index];
                selectCliente.Cedula1 = textCedula.Text;
                selectCliente.Nombre1 = textNombre.Text;
                selectCliente.Appelido1 = textApellido.Text;
                selectCliente.Correo_Electronico1 = textCorreo.Text;
                selectCliente.Fecha_Registro1 = dateTimePicker1.Value;
                clienteController.getCliente().ResetItem(index);

            }
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            MessageBox.Show("los datos se han actualizado");
            limpiar();
        }
        private void GetDataCliente()
        {
            try
            {
                dataGridView1.DataSource = clienteController.getCliente();
                NombreColumnasDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }
        private void NombreColumnasDataGrid()
        {
            dataGridView1.Columns["Cedula1"].HeaderText = "Cedula";
            dataGridView1.Columns["Nombre1"].HeaderText = "Nombre";
            dataGridView1.Columns["Appelido1"].HeaderText = "Apellido";
            dataGridView1.Columns["ID_Cliente1"].HeaderText = "ID";
            dataGridView1.Columns["Correo_Electronico1"].HeaderText = "Correo";
            dataGridView1.Columns["Fecha_Registro1"].HeaderText = "Fecha";
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
            r = MessageBox.Show("Esta seguro que desea ELIMINAR los datos", "Eliminar Datos", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (index >= 0)
                {

                    clienteController.eliminarCliente(index);
                    index = -1;
                    limpiar();
                }
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
                MessageBox.Show("los datos se han borrado");
            }
        }

        private void textCedula_KeyPress(object sender, KeyPressEventArgs e)
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
            if (textCedula.Text.Length >= 10)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
