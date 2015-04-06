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
        public string Tanda2 { get; set; }

        public Loterias()
        {
            this.IdLoteria = 0;
            this.Loteria = String.Empty;
            this.Tanda = String.Empty;
            this.Tanda2 = String.Empty;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdLoteria = 0;

            this.IdLoteria = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Loterias (Loteria, Tanda, Tanda2) values ('" + this.Loteria + "', '" + this.Tanda + "', '"+this.Tanda2+"') Select @@IDENTITY"));

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
                "', Tanda2 = '"+this.Tanda2+"' where IdLoteria = " + this.IdLoteria);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Loterias where IdLoteria=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Loteria,Tanda, Tanda2", "IdLoteria=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(dt.Rows[0]["Tanda2"].ToString())) //Corregir
                {//ejemplo
                    Encontro = true;

                    this.IdLoteria = IdBuscado;
                    this.Loteria = (string)dt.Rows[0]["Loteria"];
                    this.Tanda = (string)dt.Rows[0]["Tanda"];
                    
                }
                else {
                    Encontro = true;

                    this.IdLoteria = IdBuscado;
                    this.Loteria = (string)dt.Rows[0]["Loteria"];
                    this.Tanda = (string)dt.Rows[0]["Tanda"];
                    this.Tanda2 = (string)dt.Rows[0]["Tanda2"];
                }
            }
            return Encontro;
        }

        public DataTable ListarTandas(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Loterias where IdLoteria = " + Filtro);
        }
        
        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Loterias where " + Filtro);
        }
    }
}
