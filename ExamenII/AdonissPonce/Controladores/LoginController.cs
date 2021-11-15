using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;
using POO.Vista;
using Transitions;

namespace POO.Controladores
{
    public class LoginController
    {
        InterfazPrincipal app = new InterfazPrincipal();
        LoginSingin vista; //vista = Formulario LoginSingin
        public LoginController(LoginSingin view)
        {
            vista = view; //vista toma los valores de view

            vista.Size = new Size(999, 500);
            vista.AutoScaleMode = AutoScaleMode.Font;
            vista.Load += new EventHandler(OcultarSingup);

            vista.labelHola.Text = "!Hola " + Environment.UserName + "!";

            vista.ActiveControl = vista.label1; //Se usa la label1 como punto de foco para
                                                //que los placeholders sean legibles

            vista.labelHola2.Text = "!Hola " + Environment.UserName + "!";

            vista.labelCrear.Parent = vista.pictureBoxLogin;
            vista.labelCrear.BackColor = Color.Transparent;

            vista.labelHola.Parent = vista.pictureBoxLogin;
            vista.labelHola.BackColor = Color.Transparent;

            vista.buttonRegistrar.Parent = vista.pictureBoxLogin;
            vista.buttonRegistrar.BackColor = Color.Transparent;

            vista.labelIngresar.Parent = vista.pictureBoxSingup;
            vista.labelIngresar.BackColor = Color.Transparent;

            vista.labelHola2.Parent = vista.pictureBoxSingup;
            vista.labelHola2.BackColor = Color.Transparent;

            vista.buttonSalirSingup.Parent = vista.pictureBoxSingup;
            vista.buttonSalirSingup.BackColor = Color.Transparent;

            vista.buttonIngresar.Parent = vista.pictureBoxSingup;
            vista.buttonIngresar.BackColor = Color.Transparent;

            vista.buttonAcceder.Click += new EventHandler(ValidarUsuario);//Capturando el evento click para
                                                                          //ejecutar la función "ValidadrUsuario"
            vista.buttonAcceder.Click += new EventHandler(ValidarTextBoxs);

            vista.buttonVerLogin.Click += new EventHandler(MostrarContra);

            vista.buttonVistaSingup.Click += new EventHandler(MostrarContra);

            vista.buttonRegistrar.Click += new EventHandler(Animar);

            vista.buttonIngresar.Click += new EventHandler(Animar);

            vista.buttonSalirLogin.Click += new EventHandler(Cerrar);

            vista.buttonSalirSingup.Click += new EventHandler(Cerrar);

            

        }

        private void ValidarTextBoxs(object sender, EventArgs e)
        {
            if (vista.textBoxEmailLogin.Texts != string.Empty)
            {
                if(vista.textBoxClaveLogin.Texts != string.Empty)
                {
                    
                }
                else MessageBox.Show("Por favor, ingrese su contraseña");
            }
            else MessageBox.Show("Por favor, ingrese su correo electrónico");
        }
        private void OcultarSingup(object sender, EventArgs e)
        {
            vista.textBoxId.Hide();
            vista.textBoxNombre.Hide();
            vista.textBoxClaveSingup.Hide();
            vista.textBoxEmailSingup.Hide();
            vista.buttonCrear.Hide();
            vista.buttonGuardar.Hide();
            vista.buttonVistaSingup.Hide();
        }

        private void OcultarLogin(object sender, EventArgs e)
        {
            vista.textBoxClaveLogin.Hide();
            vista.textBoxEmailLogin.Hide();
            vista.buttonVerLogin.Hide();
            vista.buttonAcceder.Hide();
            vista.buttonSalirLogin.Hide();
        }

        private void MostrarSingup()
        {
            vista.textBoxId.Show();
            vista.textBoxNombre.Show();
            vista.textBoxClaveSingup.Show();
            vista.textBoxEmailSingup.Show();
            vista.buttonVistaSingup.Show();
            vista.buttonCrear.Show();
            vista.buttonGuardar.Show();
        }

