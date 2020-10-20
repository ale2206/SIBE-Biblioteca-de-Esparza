namespace Vistas
{
    partial class FRMInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxUnidadMasa = new System.Windows.Forms.ComboBox();
            this.numericUpDownCantidadMalEstado = new System.Windows.Forms.NumericUpDown();
            this.labelCantidadMalEstado = new System.Windows.Forms.Label();
            this.numericUpDownCantidadBuenEstado = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantidadExistencia = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelUnidadMasa = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelCantidadBuenEstado = new System.Windows.Forms.Label();
            this.labelCantidadExistencia = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonImplementoDeportivo = new System.Windows.Forms.RadioButton();
            this.radioButtonAccesorios = new System.Windows.Forms.RadioButton();
            this.radioButtonDiscos = new System.Windows.Forms.RadioButton();
            this.radioButtonMancuernas = new System.Windows.Forms.RadioButton();
            this.labelTipoImplemento = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadMalEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadBuenEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadExistencia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelGradiente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.numericUpDownPeso);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.comboBoxUnidadMasa);
            this.panel1.Controls.Add(this.numericUpDownCantidadMalEstado);
            this.panel1.Controls.Add(this.labelCantidadMalEstado);
            this.panel1.Controls.Add(this.numericUpDownCantidadBuenEstado);
            this.panel1.Controls.Add(this.numericUpDownCantidadExistencia);
            this.panel1.Controls.Add(this.textBoxMaterial);
            this.panel1.Controls.Add(this.labelMaterial);
            this.panel1.Controls.Add(this.labelUnidadMasa);
            this.panel1.Controls.Add(this.labelPeso);
            this.panel1.Controls.Add(this.labelCantidadBuenEstado);
            this.panel1.Controls.Add(this.labelCantidadExistencia);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(19, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 270);
            this.panel1.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(189, 8);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.MaxLength = 100;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(196, 26);
            this.textBoxNombre.TabIndex = 14;
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Location = new System.Drawing.Point(192, 222);
            this.numericUpDownPeso.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.ReadOnly = true;
            this.numericUpDownPeso.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownPeso.TabIndex = 8;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(3, 8);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre ";
            // 
            // comboBoxUnidadMasa
            // 
            this.comboBoxUnidadMasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadMasa.FormattingEnabled = true;
            this.comboBoxUnidadMasa.Items.AddRange(new object[] {
            "Kilos",
            "Libras"});
            this.comboBoxUnidadMasa.Location = new System.Drawing.Point(192, 153);
            this.comboBoxUnidadMasa.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUnidadMasa.Name = "comboBoxUnidadMasa";
            this.comboBoxUnidadMasa.Size = new System.Drawing.Size(90, 28);
            this.comboBoxUnidadMasa.TabIndex = 10;
            // 
            // numericUpDownCantidadMalEstado
            // 
            this.numericUpDownCantidadMalEstado.Location = new System.Drawing.Point(192, 122);
            this.numericUpDownCantidadMalEstado.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidadMalEstado.Name = "numericUpDownCantidadMalEstado";
            this.numericUpDownCantidadMalEstado.ReadOnly = true;
            this.numericUpDownCantidadMalEstado.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownCantidadMalEstado.TabIndex = 6;
            // 
            // labelCantidadMalEstado
            // 
            this.labelCantidadMalEstado.AutoSize = true;
            this.labelCantidadMalEstado.Location = new System.Drawing.Point(2, 122);
            this.labelCantidadMalEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadMalEstado.Name = "labelCantidadMalEstado";
            this.labelCantidadMalEstado.Size = new System.Drawing.Size(177, 20);
            this.labelCantidadMalEstado.TabIndex = 5;
            this.labelCantidadMalEstado.Text = "Cantidad en mal estado";
            // 
            // numericUpDownCantidadBuenEstado
            // 
            this.numericUpDownCantidadBuenEstado.Location = new System.Drawing.Point(192, 86);
            this.numericUpDownCantidadBuenEstado.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidadBuenEstado.Name = "numericUpDownCantidadBuenEstado";
            this.numericUpDownCantidadBuenEstado.ReadOnly = true;
            this.numericUpDownCantidadBuenEstado.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownCantidadBuenEstado.TabIndex = 4;
            // 
            // numericUpDownCantidadExistencia
            // 
            this.numericUpDownCantidadExistencia.Location = new System.Drawing.Point(192, 48);
            this.numericUpDownCantidadExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidadExistencia.Name = "numericUpDownCantidadExistencia";
            this.numericUpDownCantidadExistencia.ReadOnly = true;
            this.numericUpDownCantidadExistencia.Size = new System.Drawing.Size(90, 26);
            this.numericUpDownCantidadExistencia.TabIndex = 2;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(192, 187);
            this.textBoxMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaterial.MaxLength = 100;
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(195, 26);
            this.textBoxMaterial.TabIndex = 12;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(3, 190);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(65, 20);
            this.labelMaterial.TabIndex = 11;
            this.labelMaterial.Text = "Material";
            // 
            // labelUnidadMasa
            // 
            this.labelUnidadMasa.AutoSize = true;
            this.labelUnidadMasa.Location = new System.Drawing.Point(2, 156);
            this.labelUnidadMasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnidadMasa.Name = "labelUnidadMasa";
            this.labelUnidadMasa.Size = new System.Drawing.Size(125, 20);
            this.labelUnidadMasa.TabIndex = 9;
            this.labelUnidadMasa.Text = "Unidad de masa";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(3, 224);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(45, 20);
            this.labelPeso.TabIndex = 7;
            this.labelPeso.Text = "Peso";
            // 
            // labelCantidadBuenEstado
            // 
            this.labelCantidadBuenEstado.AutoSize = true;
            this.labelCantidadBuenEstado.Location = new System.Drawing.Point(2, 88);
            this.labelCantidadBuenEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadBuenEstado.Name = "labelCantidadBuenEstado";
            this.labelCantidadBuenEstado.Size = new System.Drawing.Size(188, 20);
            this.labelCantidadBuenEstado.TabIndex = 3;
            this.labelCantidadBuenEstado.Text = "Cantidad en buen estado";
            // 
            // labelCantidadExistencia
            // 
            this.labelCantidadExistencia.AutoSize = true;
            this.labelCantidadExistencia.Location = new System.Drawing.Point(3, 50);
            this.labelCantidadExistencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidadExistencia.Name = "labelCantidadExistencia";
            this.labelCantidadExistencia.Size = new System.Drawing.Size(169, 20);
            this.labelCantidadExistencia.TabIndex = 1;
            this.labelCantidadExistencia.Text = "Cantidad en existencia";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(2, 20);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(59, 20);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(117, 17);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodigo.MaxLength = 100;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(142, 26);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Controls.Add(this.textBoxCodigo);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(19, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 74);
            this.panel2.TabIndex = 0;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.Location = new System.Drawing.Point(275, 3);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 55);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButtonImplementoDeportivo);
            this.panel3.Controls.Add(this.radioButtonAccesorios);
            this.panel3.Controls.Add(this.radioButtonDiscos);
            this.panel3.Controls.Add(this.radioButtonMancuernas);
            this.panel3.Controls.Add(this.labelTipoImplemento);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(553, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 108);
            this.panel3.TabIndex = 2;
            // 
            // radioButtonImplementoDeportivo
            // 
            this.radioButtonImplementoDeportivo.AutoSize = true;
            this.radioButtonImplementoDeportivo.Location = new System.Drawing.Point(121, 61);
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
            this.radioButtonDiscos.Location = new System.Drawing.Point(121, 33);
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
            this.radioButtonMancuernas.Location = new System.Drawing.Point(10, 33);
            this.radioButtonMancuernas.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMancuernas.Name = "radioButtonMancuernas";
            this.radioButtonMancuernas.Size = new System.Drawing.Size(115, 24);
            this.radioButtonMancuernas.TabIndex = 1;
            this.radioButtonMancuernas.TabStop = true;
            this.radioButtonMancuernas.Text = "Mancuernas";
            this.radioButtonMancuernas.UseVisualStyleBackColor = true;
            // 
            // labelTipoImplemento
            // 
            this.labelTipoImplemento.AutoSize = true;
            this.labelTipoImplemento.Location = new System.Drawing.Point(77, 11);
            this.labelTipoImplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoImplemento.Name = "labelTipoImplemento";
            this.labelTipoImplemento.Size = new System.Drawing.Size(147, 20);
            this.labelTipoImplemento.TabIndex = 0;
            this.labelTipoImplemento.Text = "Tipo de implemento";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonMenu);
            this.panel4.Controls.Add(this.buttonEliminar);
            this.panel4.Controls.Add(this.buttonModificar);
            this.panel4.Controls.Add(this.buttonAgregar);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(466, 276);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 82);
            this.panel4.TabIndex = 3;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.Location = new System.Drawing.Point(368, 18);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(90, 50);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(255, 18);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(90, 50);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.Location = new System.Drawing.Point(134, 18);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(90, 50);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(12, 18);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(90, 50);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Controls.Add(this.panel3);
            this.panelGradiente1.Controls.Add(this.panel4);
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(987, 414);
            this.panelGradiente1.TabIndex = 4;
            // 
            // FRMInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 414);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de inventario";
            this.Load += new System.EventHandler(this.FRMInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadMalEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadBuenEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadExistencia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelGradiente1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCantidadExistencia;
        private System.Windows.Forms.Label labelCantidadBuenEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTipoImplemento;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadMalEstado;
        private System.Windows.Forms.Label labelCantidadMalEstado;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadBuenEstado;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadExistencia;
        private System.Windows.Forms.RadioButton radioButtonImplementoDeportivo;
        private System.Windows.Forms.RadioButton radioButtonAccesorios;
        private System.Windows.Forms.RadioButton radioButtonDiscos;
        private System.Windows.Forms.RadioButton radioButtonMancuernas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.ComboBox comboBoxUnidadMasa;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelUnidadMasa;
        private System.Windows.Forms.Label labelPeso;
        private PanelGradiente panelGradiente1;
    }
}

