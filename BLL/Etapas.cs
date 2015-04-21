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
    public class Etapas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdEtapa { get; set; }
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public double MontoPendiente { get; set; }

        public Etapas()
        {
            this.IdEtapa = 0;
            this.Nombre = string.Empty;
            this.Monto = 0;
            this.MontoPendiente = 0;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdEtapa = 0;

            this.IdEtapa = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Etapas (Nombre, Monto, MontoPendiente) values ('" + this.Nombre + "', " + this.Monto + ", "+this.MontoPendiente+") Select @@IDENTITY"));

            paso = this.IdEtapa > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Etapas set Nombre = '" + this.Nombre + "', Monto = " + this.Monto + ", MontoPendiente = " + this.MontoPendiente + " where IdEtapa =" + this.IdEtapa);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Etapas where IdEtapa = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombre, Monto, MontoPendiente", "IdEtapa = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdEtapa = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
                this.Monto = (double)dt.Rows[0]["Monto"];
                this.MontoPendiente = (double)dt.Rows[0]["MontoPendiente"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Etapas where " + Filtro);
        }

        public DataTable ListarEtapa(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Etapas where IdEtapa = " + Filtro);
        }

        public Boolean AfectarBalance(int IdEtapa, double ValorDisminuir)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Etapas Set MontoPendiente = MontoPendiente -" + ValorDisminuir.ToString() + "Where IdEtapa=" + IdEtapa.ToString());

        }
    }
}
