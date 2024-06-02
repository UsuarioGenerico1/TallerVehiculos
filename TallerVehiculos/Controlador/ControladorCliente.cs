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
