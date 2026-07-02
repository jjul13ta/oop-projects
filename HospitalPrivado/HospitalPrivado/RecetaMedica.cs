using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class RecetaMedica
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

        private int medicamentos;
        public int Medicamentos
        {
            get { return medicamentos; }
            set { medicamentos = value; }
        }


    }
}
