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
    public partial class CargaPaciente : Form
    {
        private Hospital hospital;
        internal CargaPaciente(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();
        }

        private void CargaPaciente_Load(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = hospital.Pacientes
                .Select(p => new
                {
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Edad = p.Edad,
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existente = false;
            if (ValidarTextBox())
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                int edad = Convert.ToInt32(textBox4.Text);


                foreach(Paciente p in hospital.Pacientes)
                {
                    if(p.Nombre == nombre && p.Apellido == apellido)
                    {
                        existente = true;
                    }
                }

                if(!existente)
                {
                    Paciente paciente = new Paciente();
                    paciente.Nombre = nombre;
                    paciente.Apellido = apellido;
                    paciente.Edad = edad;

                    hospital.Pacientes.Add(paciente);
                }
            }

            if(!ValidarTextBox())
            {
                MessageBox.Show("Debe ingresar todos los datos en los TextBox");
            }

            if(existente)
            {
                MessageBox.Show("Ese paciente ya esta registrado");
            }

            Actualizar();
        }

        private bool ValidarTextBox()
        {
            bool valid = true;
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox4.Text == "")
            {
                valid = false;
            }

            return valid;
        }
    }
}
