using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculos.Datos
{
    internal class Mantenimiento
    {
        int codigo_mantenimiento;
        int id_cliente;
        int id_mecanico;
        DateTime fecha_mantenimiento;
        int id_vehiculo;
        string diagnostico;
        string trabajos_realizados;
        string tipo_mantenimiento;
        int id_servicios;

        public Mantenimiento(
            int codigo_mantenimiento,
            int id_cliente,
            int id_mecanico,
            datetime fecha_mantenimiento,
            int id_vehiculo,
            string diagnostico,
            string trabajos_realizados,
            string tipo_mantenimiento,
            int id_servicios
        ) {
            this.codigo_mantenimiento = codigo_mantenimiento;
            this.id_cliente = id_cliente;
            this.id_mecanico = id_mecanico;
            this.fecha_mantenimiento = fecha_mantenimiento;
            this.id_vehiculo = id_vehiculo;
            this.diagnostico = diagnostico;
            this.trabajos_realizados = trabajos_realizados;
            this.tipo_mantenimiento = tipo_mantenimiento;
            this.id_servicios = id_servicios;
        }

        void CalcularPrecioMantenimiento() {}
    }
}
