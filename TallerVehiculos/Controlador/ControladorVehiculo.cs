using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorVehiculo
    {
        public BindingList<Vehiculo> Lista_vehiculo { get; set; }

        public ControladorVehiculo()
        {
            Lista_vehiculo = new BindingList<Vehiculo>();   

        }

        public void agregarVehiculo(Vehiculo vehiculo) {
            Lista_vehiculo.Add(vehiculo);
        }
    }
}
