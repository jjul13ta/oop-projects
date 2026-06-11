using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    internal class ReservaAdicional:Reserva
    {
        private bool cuna;
        public bool Cuna
        {
            get { return cuna; }
            set { cuna = value; }
        }
        private bool vistaMar;
        public bool VistaMar
        {
            get { return vistaMar; }
            set { vistaMar = value; }
        }

        public override int ObtenerValorTotal()
        {
            double total = base.ObtenerValorTotal();

            if (Cuna)
            {
                total += 50 * Duracion;
            }

            if (vistaMar)
            {
                total *= 1.15;
            }

            return (int)total;
        }
    }
}
