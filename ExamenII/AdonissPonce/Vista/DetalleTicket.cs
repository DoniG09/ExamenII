using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using POO.Controladores;
using POO.Modelos.DAO;
using POO.Modelos.Entidades;

namespace POO.Vista
{
    public partial class DetalleTicket : Form
    {
        public DetalleTicket()
        {
            InitializeComponent();
            DetalleTicketController controlador = new DetalleTicketController(this); //this hace referencia al formulario actual

        }
    }
}