        private void MostrarLogin()
        {
            vista.textBoxEmailLogin.Show();
            vista.textBoxClaveLogin.Show();
            vista.buttonVerLogin.Show();
            vista.buttonAcceder.Show();
            vista.linkLabelContrasenia.Show();
            vista.buttonSalirLogin.Show();
        }

        private void ValidarUsuario(object sender, EventArgs e) //Función para validar el usuario
        {
            bool usuarioValido = false;

            UsuarioDAO userDao = new UsuarioDAO();

            Usuario usuarioIngresado = new Usuario();

            usuarioIngresado.Email = vista.textBoxEmailLogin.Texts;
            usuarioIngresado.Clave = EncriptarClave(vista.textBoxClaveLogin.Texts);

            usuarioValido = userDao.ValidarUsuario(usuarioIngresado);
           
            if (usuarioValido == true)
            {
                app.Show();
                app.FormClosed += Logout;
                vista.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
                    vista.textBoxEmailLogin.Texts = "";
                    vista.textBoxClaveLogin.Texts = "";
            }

        }

        private void MostrarContra(object sender, EventArgs e) //Función para validar el usuario
        {
           if (vista.textBoxClaveLogin.PasswordChar == true)
            {
                vista.textBoxClaveLogin.PasswordChar = false;
            }
            else
            {
                vista.textBoxClaveLogin.PasswordChar = true;
            }

            if (vista.textBoxClaveSingup.PasswordChar == true)
            {
                vista.textBoxClaveSingup.PasswordChar = false;
            }
            else
            {
                vista.textBoxClaveSingup.PasswordChar = true;
            }

        }

        private void VistaPaint(object sender, EventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = vista.pictureBoxLogin.ClientRectangle;
            Rectangle r2 = vista.pictureBoxSingup.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;
            int c2 = r2.Width / 2;

            // Establecemos la nueva posición del control Label.
            vista.labelCrear.Location = new Point(c - vista.labelCrear.Width / 2, vista.labelCrear.Location.Y);
            vista.labelHola.Location = new Point(c - vista.labelHola.Width / 2, vista.labelHola.Location.Y);

            vista.labelIngresar.Location = new Point(c - vista.labelIngresar.Width / 2, vista.labelIngresar.Location.Y);
            vista.labelHola2.Location = new Point(c2 - vista.labelHola2.Width / 2, vista.labelHola2.Location.Y);
            vista.buttonIngresar.Location = new Point(c2 - vista.buttonIngresar.Width / 2, vista.buttonIngresar.Location.Y);
        }

        private void Animar(object sender, EventArgs e)
        {
            if (vista.panelLoginSingup.Location.X > 0)
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(vista.panelLoginSingup, "Left", 0);
                t.run();

                vista.buttonAcceder.Hide();
                vista.buttonSalirLogin.Hide();
                vista.textBoxEmailLogin.Hide();
                vista.textBoxClaveLogin.Hide();
                vista.buttonVerLogin.Hide();
                vista.linkLabelContrasenia.Hide();

                vista.label1.Text = "SINGUP";

                MostrarSingup();

            }
            else if(vista.panelLoginSingup.Location.X < 500)
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(vista.panelLoginSingup, "Left", 500);
                t.run();

                vista.buttonCrear.Hide();
                vista.buttonGuardar.Hide();
                vista.textBoxId.Hide();
                vista.textBoxNombre.Hide();
                vista.textBoxEmailSingup.Hide();
                vista.textBoxClaveSingup.Hide();
                vista.buttonVistaSingup.Hide();
                
                vista.label1.Text = "LOGIN";

                MostrarLogin();
            }

        }

        private void Cerrar(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            vista.textBoxClaveLogin.Texts = "";
            vista.textBoxEmailLogin.Texts = "";
            vista.textBoxClaveSingup.Texts = "";
            vista.textBoxNombre.Texts = "";
            vista.textBoxEmailSingup.Texts = "";
            vista.textBoxId.Texts = "";
            vista.Show();
        }

 

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
