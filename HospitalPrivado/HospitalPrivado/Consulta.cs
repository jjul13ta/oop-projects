using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Consulta
    {
        private Medico medico;
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private Paciente paciente;
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private string diagnostico;
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }


        private OrdenMedica ordenMedica;
        public OrdenMedica OrdenMedica
        {
            get { return ordenMedica; }
            set { ordenMedica = value; }
        }


        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        private int duracion;
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }


        private Estudio estudio;
        public Estudio Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }
    }
}
