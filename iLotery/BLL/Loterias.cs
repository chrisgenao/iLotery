using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class Loterias
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdLoteria { get; set; }
        public string Loteria { get; set; }
        public string Tanda { get; set; }

        public Loterias()
        {
            this.IdLoteria = 0;
            this.Loteria = String.Empty;
            this.Tanda = String.Empty;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdLoteria = 0;

            this.IdLoteria = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Loterias (Loteria, Tanda) values ('" + this.Loteria + "', '" + this.Tanda + "') Select @@IDENTITY"));

            paso = this.IdLoteria > 0;

            if (paso)
            {

            }

            return paso;
        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Loterias set Loteria = '" + this.Loteria + "', Tanda ='" + this.Tanda +
                "' where IdLoteria =" + this.IdLoteria);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Loterias where IdLoteria=" + IdBuscado);
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Loterias where " + Filtro);
        }
    }
}
