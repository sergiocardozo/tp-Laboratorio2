using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clases;
        private Profesor instructor;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad lectura y escritura de la lista de Alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// Propiedad Lectura y escritura del enumerado Clase.
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return clases; }
            set { this.clases = value; }
        }
        /// <summary>
        /// Propiedad lectura y escritura de la clase Profesor.
        /// </summary>
        public Profesor Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado que inicializa la Lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor que inicializa una clase y instructor.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.clases = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que guardara los de datos de la Jornada en un archivo .txt
        /// </summary>
        /// <param name="jornada">Jornada a guardar en el archivo.</param>
        /// <returns>El archivo si fue guardado correctamente</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto archivo = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt";
            return archivo.Guardar(path, jornada.ToString());
        }
        /// <summary>
        /// Leera desde un archivo una Jornada
        /// </summary>
        /// <returns>Retornara los datos de la Jornada leidas del .txt</returns>
        public static string Leer()
        {
            Texto archivo = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Jornada.txt";
            archivo.Leer(path, out string datos);
            return datos;
        }
        /// <summary>
        /// Metodo que mostrara los datos de una Jornada
        /// </summary>
        /// <returns>Los datos en String.</returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"CLASE DE: {this.Clase.ToString()} POR {this.Instructor}"));
            sb.AppendLine("ALUMNOS");
            foreach (Alumno alumno in Alumnos)
            {
                sb.Append(string.Format(alumno.ToString()));
            }
            sb.AppendLine("<------------------------------------------------------------->");
            return sb.ToString();
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Una Jornada sera igual a un Alumno si el mismo participa en la clase.
        /// </summary>
        /// <param name="j">Jornada a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns>Resultado de la comparacion.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Universitario alumno in j.Alumnos)
            {
                if (alumno.Equals(a))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Una Jornada sera distinto a un Alumno si el mismo participa en la clase
        /// </summary>
        /// <param name="j">Jornada a comprobar</param>
        /// <param name="a">Alumno a comprobar</param>
        /// <returns>Resultado de la comparacion.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// Agrega Alumnos a la clase verificando que no este previamente cargado
        /// </summary>
        /// <param name="j">Jornada a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns>Retorna el Alumno cargado en la Jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.Alumnos.Add(a);
            return j;
        }
        #endregion

    }
}
