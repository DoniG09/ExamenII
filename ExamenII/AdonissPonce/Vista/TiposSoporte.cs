using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;

namespace POO.Vista
{
 
    public partial class TiposSoporte : Form
    {
        MostrarDatos objetoMD = new MostrarDatos();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario user = new Usuario();

        public string soporteSeleccionado = "";
        
        public TiposSoporte()
        {
            LoginSingin datos = new LoginSingin();
            InitializeComponent();
            buttonAceptar.Enabled = false;
            this.ActiveControl = label3;
            labelSoporteSeleccionado.Text = "";
        }

       

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoSoporte.SelectedItem == null)
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Soporte");
                comboBoxTipoSoporte.Text = comboBoxTipoSoporte.Tag.ToString();
            }
            else
            {
                soporteSeleccionado = comboBoxTipoSoporte.SelectedItem.ToString();
                buttonSeleccionar.Enabled = true;
                labelSoporteSeleccionado.Text = soporteSeleccionado;
                buttonAceptar.Enabled = true;
            }
        }

        private void TiposSoporte_Paint(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            // Establecemos la nueva posición del control Label.
             labelSoporteSeleccionado.Location = new Point(c - labelSoporteSeleccionado.Width / 2, labelSoporteSeleccionado.Location.Y);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Su solicitud ha sido enviada");
        }

        private void TiposSoporte_Load(object sender, EventArgs e)
        {
           LoadDatosUsuario();
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            //dataGridViewTicketsGenerados.DataSource = usuarioDAO.GetUsuariosNombre();
        }

        private void LoadDatosUsuario()
        {
           
            labelCorreoPanel.Text = GuardarDatosCache.Nombre;
        }
    }
}
