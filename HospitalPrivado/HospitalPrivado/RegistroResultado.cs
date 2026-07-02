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
    public partial class RegistroResultado : Form
    {

        private Hospital hospital;
        internal RegistroResultado(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();
        }

        private void RegistroResultado_Load(object sender, EventArgs e)
        {

        }
        public void Actualizar()
        {
            dataGridView2.DataSource = null;

            dataGridView2.DataSource = hospital.Resultados
                .Select(r => new
                {
                    Paciente = r.Paciente.Nombre,
                    Fecha = r.Fecha,
                    Estudio = r.Estudio.Tipo,
                    Diagnostico = r.Descripcion,
                    Normal = (r.EsNormal is true ? "si" : "no")
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(VerificarTextbox())
            {
                Paciente paciente = null;
                string nombrePaciente = txt_Paciente.Text;

                foreach(Paciente p in hospital.Pacientes)
                {
                    if (p.Nombre == nombrePaciente)
                    {
                        paciente = p;
                    }
                }

                if (paciente != null)
                {
                    Estudio estudio = null;
                    string estudioTipo = txt_Estudio.Text;

                    foreach(Estudio es in hospital.Estudios)
                    {
                        if(es.Tipo == estudioTipo)
                        {
                            estudio = es;
                        }
                    }

                    if(estudio != null)
                    {
                        Resultado resultado = new Resultado();
                        DateTime fecha = dateTimePicker1.Value;
                        string descripcion = textBox1.Text;

                        resultado.EsNormal = checkBox1.Checked;
                        resultado.Paciente = paciente;
                        resultado.Estudio = estudio;
                        resultado.Fecha = fecha;
                        resultado.Descripcion = descripcion;

                        hospital.Resultados.Add(resultado);
                        Actualizar();
                    }
                }
            }
        }

        private bool VerificarTextbox()
        {
            bool ingresado = true;
            if(txt_Estudio.Text == "" &&
                txt_Paciente.Text == "" &&
                textBox1.Text == "" )
            {
                MessageBox.Show("Debe completar todos los campos");
                ingresado = false;
            }

            return ingresado;
        }

    }
}
