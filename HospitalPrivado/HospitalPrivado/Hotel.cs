using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    internal class Hotel
    {
        #region Operaciones
        private List<Reserva> reservas;
        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }

        private List<Habitacion> habitaciones;
        public List<Habitacion> Habitaciones
        {
            get { return habitaciones; }
            set { habitaciones = value; }
        }


        private List<Integrante> integrantes;
        public List<Integrante> Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }

        private decimal recaudacion;
        public decimal Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        #endregion Operaciones

        public void Reservar(Reserva reserva, Habitacion habitacion)
        {
            habitacion.Reservas.Add(reserva);
            reservas.Add(reserva);
            recaudacion += reserva.ObtenerValorTotal();
        }

        public void CancelarReserva(Reserva reserva, Habitacion habitacion)
        {
            habitacion.Reservas.Remove(reserva);
            reservas.Remove(reserva);
            int diasCancelacion = (reserva.FechaChekin - reserva.FechaCancelacion).Days;
            recaudacion -= reserva.ValorDeReintegro(diasCancelacion);
        }

        public Habitacion habitacionMasSolicitada()
        {
            Habitacion habitacion = null;
            foreach (Habitacion h in habitaciones)
            {
                if (habitacion == null || h.CantidadVecesHospedada > habitacion.CantidadVecesHospedada)
                {
                    habitacion = h;
                }
            }
            return habitacion;
        }

        public Integrante integranteMasHospedado()
        {
            Integrante integrante = null;
            foreach (Integrante i in integrantes)
            {
                if (integrante == null || i.CantidadVecesHospedado > integrante.CantidadVecesHospedado)
                {
                    integrante = i;
                }
            }
            return integrante;
        }

        public decimal RecaudacionTotal()
        {
            return recaudacion;
        }


    }
}
