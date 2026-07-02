using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class MedicoClinico :Medico
    {
        private List<Turno> turnos;
        public List<Turno> Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }
        public bool ObtenerDisponibilidad(DateTime fecha, int duracion)
        {
            bool disponible = true;
            foreach (Turno t in turnos)
            {
                DateTime finTurnoExistente = t.Fecha.AddMinutes(t.Duracion);
                DateTime finNuevoTurno = fecha.AddMinutes(duracion);
                if (fecha < finTurnoExistente && finNuevoTurno > t.Fecha)
                {
                    disponible = false;
                }
            }
            return disponible;
        }

        public MedicoClinico()
        {
            turnos = new List<Turno>();
        }
    }
}
