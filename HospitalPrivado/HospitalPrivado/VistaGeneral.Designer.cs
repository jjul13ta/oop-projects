namespace HospitalPrivado
{
    partial class VistaGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.dgv_Estudios = new System.Windows.Forms.DataGridView();
            this.dgv_Medicos = new System.Windows.Forms.DataGridView();
            this.dgv_Especialidades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Especialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pacientes
            // 
            this.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pacientes.Location = new System.Drawing.Point(12, 55);
            this.dgv_Pacientes.Name = "dgv_Pacientes";
            this.dgv_Pacientes.Size = new System.Drawing.Size(319, 196);
            this.dgv_Pacientes.TabIndex = 0;
            // 
            // dgv_Estudios
            // 
            this.dgv_Estudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estudios.Location = new System.Drawing.Point(12, 341);
            this.dgv_Estudios.Name = "dgv_Estudios";
            this.dgv_Estudios.Size = new System.Drawing.Size(319, 196);
            this.dgv_Estudios.TabIndex = 2;
            // 
            // dgv_Medicos
            // 
            this.dgv_Medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medicos.Location = new System.Drawing.Point(430, 55);
            this.dgv_Medicos.Name = "dgv_Medicos";
            this.dgv_Medicos.Size = new System.Drawing.Size(319, 196);
            this.dgv_Medicos.TabIndex = 3;
            // 
            // dgv_Especialidades
            // 
            this.dgv_Especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Especialidades.Location = new System.Drawing.Point(430, 341);
            this.dgv_Especialidades.Name = "dgv_Especialidades";
            this.dgv_Especialidades.Size = new System.Drawing.Size(319, 196);
            this.dgv_Especialidades.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estudios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Especialidades";
            // 
            // VistaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Especialidades);
            this.Controls.Add(this.dgv_Medicos);
            this.Controls.Add(this.dgv_Estudios);
            this.Controls.Add(this.dgv_Pacientes);
            this.Name = "VistaGeneral";
            this.Text = "VistaGeneral";
            this.Load += new System.EventHandler(this.VistaGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Especialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pacientes;
        private System.Windows.Forms.DataGridView dgv_Estudios;
        private System.Windows.Forms.DataGridView dgv_Medicos;
        private System.Windows.Forms.DataGridView dgv_Especialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}