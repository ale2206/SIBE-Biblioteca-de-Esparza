namespace Vistas
{
    partial class FRMPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPrestamo));
            this.buttonPrestamo = new System.Windows.Forms.Button();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridViewPrestamo = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelActivo = new System.Windows.Forms.Label();
            this.comboBoxActivos = new System.Windows.Forms.ComboBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGradiente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrestamo
            // 
            this.buttonPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrestamo.Location = new System.Drawing.Point(505, 563);
            this.buttonPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrestamo.Name = "buttonPrestamo";
            this.buttonPrestamo.Size = new System.Drawing.Size(96, 26);
            this.buttonPrestamo.TabIndex = 6;
            this.buttonPrestamo.Text = "Prestamo";
            this.buttonPrestamo.UseVisualStyleBackColor = true;
            this.buttonPrestamo.Click += new System.EventHandler(this.buttonPrestamo_Click);
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdentificacion.Location = new System.Drawing.Point(124, 21);
            this.textBoxIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(180, 26);
            this.textBoxIdentificacion.TabIndex = 1;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificacion.Location = new System.Drawing.Point(17, 24);
            this.labelIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(103, 20);
            this.labelIdentificacion.TabIndex = 0;
            this.labelIdentificacion.Text = "Identificación";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::Vistas.Properties.Resources.delete_40623;
            this.buttonEliminar.Location = new System.Drawing.Point(879, 343);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(90, 55);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(320, 40);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(90, 55);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridViewPrestamo
            // 
            this.dataGridViewPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad});
            this.dataGridViewPrestamo.Location = new System.Drawing.Point(267, 200);
            this.dataGridViewPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            this.dataGridViewPrestamo.ReadOnly = true;
            this.dataGridViewPrestamo.RowTemplate.Height = 24;
            this.dataGridViewPrestamo.Size = new System.Drawing.Size(543, 313);
            this.dataGridViewPrestamo.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 170F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 170F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(19, 81);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(73, 20);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelActivo
            // 
            this.labelActivo.AutoSize = true;
            this.labelActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivo.Location = new System.Drawing.Point(19, 24);
            this.labelActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(121, 20);
            this.labelActivo.TabIndex = 0;
            this.labelActivo.Text = "Activo deportivo";
            // 
            // comboBoxActivos
            // 
            this.comboBoxActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivos.FormattingEnabled = true;
            this.comboBoxActivos.Location = new System.Drawing.Point(144, 21);
            this.comboBoxActivos.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActivos.Name = "comboBoxActivos";
            this.comboBoxActivos.Size = new System.Drawing.Size(133, 28);
            this.comboBoxActivos.TabIndex = 1;
            this.comboBoxActivos.SelectedIndexChanged += new System.EventHandler(this.comboBoxActivos_SelectedIndexChanged);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(144, 79);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(71, 26);
            this.numericUpDownCantidad.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(17, 82);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(124, 82);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(180, 26);
            this.textBoxNombre.TabIndex = 4;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.Location = new System.Drawing.Point(325, 7);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 55);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelIdentificacion);
            this.panel1.Controls.Add(this.textBoxIdentificacion);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.buttonConsultar);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Location = new System.Drawing.Point(505, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 132);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelActivo);
            this.panel2.Controls.Add(this.comboBoxActivos);
            this.panel2.Controls.Add(this.labelCantidad);
            this.panel2.Controls.Add(this.numericUpDownCantidad);
            this.panel2.Controls.Add(this.buttonAgregar);
            this.panel2.Location = new System.Drawing.Point(47, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 132);
            this.panel2.TabIndex = 2;
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.textBoxFecha);
            this.panelGradiente1.Controls.Add(this.labelFecha);
            this.panelGradiente1.Controls.Add(this.buttonPrestamo);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(1201, 616);
            this.panelGradiente1.TabIndex = 7;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(1024, 6);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(165, 26);
            this.textBoxFecha.TabIndex = 1;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(959, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(54, 20);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "Fecha";
            // 
            // FRMPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridViewPrestamo);
            this.Controls.Add(this.panelGradiente1);
            this.Name = "FRMPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGradiente1.ResumeLayout(false);
            this.panelGradiente1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrestamo;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewPrestamo;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelActivo;
        private System.Windows.Forms.ComboBox comboBoxActivos;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private PanelGradiente panelGradiente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}