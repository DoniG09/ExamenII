using POO.Modelos.DAO;
using POO.Modelos.Entidades;
using POO.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Controladores
{
    
    public class GenerarTickerController
    {
        GenerarTicket vista; //vista = Formulario LoginSingin
        public string soporteSeleccionado = "";
        TicketDAO ticketDao = new TicketDAO();
        Ticket ticketCreado = new Ticket();
        //EstadoTicket estado = new EstadoTicket();
        public static int numTicket = 100;
        //int numEstado, ;
        //string estadoTicket;

        public GenerarTickerController(GenerarTicket view)
        {
            vista = view; //vista toma los valores de view
            vista.buttonGenerar.Click += new EventHandler(Generar);
            vista.Load += new EventHandler(CargarDataGried);
        }

        private void Generar(object sender, EventArgs e)
        {
            numTicket = numTicket + 1;

            if (numTicket <1)
            {
                numTicket = numTicket + Convert.ToInt32(vista.dataGridViewTicketsGenerados.CurrentRow.Cells["Numero"].Value);
            }

            vista.labelTicket.Text = numTicket.ToString();
            vista.labelTicketPanel.Text = numTicket.ToString();
            vista.labelMsj.Show();
          
            ticketCreado.NumeroTicket = numTicket;
            
            bool seAgrego = ticketDao.NuevoTicket(ticketCreado);

            if (seAgrego)
            {
                MessageBox.Show("Ticket Generado Exitosamente", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                vista.buttonGenerar.Enabled = false;
                
                
            }
            else
            {
                MessageBox.Show("No se pudo generar el ticket", "Atención", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void CargarDataGried(object sender, EventArgs e)
        {
            vista.dataGridViewTicketsGenerados.DataSource = ticketDao.GetTicket();
        }


    }
}
