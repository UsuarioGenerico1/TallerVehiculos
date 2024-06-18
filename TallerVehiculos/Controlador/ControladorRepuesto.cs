using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorRepuesto
    {
        private BindingList<Repuesto> Lista_Repuestos { get; set; }
        public ControladorRepuesto() { 
            Lista_Repuestos = new BindingList<Repuesto>();
        }

        public void agregarRepuesto(Repuesto repuesto)
        {
            Lista_Repuestos.Add(repuesto);

        }

        public BindingList<Repuesto> getRepuesto()
        {
            return Lista_Repuestos;
        }

        public void eliminarRepuesto(int indice)
        {
            Lista_Repuestos.RemoveAt(indice);

        }
    }
}
