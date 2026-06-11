using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    internal class Habitacion
    {
        #region Operaciones
        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int recaudacion;
        public int Recaudacion
        {
            get { return recaudacion; }
            set { recaudacion = value; }
        }

        private int cantidadArtefactos;
        public int CantidadArtefactos
        {
            get { return cantidadArtefactos; }
            set { cantidadArtefactos = value; }
        }

        private bool disponible;
        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        private List<Integrante> integrantes;
        public List<Integrante> Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }

        private int valor;
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int duracion;
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private Reserva reserva;
        public Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

        private List<Reserva> reservas;
        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }

        private int cantidadVecesHospedada;
        public int CantidadVecesHospedada
        {
            get { return cantidadVecesHospedada; }
            set { cantidadVecesHospedada = value; }
        }

        public Habitacion()
        {
            Reservas = new List<Reserva>();
            Integrantes = new List<Integrante>();
        }

        #endregion Operaciones

        public bool VerificarDisponibilidad(DateTime fechaInicial, int duracion)
        {
            disponible = true;
            int i = 0;
            DateTime fechaFin = fechaInicial.AddDays(duracion);

            while (disponible && i < Reservas.Count)
            {
                Reserva reserva = reservas[i];
                DateTime ff = reserva.FechaChekout;
                disponible = (ff <= fechaInicial || reserva.FechaChekout < fechaFin);

                i++;
            }
            return disponible;
        }
    }
}
