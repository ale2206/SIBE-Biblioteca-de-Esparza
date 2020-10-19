namespace Vistas
{
    partial class FRMListadoEstudiantes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMListadoEstudiantes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Padecimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numerotelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreroElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.labelTipoUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.panelGradiente1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Location = new System.Drawing.Point(22, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 76);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(269, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 55);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(109, 20);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 26);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxIdentificacion_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(2, 23);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.AllowUserToAddRows = false;
            this.dataGridViewEstudiantes.AllowUserToDeleteRows = false;
            this.dataGridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Carrera,
            this.Padecimientos,
            this.Numerotelefono,
            this.CorreroElectronico,
            this.tipo});
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(22, 118);
            this.dataGridViewEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.ReadOnly = true;
            this.dataGridViewEstudiantes.RowTemplate.Height = 24;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(858, 408);
            this.dataGridViewEstudiantes.TabIndex = 2;
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
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Padecimientos
            // 
            this.Padecimientos.HeaderText = "Padecimientos";
            this.Padecimientos.Name = "Padecimientos";
            this.Padecimientos.ReadOnly = true;
            // 
            // Numerotelefono
            // 
            this.Numerotelefono.HeaderText = "Número de telefono";
            this.Numerotelefono.Name = "Numerotelefono";
            this.Numerotelefono.ReadOnly = true;
            // 
            // CorreroElectronico
            // 
            this.CorreroElectronico.HeaderText = "Correro electronico";
            this.CorreroElectronico.Name = "CorreroElectronico";
            this.CorreroElectronico.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.panel2);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(940, 583);
            this.panelGradiente1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxTipoUsuario);
            this.panel2.Controls.Add(this.labelTipoUsuario);
            this.panel2.Location = new System.Drawing.Point(557, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 76);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Todos",
            "Funcionario",
            "Estudiante"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(123, 20);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(138, 28);
            this.comboBoxTipoUsuario.TabIndex = 1;
            this.comboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // labelTipoUsuario
            // 
            this.labelTipoUsuario.AutoSize = true;
            this.labelTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUsuario.Location = new System.Drawing.Point(2, 23);
            this.labelTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoUsuario.Name = "labelTipoUsuario";
            this.labelTipoUsuario.Size = new System.Drawing.Size(117, 20);
            this.labelTipoUsuario.TabIndex = 0;
            this.labelTipoUsuario.Text = "Tipo de usuario";
            // 
            // FRMListadoEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 583);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMListadoEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de registro usuarios del gimnasio y activos deportivos ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.panelGradiente1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label labelTipoUsuario;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Padecimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numerotelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreroElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private PanelGradiente panelGradiente1;
    }
}

