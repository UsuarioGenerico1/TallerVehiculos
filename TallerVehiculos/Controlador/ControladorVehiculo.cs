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
        private BindingList<Vehiculo> Lista_vehiculo { get; set; }

        public ControladorVehiculo()
        {
            Lista_vehiculo = new BindingList<Vehiculo>();   

        }

        public void agregarVehiculo(Vehiculo vehiculo) {
            Lista_vehiculo.Add(vehiculo);
        }

        public BindingList<Vehiculo> GetVehiculos()
        {
            return Lista_vehiculo;
        }


        public Vehiculo buscarVehiculo(int id) {
            Vehiculo buscarVehiculo = new Vehiculo();
            for (int i=0;i<Lista_vehiculo.Count;i++) {
                if (Lista_vehiculo[i].ID_Vehiculo1==id)
                {
                    buscarVehiculo.Placa1 = Lista_vehiculo[i].Placa1;
                    buscarVehiculo.Modelo1 = Lista_vehiculo[i].Modelo1;
                    buscarVehiculo.Color1 = Lista_vehiculo[i].Color1;
                    buscarVehiculo.Marca1 = Lista_vehiculo[i].Marca1;
                }
            }
            return buscarVehiculo;  
        }
    }
}
