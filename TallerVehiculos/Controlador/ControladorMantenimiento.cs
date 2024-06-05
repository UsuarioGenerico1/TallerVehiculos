using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorMantenimiento
    {
        public BindingList<DatosMantenimiento> Lista_Mantenimientos { get; set; }

        public ControladorMantenimiento() {
            Lista_Mantenimientos = new BindingList<DatosMantenimiento>();
            
        }

        public void agrearMantenimiento(DatosMantenimiento mantenimiento) { 
            Lista_Mantenimientos.Add(mantenimiento);    
        }

        public DatosMantenimiento buscarMantenimiento(int mantenimiento)
        {
            DatosMantenimiento buscarMantenimiento = new DatosMantenimiento();
            for (int i = 0; i < Lista_Mantenimientos.Count; i++)
            {
                if (Lista_Mantenimientos[i].Codigo_mantenimiento == mantenimiento)
                {
                    buscarMantenimiento.Fecha_mantenimiento = Lista_Mantenimientos[i].Fecha_mantenimiento;
                    buscarMantenimiento.Tipo_mantenimiento = Lista_Mantenimientos[i].Tipo_mantenimiento;
                    buscarMantenimiento.Diagnostico = Lista_Mantenimientos[i].Diagnostico;
                    buscarMantenimiento.Trabajos_realizados = Lista_Mantenimientos[i].Trabajos_realizados;
                }
            }
            return buscarMantenimiento;
        }

       

        //repuestos , servicios , tipo de mantenimiento


    }
}
