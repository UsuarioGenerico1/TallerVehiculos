﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Servicio
    {
        private int ID_Servicio;
        private string Nombre_Servicio;
        private double Precio;
        public Servicio()
        {
            Nombre_Servicio=String.Empty;
        }
        public Servicio(int iD_Servicio, string nombre_Servicio, double precio)
        {
            this.ID_Servicio = iD_Servicio;
            this.Nombre_Servicio = nombre_Servicio;
            this.Precio = precio;
        }

        public int ID_Servicio1 { get => ID_Servicio; set => ID_Servicio = value; }
        public string Nombre_Servicio1 { get => Nombre_Servicio; set => Nombre_Servicio = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
    }
}
