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
    public partial class CargaEspecialidad : Form
    {
        private Hospital hospital;
       
        internal CargaEspecialidad(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();

        }

        private void CargaEspecialidad_Load(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = hospital.Especialidades
                .Select(e => new
                {
                    Nombre = e.Nombre,
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool escrito = true;
            bool encontrado = false;
            if (textBox1.Text == "")
            {
                escrito = false;
            }

            if(escrito)
            {
                string nombre = textBox1.Text;
                foreach(Especialidad es in hospital.Especialidades)
                {
                    if(es.Nombre == nombre)
                    {
                        encontrado = true;
                    }
                }

                if(!encontrado)
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.Nombre = nombre;
                    hospital.Especialidades.Add(especialidad);
                }
            }

            if(!escrito)
            {
                MessageBox.Show("Debe ingresar el nombre");
            }

            if(encontrado)
            {
                MessageBox.Show("Esa especialidad ya esta cargada");
            }
            Actualizar();
        }
    }
}
