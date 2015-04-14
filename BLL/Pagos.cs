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
    public class Pagos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdPago { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public int Monto { get; set; }
        public int MontoPendiente { get; set; }
        public DateTime Fecha { get; set; }

        public Pagos()
        {
            this.IdPago = 0;
            this.IdPersona = 0;
            this.Nombre = string.Empty;
            this.Monto = 0;
            this.MontoPendiente = 0;
            this.Fecha = DateTime.Today;
        }

        public Boolean Insertar(int IdPersona, string Nombre, int Monto, int MontoPendiente)
        {
            bool paso = false;

            this.IdPago = 0;

            this.IdPago = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Pagos (IdPersona, Nombre, Monto, MontoPendiente, Fecha) values (" + IdPersona + ",'" + Nombre + "', " + Monto + ", " + MontoPendiente + ", GETDATE()) Select @@IDENTITY"));

            paso = this.IdPago > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;
            //Terminar de aqui hacia abajo.
            paso = Conexion.EjecutarDB("Update Pagos set Nombre = '" + this.Nombre + "' where IdPago =" + this.IdPago);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Pagos where IdPago = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombre", "IdPago = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPago = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Pagos where " + Filtro);
        }

        public DataTable ListarPago()
        {      
            return Conexion.BuscarDb("Select * from Pagos where IdPago = (SELECT MAX(IdPago) from Pagos)");
        }

    }
}
