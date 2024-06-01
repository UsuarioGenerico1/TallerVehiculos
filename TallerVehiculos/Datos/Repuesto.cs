using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Repuesto
    {
        private int ID_Repuesto;
        private string Nombre_Respuesto;
        private double Precio;

        public Repuesto(int iD_Repuesto, String nombre_Respuesto, double precio)
        {
            this.ID_Repuesto = iD_Repuesto;
            this.Nombre_Respuesto = nombre_Respuesto;
            this.Precio = precio;
        }

        public int ID_Repuesto1 { get => ID_Repuesto; set => ID_Repuesto = value; }
        public string Nombre_Respuesto1 { get => Nombre_Respuesto; set => Nombre_Respuesto = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
    }
}
