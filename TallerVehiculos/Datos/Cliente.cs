using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Cliente: Persona
    {
        private int ID_Cliente;
        private string Correo_Electronico;
        private DateTime Fecha_Registro;


        public Cliente() {
            Correo_Electronico = "";
        }

        public Cliente(int iD_Cliente, string correo_Electronico, DateTime fecha_Registro, 
            string cedula, string nombre, string apellido):base(cedula,nombre,apellido)
        {
            ID_Cliente1 = iD_Cliente;
            Correo_Electronico1 = correo_Electronico;
            Fecha_Registro1 = fecha_Registro;
        }

        public int ID_Cliente1 { get => ID_Cliente; set => ID_Cliente = value; }
        public string Correo_Electronico1 { get => Correo_Electronico; set => Correo_Electronico = value; }
        public DateTime Fecha_Registro1 { get => Fecha_Registro; set => Fecha_Registro = value; }
    }
}
