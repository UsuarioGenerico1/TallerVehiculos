using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorServicio
    {
        public BindingList<Servicio> Lista_Servicio { get; set; }

        public ControladorServicio()
        {
            Lista_Servicio = new BindingList<Servicio>();
            serviciosPrincipales();
        }

        public void serviciosPrincipales(){
            Servicio servicio = new Servicio();
            servicio.Nombre_Servicio1 = "Lavado";
            servicio.Precio1 = 10;
            Lista_Servicio.Add(servicio);

            Servicio servicio2 = new Servicio();
            servicio2.Nombre_Servicio1 = "Alineado";
            servicio2.Precio1 = 20;
            Lista_Servicio.Add(servicio2);

            Servicio servicio3 = new Servicio();
            servicio3.Nombre_Servicio1 = "Cambio de aceite";
            servicio3.Precio1 = 15;
            Lista_Servicio.Add(servicio3);
        }

    }
    }

