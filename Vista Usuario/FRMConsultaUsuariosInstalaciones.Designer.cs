namespace Vistas
{
    partial class FRMConsultaUsuariosInstalaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMConsultaUsuariosInstalaciones));
            this.labelModulo = new System.Windows.Forms.Label();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.labelFechas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGradiente1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModulo
            // 
            this.labelModulo.AutoSize = true;
            this.labelModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModulo.Location = new System.Drawing.Point(325, 24);
            this.labelModulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModulo.Name = "labelModulo";
            this.labelModulo.Size = new System.Drawing.Size(302, 20);
            this.labelModulo.TabIndex = 2;
            this.labelModulo.Text = "CONSULTAS DEL USO DEL GIMNASIO";
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.panel2);
            this.panelGradiente1.Controls.Add(this.panel1);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(991, 586);
            this.panelGradiente1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.labelTipo);
            this.panel2.Controls.Add(this.comboBoxTipo);
            this.panel2.Controls.Add(this.labelDesde);
            this.panel2.Controls.Add(this.labelHasta);
            this.panel2.Controls.Add(this.dateTimePickerHasta);
            this.panel2.Controls.Add(this.dateTimePickerDesde);
            this.panel2.Controls.Add(this.labelFechas);
            this.panel2.Location = new System.Drawing.Point(119, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 185);
            this.panel2.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.Location = new System.Drawing.Point(544, 103);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 55);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Visible = false;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(514, 24);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(120, 20);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Tipo de Usuario";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Todos",
            "Funcionario",
            "Estudiante"});
            this.comboBoxTipo.Location = new System.Drawing.Point(507, 56);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(140, 28);
            this.comboBoxTipo.TabIndex = 6;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(32, 56);
            this.labelDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(56, 20);
            this.labelDesde.TabIndex = 1;
            this.labelDesde.Text = "Desde";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasta.Location = new System.Drawing.Point(32, 108);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(52, 20);
            this.labelHasta.TabIndex = 3;
            this.labelHasta.Text = "Hasta";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Location = new System.Drawing.Point(112, 103);
            this.dateTimePickerHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(302, 26);
            this.dateTimePickerHasta.TabIndex = 4;
            this.dateTimePickerHasta.ValueChanged += new System.EventHandler(this.dateTimePickerHasta_ValueChanged);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Location = new System.Drawing.Point(112, 51);
            this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(302, 26);
            this.dateTimePickerDesde.TabIndex = 2;
            this.dateTimePickerDesde.ValueChanged += new System.EventHandler(this.dateTimePickerDesde_ValueChanged);
            // 
            // labelFechas
            // 
            this.labelFechas.AutoSize = true;
            this.labelFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechas.Location = new System.Drawing.Point(146, 11);
            this.labelFechas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(120, 20);
            this.labelFechas.TabIndex = 0;
            this.labelFechas.Text = "Ingresar fechas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewUsuarios);
            this.panel1.Location = new System.Drawing.Point(107, 261);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 230);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Ocupacion,
            this.Fecha});
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(741, 228);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Ocupacion
            // 
            this.Ocupacion.HeaderText = "Ocupacion";
            this.Ocupacion.Name = "Ocupacion";
            this.Ocupacion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FRMConsultaUsuariosInstalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 586);
            this.Controls.Add(this.labelModulo);
            this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMConsultaUsuariosInstalaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuarios de las Instalaciones";
            this.panelGradiente1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label labelFechas;
        private System.Windows.Forms.Label labelModulo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private PanelGradiente panelGradiente1;
    }
}