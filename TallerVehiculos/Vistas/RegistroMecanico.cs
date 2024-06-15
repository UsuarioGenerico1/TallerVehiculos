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
    public partial class RegistroMecanico : Form
    {
        ControladorMecanico mecanicoController;
        public bool banderaNuevo = true;
        int index = -1;
        internal RegistroMecanico(ControladorMecanico Controller)
        {
            InitializeComponent();
            this.mecanicoController = Controller;
            if (mecanicoController.getMecanico() != null)
            {
                dataGridView1.DataSource = mecanicoController.getMecanico();
                nombreColumnasDataGrid();
            }
            else
            {
                Console.WriteLine("no hay nada");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mecanico nuevoMecanico = new Mecanico();

            if (string.IsNullOrEmpty(textCedula.Text)
                || string.IsNullOrEmpty(textNombre.Text)
                || string.IsNullOrEmpty(textApellido.Text)
                || string.IsNullOrEmpty(textDireccion.Text)
                || string.IsNullOrEmpty(textEspecialidad.Text)
                || string.IsNullOrEmpty(textExp.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }

            nuevoMecanico.ID_Mecanico1 = mecanicoController.getMecanico().Count + 1;
            nuevoMecanico.Cedula1 = textCedula.Text;
            nuevoMecanico.Nombre1 = textNombre.Text;
            nuevoMecanico.Appelido1 = textApellido.Text;
            nuevoMecanico.Direccion1 = textDireccion.Text;
            nuevoMecanico.Especialidad1 = textEspecialidad.Text;
            nuevoMecanico.Experiencia1 = textExp.Text;

            mecanicoController.agregarMecanico(nuevoMecanico);
            MessageBox.Show("datos registrados");
            GetDataMecanico();
            limpiar();
        }

        private void GetDataMecanico()
        {
            try
            {
                dataGridView1.DataSource = mecanicoController.getMecanico();
                nombreColumnasDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }

        private void nombreColumnasDataGrid()
        {
            dataGridView1.Columns["Cedula1"].HeaderText = "Cedula";
            dataGridView1.Columns["Nombre1"].HeaderText = "Nombre";
            dataGridView1.Columns["Appelido1"].HeaderText = "Apellido";
            dataGridView1.Columns["Direccion1"].HeaderText = "Direccion";
            dataGridView1.Columns["Especialidad1"].HeaderText = "Especialidad";
            dataGridView1.Columns["Experiencia1"].HeaderText = "Experiencia";
            dataGridView1.Columns["ID_Mecanico1"].HeaderText = "ID";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Mecanico selectMecanico = mecanicoController.getMecanico()[index];
                selectMecanico.Cedula1 = textCedula.Text;
                selectMecanico.Nombre1 = textNombre.Text;
                selectMecanico.Appelido1 = textApellido.Text;
                selectMecanico.Direccion1 = textDireccion.Text;
                selectMecanico.Especialidad1 = textEspecialidad.Text;
                selectMecanico.Experiencia1 = textExp.Text;
                mecanicoController.getMecanico().ResetItem(index);             
            }
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            MessageBox.Show("los datos se han actualizado");
            limpiar();
        }

        public void limpiar()
        {
            textCedula.Text = string.Empty;
            textNombre.Text = string.Empty;
            textApellido.Text = string.Empty;
            textDireccion.Text = string.Empty;
            textEspecialidad.Text = string.Empty;
            textExp.Text = string.Empty;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                textCedula.Text = row.Cells[4].Value.ToString();
                textNombre.Text = row.Cells[5].Value.ToString();
                textApellido.Text = row.Cells[6].Value.ToString();
                textDireccion.Text = row.Cells[1].Value.ToString();
                textEspecialidad.Text = row.Cells[2].Value.ToString();
                textExp.Text = row.Cells[3].Value.ToString();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay datos " + ex.Message);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
            }        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Esta seguro que quiere eliminar los datos", "Eliminar Datos", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    mecanicoController.eliminarMecanico(index);
                    index = -1;
                    limpiar();
                }
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
                MessageBox.Show("los datos se han borrado");
            }
        }     
    }
}
