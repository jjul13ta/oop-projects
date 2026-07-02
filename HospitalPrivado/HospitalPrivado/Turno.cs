using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Turno
    {
        private Paciente paciente;
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private Medico medico;
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private int duracion;
            public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
