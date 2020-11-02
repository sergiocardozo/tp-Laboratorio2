using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        ///  Constructor que hereda el constructor base de persona 
        /// e inicializa el atributo legajo de la clase Universitario
        /// </summary>
        /// <param name="legajo">Legajo del universitario</param>
        /// <param name="nombre">Nombre del universitario</param>
        /// <param name="apellido">Apellido del universitario</param>
        /// <param name="dni">DNI del universitario</param>
        /// <param name="nacionalidad">Nacionalidad del universitario</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo protegido y virtual que muestra todos los datos de un universitario
        /// </summary>
        /// <returns>Retorna todos los datos en string.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format($"LEGAJO: {this.legajo}"));
            return sb.ToString();
        }
        /// <summary>
        /// Metodo abstracto sin implementacion.
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticipaEnClase();
        /// <summary>
        /// Dos universitarios son iguales si y solo si son del mismo tipo y su legajo o DNI son iguales.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>Retorna el resultado de la comparacion.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                if ((this.legajo == ((Universitario)obj).legajo || this.DNI == ((Universitario)obj).DNI))
                    return true;
            }
            return false;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Compara dos Universitarios para saber si son iguales reutilizando el metodo Equals.
        /// </summary>
        /// <param name="pg1">Universitario a comparar</param>
        /// <param name="pg2">Universitario a comparar</param>
        /// <returns>Retorna el resultado de la comparacion</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }
        /// <summary>
        /// Compara dos Universitarios para saber si son distintos.
        /// </summary>
        /// <param name="pg1">Univertario a comparar</param>
        /// <param name="pg2">Universitario a comparar.</param>
        /// <returns>Retorna el resultado de la comparacion.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion

    }
}
