using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hoteleria
{
    public partial class Form1 : Form
    {

        Hotel hotel = new Hotel();
        internal Form1()
        {
            InitializeComponent();

            hotel.Habitaciones = new List<Habitacion>();
            hotel.Reservas = new List<Reserva>();
            hotel.Integrantes = new List<Integrante>();

            dataGridView1.Columns.Add("colHabitacion", "Habitación");
            dataGridView1.Columns.Add("colTipo", "Tipo");
            dataGridView1.Columns.Add("colNombre", "Nombre");
            dataGridView1.Columns.Add("colCantidad", "Integrantes");
            dataGridView1.Columns.Add("colCheckin", "Checkin");
            dataGridView1.Columns.Add("colCheckout", "Checkout");
            dataGridView1.Columns.Add("colCuna", "Cuna");
            dataGridView1.Columns.Add("colVista", "Vista Mar");

            #region Habitaciones

            Habitacion h1 = new Habitacion();
            Habitacion h2 = new Habitacion();
            Habitacion h3 = new Habitacion();
            Habitacion h4 = new Habitacion();
            Habitacion h5 = new Habitacion();
            Habitacion h6 = new Habitacion();
            Habitacion h7 = new Habitacion();
            Habitacion h8 = new Habitacion();
            Habitacion h9 = new Habitacion();
            Habitacion h10 = new Habitacion();
            Habitacion h11 = new Habitacion();


            hotel.Habitaciones.Add(h1);
            hotel.Habitaciones.Add(h2);
            hotel.Habitaciones.Add(h3);
            hotel.Habitaciones.Add(h4);
            hotel.Habitaciones.Add(h5);
            hotel.Habitaciones.Add(h6);
            hotel.Habitaciones.Add(h7);
            hotel.Habitaciones.Add(h8);
            hotel.Habitaciones.Add(h9);
            hotel.Habitaciones.Add(h10);
            hotel.Habitaciones.Add(h11);


            h1.Numero = 101;
            h1.Valor = 200;
            h1.Tipo = "SIMPLE";

            h2.Numero = 102;
            h2.Valor = 350;
            h2.Tipo = "DOBLE";

            h3.Numero = 103;
            h3.Valor = 550;
            h3.Tipo = "TRIPLE";

            h4.Numero = 201;
            h4.Valor = 200;
            h4.Tipo = "SIMPLE";

            h5.Numero = 202;
            h5.Valor = 350;
            h5.Tipo = "DOBLE";

            h6.Numero = 203;
            h6.Valor = 550;
            h6.Tipo = "TRIPLE";

            h7.Numero = 301;
            h7.Valor = 200;
            h7.Tipo = "SIMPLE";

            h8.Numero = 302;
            h8.Valor = 350;
            h8.Tipo = "DOBLE";

            h9.Numero = 303;
            h9.Valor = 550;
            h9.Tipo = "TRIPLE";

            h10.Numero = 401;
            h10.Valor = 700;
            h10.Tipo = "CUADRUPLE";

            h11.Numero = 402;
            h11.Valor = 700;
            h11.Tipo = "CUADRUPLE";

            #endregion Habitaciones

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e) // Reservar
        {
            // verifico que haya cosas en el combobox
            if (comboBox1.Text == "" ||
            textBox1.Text == "" ||
            textBox2.Text == "" ||
            textBox3.Text == "" ||
            textBox4.Text == "" ||
            textBox5.Text == "" ||
            textBox6.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // creo la reserva con los radiobuttons
            Reserva reserva;

            if (radioButton1.Checked)
            {
                ReservaAdicional adicional = new ReservaAdicional();
                adicional.Cuna = true;
                reserva = adicional;
            }
            else if (radioButton2.Checked)
            {
                ReservaAdicional adicional = new ReservaAdicional();
                adicional.VistaMar = true;
                reserva = adicional;

            }
            else
            {
                reserva = new Reserva();
            }

            // selecciono los checkin y comprobaciones
            DateTime checkin = dateTimePicker1.Value;
            DateTime checkout = dateTimePicker3.Value;
                     

            // paso los tipos de datos
            string tipo = comboBox1.Text;
            int cantidadIntegrantes = Convert.ToInt32(textBox2.Text);
            int numeroHabitacion = Convert.ToInt32(textBox1.Text);

            // creo la habtiacion y busco el numero comparando con el encontrado, luego hago comprobaciones si lo encuentra  o los tipos (si coinciden y cant integrantes)
            Habitacion habitacionEncontrada = null;
            foreach (Habitacion h in hotel.Habitaciones)
            {
                if (h.Numero == numeroHabitacion)
                {
                    habitacionEncontrada = h;
                }
            }

            if (habitacionEncontrada == null)
            {
                MessageBox.Show("Habitación inexistente");
            }
            else if (habitacionEncontrada.Tipo != tipo)
            {
                MessageBox.Show("La habitación no coincide con el tipo");
            }
            else if (tipo == "SIMPLE" && cantidadIntegrantes > 1)
            {
                MessageBox.Show("Una habitación simple admite máximo 1 integrante");
            }
            else if (tipo == "DOBLE" && cantidadIntegrantes > 2)
            {
                MessageBox.Show("Una habitación doble admite máximo 2 integrantes");
            }
            else if (tipo == "TRIPLE" && cantidadIntegrantes > 3)
            {
                MessageBox.Show("Una habitación triple admite máximo 3 integrantes");
            }
            else if (tipo == "CUADRUPLE" && cantidadIntegrantes > 4)
            {
                MessageBox.Show("Una habitación cuádruple admite máximo 4 integrantes");
            }
            else 
            {
                int dias = (checkout.Date - checkin.Date).Days;

                bool disponible = habitacionEncontrada.VerificarDisponibilidad(checkin, dias);

                if (!disponible)
                {
                    MessageBox.Show("La habitación no está disponible");
                }
                else
                {
                    // realizar reserva
                    reserva.FechaChekin = checkin;
                    reserva.FechaChekout = checkout;
                    reserva.Habitacion = habitacionEncontrada;

                    hotel.Reservar(reserva, habitacionEncontrada);

                    Integrante integrante = new Integrante();

                    integrante.Nombre = textBox3.Text;
                    integrante.Apellido = textBox4.Text;
                    integrante.Dni = Convert.ToInt32(textBox5.Text);
                    integrante.Edad = Convert.ToInt32(textBox6.Text);
                    integrante.FechaNacimiento = dateTimePicker2.Value;

                    hotel.Integrantes.Add(integrante);
                    habitacionEncontrada.Integrantes.Add(integrante);

                    MessageBox.Show("Reserva realizada correctamente");

                    ActualizarPantalla();
                }
            
        }
        }

        private void ActualizarPantalla()
        {

            RecaudacionTotal.Text = "Recaudacion total = " + hotel.RecaudacionTotal();
            habitacionMasSolicitada.Text = "Habitacion Mas Solicitada = " + hotel.habitacionMasSolicitada().Numero;
            integranteMasHospedado.Text = "Integrante mas hospedado = " + hotel.integranteMasHospedado().Nombre;

            dataGridView1.Rows.Clear();

            foreach (Habitacion h in hotel.Habitaciones)
            {
                foreach (Reserva r in h.Reservas)
                {
                    ReservaAdicional adicional = r as ReservaAdicional;

                         dataGridView1.Rows.Add(
                        h.Numero,
                        h.Tipo,
                        h.Integrantes.Count > 0 ? h.Integrantes[0].Nombre : "",
                        h.Integrantes.Count,
                        r.FechaChekin.ToShortDateString(),
                        r.FechaChekout.ToShortDateString(),
                        adicional != null && adicional.Cuna ? "SI" : "NO",
                        adicional != null && adicional.VistaMar ? "SI" : "NO"
                    );
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numHabitacion = Convert.ToInt32(Interaction.InputBox("Ingrese el numero de la habitacion"));

            Habitacion habitacionEncontrada = null;
            foreach(Habitacion h in hotel.Habitaciones)
            {
                if(h.Numero == numHabitacion)
                {
                    habitacionEncontrada = h;
                }
            }

            if (habitacionEncontrada == null)
            {
                MessageBox.Show("Habitacion no encontrada");
            }

            else if (habitacionEncontrada.Reservas.Count == 0)
            {
                MessageBox.Show("La habitación no tiene reservas");
            }
            else
            {
                DateTime checkin = dateTimePicker1.Value;
                DateTime checkout = dateTimePicker3.Value;

                int dias = (checkin - checkout).Days;
                Reserva reserva = habitacionEncontrada.Reservas[habitacionEncontrada.Reservas.Count - 1];

                reserva.FechaCancelacion = DateTime.Now;

                hotel.CancelarReserva(reserva, habitacionEncontrada);

                MessageBox.Show("Reserva cancelada");
                ActualizarPantalla();
            }
        }
        }
    }

