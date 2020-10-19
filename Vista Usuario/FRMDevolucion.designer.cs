namespace Vistas
{
    partial class FRMDevolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.buttonDevolucion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDevolucion = new System.Windows.Forms.DataGridView();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDañada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panelGradiente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxNombre);
            this.panel3.Controls.Add(this.labelNombre);
            this.panel3.Controls.Add(this.buttonConsultar);
            this.panel3.Controls.Add(this.textBoxIdentificacion);
            this.panel3.Controls.Add(this.labelIdentificacion);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(36, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 145);
            this.panel3.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 93);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = global::Vistas.Properties.Resources.loupe_78956;
            this.buttonConsultar.Location = new System.Drawing.Point(334, 16);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 55);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.AccessibleDescription = "";
            this.textBoxIdentificacion.Location = new System.Drawing.Point(120, 30);
            this.textBoxIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(187, 26);
            this.textBoxIdentificacion.TabIndex = 1;
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(2, 33);
            this.labelIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(103, 20);
            this.labelIdentificacion.TabIndex = 0;
            this.labelIdentificacion.Text = "Identificación";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(120, 93);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(260, 26);
            this.textBoxNombre.TabIndex = 4;
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.buttonDevolucion);
            this.panelGradiente1.Controls.Add(this.label2);
            this.panelGradiente1.Controls.Add(this.dataGridViewDevolucion);
            this.panelGradiente1.Controls.Add(this.textBoxFecha);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(774, 536);
            this.panelGradiente1.TabIndex = 6;
            // 
            // buttonDevolucion
            // 
            this.buttonDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucion.Location = new System.Drawing.Point(343, 450);
            this.buttonDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDevolucion.Name = "buttonDevolucion";
            this.buttonDevolucion.Size = new System.Drawing.Size(100, 50);
            this.buttonDevolucion.TabIndex = 5;
            this.buttonDevolucion.Text = "Devolución";
            this.buttonDevolucion.UseVisualStyleBackColor = true;
            this.buttonDevolucion.Click += new System.EventHandler(this.buttonDevolucion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // dataGridViewDevolucion
            // 
            this.dataGridViewDevolucion.AllowUserToAddRows = false;
            this.dataGridViewDevolucion.AllowUserToDeleteRows = false;
            this.dataGridViewDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.CantidadDañada});
            this.dataGridViewDevolucion.Location = new System.Drawing.Point(157, 186);
            this.dataGridViewDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDevolucion.Name = "dataGridViewDevolucion";
            this.dataGridViewDevolucion.RowTemplate.Height = 24;
            this.dataGridViewDevolucion.Size = new System.Drawing.Size(464, 231);
            this.dataGridViewDevolucion.TabIndex = 4;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(603, 6);
            this.textBoxFecha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(160, 26);
            this.textBoxFecha.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // CantidadDañada
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.CantidadDañada.DefaultCellStyle = dataGridViewCellStyle1;
            this.CantidadDañada.HeaderText = "Cantidad Dañada";
            this.CantidadDañada.Name = "CantidadDañada";
            this.CantidadDañada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FRMDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelGradiente1.ResumeLayout(false);
            this.panelGradiente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.DataGridView dataGridViewDevolucion;
        private System.Windows.Forms.Button buttonDevolucion;
        private PanelGradiente panelGradiente1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDañada;
    }
}

