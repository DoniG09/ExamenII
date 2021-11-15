using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;
using POO.Vista;

namespace POO.Controladores
{
    public class TipoSoporteController
    {
        TiposSoporte vista; //vista = Formulario LoginSingin
        public string soporteSeleccionado = "";
        TipoSoporteDAO tipoSopDao = new TipoSoporteDAO();
        TipoSoporteElegido soporte = new TipoSoporteElegido();
        public TipoSoporteController(TiposSoporte view)
        {
            vista = view; //vista toma los valores de view

            vista.buttonAceptar.Enabled = false;
            vista.ActiveControl = vista.label3;
            vista.labelSoporteSeleccionado.Text = "";

            vista.buttonSeleccionar.Click += new EventHandler(SoporteElegido);

            vista.Paint += new PaintEventHandler(Centrar);

            vista.buttonAceptar.Click += new EventHandler(Enviado);
            vista.buttonAceptar.Click += new EventHandler(Seleccionar);

            vista.Load += new EventHandler(Llamadas);//Pendiente

        }
        private void SoporteElegido(object sender, EventArgs e)
        {
            if (vista.comboBoxTipoSoporte.SelectedItem == null)
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Soporte");
                vista.comboBoxTipoSoporte.Text = vista.comboBoxTipoSoporte.Tag.ToString();
            }
            else
            {
                soporteSeleccionado = vista.comboBoxTipoSoporte.SelectedItem.ToString();
                vista.buttonSeleccionar.Enabled = true;
                vista.labelSoporteSeleccionado.Text = soporteSeleccionado;
                vista.buttonAceptar.Enabled = true;
            }
        }
        private void Centrar(object sender, PaintEventArgs e)
        {
            // Área cliente del formulario.
            //
            Rectangle r = vista.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            // Establecemos la nueva posición del control Label.
            vista.labelSoporteSeleccionado.Location = new Point(c - vista.labelSoporteSeleccionado.Width / 2, vista.labelSoporteSeleccionado.Location.Y);

        }

        private void Enviado(object sender, EventArgs e)
        {
            MessageBox.Show("Su solicitud ha sido enviada");
        }

        private void Seleccionar(object sender, EventArgs e)
        {

            soporte.SoporteRequerido = (vista.comboBoxTipoSoporte.SelectedItem).ToString();

            bool seAgrego = tipoSopDao.NuevoSoporte(soporte);

            if (seAgrego)
            {
                MessageBox.Show("El estado de su ticket es: " + (vista.comboBoxTipoSoporte.SelectedItem).ToString(), "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                vista.buttonAceptar.Enabled = false;
            }
        }

        private void Llamadas(object sender, EventArgs e)
        {
            //LoadDatosUsuario();
            //ListarUsuarios();
        }

     }
}
