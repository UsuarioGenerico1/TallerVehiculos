using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorCliente
    {

        private BindingList<Cliente> Lista_Clientes { get; set; }


        public ControladorCliente() {
            Lista_Clientes = new BindingList<Cliente>();
        }

        public void agregarCliente(Cliente cliente)
        {
            Lista_Clientes.Add(cliente);

        }

        public BindingList<Cliente> getCliente()
        {
            return Lista_Clientes;
        }

        public void eliminarCliente(int index) {
            Lista_Clientes.RemoveAt(index);
        }

        //busqueda usada en la pantalla factura
        public Cliente buscarCliente(string mantenimiento) {
                Cliente clienteBuscar = new Cliente();
            for (int i = 0; i < Lista_Clientes.Count; i++)
            {
                if (Lista_Clientes[i].Cedula1 == mantenimiento )
                {
                    clienteBuscar.Cedula1 = Lista_Clientes[i].Cedula1;
                    clienteBuscar.Nombre1 = Lista_Clientes[i].Nombre1;
                    clienteBuscar.Appelido1 = Lista_Clientes[i].Appelido1;
                    clienteBuscar.Correo_Electronico1 = Lista_Clientes[i].Correo_Electronico1;
                }
            }
            return clienteBuscar;
        }


    }
}
