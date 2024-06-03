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
        public BindingList<DatosMantenimiento> Lista_Mantenimientos { get; set; }

        public ControladorMantenimiento() {
            Lista_Mantenimientos = new BindingList<DatosMantenimiento>();
            
        }

        public void agrearMantenimiento(DatosMantenimiento mantenimiento) { 
            Lista_Mantenimientos.Add(mantenimiento);    
        }
    }
}
