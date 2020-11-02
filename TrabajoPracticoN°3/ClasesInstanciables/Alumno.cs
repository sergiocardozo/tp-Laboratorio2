using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Enumerado
        public enum EEstadoCuenta { AlDia, Deudor, Becado }
        #endregion

        #region Atributos
        private Universidad.EClases clasesQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno()
        {

        }
        /// <summary>
        /// Constructor que inicializa atributos de la clase heredad y la clase que toma. 
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del Alumno</param>
        /// <param name="apellido">Apellido del Alumno</param>
        /// <param name="dni">DNI del Alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="clasesQueToma">Clase Que Toma el Alumno</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesQueToma = clasesQueToma;
        }
        /// <summary>
        /// Inicializa el estado de cuenta del Alumno.
        /// </summary>
        /// <param name="id">Legajo del Alumno</param>
        /// <param name="nombre">Nombre del Alumno</param>
        /// <param name="apellido">Apellido del Alumno</param>
        /// <param name="dni">DNI del Alumno</param>
        /// <param name="nacionalidad">Nacionalidad del Alumno</param>
        /// <param name="clasesQueToma">Clase Que Toma el Alumno</param>
        /// <param name="estadoCuenta">Estado de cuenta del Alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del Metodo que va a mostrar todos los datos de un Alumno.
        /// </summary>
        /// <returns>Retorna los datos en String</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            string cuenta = "";
            switch (estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    cuenta = "Cuota al Dia";
                    break;
                case EEstadoCuenta.Deudor:
                    cuenta = "Deudor";
                    break;
                case EEstadoCuenta.Becado:
                    cuenta = "Becado";
                    break;
            }
            sb.AppendLine(string.Format($"ESTADO DE CUENTA: {cuenta}"));
            sb.AppendLine(ParticipaEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga que va a mostrar las clases en las que participa un Alumno.
        /// </summary>
        /// <returns>Retorna la clase que toma el alumno en string.</returns>
        protected override string ParticipaEnClase()
        {
            return string.Format($"TOMA CLASE DE {this.clasesQueToma}");
        }
        /// <summary>
        /// Metodo que hace publico los datos de un Alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Comprueba si un Alumno toma una clase determinada y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">Alumno a comprobar</param>
        /// <param name="clase">clase a verificar</param>
        /// <returns>Retorna el resultado de la comparacion.</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return a.clasesQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor;
        }
        /// <summary>
        /// Comprueba si un alumno no toma una clase determinada.
        /// </summary>
        /// <param name="a">Alumno a comprobar</param>
        /// <param name="clase">Clase a comprobar</param>
        /// <returns>Retorna el resultado de la comparacion.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.clasesQueToma != clase;
        } 
        #endregion

    }
}
