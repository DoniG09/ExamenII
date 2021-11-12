using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace POO
{
    public partial class InterfazPrincipal : Form
    {

        //Campos
        private IconButton botónActual;
        private Panel bordeBotónIzquierdo;
        public Form formularioHijoActual;
        private int borderSize = 2;
        private Size formSize; //MantengMantienea el tamaño del formulario cuando se minimice y restaure.
                               //porque tiene en cuenta el tamaño de la barra de título y los bordes.

        //Constructor
        public InterfazPrincipal()
        {
            InitializeComponent();
            this.Size = new Size(1306, 1068);
            ContraerMenu();

            AbrirFormularioHijo(new Inicio());
            this.Padding = new Padding(borderSize);//Tamaño de Borde
            this.BackColor = Color.FromArgb(203, 0, 65);//Color de Borde

            bordeBotónIzquierdo = new Panel();
            bordeBotónIzquierdo.Size = new Size(10, buttonDetallesTicket.Size.Height);
            panelMenú.Controls.Add(bordeBotónIzquierdo);

        }

        //Estructura
        private struct ColoresRGB
        {
            public static Color color1 = Color.FromArgb(255, 47, 105);
            public static Color color2 = Color.FromArgb(246, 83, 100);
            public static Color color3 = Color.FromArgb(254, 98, 137);
            public static Color color4 = Color.FromArgb(226, 123, 155);
            public static Color color5 = Color.FromArgb(255, 193, 204);
        }

        //Métodos
        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                BotonInactivo();

                //Botón
                botónActual = (IconButton)senderBtn;
                botónActual.BackColor = Color.FromArgb(50, 50, 50);
                botónActual.ForeColor = color;
                botónActual.TextAlign = ContentAlignment.MiddleCenter;
                botónActual.IconColor = color;
                botónActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botónActual.ImageAlign = ContentAlignment.MiddleRight;

                //Borde Izquierdo del Botón
                bordeBotónIzquierdo.BackColor = color;
                bordeBotónIzquierdo.Location = new Point(0, botónActual.Location.Y);
                bordeBotónIzquierdo.Visible = true;
                bordeBotónIzquierdo.BringToFront();

                //Current Child Form Icon
                iconFormularioHijoActual.IconChar = botónActual.IconChar;
                iconFormularioHijoActual.IconColor = color;

            }
        }

        private void BotonInactivo()
        {
            if (botónActual != null)
            {

                //Botón
                botónActual.BackColor = Color.FromArgb(43, 43, 43);
                botónActual.ForeColor = SystemColors.ButtonHighlight;
                botónActual.TextAlign = ContentAlignment.MiddleLeft;
                botónActual.IconColor = SystemColors.ButtonHighlight;
                botónActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botónActual.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void AbrirFormularioHijo(Form childForm)
        {

            if (formularioHijoActual != null)
            {
                //Abrir sólo el formulario 
                formularioHijoActual.Hide();
            }
            formularioHijoActual = childForm;
            //Final
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTituloFormularioHijo.Text = childForm.Text;

        }

        private void buttonTiposSoporte_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, ColoresRGB.color1);
            formularioHijoActual.Hide();
            AbrirFormularioHijo(new Vista.TiposSoporte());
        }

        private void buttonGenerarTicket_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, ColoresRGB.color2);
            formularioHijoActual.Hide();
            AbrirFormularioHijo(new Vista.GenerarTicket());

        }

        public void buttonEstadoTicket_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, ColoresRGB.color3);
            formularioHijoActual.Hide();
            AbrirFormularioHijo(new Vista.EstadoTicket());

        }

        private void buttonDetallesTicket_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, ColoresRGB.color5);
            formularioHijoActual.Hide();
            AbrirFormularioHijo(new Vista.DetalleTicket());
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, ColoresRGB.color4);
            if (MessageBox.Show("¿Está seguro de que quiere salir?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();
            }
       
        }

        private void ButtonInicio_Click(object sender, EventArgs e)
        {

            formularioHijoActual.Hide();
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Hide();
            }
            AbrirFormularioHijo(new Inicio());
            
            Reiniciar();

        }

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTítulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        //Anular Métodos
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window

            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part
                                            //of the window corresponds to a point, allows to resize the form.

            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally
                                     //to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally
                                      //to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize
                                        //diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows
                                         //resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest 
            ///</Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client
                                                  //area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and
                                                                           //Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen
                                                                             //point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the
                                                            //resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less
                                                                 //than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the
                                                                                        //coordinate X=11 or less than the width of the
                                                                                        //form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form
                                                                                       //at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion


            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it
            //takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }

            base.WndProc(ref m);

        }

        //Eventos privados
        private void AjustarFormulario()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(11, 11, 11, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void ContraerMenu()
        {
            if (this.panelMenú.Width > 200) //Contraer menú
            {
                panelMenú.Width = 100;
                buttonInicio.Visible = false;
                buttonMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenú.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else //Expandir menú
            {
                panelMenú.Width = 310;
                buttonInicio.Visible = true;
                buttonMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenú.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Reiniciar()
        {
            BotonInactivo();
            bordeBotónIzquierdo.Visible = false;
            iconFormularioHijoActual.IconChar = IconChar.Home;
            iconFormularioHijoActual.IconColor = Color.FromArgb(255, 180, 165);
            labelTituloFormularioHijo.Text = "Inicio";
        }

        //Métodos de Evento
        private void InterfazPrincipal_Resize(object sender, EventArgs e)
        {
            AjustarFormulario();
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            ContraerMenu();
        }

        private void ButtonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonExpandir_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
