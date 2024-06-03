using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorMantenimiento
    {
        public BindingList<Mantenimiento> Lista_Mantenimientos { get; set; }

        public ControladorMantenimiento() {
            Lista_Mantenimientos = new BindingList<Mantenimiento>();
            
        }

        public void agrearMantenimiento(Mantenimiento mantenimiento) { 
            Lista_Mantenimientos.Add(mantenimiento);    
        }
    }
}
