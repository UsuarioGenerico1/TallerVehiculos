﻿using System;
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
            servicio2.Precio1 = 50;
            Lista_Servicio.Add(servicio2);

            Servicio servicio3 = new Servicio();
            servicio3.Nombre_Servicio1 = "Cambio de aceite";
            servicio3.Precio1 = 30;
            Lista_Servicio.Add(servicio3);

            Servicio servicio4 = new Servicio();
            servicio3.Nombre_Servicio1 = "Cambio de pastillas de freno";
            servicio3.Precio1 = 100;
            Lista_Servicio.Add(servicio4);

            Servicio servicio5 = new Servicio();
            servicio3.Nombre_Servicio1 = "Cambio de filtro";
            servicio3.Precio1 = 50;
            Lista_Servicio.Add(servicio5);

            Servicio servicio6 = new Servicio();
            servicio3.Nombre_Servicio1 = "Ninguno";
            servicio3.Precio1 = 0;
            Lista_Servicio.Add(servicio6);
        }


        public Servicio buscarServicio(string servicio) {
            Servicio servicioGuardado = new Servicio();
            
            for (int i = 0; i < Lista_Servicio.Count; i++)
            {
                if (Lista_Servicio[i].Nombre_Servicio1 == servicio)
                {
                    servicioGuardado.Nombre_Servicio1 = Lista_Servicio[i].Nombre_Servicio1;
                    servicioGuardado.Precio1= Lista_Servicio[i].Precio1;  
                }
            }
            return servicioGuardado;
        }

    }
}
