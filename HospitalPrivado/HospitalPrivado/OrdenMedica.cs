using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class OrdenMedica
    {
        private string firma;
        public string Firma
        {
            get { return firma; }
            set { firma = value; }
        }

        private Medico medico;
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


    }
}
