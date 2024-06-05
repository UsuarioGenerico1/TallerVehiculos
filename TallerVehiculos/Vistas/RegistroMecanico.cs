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
            if (mecanicoController.Lista_Mecanico != null)
            {
                dataGridView1.DataSource = mecanicoController.Lista_Mecanico;
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

            nuevoMecanico.ID_Mecanico1 = mecanicoController.Lista_Mecanico.Count + 1;

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
                dataGridView1.DataSource = mecanicoController.Lista_Mecanico;
                nombreColumnasDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }

        private void nombreColumnasDataGrid() {
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
                Mecanico selectMecanico = mecanicoController.Lista_Mecanico[index];
                selectMecanico.Cedula1 = textCedula.Text;
                selectMecanico.Nombre1 = textNombre.Text;
                selectMecanico.Appelido1 = textApellido.Text;
                selectMecanico.Direccion1 = textDireccion.Text;
                selectMecanico.Especialidad1 = textEspecialidad.Text;
                selectMecanico.Experiencia1 = textExp.Text;
                mecanicoController.Lista_Mecanico.ResetItem(index);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            textCedula.Text = row.Cells[4].Value.ToString();
            textNombre.Text = row.Cells[5].Value.ToString();
            textApellido.Text = row.Cells[6].Value.ToString();
            textDireccion.Text = row.Cells[1].Value.ToString();
            textEspecialidad.Text = row.Cells[2].Value.ToString();
            textExp.Text = row.Cells[3].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Esta seguro que quiere eliminar los datos", "Eliminar Datos", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (index >= 0)
                {

                    mecanicoController.Lista_Mecanico.RemoveAt(index);
                    index = -1;
                    limpiar();
                }
                MessageBox.Show("los datos se han borrado");
            }
        }
    }
}
