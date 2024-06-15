using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class DatosMantenimiento
    {
   
        int codigo_mantenimiento;
        DateTime fecha_mantenimiento;
        string diagnostico;
        string trabajos_realizados;
        string tipo_mantenimiento;

        string referenciaCliente;
        string referenciaMecanico;
        public DatosMantenimiento() {
            codigo_mantenimiento = 0;
            diagnostico = string.Empty;
            trabajos_realizados = string.Empty;
            tipo_mantenimiento = string.Empty;
            referenciaCliente = string.Empty; 
            
        }

        

        public int Codigo_mantenimiento { get => codigo_mantenimiento; set => codigo_mantenimiento = value; }
        public DateTime Fecha_mantenimiento { get => fecha_mantenimiento; set => fecha_mantenimiento = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Trabajos_realizados { get => trabajos_realizados; set => trabajos_realizados = value; }
        public string Tipo_mantenimiento { get => tipo_mantenimiento; set => tipo_mantenimiento = value; }
        public string ReferenciaCliente { get => referenciaCliente; set => referenciaCliente = value; }
        public string ReferenciaMecanico { get => referenciaMecanico; set => referenciaMecanico = value; }
        
    }
}
