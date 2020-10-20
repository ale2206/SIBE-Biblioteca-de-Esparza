namespace Vistas
{
    partial class FRMControlUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMControlUsuarios));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxidentificacion = new System.Windows.Forms.TextBox();
            this.buttonConsultarAgregar = new System.Windows.Forms.Button();
            this.dataGridViewUsuariosInstalacionesDia = new System.Windows.Forms.DataGridView();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            //this.panelGradiente1 = new Vistas.PanelGradiente();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosInstalacionesDia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación";
            // 
            // textBoxidentificacion
            // 
            this.textBoxidentificacion.Location = new System.Drawing.Point(204, 55);
            this.textBoxidentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidentificacion.Name = "textBoxidentificacion";
            this.textBoxidentificacion.Size = new System.Drawing.Size(187, 26);
            this.textBoxidentificacion.TabIndex = 3;
            // 
            // buttonConsultarAgregar
            // 
            this.buttonConsultarAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConsultarAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConsultarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultarAgregar.Image")));
            this.buttonConsultarAgregar.Location = new System.Drawing.Point(429, 41);
            this.buttonConsultarAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultarAgregar.Name = "buttonConsultarAgregar";
            this.buttonConsultarAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConsultarAgregar.Size = new System.Drawing.Size(79, 54);
            this.buttonConsultarAgregar.TabIndex = 4;
            this.buttonConsultarAgregar.UseVisualStyleBackColor = false;
            this.buttonConsultarAgregar.Click += new System.EventHandler(this.buttonConsultarAgregar_Click);
            // 
            // dataGridViewUsuariosInstalacionesDia
            // 
            this.dataGridViewUsuariosInstalacionesDia.AllowUserToAddRows = false;
            this.dataGridViewUsuariosInstalacionesDia.AllowUserToDeleteRows = false;
            this.dataGridViewUsuariosInstalacionesDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuariosInstalacionesDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuariosInstalacionesDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificacion,
            this.Column1,
            this.Column2});
            this.dataGridViewUsuariosInstalacionesDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuariosInstalacionesDia.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuariosInstalacionesDia.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuariosInstalacionesDia.Name = "dataGridViewUsuariosInstalacionesDia";
            this.dataGridViewUsuariosInstalacionesDia.ReadOnly = true;
            this.dataGridViewUsuariosInstalacionesDia.RowTemplate.Height = 24;
            this.dataGridViewUsuariosInstalacionesDia.Size = new System.Drawing.Size(733, 220);
            this.dataGridViewUsuariosInstalacionesDia.TabIndex = 10;
            // 
            // identificacion
            // 
            this.identificacion.HeaderText = "Identificación";
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Carrera o Oficio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxidentificacion);
            this.panel1.Controls.Add(this.buttonConsultarAgregar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(128, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 129);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewUsuariosInstalacionesDia);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(62, 229);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 222);
            this.panel2.TabIndex = 12;
            // 
            // panelGradiente1
            // 
            //this.panelGradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(164)))));
            //this.panelGradiente1.ColorTop = System.Drawing.Color.Empty;
            //this.panelGradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.panelGradiente1.Location = new System.Drawing.Point(0, 0);
            //this.panelGradiente1.Name = "panelGradiente1";
            //this.panelGradiente1.Size = new System.Drawing.Size(866, 539);
            //this.panelGradiente1.TabIndex = 13;
            // 
            // FRMControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(866, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            //this.Controls.Add(this.panelGradiente1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMControlUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Gimnasio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosInstalacionesDia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxidentificacion;
        private System.Windows.Forms.Button buttonConsultarAgregar;
        private System.Windows.Forms.DataGridView dataGridViewUsuariosInstalacionesDia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        //private PanelGradiente panelGradiente1;
    }
}

