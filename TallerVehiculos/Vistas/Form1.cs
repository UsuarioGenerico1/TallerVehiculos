using TallerVehiculos.Controlador;

namespace TallerVehiculos
{
    public partial class Form1 : Form
    {

        ControladorCliente clienteController;
        ControladorMecanico mecanicoController;
        ControladorServicio servicios;
        public Form1()
        {
            InitializeComponent();
            clienteController = new ControladorCliente();
            mecanicoController = new ControladorMecanico();
            servicios = new ControladorServicio();
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
            Mantenimiento mantenimiento = new Mantenimiento(clienteController, mecanicoController,servicios); 
            mantenimiento.ShowDialog(); 
        }
    }
}
