namespace Vistas
{
    partial class FRMConsultaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMConsultaInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numerotelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreroElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadbuenestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidadmasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonImplementoDeportivo = new System.Windows.Forms.RadioButton();
            this.radioButtonAccesorios = new System.Windows.Forms.RadioButton();
            this.radioButtonDiscos = new System.Windows.Forms.RadioButton();
            this.radioButtonMancuernas = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelCodigo);
            this.panel1.Location = new System.Drawing.Point(11, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 89);
            this.panel1.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(315, 10);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 55);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(148, 23);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(151, 26);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(10, 26);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(134, 20);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Nombre de Activo";
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.AllowUserToAddRows = false;
            this.dataGridViewInventario.AllowUserToDeleteRows = false;
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Numerotelefono,
            this.CorreroElectronico,
            this.Cantidadbuenestado,
            this.tipo,
            this.Unidadmasa,
            this.Material});
            this.dataGridViewInventario.Location = new System.Drawing.Point(66, 175);
            this.dataGridViewInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.ReadOnly = true;
            this.dataGridViewInventario.RowTemplate.Height = 24;
            this.dataGridViewInventario.Size = new System.Drawing.Size(845, 315);
            this.dataGridViewInventario.TabIndex = 3;
            // 
            // Código
            // 
            this.Código.HeaderText = "Codigo";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Numerotelefono
            // 
            this.Numerotelefono.HeaderText = "Cantidad en existencia";
            this.Numerotelefono.Name = "Numerotelefono";
            this.Numerotelefono.ReadOnly = true;
            // 
            // CorreroElectronico
            // 
            this.CorreroElectronico.HeaderText = "Cantidad en buen estado";
            this.CorreroElectronico.Name = "CorreroElectronico";
            this.CorreroElectronico.ReadOnly = true;
            // 
            // Cantidadbuenestado
            // 
            this.Cantidadbuenestado.HeaderText = "Cantidad en mal estado";
            this.Cantidadbuenestado.Name = "Cantidadbuenestado";
            this.Cantidadbuenestado.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Peso";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // Unidadmasa
            // 
            this.Unidadmasa.HeaderText = "Unidad de masa";
            this.Unidadmasa.Name = "Unidadmasa";
            this.Unidadmasa.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButtonTodos);
            this.panel3.Controls.Add(this.radioButtonImplementoDeportivo);
            this.panel3.Controls.Add(this.radioButtonAccesorios);
            this.panel3.Controls.Add(this.radioButtonDiscos);
            this.panel3.Controls.Add(this.radioButtonMancuernas);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(459, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 129);
            this.panel3.TabIndex = 11;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTodos.Location = new System.Drawing.Point(89, 90);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(71, 24);
            this.radioButtonTodos.TabIndex = 5;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonImplementoDeportivo
            // 
            this.radioButtonImplementoDeportivo.AutoSize = true;
            this.radioButtonImplementoDeportivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonImplementoDeportivo.Location = new System.Drawing.Point(129, 61);
            this.radioButtonImplementoDeportivo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonImplementoDeportivo.Name = "radioButtonImplementoDeportivo";
            this.radioButtonImplementoDeportivo.Size = new System.Drawing.Size(158, 24);
            this.radioButtonImplementoDeportivo.TabIndex = 4;
            this.radioButtonImplementoDeportivo.TabStop = true;
            this.radioButtonImplementoDeportivo.Text = "Implento deportivo";
            this.radioButtonImplementoDeportivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccesorios
            // 
            this.radioButtonAccesorios.AutoSize = true;
            this.radioButtonAccesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAccesorios.Location = new System.Drawing.Point(10, 61);
            this.radioButtonAccesorios.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAccesorios.Name = "radioButtonAccesorios";
            this.radioButtonAccesorios.Size = new System.Drawing.Size(105, 24);
            this.radioButtonAccesorios.TabIndex = 3;
            this.radioButtonAccesorios.TabStop = true;
            this.radioButtonAccesorios.Text = "Accesorios";
            this.radioButtonAccesorios.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiscos
            // 
            this.radioButtonDiscos.AutoSize = true;
            this.radioButtonDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDiscos.Location = new System.Drawing.Point(129, 33);
            this.radioButtonDiscos.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDiscos.Name = "radioButtonDiscos";
            this.radioButtonDiscos.Size = new System.Drawing.Size(75, 24);
            this.radioButtonDiscos.TabIndex = 2;
            this.radioButtonDiscos.TabStop = true;
            this.radioButtonDiscos.Text = "Discos";
            this.radioButtonDiscos.UseVisualStyleBackColor = true;
            // 
            // radioButtonMancuernas
            // 
            this.radioButtonMancuernas.AutoSize = true;
            this.radioButtonMancuernas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMancuernas.Location = new System.Drawing.Point(10, 33);
            this.radioButtonMancuernas.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMancuernas.Name = "radioButtonMancuernas";
            this.radioButtonMancuernas.Size = new System.Drawing.Size(115, 24);
            this.radioButtonMancuernas.TabIndex = 1;
            this.radioButtonMancuernas.TabStop = true;
            this.radioButtonMancuernas.Text = "Mancuernas";
            this.radioButtonMancuernas.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de implemento";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxEstado);
            this.panel2.Controls.Add(this.labelEstado);
            this.panel2.Location = new System.Drawing.Point(773, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 86);
            this.panel2.TabIndex = 12;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Todos",
            "Buen Estado",
            "Mal Estado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(81, 23);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(143, 28);
            this.comboBoxEstado.TabIndex = 1;
            this.comboBoxEstado.SelectedValueChanged += new System.EventHandler(this.comboBoxEstado_SelectedValueChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(17, 26);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(60, 20);
            this.labelEstado.TabIndex = 0;
            this.labelEstado.Text = "Estado";
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(243)))));
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(1029, 534);
            this.panelGradiente1.TabIndex = 13;
            // 
            // FRMConsultaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewInventario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMConsultaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de inventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numerotelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreroElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadbuenestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidadmasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonImplementoDeportivo;
        private System.Windows.Forms.RadioButton radioButtonAccesorios;
        private System.Windows.Forms.RadioButton radioButtonDiscos;
        private System.Windows.Forms.RadioButton radioButtonMancuernas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private PanelGradiente panelGradiente1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}

