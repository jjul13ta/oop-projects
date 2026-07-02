using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Resultado
    {
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Paciente paciente;
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private Estudio estudio;
        public Estudio Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }

        private bool esNormal;
        public bool EsNormal
        {
            get { return esNormal; }
            set { esNormal = value; }
        }

    }
}
