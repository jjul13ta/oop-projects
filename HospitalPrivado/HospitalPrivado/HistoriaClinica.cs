using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrivado
{
    internal class HistoriaClinica
    {
        private List<Consulta> consultas;
        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }

        private List<Estudio> estudios;
        public List<Estudio> Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }

        private List<RecetaMedica> recetas;
        public List<RecetaMedica> Recetas
        {
            get { return recetas; }
            set { recetas = value; }
        }

        public HistoriaClinica()
        {
            consultas = new List<Consulta>();
            estudios = new List<Estudio>();
            recetas = new List<RecetaMedica>();
        }

    }
}
