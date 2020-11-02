using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estatico que inicializa el atributo Random.
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {

        }
        /// <summary>
        /// Constructor que inicializa un Profesor tomando como base al constructor de Universitario.
        /// </summary>
        /// <param name="id">Legajo del Profesor</param>
        /// <param name="nombre">Nombre del Profesor</param>
        /// <param name="apellido">Apellido del Profesor</param>
        /// <param name="dni">DNI del Profesor</param>
        /// <param name="nacionalidad">Nacionalidad del Profesor</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que agrega una clase aleatoria a la cola.
        /// </summary>
        private void _randomClases()
        {
            clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));
            Thread.Sleep(1000);
        }
        /// <summary>
        /// Metodo que muestra la clase en la que participa el Profesor.
        /// </summary>
        /// <returns>Retorna la clase en string.</returns>
        protected override string ParticipaEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA");
            foreach (Universidad.EClases clases in clasesDelDia)
            {
                sb.AppendLine(clases.ToString());

            }
            return sb.ToString();
        }
        /// <summary>
        /// Metodo protegido que muestra los datos del Profesor.
        /// </summary>
        /// <returns>Retorna los datos en String.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(ParticipaEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que hace publico los datos del Profesor
        /// </summary>
        /// <returns>Retorna todos los datos.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Un Profesor sera igual a una Clase si da esa clase.
        /// </summary>
        /// <param name="i">Instructor a verificar</param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns>Retorna el resultado de la comparacion.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }
        /// <summary>
        /// Un profesor sera distinto a una clase si no da esa clase
        /// </summary>
        /// <param name="i">Instructor a comprobar</param>
        /// <param name="clase">Clase a comprobar</param>
        /// <returns>REsultado de la comparacion.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion

    }
}
