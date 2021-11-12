using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using POO.Controladores;
using Transitions;


namespace POO
{
    public partial class LoginSingin : Form
    {
        public LoginSingin()
        {
            InitializeComponent();

            this.Size = new Size(999, 500);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.ContainerControl |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor
                          , true);

            LoginController controlador = new LoginController(this); //this hace referencia al formulario actual

            UsuarioIngresadoController controladorUsuario = new UsuarioIngresadoController(this); //this hace referencia al formulario actual
        }

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelLoginSingup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxSingup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void panelLoginSingup_Paint(object sender, PaintEventArgs e)
        //{
        //    this.AutoScaleMode = AutoScaleMode.None;
        //}

        //private void label1_Paint(object sender, PaintEventArgs e)
        //{
        //    this.AutoScaleMode = AutoScaleMode.None;
        //}

        //private void linkLabelContrasenia_Paint(object sender, PaintEventArgs e)
        //{
        //    this.AutoScaleMode = AutoScaleMode.None;
        //}

        //private void textBoxEmailLogin_Paint(object sender, PaintEventArgs e)
        //{
        //    this.AutoScaleMode = AutoScaleMode.None;
        //}
    }
}
