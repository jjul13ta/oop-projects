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
    public partial class CargaEstudio : Form
    {
        private Hospital hospital;
        internal CargaEstudio(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();
        }

        private void CargaEstudio_Load(object sender, EventArgs e)
        {

        }
        public void Actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = hospital.Estudios
                .Select(e => new
                {
                    Tipo = e.Tipo,
                    Costo = e.Costo,
                    CupoMaximo = e.CupoMaximo,
                    CupoActual = e.CupoActual
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool yaExiste = false;
            bool posible = true;
            if (textBox1.Text == "" ||
                textBox4.Text == "" ||
                 textBox5.Text == "")
            { 
                posible = false;
            }

            if (posible)
            {
                int costo = Convert.ToInt32(textBox1.Text);

                int cupos = Convert.ToInt32(textBox5.Text);
                string tipo = textBox4.Text;


                foreach (Estudio es in hospital.Estudios)
                {
                    if (es.Tipo == tipo)
                    {
                        yaExiste = true;
                    }
                }

                if (!yaExiste)

                {

                    Estudio estudio = new Estudio();
                    estudio.Tipo = tipo;
                    estudio.CupoMaximo = cupos;
                    estudio.Costo = costo;
                    hospital.Estudios.Add(estudio);
                    Actualizar();
                }

            }
            if (!posible || yaExiste == true)
            {
                MessageBox.Show("Campos incompletos o Estudio existente");
            }
        }
    }
}
