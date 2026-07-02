<<<<<<< HEAD
﻿namespace Hoteleria
=======
﻿namespace HospitalPrivado
>>>>>>> main
{
    partial class Form1
    {
        /// <summary>
<<<<<<< HEAD
        ///  Required designer variable.
=======
        /// Variable del diseñador necesaria.
>>>>>>> main
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
<<<<<<< HEAD
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
=======
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
>>>>>>> main
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

<<<<<<< HEAD
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            habitacionMasSolicitada = new Label();
            integranteMasHospedado = new Label();
            RecaudacionTotal = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button14 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 243);
            button1.Name = "button1";
            button1.Size = new Size(145, 23);
            button1.TabIndex = 0;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(354, 243);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar Reserva";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(487, 196);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 334);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(399, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 337);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 7;
            label2.Text = "Cantidad de Integrantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 290);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(399, 319);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(399, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 417);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(399, 420);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 319);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 13;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 351);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 14;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 385);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 15;
            label6.Text = "Fecha Nacimiento";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(399, 379);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(514, 420);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 17;
            label7.Text = "Edad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SIMPLE", "DOBLE", "TRIPLE", "CUADRUPLE" });
            comboBox1.Location = new Point(12, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 298);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 6;
            label1.Text = "Tipo de habitacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 380);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 30;
            label8.Text = "Habitacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 31;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(12, 458);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(100, 23);
            dateTimePicker3.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 420);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 33;
            label10.Text = "ChekIN";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(132, 458);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 34;
            label11.Text = "ChekOUT";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(399, 454);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 35;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cuna";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(399, 480);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 19);
            radioButton2.TabIndex = 36;
            radioButton2.TabStop = true;
            radioButton2.Text = "Vista al Mar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // habitacionMasSolicitada
            // 
            habitacionMasSolicitada.AutoSize = true;
            habitacionMasSolicitada.Location = new Point(584, 441);
            habitacionMasSolicitada.Name = "habitacionMasSolicitada";
            habitacionMasSolicitada.Size = new Size(155, 15);
            habitacionMasSolicitada.TabIndex = 37;
            habitacionMasSolicitada.Text = "Habitacion Mas Solicitada =";
            // 
            // integranteMasHospedado
            // 
            integranteMasHospedado.AutoSize = true;
            integranteMasHospedado.Location = new Point(584, 467);
            integranteMasHospedado.Name = "integranteMasHospedado";
            integranteMasHospedado.Size = new Size(159, 15);
            integranteMasHospedado.TabIndex = 38;
            integranteMasHospedado.Text = "Integrante mas hospedado =";
            // 
            // RecaudacionTotal
            // 
            RecaudacionTotal.AutoSize = true;
            RecaudacionTotal.Location = new Point(584, 488);
            RecaudacionTotal.Name = "RecaudacionTotal";
            RecaudacionTotal.Size = new Size(116, 15);
            RecaudacionTotal.TabIndex = 39;
            RecaudacionTotal.Text = "Recaudacion total = ";
            // 
            // button3
            // 
            button3.Location = new Point(534, 41);
            button3.Name = "button3";
            button3.Size = new Size(67, 53);
            button3.TabIndex = 40;
            button3.Text = "101";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(621, 41);
            button4.Name = "button4";
            button4.Size = new Size(67, 53);
            button4.TabIndex = 41;
            button4.Text = "102";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(717, 41);
            button5.Name = "button5";
            button5.Size = new Size(67, 53);
            button5.TabIndex = 42;
            button5.Text = "103";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(717, 100);
            button6.Name = "button6";
            button6.Size = new Size(67, 53);
            button6.TabIndex = 45;
            button6.Text = "203";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(621, 100);
            button7.Name = "button7";
            button7.Size = new Size(67, 53);
            button7.TabIndex = 44;
            button7.Text = "202";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(534, 100);
            button8.Name = "button8";
            button8.Size = new Size(67, 53);
            button8.TabIndex = 43;
            button8.Text = "201";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(717, 159);
            button9.Name = "button9";
            button9.Size = new Size(67, 53);
            button9.TabIndex = 48;
            button9.Text = "303";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(621, 159);
            button10.Name = "button10";
            button10.Size = new Size(67, 53);
            button10.TabIndex = 47;
            button10.Text = "302";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(534, 159);
            button11.Name = "button11";
            button11.Size = new Size(67, 53);
            button11.TabIndex = 46;
            button11.Text = "301";
            button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(661, 228);
            button13.Name = "button13";
            button13.Size = new Size(67, 53);
            button13.TabIndex = 50;
            button13.Text = "402";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(574, 228);
            button14.Name = "button14";
            button14.Size = new Size(67, 53);
            button14.TabIndex = 49;
            button14.Text = "401";
            button14.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 519);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(RecaudacionTotal);
            Controls.Add(integranteMasHospedado);
            Controls.Add(habitacionMasSolicitada);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker3);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
