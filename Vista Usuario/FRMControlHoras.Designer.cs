namespace Vistas
{
    partial class FRMControlHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMControlHoras));
            this.dataGridViewControlHoras = new System.Windows.Forms.DataGridView();
            this.Identidicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControlHoras)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelGradiente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewControlHoras
            // 
            this.dataGridViewControlHoras.AllowUserToAddRows = false;
            this.dataGridViewControlHoras.AllowUserToDeleteRows = false;
            this.dataGridViewControlHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewControlHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewControlHoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identidicacion,
            this.Nombre,
            this.HoraEntrada,
            this.HoraSalida,
            this.Dia});
            this.dataGridViewControlHoras.Location = new System.Drawing.Point(74, 168);
            this.dataGridViewControlHoras.Name = "dataGridViewControlHoras";
            this.dataGridViewControlHoras.Size = new System.Drawing.Size(840, 319);
            this.dataGridViewControlHoras.TabIndex = 0;
            // 
            // Identidicacion
            // 
            this.Identidicacion.HeaderText = "Identificación";
            this.Identidicacion.Name = "Identidicacion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Hora Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora Salida";
            this.HoraSalida.Name = "HoraSalida";
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePickerHasta);
            this.panel1.Controls.Add(this.dateTimePickerDesde);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Location = new System.Drawing.Point(62, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 76);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Location = new System.Drawing.Point(455, 23);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(220, 26);
            this.dateTimePickerHasta.TabIndex = 5;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Location = new System.Drawing.Point(89, 23);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(218, 26);
            this.dateTimePickerDesde.TabIndex = 2;
            this.dateTimePickerDesde.ValueChanged += new System.EventHandler(this.dateTimePickerDesde_ValueChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(740, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 55);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.Location = new System.Drawing.Point(384, 28);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(52, 20);
            this.labelFechaFin.TabIndex = 1;
            this.labelFechaFin.Text = "Hasta";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(16, 28);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(56, 20);
            this.labelFechaInicio.TabIndex = 0;
            this.labelFechaInicio.Text = "Desde";
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.panel1);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(1016, 575);
            this.panelGradiente1.TabIndex = 2;
            // 
            // FRMControlHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 575);
            this.Controls.Add(this.dataGridViewControlHoras);
            this.Controls.Add(this.panelGradiente1);
            this.Name = "FRMControlHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Horas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControlHoras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGradiente1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewControlHoras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private PanelGradiente panelGradiente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
    }
}