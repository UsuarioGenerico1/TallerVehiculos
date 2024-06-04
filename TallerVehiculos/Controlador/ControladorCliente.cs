using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorCliente
    {

        public BindingList<Cliente> Lista_Clientes { get; set; }


        public ControladorCliente() {
            Lista_Clientes = new BindingList<Cliente>();
        }

        public void agregarCliente (Cliente cliente)
        {
            Lista_Clientes.Add (cliente);
            
        }
        public Cliente buscarCliente(string mantenimiento) {
                Cliente clienteBuscar = new Cliente();
            for (int i = 0; i < Lista_Clientes.Count; i++)
            {
                if (Lista_Clientes[i].Cedula1 == mantenimiento )
                {
                    clienteBuscar.Cedula1 = Lista_Clientes[i].Cedula1;
                    clienteBuscar.Nombre1 = Lista_Clientes[i].Nombre1;
                }
            }
            return clienteBuscar;
        }

        public void modificarCliente(Cliente cliente)
        {
            for (int i=0;i<Lista_Clientes.Count;i++) {

                if (Lista_Clientes[i].Cedula1==cliente.Cedula1) {
                    Lista_Clientes[i] = cliente;
                    break;
                }
                
            }

        }

    }
}
