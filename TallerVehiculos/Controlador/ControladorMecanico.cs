using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorMecanico
    {
        private BindingList<Mecanico> Lista_Mecanico { get; set; }

        public ControladorMecanico() {
            Lista_Mecanico = new BindingList<Mecanico>();
        }
        public void agregarMecanico(Mecanico mecanico) {
            Lista_Mecanico.Add(mecanico);
        }

        public BindingList<Mecanico> getMecanico()
        {
            return Lista_Mecanico;
        }

        public void eliminarMecanico(int indice) { 
            Lista_Mecanico.RemoveAt(indice);
        }

    }
}
