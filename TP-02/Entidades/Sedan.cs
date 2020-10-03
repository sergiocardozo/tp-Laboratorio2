using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Enumerados
        /// <summary>
        /// Enumerado que define el tipo de vehiculo sedan
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas, CincoPuertas
        }
        #endregion

        #region Atributo
        private ETipo tipo; 
        #endregion

        #region Constructor
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        /// <summary>
        /// Constructor que inicializa atributos utilizando la clase base e inicializa el tipo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="etipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo etipo)
            : base(chasis, marca, color)
        {
            tipo = etipo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly. Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que sobreescribe los datos de la clase base y añade el tamaño
        /// </summary>
        /// <returns>Retorna el mensaje en string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine(" TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        } 
        #endregion
    }
}
