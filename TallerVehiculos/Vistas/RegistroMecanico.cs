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
        static ControladorMecanico mecanicoController = new ControladorMecanico();
        public bool banderaNuevo = true;
        public RegistroMecanico()
        {
            InitializeComponent();
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

            if (banderaNuevo)
            {
                mecanicoController.agregarMecanico(nuevoMecanico);
            }
            else
            {
                mecanicoController.modificarMecanico(nuevoMecanico);
            }

            MessageBox.Show("datos registrados");

            GetDataMecanico();
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
                textDireccion.Text = string.Empty;
                textNombre.Text = string.Empty;
                textEspecialidad.Text= string.Empty;
                textExp.Text = string.Empty;

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

        private void GetDataMecanico()
        {
            try
            {
                dataGridView1.DataSource = mecanicoController.Lista_Mecanico;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos" + ex.Message);
            }
        }
    }
}
