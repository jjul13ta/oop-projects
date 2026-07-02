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
    public partial class VistaGeneral : Form
    {

        private Hospital hospital;
        internal VistaGeneral(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
            Actualizar();
        }

        private void VistaGeneral_Load(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            dgv_Pacientes.DataSource = null;

            dgv_Pacientes.DataSource = hospital.Pacientes
                .Select(p => new
                {
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Edad = p.Edad,
                })
                .ToList();


            dgv_Especialidades.DataSource = null;

            dgv_Especialidades.DataSource = hospital.Especialidades
                .Select(e => new
                {
                    Nombre = e.Nombre,
                })
                .ToList();

            dgv_Estudios.DataSource = null;

            dgv_Estudios.DataSource = hospital.Estudios
                .Select(es => new
                {
                    Tipo = es.Tipo,
                    Costo = es.Costo,
                    CupoActual = es.CupoActual,
                    CupoMax = es.CupoMaximo
                })
                .ToList();

            dgv_Medicos.DataSource = null;

            dgv_Medicos.DataSource = hospital.Medicos
                .Select(m => new
                {
                    Nombre = m.Nombre,
                    Apellido = m.Apellido,
                    Edad = m.Edad,
                    Costo = m.Costo
                })
                .ToList();
        }
    }
}