=======
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DescendienteHI = new System.Windows.Forms.Button();
            this.btn_EspecialidadHI = new System.Windows.Forms.Button();
            this.btn_DescendienteEsp = new System.Windows.Forms.Button();
            this.btn_AscendenteEsp = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_NameEsp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NamePaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_GananciaHosp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cargaMedicosToolStripMenuItem,
            this.cargaPacientesToolStripMenuItem,
            this.cargaEstudiosToolStripMenuItem,
            this.registroResultadosToolStripMenuItem,
            this.vistaGeneralToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 20);
            this.toolStripMenuItem1.Text = "Carga Especialidades";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cargaMedicosToolStripMenuItem
            // 
            this.cargaMedicosToolStripMenuItem.Name = "cargaMedicosToolStripMenuItem";
            this.cargaMedicosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.cargaMedicosToolStripMenuItem.Text = "Carga Medicos";
            this.cargaMedicosToolStripMenuItem.Click += new System.EventHandler(this.cargaMedicosToolStripMenuItem_Click);
            // 
            // cargaPacientesToolStripMenuItem
            // 
            this.cargaPacientesToolStripMenuItem.Name = "cargaPacientesToolStripMenuItem";
            this.cargaPacientesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.cargaPacientesToolStripMenuItem.Text = "Carga Pacientes";
            this.cargaPacientesToolStripMenuItem.Click += new System.EventHandler(this.cargaPacientesToolStripMenuItem_Click);
            // 
            // cargaEstudiosToolStripMenuItem
            // 
            this.cargaEstudiosToolStripMenuItem.Name = "cargaEstudiosToolStripMenuItem";
            this.cargaEstudiosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.cargaEstudiosToolStripMenuItem.Text = "Carga Estudios";
            this.cargaEstudiosToolStripMenuItem.Click += new System.EventHandler(this.cargaEstudiosToolStripMenuItem_Click);
            // 
            // registroResultadosToolStripMenuItem
            // 
            this.registroResultadosToolStripMenuItem.Name = "registroResultadosToolStripMenuItem";
            this.registroResultadosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.registroResultadosToolStripMenuItem.Text = "Registro Resultados";
            this.registroResultadosToolStripMenuItem.Click += new System.EventHandler(this.registroResultadosToolStripMenuItem_Click);
            // 
            // vistaGeneralToolStripMenuItem
            // 
            this.vistaGeneralToolStripMenuItem.Name = "vistaGeneralToolStripMenuItem";
            this.vistaGeneralToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.vistaGeneralToolStripMenuItem.Text = "Vista General";
            this.vistaGeneralToolStripMenuItem.Click += new System.EventHandler(this.vistaGeneralToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 157);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_DescendienteHI
            // 
            this.btn_DescendienteHI.Location = new System.Drawing.Point(70, 243);
            this.btn_DescendienteHI.Name = "btn_DescendienteHI";
            this.btn_DescendienteHI.Size = new System.Drawing.Size(144, 23);
            this.btn_DescendienteHI.TabIndex = 2;
            this.btn_DescendienteHI.Text = "Descendiente fecha";
            this.btn_DescendienteHI.UseVisualStyleBackColor = true;
            this.btn_DescendienteHI.Click += new System.EventHandler(this.btn_DescendienteHI_Click);
            // 
            // btn_EspecialidadHI
            // 
            this.btn_EspecialidadHI.Location = new System.Drawing.Point(343, 243);
            this.btn_EspecialidadHI.Name = "btn_EspecialidadHI";
            this.btn_EspecialidadHI.Size = new System.Drawing.Size(166, 23);
            this.btn_EspecialidadHI.TabIndex = 3;
            this.btn_EspecialidadHI.Text = "Especialidad";
            this.btn_EspecialidadHI.UseVisualStyleBackColor = true;
            this.btn_EspecialidadHI.Click += new System.EventHandler(this.btn_EspecialidadHI_Click);
            // 
            // btn_DescendienteEsp
            // 
            this.btn_DescendienteEsp.Location = new System.Drawing.Point(343, 478);
            this.btn_DescendienteEsp.Name = "btn_DescendienteEsp";
            this.btn_DescendienteEsp.Size = new System.Drawing.Size(166, 23);
            this.btn_DescendienteEsp.TabIndex = 6;
            this.btn_DescendienteEsp.Text = "Descendente cant pacientes";
            this.btn_DescendienteEsp.UseVisualStyleBackColor = true;
            this.btn_DescendienteEsp.Click += new System.EventHandler(this.btn_DescendienteEsp_Click);
            // 
            // btn_AscendenteEsp
            // 
            this.btn_AscendenteEsp.Location = new System.Drawing.Point(70, 478);
            this.btn_AscendenteEsp.Name = "btn_AscendenteEsp";
            this.btn_AscendenteEsp.Size = new System.Drawing.Size(144, 23);
            this.btn_AscendenteEsp.TabIndex = 5;
            this.btn_AscendenteEsp.Text = "Ascendente Ganancia";
            this.btn_AscendenteEsp.UseVisualStyleBackColor = true;
            this.btn_AscendenteEsp.Click += new System.EventHandler(this.btn_AscendenteEsp_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(70, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(439, 157);
            this.dataGridView2.TabIndex = 4;
            // 
            // txt_NameEsp
            // 
            this.txt_NameEsp.Location = new System.Drawing.Point(409, 54);
            this.txt_NameEsp.Name = "txt_NameEsp";
            this.txt_NameEsp.Size = new System.Drawing.Size(100, 20);
            this.txt_NameEsp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paciente HISTORIA CLINICA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Especialidades";
            // 
            // txt_NamePaciente
            // 
            this.txt_NamePaciente.Location = new System.Drawing.Point(293, 54);
            this.txt_NamePaciente.Name = "txt_NamePaciente";
            this.txt_NamePaciente.Size = new System.Drawing.Size(100, 20);
            this.txt_NamePaciente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre especialidad";
            // 
            // lbl_GananciaHosp
            // 
            this.lbl_GananciaHosp.AutoSize = true;
            this.lbl_GananciaHosp.Location = new System.Drawing.Point(535, 531);
            this.lbl_GananciaHosp.Name = "lbl_GananciaHosp";
            this.lbl_GananciaHosp.Size = new System.Drawing.Size(100, 13);
            this.lbl_GananciaHosp.TabIndex = 13;
            this.lbl_GananciaHosp.Text = "Recaudacion total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 553);
            this.Controls.Add(this.lbl_GananciaHosp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NamePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NameEsp);
            this.Controls.Add(this.btn_DescendienteEsp);
            this.Controls.Add(this.btn_AscendenteEsp);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_EspecialidadHI);
            this.Controls.Add(this.btn_DescendienteHI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> main
        }

        #endregion

<<<<<<< HEAD
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private ComboBox comboBox1;
        private Label label1;
        private Label label8;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker3;
        private Label label10;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label habitacionMasSolicitada;
        private Label integranteMasHospedado;
        private Label RecaudacionTotal;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button14;
    }
}
=======
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargaMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaEstudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroResultadosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DescendienteHI;
        private System.Windows.Forms.Button btn_EspecialidadHI;
        private System.Windows.Forms.Button btn_DescendienteEsp;
        private System.Windows.Forms.Button btn_AscendenteEsp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_NameEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NamePaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem vistaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_GananciaHosp;
    }
}

>>>>>>> main
