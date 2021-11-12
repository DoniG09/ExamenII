
namespace POO.Vista
{
    partial class EstadoTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.labelCompraPanel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDescuentoPanel = new System.Windows.Forms.Label();
            this.textBoxNumTicket = new RJCodeAdvance.RJControls.RJTextBox();
            this.buttonVerificar = new Controles_Personalizados.Controles_Pers.Button_Personalizado();
            this.dataGridViewTicketsGenerados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsGenerados)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.flowLayoutPanel7.Controls.Add(this.panel1);
            this.flowLayoutPanel7.Controls.Add(this.panel2);
            this.flowLayoutPanel7.Controls.Add(this.labelCompraPanel);
            this.flowLayoutPanel7.Controls.Add(this.panel4);
            this.flowLayoutPanel7.Controls.Add(this.panel5);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(549, 14);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(390, 194);
            this.flowLayoutPanel7.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 38);
            this.panel1.TabIndex = 0;
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
            this.label5.Size = new System.Drawing.Size(187, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ticket Ingresado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(3, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 109);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(100, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 111);
            this.panel3.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 80;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(102, 109);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // labelCompraPanel
            // 
            this.labelCompraPanel.AutoSize = true;
            this.labelCompraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompraPanel.Font = new System.Drawing.Font("Geomanist", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompraPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCompraPanel.Location = new System.Drawing.Point(112, 44);
            this.labelCompraPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompraPanel.Name = "labelCompraPanel";
            this.labelCompraPanel.Size = new System.Drawing.Size(265, 115);
            this.labelCompraPanel.TabIndex = 2;
            this.labelCompraPanel.Text = "L.               0.00";
            this.labelCompraPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(3, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 32);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estado";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelDescuentoPanel);
            this.panel5.Location = new System.Drawing.Point(211, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(176, 32);
            this.panel5.TabIndex = 4;
            // 
            // labelDescuentoPanel
            // 
            this.labelDescuentoPanel.AutoSize = true;
            this.labelDescuentoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDescuentoPanel.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuentoPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescuentoPanel.Location = new System.Drawing.Point(60, 0);
            this.labelDescuentoPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescuentoPanel.Name = "labelDescuentoPanel";
            this.labelDescuentoPanel.Size = new System.Drawing.Size(116, 25);
            this.labelDescuentoPanel.TabIndex = 1;
            this.labelDescuentoPanel.Text = "L.           0.00";
            // 
            // textBoxNumTicket
            // 
            this.textBoxNumTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.textBoxNumTicket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.textBoxNumTicket.BorderFocusColor = System.Drawing.Color.Crimson;
            this.textBoxNumTicket.BorderRadius = 0;
            this.textBoxNumTicket.BorderSize = 2;
            this.textBoxNumTicket.Font = new System.Drawing.Font("Geomanist", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumTicket.Location = new System.Drawing.Point(13, 17);
            this.textBoxNumTicket.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumTicket.Multiline = false;
            this.textBoxNumTicket.Name = "textBoxNumTicket";
            this.textBoxNumTicket.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxNumTicket.PasswordChar = false;
            this.textBoxNumTicket.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.textBoxNumTicket.PlaceholderText = "Digíte el Número de su Ticket";
            this.textBoxNumTicket.ReadOnly = false;
            this.textBoxNumTicket.Size = new System.Drawing.Size(435, 45);
            this.textBoxNumTicket.TabIndex = 18;
            this.textBoxNumTicket.Texts = "";
            this.textBoxNumTicket.UnderlinedStyle = false;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.buttonVerificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.buttonVerificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonVerificar.BorderRadius = 10;
            this.buttonVerificar.BorderSize = 0;
            this.buttonVerificar.FlatAppearance.BorderSize = 0;
            this.buttonVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerificar.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerificar.Location = new System.Drawing.Point(109, 166);
            this.buttonVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(231, 42);
            this.buttonVerificar.TabIndex = 22;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVerificar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTicketsGenerados
            // 
            this.dataGridViewTicketsGenerados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewTicketsGenerados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTicketsGenerados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTicketsGenerados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.dataGridViewTicketsGenerados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTicketsGenerados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTicketsGenerados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTicketsGenerados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTicketsGenerados.ColumnHeadersHeight = 35;
            this.dataGridViewTicketsGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTicketsGenerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewTicketsGenerados.EnableHeadersVisualStyles = false;
            this.dataGridViewTicketsGenerados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTicketsGenerados.Location = new System.Drawing.Point(-1, 382);
            this.dataGridViewTicketsGenerados.Name = "dataGridViewTicketsGenerados";
            this.dataGridViewTicketsGenerados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTicketsGenerados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTicketsGenerados.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Geomanist", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridViewTicketsGenerados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTicketsGenerados.RowTemplate.Height = 28;
            this.dataGridViewTicketsGenerados.Size = new System.Drawing.Size(532, 343);
            this.dataGridViewTicketsGenerados.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número de Ticket";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 103;
            // 
            // EstadoTicket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(952, 605);
            this.Controls.Add(this.dataGridViewTicketsGenerados);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.textBoxNumTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoTicket";
            this.Text = "Estado del Ticket";
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsGenerados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label labelCompraPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDescuentoPanel;
        private RJCodeAdvance.RJControls.RJTextBox textBoxNumTicket;
        public Controles_Personalizados.Controles_Pers.Button_Personalizado buttonVerificar;
        private System.Windows.Forms.DataGridView dataGridViewTicketsGenerados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}