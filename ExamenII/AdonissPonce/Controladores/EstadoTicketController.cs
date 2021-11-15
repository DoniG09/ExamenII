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
    public class EstadoTicketController
    {
        EstadoTicket vista; //vista = Formulario LoginSingin
        //public string soporteSeleccionado = "";
        TicketDAO ticketDao = new TicketDAO();
        Ticket ticketCreado = new Ticket();
        EstadoTicketDAO estadoDao = new EstadoTicketDAO();
        EstadoTick gestionEstadoTicket = new EstadoTick();
        int numEstado;
        public static string estadoTicket;

        public EstadoTicketController(EstadoTicket view)
        {
            vista = view; //vista toma los valores de view
            vista.buttonVerificar.Click += new EventHandler(ValidacionTicket);
            vista.buttonVerificar.Click += new EventHandler(GestionarEstado);
            vista.buttonVerificar.Click += new EventHandler(Gestionar);
            vista.Load += new EventHandler(CargarDataGried);
        }

        private void ValidacionTicket(object sender, EventArgs e)
        {

            bool ticketValido = false;

            TicketDAO ticketDao = new TicketDAO();
            Ticket ticketGenerado = new Ticket();

            if(vista.textBoxNumTicket.Texts != "")
            {
                ticketGenerado.NumeroTicket = Convert.ToInt32(vista.textBoxNumTicket.Texts);

                ticketValido = ticketDao.ValidarTicket(ticketGenerado);

                if (ticketValido == true)
                {
                    MessageBox.Show("Su ticket ha sido localizado");
                }
                else
                {
                    MessageBox.Show("Su ticket no ha sido localizado");
                    vista.textBoxNumTicket.Texts = "";
                }
                
            }
            else
            {
                MessageBox.Show("Debe Digitar su Ticket");
            }

        }

        private void GestionarEstado(object sender, EventArgs e)
        {
            #pragma warning disable SecurityIntelliSenseCS // MS Security rules violation
            Random rand = new Random();
            #pragma warning restore SecurityIntelliSenseCS // MS Security rules violation

            numEstado = rand.Next(1, 5);

            switch (numEstado)
            {
                case 1:
                    estadoTicket = "Sin resolver";
                    break;
                case 2:
                    estadoTicket = "Abierto";
                    break;
                case 3:
                    estadoTicket = "En espera";
                    break;
                case 4:
                    estadoTicket = "Cerrado";
                    break;
            }

            

            TicketDAO ticketDao = new TicketDAO();

            Ticket ticketCreado = new Ticket();

            ticketCreado.EstadoTicket = estadoTicket;

            vista.labelEstadoPanel.Text = estadoTicket;
            vista.labelTicketPanel.Text = "                   " + vista.textBoxNumTicket.Texts;
        }

        private void Gestionar(object sender, EventArgs e)
        {
            if (vista.textBoxNumTicket.Texts != "")
            {
                gestionEstadoTicket.EstadoDeTicket = estadoTicket;

                bool seAgrego = estadoDao.NuevoEstado(gestionEstadoTicket);

                if (seAgrego)
                {
                    MessageBox.Show("El estado de su ticket es: " + estadoTicket,
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vista.buttonVerificar.Enabled = false;
                }
            }
            
        }

        private void CargarDataGried(object sender, EventArgs e)
        {
            vista.dataGridViewTicketsEstado.DataSource = estadoDao.GetEstado();
        }
    }

    
}
