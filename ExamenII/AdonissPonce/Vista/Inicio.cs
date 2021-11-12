using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();

            
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelSaludo.Text = "Bienvenido " + Environment.UserName + " espero que te guste el programa";
            labelInstruccion.Text = "Presiona el botón de menú para continuar con el panel";
            labelCreditos.Text = "Creado por Adoniss Ponce 20171002692, adoniss.ponce@unah.hn";

            timer1.Enabled = true;

        }

        private void Inicio_Paint(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            // Establecemos la nueva posición del control Label.
            //
            pictureBox1.Location = new Point(c - pictureBox1.Width / 2, pictureBox1.Location.Y);
            labelHora.Location = new Point(c - labelHora.Width / 2, labelHora.Location.Y);
            labelFecha.Location = new Point(c - labelFecha.Width / 2, labelFecha.Location.Y);
            labelSaludo.Location = new Point(c - labelSaludo.Width / 2, labelSaludo.Location.Y);
            labelInstruccion.Location = new Point(c - labelInstruccion.Width / 2, labelInstruccion.Location.Y);
            labelCreditos.Location = new Point(c - labelCreditos.Width / 2, labelCreditos.Location.Y);

        }


        private void Inicio_Resize(object sender, EventArgs e)
        {
            // invalidamos el formulario
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }


    }
}
