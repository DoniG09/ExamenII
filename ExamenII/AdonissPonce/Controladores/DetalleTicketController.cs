using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Controladores;
using POO.Vista;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;
using System.Windows.Forms;

namespace POO.Controladores
{
    class DetalleTicketController
    {

        EstadoTick gestionEstadoTicket = new EstadoTick();
        EstadoTicket vistaEstado = new EstadoTicket();
        
        Usuario usuarioPropietario = new Usuario();
        Ticket numeroTicket = new Ticket();
        TipoSoporteElegido soporteRequerido = new TipoSoporteElegido();
        DetalleDeTicket detalleGenerado = new DetalleDeTicket();
        DetalleTicketDAO detalleTicketDAO = new DetalleTicketDAO();

        static string estadoTickt;
        string propietarioTickt;
        int numeroTickt;
        string soportRequerido;

        DetalleTicket vista; //vista = Formulario 

        public DetalleTicketController(DetalleTicket view)
        {
            vista = view; //vista toma los valores de view
            
            vista.Load += new EventHandler(LlenarVariables);

            vista.Load += new EventHandler(CargarDataGried);
        }

        private void LlenarVariables(object sender, EventArgs e)
        {
            

             estadoTickt = gestionEstadoTicket.EstadoDeTicket;
            propietarioTickt = usuarioPropietario.Nombre;
            numeroTickt = numeroTicket.NumeroTicket;
            soportRequerido = soporteRequerido.SoporteRequerido;

            detalleGenerado.EstadoDelTicket = estadoTickt;
            detalleGenerado.NombreDueñoDelTicket = propietarioTickt;
            detalleGenerado.NumeroDelTicket = numeroTickt;
            detalleGenerado.SoporteRequeridoElegido = soportRequerido;

            bool seAgrego = detalleTicketDAO.LlenarDetalle(detalleGenerado);

            if (seAgrego)
            {
                MessageBox.Show("Hols");
            }
        }

        private void CargarDataGried(object sender, EventArgs e)
        {
            vista.dataGridViewTicketsGenerados.DataSource = detalleTicketDAO.GetDetalles();
        }



    }

   

}
