using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    internal class Reserva
    {
        #region Operaciones
        private DateTime fechaCheckin;
        public DateTime FechaChekin
        {
            get { return fechaCheckin; }
            set { fechaCheckin = value; }
        }

        private DateTime fechaCheckout;
        public DateTime FechaChekout
        {
            get { return fechaCheckout; }
            set { fechaCheckout = value; }
        }

        private int adicionales; // ya hay int adicionales en habit
        public int Adicionales
        {
            get { return adicionales; }
            set { adicionales = value; }
        }

        private int duracion; // ya hay int adicionales en habit
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private int deposito; 
        public int Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }

        private Habitacion habitacion; 
        public Habitacion Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

        private DateTime fechaCancelacion; 
        public DateTime FechaCancelacion
        {
            get { return fechaCancelacion; }
            set { fechaCancelacion = value; }
        }
        #endregion Operaciones


        public virtual int ObtenerValorTotal()
        {
            duracion = (FechaChekout.Date - FechaChekin.Date).Days;
            int total = Habitacion.Valor * duracion;

            return total;
        }


        public decimal ValorDeReintegro(decimal DiasCancelacion)
        {
            decimal reintegro;
            if (DiasCancelacion <= 2)
            {
                reintegro = ReintegroInferiorDosDias();
            }
            else if (DiasCancelacion > 2 && DiasCancelacion < 8)
            {
                reintegro = ReintegroDentroDeLaSemana();
            }
            else
            {
                reintegro = ReintegroMayorDeSemana();
            }
            return reintegro;
        }

        public decimal ReintegroInferiorDosDias()
        {
            decimal reintegro = deposito * 0.10m;
            return reintegro;
        }

        public decimal ReintegroDentroDeLaSemana()
        {
            decimal reintegro = deposito / 2;
            return reintegro;
        }

        public decimal ReintegroMayorDeSemana()
        {
            decimal reintegro = ObtenerValorTotal();
            return reintegro;

        }
    }
}

