using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPrivado
{
    internal class Hospital
    {
        #region Operaciones
        private List<Paciente> pacientes;
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }


        private List<HistoriaClinica> historiasClinicas;
        public List<HistoriaClinica> HistoriasClinicas
        {
            get { return historiasClinicas; }
            set { historiasClinicas = value; }
        }
        private List<Medico> medicos;
        public List<Medico> Medicos
        {
            get { return medicos; }
            set { medicos = value; }
        }

        private List<Consulta> consultas;
        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }


        private List<Resultado> resultados;
        public List<Resultado> Resultados
        {
            get { return resultados; }
            set { resultados = value; }
        }

        private List<OrdenMedica> ordenesMedicas;
        public List<OrdenMedica> OrdenesMedicas
        {
            get { return ordenesMedicas; }
            set { ordenesMedicas = value; }
        }

        private List<Especialidad> especialidades;
        public List<Especialidad> Especialidades
        {
            get { return especialidades; }
            set { especialidades = value; }
        }

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

        #endregion Operaciones
        public Hospital()
        {
            estudios = new List<Estudio>();
            pacientes = new List<Paciente>();
            ordenesMedicas = new List<OrdenMedica>();
            consultas = new List<Consulta>();
            medicos = new List<Medico>();
            especialidades = new List<Especialidad>();
            historiasClinicas = new List<HistoriaClinica>();
            resultados = new List<Resultado>();
        }
        public void CrearConsulta(Medico medico, Paciente paciente, Especialidad especialidad,
                           Estudio estudio, DateTime fechaTurno, int duracion)
        {
            bool puedeCrear = true;

            if (medico is MedicoClinico medicoClinico)
            {
                bool disponible = medicoClinico.ObtenerDisponibilidad(fechaTurno, duracion);

                if (!disponible)
                {
                    MessageBox.Show("El medico no tiene disponibilidad en ese horario.");
                    puedeCrear = false;
                }
            }

            if (estudio != null && !estudio.VerificarDisponibilidad())
            {
                MessageBox.Show("No hay cupo disponible para este estudio.");
                puedeCrear = false;
            }

            if (puedeCrear)
            {
                Consulta consulta = new Consulta();
                consulta.Medico = medico;
                consulta.Paciente = paciente;
                consulta.Fecha = fechaTurno;
                consulta.Duracion = duracion;
                consulta.Estudio = estudio;

                if (medico is MedicoClinico mc)
                {
                    Turno turno = new Turno();
                    turno.Medico = medico;
                    turno.Paciente = paciente;
                    turno.Fecha = fechaTurno;
                    turno.Duracion = duracion;
                    mc.Turnos.Add(turno);
                }

                if (estudio != null)
                {
                    estudio.CupoActual++;

                    OrdenMedica orden = new OrdenMedica();
                    orden.Medico = medico;
                    orden.Fecha = fechaTurno;

                    ordenesMedicas.Add(orden);
                    consulta.OrdenMedica = orden;

                    paciente.HistoriaClinica.Estudios.Add(estudio);
                }

                paciente.HistoriaClinica.Consultas.Add(consulta);

                if (!especialidad.Pacientes.Contains(paciente))
                {
                    especialidad.Pacientes.Add(paciente);
                    especialidad.CantPacientes++;
                }

                double valor = medico.ObtenerValor();
                especialidad.Ganancia += valor;
                ganancia += valor;

                consultas.Add(consulta);
            }
        }



    }
    
}
