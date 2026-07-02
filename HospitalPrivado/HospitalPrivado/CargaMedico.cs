using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPrivado
{
    public partial class CargaMedico : Form
    {
        private Hospital hospital;
        internal CargaMedico(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();
        }

        private void CargaMedico_Load(object sender, EventArgs e)
        {

        }
        public void Actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = hospital.Medicos
                .Select(m => new
                {
                    Nombre = m.Nombre,
                    Apellido = m.Apellido,
                    Costo = m.Costo,
                    Edad = m.Edad,
                    Especialidades = m.Especialidades.Count,
                    Clinico =  (m is MedicoClinico) ?  "SI" : "NO" 
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existente = false;
            if (ValidarTextbox())
            {
                string nombre = textBox1.Text;
                string especialidad1Name = textBox5.Text;
                string especialidad2Name = textBox6.Text;
                string apellido = textBox2.Text;
                int costo = Convert.ToInt32(textBox3.Text);
                int edad = Convert.ToInt32(textBox4.Text);

                bool especialidad1FOUND = false;
                bool especialidad2FOUND = false;

                foreach(Medico m in hospital.Medicos)
                {
                    if(m.Nombre == nombre && m.Apellido == apellido)
                    {
                        existente = true; 
                    }

                }

                if(!existente)
                {
                    Medico medico;

                    if (checkBox1.Checked)
                    {
                        medico = new MedicoClinico();
                    }
                    else
                    {
                        medico = new Medico();
                    }

                    medico.Nombre = nombre;
                    medico.Nombre = nombre;
                    medico.Apellido = apellido;
                    medico.Costo = costo;
                    medico.Edad = edad;

                    if (textBox5.Text != "")
                    {
                        Especialidad especialidad1 = null;

                        foreach (Especialidad es1 in hospital.Especialidades)
                        {
                            if (es1.Nombre == especialidad1Name)
                            {
                                especialidad1FOUND = true;
                                especialidad1 = es1;
                            }
                        }

                        if(especialidad1FOUND)
                        { medico.Especialidades.Add(especialidad1); }
                        
                    }

                    if (textBox6.Text != "")
                    {
                        Especialidad especialidad2 = null;
                        foreach (Especialidad es2 in hospital.Especialidades)
                        {
                            if (es2.Nombre == especialidad2Name)
                            {
                                especialidad2FOUND = true;
                                especialidad2 = es2;
                            }
                        }
                        if(especialidad2FOUND)
                        { medico.Especialidades.Add(especialidad2); }

                    }

                    
   
                    hospital.Medicos.Add(medico);
                }
            }

            if(existente)
            {
                MessageBox.Show("Ya esta cargado ese medico");
            }

            if(!ValidarTextbox())
            {
                MessageBox.Show("Debe completar todos los campos");
            }

            Actualizar();

        }

        private bool ValidarTextbox()
        {
            bool ingresados = false;
            if(textBox1.Text != "" &&
               textBox2.Text != "" &&
               textBox3.Text != "" &&
               textBox4.Text != "")
            {
                ingresados = true;
            }
            return ingresados;
        }

        
    }
}
