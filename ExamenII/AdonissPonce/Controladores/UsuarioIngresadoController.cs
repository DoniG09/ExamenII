using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;
using POO.Vista;

namespace POO.Controladores
{
    public class UsuarioIngresadoController
    {
        LoginSingin vista;
        string operacion = string.Empty;

        public UsuarioIngresadoController(LoginSingin view)
        {
            vista = view;
            vista.buttonCrear.Click += new EventHandler(Crear);
            vista.buttonGuardar.Click += new EventHandler(Guardar);
        }

        private void Crear(object sender, EventArgs e) 
        {
            HabilitarControles();
            operacion = "Crear";
        }

        private void Guardar(object sender, EventArgs e) 
        {
            if(vista.textBoxNombre.Texts == "")
            {
                vista.errorProvider1.SetError(vista.textBoxNombre, "Ingrese su Nombre");
                vista.textBoxNombre.Focus();
                return;
            }
            if (vista.textBoxEmailSingup.Texts == "")
            {
                vista.errorProvider1.SetError(vista.textBoxEmailSingup, "Ingrese su Correo");
                vista.textBoxEmailSingup.Focus();
                return;
            }
            if (vista.textBoxClaveSingup.Texts == "")
            {
                vista.errorProvider1.SetError(vista.textBoxClaveSingup, "Ingrese su Contraseña");
                vista.textBoxClaveSingup.Focus();
                return;
            }

            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario usuarioIngresado = new Usuario();

            usuarioIngresado.Nombre = vista.textBoxNombre.Texts;
            usuarioIngresado.Email = vista.textBoxEmailSingup.Texts;
            usuarioIngresado.Clave = vista.textBoxClaveSingup.Texts;

            bool seAgrego = userDAO.NuevoUsuario(usuarioIngresado);

            if (seAgrego)
            {
                DesabilitarControles();
                LimpiarControles();
                MessageBox.Show("Usuario Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                InterfazPrincipal app = new InterfazPrincipal();
                vista.Hide();
                app.Show();
            }
            else
            {
                MessageBox.Show("No se pudo insertar el usuario", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }

        private void HabilitarControles()
        {
            vista.textBoxId.Enabled = false;
            vista.textBoxNombre.Enabled = true;
            vista.textBoxClaveSingup.Enabled = true;
            vista.textBoxEmailSingup.Enabled = true;

            vista.buttonCrear.Enabled = false;
            vista.buttonGuardar.Enabled = true;
            vista.buttonVistaSingup.Enabled = true;
        }

        private void LimpiarControles()
        {
            Limpiar limpiar = new Limpiar();
        }

        private void DesabilitarControles()
        {
            vista.textBoxId.Enabled = false;
            vista.textBoxNombre.Enabled = false;
            vista.textBoxEmailSingup.Enabled = false;
            vista.textBoxClaveSingup.Enabled = false;

            vista.buttonGuardar.Enabled = false;
            vista.buttonCrear.Enabled = true;
        }

    }
}
