using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Mecanico: Persona
    {
        private int ID_Mecanico;
        private string Direccion;
        private string Especialidad;
        private string Experiencia;


        public Mecanico()
        {
            Direccion= String.Empty;
            Especialidad = String.Empty;
            Experiencia= String.Empty;

        }
        public Mecanico(int iD_Mecanico, string direccion, string especialidad, string experiencia
            ,string cedula,string nombre,string apellido):base(cedula,nombre,apellido)
        {
            ID_Mecanico1 = iD_Mecanico;
            Direccion1 = direccion;
            Especialidad1 = especialidad;
            Experiencia1 = experiencia;
        }

        public int ID_Mecanico1 { get => ID_Mecanico; set => ID_Mecanico = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public string Experiencia1 { get => Experiencia; set => Experiencia = value; }
    }
}
