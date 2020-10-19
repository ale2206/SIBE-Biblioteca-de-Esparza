namespace Vistas
{
    partial class FRMHorasEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMHorasEstudiantes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGradiente1 = new Vistas.PanelGradiente();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSalida);
            this.panel1.Controls.Add(this.buttonEntrada);
            this.panel1.Location = new System.Drawing.Point(129, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 106);
            this.panel1.TabIndex = 1;
            // 
            // buttonSalida
            // 
            this.buttonSalida.BackColor = System.Drawing.Color.Salmon;
            this.buttonSalida.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalida.Image")));
            this.buttonSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalida.Location = new System.Drawing.Point(199, 21);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(93, 58);
            this.buttonSalida.TabIndex = 1;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalida.UseVisualStyleBackColor = false;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonEntrada.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntrada.Image")));
            this.buttonEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEntrada.Location = new System.Drawing.Point(27, 21);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(93, 58);
            this.buttonEntrada.TabIndex = 0;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEntrada.UseVisualStyleBackColor = false;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(24, 21);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.labelNombreUsuario.TabIndex = 1;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Enabled = false;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(192, 18);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(215, 26);
            this.textBoxNombreUsuario.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxNombreUsuario);
            this.panel2.Controls.Add(this.labelNombreUsuario);
            this.panel2.Location = new System.Drawing.Point(79, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 59);
            this.panel2.TabIndex = 0;
            // 
            // panelGradiente1
            // 
            this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            this.panelGradiente1.Name = "panelGradiente1";
            this.panelGradiente1.Size = new System.Drawing.Size(592, 268);
            this.panelGradiente1.TabIndex = 2;
            // 
            // FRMHorasEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGradiente1);
            this.Name = "FRMHorasEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Entrada y Salida de Estudiantes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.Button buttonEntrada;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Panel panel2;
        private PanelGradiente panelGradiente1;
    }
}