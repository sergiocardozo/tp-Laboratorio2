using LogicApp.Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.PersistenciaDeDatos
{
    public abstract class ConexionSQL
    {
        private static SqlConnection connection;
        private static SqlCommand command;
      
        /// <summary>
        /// Propiedad solo lectura de la Conexion a SQL
        /// </summary>
        protected static SqlConnection Conexion
        {
            get { return ConexionSQL.connection; }            
        }
        /// <summary>
        /// Propiedad solo lectura de los Comandos
        /// </summary>
        protected static SqlCommand Comando
        {
            get { return ConexionSQL.command; }          
        }
        /// <summary>
        /// Constructor de clase que inicializa la conection string.
        /// </summary>
        static ConexionSQL()
        {
            ConexionSQL.connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=DBPlayForFun;Trusted_Connection=true;");
            ConexionSQL.command = new SqlCommand();
            ConexionSQL.command.Connection = ConexionSQL.connection;
        }

        /// <summary>
        /// Metodo Que va a abrir una nueva conexion a la base de datos y terminado el proceso la cierra
        /// </summary>
        protected static void Ejecutar()
        {
            try
            {
                ConexionSQL.Conexion.Open();
                ConexionSQL.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new SistemaVentasException("Ocurrio un error al ingresar a la base de datos", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                    ConexionSQL.Conexion.Close();
            }
        }
    }
}
