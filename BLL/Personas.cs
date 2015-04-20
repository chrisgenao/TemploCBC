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
    public class Personas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Celula { get; set; }
        public int Grupo { get; set; }
        public string FormaPago { get; set; }
        public int Balance { get; set; }
        public DateTime Fecha { get; set; }

        public Personas()
        {
            this.IdPersona = 0;
            this.Nombre = string.Empty;
            this.Cedula = string.Empty;
            this.Celula = string.Empty;
            this.Grupo = 0;
            this.FormaPago = string.Empty;
            this.Balance = 0;
            this.Fecha = DateTime.Now;
        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdPersona = 0;

            this.IdPersona = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Personas (Nombre, Cedula, Celula, Grupo, FormaPago, Balance, Fecha) values ('" + this.Nombre + "', '" + this.Cedula + "', '" + this.Celula + "', " + this.Grupo + ", '" + this.FormaPago + "', "+this.Balance+", GETDATE()) Select @@IDENTITY"));

            paso = this.IdPersona > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Personas set Nombre = '" + this.Nombre + "', Cedula= '" + this.Cedula + "', Celula ='" + this.Celula +
                "', Grupo = " + this.Grupo + ", FormaPago = '" + this.FormaPago + "', Balance = "+this.Balance+" where IdPersona =" + this.IdPersona);


            return paso;//End Modificar
        }

        public Boolean ModificarPago(int IdActualizado)
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Personas set Balance = " + this.Balance + " where IdPersona =" + IdActualizado);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Personas where IdPersona = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombre, Cedula, Celula, Grupo, FormaPago, Balance", "IdPersona = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPersona = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
                this.Cedula = (string)dt.Rows[0]["Cedula"];
                this.Celula = (string)dt.Rows[0]["Celula"];
                this.Grupo = (int)dt.Rows[0]["Grupo"];
                this.FormaPago = (string)dt.Rows[0]["FormaPago"];
                this.Balance = (int)dt.Rows[0]["Balance"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Personas where " + Filtro);
        }
    }
}


