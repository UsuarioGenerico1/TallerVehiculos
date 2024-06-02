using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerVehiculos.Datos;

namespace TallerVehiculos.Controlador
{
    internal class ControladorMecanico
    {
        public BindingList<Mecanico> Lista_Mecanico = new BindingList<Mecanico>();

        public void agregarMecanico(Mecanico mecanico) {
            Lista_Mecanico.Add(mecanico);
        }

        public void modificarMecanico(Mecanico mecanico)
        {
            for (int i = 0; i < Lista_Mecanico.Count; i++)
            {

                if (Lista_Mecanico[i].Cedula1 == mecanico.Cedula1)
                {
                    Lista_Mecanico[i] = mecanico;
                    break;
                }

            }

        }

    }
}
