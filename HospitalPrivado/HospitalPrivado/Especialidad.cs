using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPrivado
{
    internal class Especialidad
    {
        private List<Estudio> estudios;
        public List<Estudio> Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }

        private double ganancia;
        public double Ganancia
        {
            get { return ganancia; }
            set { ganancia = value; }
        }

        private List<Paciente> pacientes;
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }

        private int cantPacientes;
        public int CantPacientes
        {
            get { return cantPacientes; }
            set { cantPacientes = value; }

        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }


        public Especialidad()
        {
            pacientes = new List<Paciente>();
            estudios = new List<Estudio>();
        }
    }
}
