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
            this.ID_Vehiculo = iD_Vehiculo;
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
        }

        public int ID_Vehiculo1 { get => ID_Vehiculo; set => ID_Vehiculo = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Color1 { get => Color; set => Color = value; }
    }
}
