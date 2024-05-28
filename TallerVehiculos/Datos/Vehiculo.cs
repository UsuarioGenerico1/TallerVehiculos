using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Vehiculo
    {
        private int ID_Vehiculo;
        private string Placa;
        private string Marca;
        private string Modelo;
        private string Color;



        public Vehiculo()
        {   
            Placa= string.Empty;
            Marca= string.Empty;
            Modelo= string.Empty;
            Color= string.Empty;
        }

        public Vehiculo(int iD_Vehiculo, string placa, string marca, string modelo, string color)
        {
            ID_Vehiculo1 = iD_Vehiculo;
            Placa1 = placa;
            Marca1 = marca;
            Modelo1 = modelo;
            Color1 = color;
        }

        public int ID_Vehiculo1 { get => ID_Vehiculo; set => ID_Vehiculo = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Color1 { get => Color; set => Color = value; }
    }
}
