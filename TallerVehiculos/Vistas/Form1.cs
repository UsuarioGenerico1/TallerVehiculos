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
            Mantenimiento mantenimiento = new Mantenimiento(clienteController, mecanicoController,servicios,mantenimiento1,vehiculoController); 
            mantenimiento.ShowDialog(); 
        }
    }
}
