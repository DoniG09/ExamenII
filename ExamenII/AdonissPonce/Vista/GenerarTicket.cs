using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO.Controladores;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;

namespace POO.Vista
{
    public partial class GenerarTicket : Form
    {
        TicketDAO ticketDao = new TicketDAO();
        //TicketDAO ticketn = new TicketDAO();
        //Ticket nuevoTicket = new Ticket();
        //EstadoTicket estado = new EstadoTicket();
        //int numEstado, numTicket; 

        //string estadoTicket;
        public GenerarTicket()
        {
            InitializeComponent();
            this.dataGridViewTicketsGenerados.DataSource = ticketDao.GetTicket();
            labelMsj.Hide();
            GenerarTickerController controlador = new GenerarTickerController(this); //this hace referencia al formulario actual
        }

        //        private void buttonGenerar_Click(object sender, EventArgs e)
        //        {
        //            numTicket = numTicket + 1;

        //#pragma warning disable SecurityIntelliSenseCS // MS Security rules violation
        //            Random rand = new Random();
        //#pragma warning restore SecurityIntelliSenseCS // MS Security rules violation

        //            numEstado = rand.Next(1, 5);

        //            switch (numEstado)
        //            {
        //                case 1:
        //                    estadoTicket = "Sin resolver";
        //                    break;
        //                case 2:
        //                    estadoTicket = "Abierto";
        //                    break;
        //                case 3:
        //                    estadoTicket = "En espera";
        //                    break;
        //                case 4:
        //                    estadoTicket = "Cerrado";
        //                    break;
        //            }

        //            MessageBox.Show(estadoTicket);
        //            MessageBox.Show(numTicket.ToString());

        //            TicketDAO ticketDao = new TicketDAO();

        //            Ticket ticketCreado = new Ticket();

        //            ticketCreado.NumeroTicket = numTicket;
        //            ticketCreado.EstadoTicket = estadoTicket;

        //        }
    }
}
