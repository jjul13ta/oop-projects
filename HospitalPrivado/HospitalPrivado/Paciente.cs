using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Paciente
    {
        private HistoriaClinica historiaClinica;
        public HistoriaClinica HistoriaClinica
        {
            get { return historiaClinica; }
            set { historiaClinica = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Paciente()
        {
            historiaClinica = new HistoriaClinica();
        }

    }
}
