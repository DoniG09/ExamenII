
namespace POO.Vista
{
    partial class TiposSoporte
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
            this.comboBoxTipoSoporte = new System.Windows.Forms.ComboBox();
            this.buttonAceptar = new Controles_Personalizados.Controles_Pers.Button_Personalizado();
            this.buttonSeleccionar = new Controles_Personalizados.Controles_Pers.Button_Personalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSoporteSeleccionado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCorreoPanel = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTipoSoporte
            // 
            this.comboBoxTipoSoporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTipoSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.comboBoxTipoSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoSoporte.Font = new System.Drawing.Font("Geomanist", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoSoporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxTipoSoporte.FormattingEnabled = true;
            this.comboBoxTipoSoporte.Items.AddRange(new object[] {
            "Instalación, Actualización y Configuración de Software del Dispositivos",
            "Reparación de Dispositivos",
            "Asistencia a redes wifi",
            "Respaldo de Datos",
            "Diagnóstico Preventivo",
            "Limpieza Física de Dispositivos",
            "Asistencia de Cableado Estructurado",
            "Copias de Seguridad"});
            this.comboBoxTipoSoporte.Location = new System.Drawing.Point(145, 196);
            this.comboBoxTipoSoporte.Name = "comboBoxTipoSoporte";
            this.comboBoxTipoSoporte.Size = new System.Drawing.Size(659, 48);
            this.comboBoxTipoSoporte.TabIndex = 1;
            this.comboBoxTipoSoporte.Tag = "Seleccione el Soporte que Solicita";
            this.comboBoxTipoSoporte.Text = "Seleccione el Soporte que Solicita";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.buttonAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.buttonAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAceptar.BorderRadius = 10;
            this.buttonAceptar.BorderSize = 0;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAceptar.Location = new System.Drawing.Point(359, 549);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(231, 42);
            this.buttonAceptar.TabIndex = 22;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.buttonSeleccionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.buttonSeleccionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSeleccionar.BorderRadius = 10;
            this.buttonSeleccionar.BorderSize = 0;
            this.buttonSeleccionar.FlatAppearance.BorderSize = 0;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSeleccionar.Location = new System.Drawing.Point(359, 328);
            this.buttonSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(231, 42);
            this.buttonSeleccionar.TabIndex = 21;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Geomanist Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(303, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Servicio de Soporte Solicitado:";
            // 
            // labelSoporteSeleccionado
            // 
            this.labelSoporteSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSoporteSeleccionado.AutoSize = true;
            this.labelSoporteSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSoporteSeleccionado.Font = new System.Drawing.Font("Geomanist Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoporteSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.labelSoporteSeleccionado.Location = new System.Drawing.Point(405, 456);
            this.labelSoporteSeleccionado.Name = "labelSoporteSeleccionado";
            this.labelSoporteSeleccionado.Size = new System.Drawing.Size(139, 52);
            this.labelSoporteSeleccionado.TabIndex = 25;
            this.labelSoporteSeleccionado.Text = "L. 0.00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Geomanist Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(296, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Le atenderemos lo más pronto posible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Geomanist", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Correo de Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 60);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 70;
            this.iconButton1.Location = new System.Drawing.Point(16, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(65, 74);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 77);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelCorreoPanel);
            this.panel3.Location = new System.Drawing.Point(106, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 77);
            this.panel3.TabIndex = 2;
            // 
            // labelCorreoPanel
            // 
            this.labelCorreoPanel.AutoSize = true;
            this.labelCorreoPanel.Font = new System.Drawing.Font("Geomanist", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCorreoPanel.Location = new System.Drawing.Point(552, 18);
            this.labelCorreoPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreoPanel.Name = "labelCorreoPanel";
            this.labelCorreoPanel.Size = new System.Drawing.Size(270, 47);
            this.labelCorreoPanel.TabIndex = 2;
            this.labelCorreoPanel.Text = "                  0.00";
            this.labelCorreoPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.flowLayoutPanel7.Controls.Add(this.panel1);
            this.flowLayoutPanel7.Controls.Add(this.panel2);
            this.flowLayoutPanel7.Controls.Add(this.panel3);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(952, 151);
            this.flowLayoutPanel7.TabIndex = 27;
            // 
            // TiposSoporte
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(952, 605);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSoporteSeleccionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.comboBoxTipoSoporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TiposSoporte";
            this.Text = "Tipos de Soporte";
            this.Load += new System.EventHandler(this.TiposSoporte_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TiposSoporte_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Controles_Personalizados.Controles_Pers.Button_Personalizado buttonAceptar;
        public Controles_Personalizados.Controles_Pers.Button_Personalizado buttonSeleccionar;
        public System.Windows.Forms.ComboBox comboBoxTipoSoporte;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelSoporteSeleccionado;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCorreoPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    }
}