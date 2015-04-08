using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class TicketsDetalles
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdTicketDetalle { get; set; }
        public DateTime Fecha { get; set; }
        
        public TicketsDetalles()
        {
            this.IdTicketDetalle = 0;
            this.Fecha = DateTime.Now;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdTicketDetalle = 0;

            this.IdTicketDetalle = Convert.ToInt32(Conexion.ObtenerValorDb("insert into TicketDetalle (Fecha) values (GETDATE())"));
            paso = this.IdTicketDetalle > 0;

            if (paso)
            {

            }

            return paso;
        }

    }
}
