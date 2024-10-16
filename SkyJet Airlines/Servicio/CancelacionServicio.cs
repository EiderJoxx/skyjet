using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class CancelacionServicio
    {
        private CancelacionBD cancelacionBD;
        private TicketBD ticketBD;
        public CancelacionServicio()
        {
            ticketBD = new TicketBD();
            cancelacionBD = new CancelacionBD();
        }

        public bool Agregar(Cancelacion cancelacion)
        {
            if (cancelacionBD.ExisteCancelacion(cancelacion.Id))
                return false;

            cancelacionBD.InsertarCancelacion(cancelacion);
            ticketBD.EliminarTicketPorId(cancelacion.IdTicket);
            return true;
        }

        public List<Cancelacion> Lista()
        {
            return cancelacionBD.ListaCancelaciones();
        }

        public List<int> ListaTicketId()
        {
            List<int> list = new List<int>();

            foreach (var item in ticketBD.ListaTickets())
            {
                list.Add(item.Id);
            }

            return list;
        }

        public Ticket GetTicket(int id)
        {
            Ticket ticket = null;

            foreach (var item in ticketBD.ListaTickets())
            {
                if (id == item.Id)
                    ticket = item;
            }

            return ticket;
        }
    }
}
