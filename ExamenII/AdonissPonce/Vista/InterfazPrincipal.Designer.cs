
namespace POO
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.panelMenú = new System.Windows.Forms.Panel();
            this.buttonSalir = new FontAwesome.Sharp.IconButton();
            this.buttonDetallesTicket = new FontAwesome.Sharp.IconButton();
            this.buttonEstadoTicket = new FontAwesome.Sharp.IconButton();
            this.buttonGenerarTicket = new FontAwesome.Sharp.IconButton();
            this.buttonTiposSoporte = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new FontAwesome.Sharp.IconButton();
            this.buttonInicio = new System.Windows.Forms.PictureBox();
            this.panelBarraTítulo = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new FontAwesome.Sharp.IconButton();
            this.buttonExpandir = new FontAwesome.Sharp.IconButton();
            this.buttonCerrar = new FontAwesome.Sharp.IconButton();
            this.labelTituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconFormularioHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.panelMenú.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInicio)).BeginInit();
            this.panelBarraTítulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioHijoActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenú
            // 
            this.panelMenú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelMenú.Controls.Add(this.buttonSalir);
            this.panelMenú.Controls.Add(this.buttonDetallesTicket);
            this.panelMenú.Controls.Add(this.buttonEstadoTicket);
            this.panelMenú.Controls.Add(this.buttonGenerarTicket);
            this.panelMenú.Controls.Add(this.buttonTiposSoporte);
            this.panelMenú.Controls.Add(this.panel1);
            this.panelMenú.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenú.Location = new System.Drawing.Point(0, 0);
            this.panelMenú.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(310, 1012);
            this.panelMenú.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.buttonSalir.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonSalir.IconSize = 40;
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(0, 867);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonSalir.Size = new System.Drawing.Size(310, 145);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Tag = "Salir";
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonDetallesTicket
            // 
            this.buttonDetallesTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDetallesTicket.FlatAppearance.BorderSize = 0;
            this.buttonDetallesTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetallesTicket.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetallesTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetallesTicket.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.buttonDetallesTicket.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetallesTicket.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonDetallesTicket.IconSize = 40;
            this.buttonDetallesTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetallesTicket.Location = new System.Drawing.Point(0, 721);
            this.buttonDetallesTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetallesTicket.Name = "buttonDetallesTicket";
            this.buttonDetallesTicket.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonDetallesTicket.Size = new System.Drawing.Size(310, 145);
            this.buttonDetallesTicket.TabIndex = 6;
            this.buttonDetallesTicket.Tag = "Detalles de Ticket";
            this.buttonDetallesTicket.Text = "Detalles de Ticket";
            this.buttonDetallesTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDetallesTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDetallesTicket.UseVisualStyleBackColor = true;
            this.buttonDetallesTicket.Click += new System.EventHandler(this.buttonDetallesTicket_Click);
            // 
            // buttonEstadoTicket
            // 
            this.buttonEstadoTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEstadoTicket.FlatAppearance.BorderSize = 0;
            this.buttonEstadoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstadoTicket.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadoTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEstadoTicket.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.buttonEstadoTicket.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEstadoTicket.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonEstadoTicket.IconSize = 40;
            this.buttonEstadoTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstadoTicket.Location = new System.Drawing.Point(0, 576);
            this.buttonEstadoTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEstadoTicket.Name = "buttonEstadoTicket";
            this.buttonEstadoTicket.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonEstadoTicket.Size = new System.Drawing.Size(310, 145);
            this.buttonEstadoTicket.TabIndex = 3;
            this.buttonEstadoTicket.Tag = "Estado del Ticket";
            this.buttonEstadoTicket.Text = "Estado del Ticket";
            this.buttonEstadoTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstadoTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEstadoTicket.UseVisualStyleBackColor = true;
            this.buttonEstadoTicket.Click += new System.EventHandler(this.buttonEstadoTicket_Click);
            // 
            // buttonGenerarTicket
            // 
            this.buttonGenerarTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerarTicket.FlatAppearance.BorderSize = 0;
            this.buttonGenerarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarTicket.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenerarTicket.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.buttonGenerarTicket.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenerarTicket.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonGenerarTicket.IconSize = 40;
            this.buttonGenerarTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerarTicket.Location = new System.Drawing.Point(0, 431);
            this.buttonGenerarTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGenerarTicket.Name = "buttonGenerarTicket";
            this.buttonGenerarTicket.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonGenerarTicket.Size = new System.Drawing.Size(310, 145);
            this.buttonGenerarTicket.TabIndex = 0;
            this.buttonGenerarTicket.Tag = "Generar Ticket";
            this.buttonGenerarTicket.Text = "Generar Ticket";
            this.buttonGenerarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerarTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGenerarTicket.UseVisualStyleBackColor = true;
            this.buttonGenerarTicket.Click += new System.EventHandler(this.buttonGenerarTicket_Click);
            // 
            // buttonTiposSoporte
            // 
            this.buttonTiposSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTiposSoporte.FlatAppearance.BorderSize = 0;
            this.buttonTiposSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTiposSoporte.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiposSoporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTiposSoporte.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.buttonTiposSoporte.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTiposSoporte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonTiposSoporte.IconSize = 40;
            this.buttonTiposSoporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTiposSoporte.Location = new System.Drawing.Point(0, 286);
            this.buttonTiposSoporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTiposSoporte.Name = "buttonTiposSoporte";
            this.buttonTiposSoporte.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTiposSoporte.Size = new System.Drawing.Size(310, 145);
            this.buttonTiposSoporte.TabIndex = 1;
            this.buttonTiposSoporte.Tag = "Tipos de Soporte";
            this.buttonTiposSoporte.Text = "Tipos de Soporte";
            this.buttonTiposSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTiposSoporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTiposSoporte.UseVisualStyleBackColor = true;
            this.buttonTiposSoporte.Click += new System.EventHandler(this.buttonTiposSoporte_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 286);
            this.panel1.TabIndex = 0;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.buttonMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(203)))));
            this.buttonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMenu.Location = new System.Drawing.Point(232, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(75, 72);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Image = global::POO.Properties.Resources.Encabezado_BALAMERos_Oscuro;
            this.buttonInicio.Location = new System.Drawing.Point(14, 28);
            this.buttonInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(279, 232);
            this.buttonInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonInicio.TabIndex = 2;
            this.buttonInicio.TabStop = false;
            this.buttonInicio.Click += new System.EventHandler(this.ButtonInicio_Click);
            // 
            // panelBarraTítulo
            // 
            this.panelBarraTítulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panelBarraTítulo.Controls.Add(this.buttonMinimizar);
            this.panelBarraTítulo.Controls.Add(this.buttonExpandir);
            this.panelBarraTítulo.Controls.Add(this.buttonCerrar);
            this.panelBarraTítulo.Controls.Add(this.labelTituloFormularioHijo);
            this.panelBarraTítulo.Controls.Add(this.iconFormularioHijoActual);
            this.panelBarraTítulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTítulo.Location = new System.Drawing.Point(310, 0);
            this.panelBarraTítulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBarraTítulo.Name = "panelBarraTítulo";
            this.panelBarraTítulo.Size = new System.Drawing.Size(974, 88);
            this.panelBarraTítulo.TabIndex = 2;
            this.panelBarraTítulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTítulo_MouseDown);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimizar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMinimizar.IconSize = 30;
            this.buttonMinimizar.Location = new System.Drawing.Point(839, 0);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(45, 35);
            this.buttonMinimizar.TabIndex = 8;
            this.buttonMinimizar.UseVisualStyleBackColor = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.ButtonMinimizar_Click);
            // 
            // buttonExpandir
            // 
            this.buttonExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExpandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.buttonExpandir.FlatAppearance.BorderSize = 0;
            this.buttonExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpandir.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.buttonExpandir.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExpandir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonExpandir.IconSize = 30;
            this.buttonExpandir.Location = new System.Drawing.Point(884, 0);
            this.buttonExpandir.Name = "buttonExpandir";
            this.buttonExpandir.Size = new System.Drawing.Size(45, 35);
            this.buttonExpandir.TabIndex = 7;
            this.buttonExpandir.UseVisualStyleBackColor = false;
            this.buttonExpandir.Click += new System.EventHandler(this.ButtonExpandir_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonCerrar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCerrar.IconSize = 30;
            this.buttonCerrar.Location = new System.Drawing.Point(929, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(45, 35);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // labelTituloFormularioHijo
            // 
            this.labelTituloFormularioHijo.AutoSize = true;
            this.labelTituloFormularioHijo.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloFormularioHijo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTituloFormularioHijo.Location = new System.Drawing.Point(66, 29);
            this.labelTituloFormularioHijo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloFormularioHijo.Name = "labelTituloFormularioHijo";
            this.labelTituloFormularioHijo.Size = new System.Drawing.Size(141, 25);
            this.labelTituloFormularioHijo.TabIndex = 1;
            this.labelTituloFormularioHijo.Text = "Menú de Inicio";
            // 
            // iconFormularioHijoActual
            // 
            this.iconFormularioHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.iconFormularioHijoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(171)))));
            this.iconFormularioHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormularioHijoActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(171)))));
            this.iconFormularioHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormularioHijoActual.IconSize = 48;
            this.iconFormularioHijoActual.Location = new System.Drawing.Point(9, 18);
            this.iconFormularioHijoActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconFormularioHijoActual.Name = "iconFormularioHijoActual";
            this.iconFormularioHijoActual.Size = new System.Drawing.Size(48, 49);
            this.iconFormularioHijoActual.TabIndex = 0;
            this.iconFormularioHijoActual.TabStop = false;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(310, 88);
            this.panelEscritorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(974, 924);
            this.panelEscritorio.TabIndex = 4;
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1284, 1012);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelBarraTítulo);
            this.Controls.Add(this.panelMenú);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazPrincipal_Load);
            this.Resize += new System.EventHandler(this.InterfazPrincipal_Resize);
            this.panelMenú.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonInicio)).EndInit();
            this.panelBarraTítulo.ResumeLayout(false);
            this.panelBarraTítulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioHijoActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public FontAwesome.Sharp.IconButton buttonEstadoTicket;
        public FontAwesome.Sharp.IconButton buttonDetallesTicket;
        public FontAwesome.Sharp.IconButton buttonTiposSoporte;
        public FontAwesome.Sharp.IconButton buttonGenerarTicket;
        public System.Windows.Forms.PictureBox buttonInicio;
        public System.Windows.Forms.Panel panelBarraTítulo;
        public FontAwesome.Sharp.IconPictureBox iconFormularioHijoActual;
        public System.Windows.Forms.Label labelTituloFormularioHijo;
        public FontAwesome.Sharp.IconButton buttonMenu;
        public System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton buttonSalir;
        public FontAwesome.Sharp.IconButton buttonCerrar;
        public FontAwesome.Sharp.IconButton buttonExpandir;
        public FontAwesome.Sharp.IconButton buttonMinimizar;
        public System.Windows.Forms.Panel panelMenú;
        public System.Windows.Forms.Panel panelEscritorio;
    }
}

