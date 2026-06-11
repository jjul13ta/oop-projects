using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    internal class Integrante
    {
        #region Operaciones
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

        private int dni;
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private int cantidadVecesHospedado;
        public int CantidadVecesHospedado
        {
            get { return cantidadVecesHospedado; }
            set { cantidadVecesHospedado = value; }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        #endregion Operaciones
    }
}
