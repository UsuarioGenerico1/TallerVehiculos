using System.Text;
using TallerVehiculos.Controlador;

namespace TallerVehiculos
{
    public partial class Form1 : Form
    {

        ControladorCliente clienteController;
        ControladorMecanico mecanicoController;
        ControladorServicio servicios;
        ControladorMantenimiento mantenimiento1;
        ControladorVehiculo vehiculoController;
        public Form1()
        {
            InitializeComponent();
            clienteController = new ControladorCliente();
            mecanicoController = new ControladorMecanico();
            servicios = new ControladorServicio();
            mantenimiento1 = new ControladorMantenimiento();
            vehiculoController = new ControladorVehiculo();
        }

        private void btn_rg_cliente_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente(clienteController);
            registrarCliente.ShowDialog();
        }

        private void btn_rg_mecanico_Click(object sender, EventArgs e)
        {
            RegistroMecanico registroMecanico = new RegistroMecanico(mecanicoController);
            registroMecanico.ShowDialog();
        }

        private void btn_gr_mantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento(clienteController, mecanicoController, servicios, mantenimiento1, vehiculoController);
            mantenimiento.ShowDialog();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "Gutierrez Murillo Joseph Gerardo",
                "Lomas Cepeda Milton Leonardo",
                "Clavijo Fariño Harold Esteban",
                "Domínguez Gómez Carlos Emanuel",
                

            };
            StringBuilder sb = new StringBuilder(); 

            foreach (string item in list) { 
                sb.AppendLine(item);    
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
