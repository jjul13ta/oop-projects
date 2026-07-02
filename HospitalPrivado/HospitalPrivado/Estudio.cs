using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class Estudio : IFacturable
    {
        #region Operaciones
        private int costo;
        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        private int cupoMaximo;
        public int CupoMaximo
        {
            get { return cupoMaximo; }
            set { cupoMaximo = value; }
        }

        private int cupoActual;
        public int CupoActual
        {
            get { return cupoActual; }
            set { cupoActual = value; }
        }

        private Resultado resultado;
        public Resultado Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        #endregion Operaciones

        public bool VerificarDisponibilidad()
        {
            bool disponible = true;
            if(cupoActual >= cupoMaximo)
            {
                disponible = false;
            }
            return disponible;
        }

        public double ObtenerValor()
        {
            return costo; 
        }
    }
}
