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
    public class Celulas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdCelula { get; set; }
        public string Nombre { get; set; }

        public Celulas()
        {
            this.IdCelula = 0;
            this.Nombre = string.Empty;

        }

        public Boolean Insertar()
        {
            bool paso = false;

            this.IdCelula = 0;

            this.IdCelula = Convert.ToInt32(Conexion.ObtenerValorDb("insert into Celulas (Nombre) values ('" + this.Nombre +"') Select @@IDENTITY"));

            paso = this.IdCelula > 0;

            if (paso)
            {

            }

            return paso;

        }

        public Boolean Modificar()
        {
            Boolean paso = false;

            paso = Conexion.EjecutarDB("Update Celulas set Nombre = '" + this.Nombre + "' where IdCelula =" + this.IdCelula);


            return paso;//End Modificar
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Celulas where IdCelula = " + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Nombre", "IdCelula = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdCelula = IdBuscado;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Celulas where " + Filtro);
        }
    }
}


