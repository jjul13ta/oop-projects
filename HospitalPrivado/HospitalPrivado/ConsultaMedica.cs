using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalPrivado
{
    public partial class ConsultaMedica : Form
    {
        private Hospital hospital;
        internal ConsultaMedica(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            dateTimePicker2.Enabled = false;
            textBox6.Enabled = false;
            Actualizar();
        }

        public void Actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = hospital.Consultas
                .Select(c => new
                {
                    Paciente = c.Paciente.Nombre,
                    Medico = c.Medico.Nombre,
                    Fecha = c.Fecha,
                    OrdenMedica = c.OrdenMedica != null, // esto no ta bien
                    Estudio = c.Estudio.Tipo,
                    Duracion = c.Duracion,
                })
                .ToList();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarTextbox())
            {
                Especialidad especialidad = null;
                Paciente paciente = null;
                Estudio estudio = null;
                Medico medico = null;
                MedicoClinico medicoClinico = null;

                string nombrePaciente = textBox1.Text;
                string nombreMedico = textBox2.Text;
                string nombreEspecialidad = textBox3.Text;
                int duracion = Convert.ToInt32(textBox4.Text);
                string estudioTipo = textBox5.Text;
                bool urgencia = checkBox1.Checked;
                DateTime fecha = dateTimePicker1.Value;

                bool encontradoMedico = false;
                bool encontradoPaciente = false;
                bool encontradoEstudio = false;

                foreach (Paciente p in hospital.Pacientes)
                {
                    if (p.Nombre == nombrePaciente)
                    {
                        encontradoPaciente = true;
                        paciente = p;
                    }
                }

                if (encontradoPaciente)
                {
                    foreach (Estudio es in hospital.Estudios)
                    {
                        if (es.Tipo == estudioTipo)
                        {
                            encontradoEstudio = true;
                            estudio = es;
                        }
                    }

                    if (!encontradoEstudio)
                    {
                        MessageBox.Show("No se encontró el estudio.");
                    }

                    if (encontradoEstudio)
                    {
                        foreach (Medico m in hospital.Medicos)
                        {
                            foreach (Especialidad es in m.Especialidades)
                            {
                                if (es.Nombre == nombreEspecialidad)
                                {
                                    if (m.Nombre == nombreMedico)
                                    {
                                        medico = m;
                                        especialidad = es;
                                        encontradoMedico = true;

                                        if (m is MedicoClinico mc)
                                        {
                                            medicoClinico = mc;
                                        }
                                    }
                                }
                            }
                        }

                        if (encontradoMedico)
                        {
                            if (!urgencia && medicoClinico == null)
                            {
                                MessageBox.Show("Para reservar turno el medico debe ser clinico.");
                            }
                            else if (urgencia && medicoClinico != null)
                            {
                                MessageBox.Show("La demanda espontanea solo puede ser atendida por medicos de guardia.");
                            }
                            else
                            {
                                hospital.CrearConsulta(medico, paciente, especialidad, estudio, fecha, duracion);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro al medico ingresado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al paciente.");
                }

            }
            Actualizar();
        }

        private bool ValidarTextbox()
        {
            bool todoIngresado = true;
        
            if(textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "" 
                )
            {
                todoIngresado = false;
            }

            return todoIngresado;
        }


        private void anularTXT()
        {
            if(checkBox2.Checked)
            {
                dateTimePicker2.Enabled = true;
                textBox6.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            anularTXT();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
