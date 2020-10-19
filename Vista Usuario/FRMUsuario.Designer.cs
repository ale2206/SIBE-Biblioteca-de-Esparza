namespace Vistas
{
    partial class FRMUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuario));
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTipoUsuario = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.radioButtonAsistente = new System.Windows.Forms.RadioButton();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAdministrador = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonInactivo = new System.Windows.Forms.RadioButton();
            this.radioButtonActivo = new System.Windows.Forms.RadioButton();
            this.labelEstado = new System.Windows.Forms.Label();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet.Location = new System.Drawing.Point(14, 25);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(103, 20);
            this.labelCarnet.TabIndex = 0;
            this.labelCarnet.Text = "Identificacion";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(14, 38);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(14, 95);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.labelNombreUsuario.TabIndex = 2;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(14, 141);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(92, 20);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(14, 204);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(14, 259);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(57, 20);
            this.labelCorreo.TabIndex = 8;
            this.labelCorreo.Text = "Correo";
            // 
            // labelTipoUsuario
            // 
            this.labelTipoUsuario.AutoSize = true;
            this.labelTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUsuario.Location = new System.Drawing.Point(113, 33);
            this.labelTipoUsuario.Name = "labelTipoUsuario";
            this.labelTipoUsuario.Size = new System.Drawing.Size(120, 20);
            this.labelTipoUsuario.TabIndex = 0;
            this.labelTipoUsuario.Text = "Tipo de Usuario";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCarnet.Location = new System.Drawing.Point(189, 25);
            this.textBoxCarnet.MaxLength = 100;
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(157, 26);
            this.textBoxCarnet.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(189, 38);
            this.textBoxNombre.MaxLength = 100;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(309, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(189, 92);
            this.textBoxNombreUsuario.MaxLength = 100;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(142, 26);
            this.textBoxNombreUsuario.TabIndex = 3;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(189, 141);
            this.textBoxContraseña.MaxLength = 100;
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(142, 26);
            this.textBoxContraseña.TabIndex = 5;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(189, 198);
            this.textBoxTelefono.MaxLength = 8;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(142, 26);
            this.textBoxTelefono.TabIndex = 7;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(189, 253);
            this.textBoxCorreo.MaxLength = 100;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(309, 26);
            this.textBoxCorreo.TabIndex = 9;
            // 
            // radioButtonAsistente
            // 
            this.radioButtonAsistente.AutoSize = true;
            this.radioButtonAsistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAsistente.Location = new System.Drawing.Point(217, 85);
            this.radioButtonAsistente.Name = "radioButtonAsistente";
            this.radioButtonAsistente.Size = new System.Drawing.Size(94, 24);
            this.radioButtonAsistente.TabIndex = 2;
            this.radioButtonAsistente.TabStop = true;
            this.radioButtonAsistente.Text = "Asistente";
            this.radioButtonAsistente.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(378, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 55);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonAdministrador);
            this.panel1.Controls.Add(this.labelTipoUsuario);
            this.panel1.Controls.Add(this.radioButtonAsistente);
            this.panel1.Location = new System.Drawing.Point(736, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 152);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonAdministrador
            // 
            this.radioButtonAdministrador.AutoSize = true;
            this.radioButtonAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdministrador.Location = new System.Drawing.Point(47, 85);
            this.radioButtonAdministrador.Name = "radioButtonAdministrador";
            this.radioButtonAdministrador.Size = new System.Drawing.Size(125, 24);
            this.radioButtonAdministrador.TabIndex = 1;
            this.radioButtonAdministrador.TabStop = true;
            this.radioButtonAdministrador.Text = "Administrador";
            this.radioButtonAdministrador.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonMenu);
            this.panel2.Controls.Add(this.buttonModificar);
            this.panel2.Controls.Add(this.buttonAgregar);
            this.panel2.Location = new System.Drawing.Point(624, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 97);
            this.panel2.TabIndex = 3;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.Location = new System.Drawing.Point(353, 25);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(90, 50);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.Location = new System.Drawing.Point(194, 25);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(90, 50);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(28, 25);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(90, 50);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonBuscar);
            this.panel3.Controls.Add(this.textBoxCarnet);
            this.panel3.Controls.Add(this.labelCarnet);
            this.panel3.Location = new System.Drawing.Point(60, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 79);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButtonInactivo);
            this.panel4.Controls.Add(this.radioButtonActivo);
            this.panel4.Controls.Add(this.labelEstado);
            this.panel4.Controls.Add(this.labelNombre);
            this.panel4.Controls.Add(this.textBoxNombre);
            this.panel4.Controls.Add(this.labelNombreUsuario);
            this.panel4.Controls.Add(this.textBoxNombreUsuario);
            this.panel4.Controls.Add(this.textBoxCorreo);
            this.panel4.Controls.Add(this.labelContraseña);
            this.panel4.Controls.Add(this.labelCorreo);
            this.panel4.Controls.Add(this.textBoxTelefono);
            this.panel4.Controls.Add(this.textBoxContraseña);
            this.panel4.Controls.Add(this.labelTelefono);
            this.panel4.Location = new System.Drawing.Point(60, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 375);
            this.panel4.TabIndex = 1;
            // 
            // radioButtonInactivo
            // 
            this.radioButtonInactivo.AutoSize = true;
            this.radioButtonInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInactivo.Location = new System.Drawing.Point(333, 314);
            this.radioButtonInactivo.Name = "radioButtonInactivo";
            this.radioButtonInactivo.Size = new System.Drawing.Size(82, 24);
            this.radioButtonInactivo.TabIndex = 12;
            this.radioButtonInactivo.TabStop = true;
            this.radioButtonInactivo.Text = "Inactivo";
            this.radioButtonInactivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonActivo
            // 
            this.radioButtonActivo.AutoSize = true;
            this.radioButtonActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonActivo.Location = new System.Drawing.Point(222, 314);
            this.radioButtonActivo.Name = "radioButtonActivo";
            this.radioButtonActivo.Size = new System.Drawing.Size(70, 24);
            this.radioButtonActivo.TabIndex = 11;
            this.radioButtonActivo.TabStop = true;
            this.radioButtonActivo.Text = "Activo";
            this.radioButtonActivo.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(18, 314);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(60, 20);
            this.labelEstado.TabIndex = 10;
            this.labelEstado.Text = "Estado";
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(1183, 508);
            this.panelGradiente1.TabIndex = 4;
            // 
            // FRMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 508);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradiente1);
            this.Name = "FRMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Usuarios de Sistema";
            this.Load += new System.EventHandler(this.FRMUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTipoUsuario;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.RadioButton radioButtonAsistente;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButtonInactivo;
        private System.Windows.Forms.RadioButton radioButtonActivo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.RadioButton radioButtonAdministrador;
        private PanelGradiente panelGradiente1;
    }
}

