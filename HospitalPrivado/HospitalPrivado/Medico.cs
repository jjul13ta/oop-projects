using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Medico : IFacturable
    {
        #region Operaciones
        private double costo;
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private List<Especialidad> especialidades; 
        public List<Especialidad> Especialidades
        {
            get { return especialidades; }
            set { especialidades = value; }
        }

        private int cantidadEspecialidades;
        public int CantidadEspecialidades
        {
            get { return cantidadEspecialidades; }
            set { cantidadEspecialidades = value; }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
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
        #endregion Operaciones

        public Medico()
        {
            especialidades = new List<Especialidad>();
        }
        public double ObtenerValor()
        {
            double valorTotal;
            cantidadEspecialidades = especialidades.Count();
            valorTotal = costo + (costo * 0.15 * cantidadEspecialidades);
            return valorTotal;
        }

    }
}
