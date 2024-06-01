using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Persona
    {
        private string Cedula;
        private string Nombre;
        private string Appelido;

        public Persona() {
            Cedula = "";
            Nombre = "";
            Appelido = "";
        }

        public Persona(string cedula, string nombre, string appelido)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Appelido = appelido;
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Appelido1 { get => Appelido; set => Appelido = value; }
    }
}
