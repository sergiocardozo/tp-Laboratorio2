using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Enumerado
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        #endregion

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad lectura y escritura de la lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// Propiedad lectura y escritura de la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return profesores; }
            set { profesores = value; }
        }
        /// <summary>
        /// Propiedad lectura y escritura de la Lista de Jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return jornada; }
            set { jornada = value; }
        }
        /// <summary>
        /// Indexador de Jornadas
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Una Jornada en especifica.</returns>
        public Jornada this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Jornadas.Count)
                    return this.Jornadas[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < this.Jornadas.Count)
                    this.Jornadas[index] = value;
                else
                    this.Jornadas.Add(value);
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que inicializa las listas.
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo de clase serializa los datos de Universidad en XML.
        /// </summary>
        /// <param name="uni">Universidad a guardar en el archivo.</param>
        /// <returns>True si se guardo correctamente el archivo.</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> serializer = new Xml<Universidad>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml";
            return serializer.Guardar(path, uni);
        }
        /// <summary>
        /// Metodo de clase que Leera desde un archivo XML una Universidad.
        /// </summary>
        /// <returns>Retornara una Universidad con todos los datos serializados.</returns>
        public static Universidad Leer()
        {
            Xml<Universidad> deserializer = new Xml<Universidad>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Univerdad.xml";
            Universidad retorno;
            deserializer.Leer(path, out retorno);
            return retorno;
        }
        /// <summary>
        /// Metodo privado y de clase que muestra los datos de una Universidad.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Retorna los datos en string.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.Append(jornada.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que hace publico los datos de una Universidad
        /// </summary>
        /// <returns>Retorna los datos de una Universidad.</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Una universidad sera igual a un alumno si el mismo esta inscripto en ella.
        /// </summary>
        /// <param name="g">Universidad a comprobar</param>
        /// <param name="a">Alumno a comprobar</param>
        /// <returns>Resultado de la comparacion</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Una universidad sera distinta a un alumno si el mismo esta inscripto en ella.
        /// </summary>
        /// <param name="g">Universidad a comprobar</param>
        /// <param name="a">Alumno a comprobar</param>
        /// <returns>Resultado de la comparacion</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// Una universidad sera igual a un profesor si el mismo esta dando clases en ella.
        /// </summary>
        /// <param name="g">Universidad a comprobar</param>
        /// <param name="i">Profesor a comprobar</param>
        /// <returns>Resultado de la comparacion</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor == i)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Una universidad sera distinto a un profesor si el mismo esta dando clases en ella.
        /// </summary>
        /// <param name="g">Universidad a comprobar</param>
        /// <param name="i">Profesor a comprobar</param>
        /// <returns>Resultado de la comparacion</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        /// <summary>
        /// Igualacion entre Universidad y clase.
        /// </summary>
        /// <param name="u">Universidad a comprobar</param>
        /// <param name="clase">Clase a comprobar</param>
        /// <returns>El primer profesor capaz de dar la clase, caso contrario lanzara una Excepcion.</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                    return profesor;
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Igualacion entre Universidad y clase.
        /// </summary>
        /// <param name="u">Universidad a comprobar</param>
        /// <param name="clase">Clase a comprobar</param>
        /// <returns>El primer profesor que no puede dar la clase, caso contrario lanzara una Excepcion.</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor != clase)
                    return profesor;
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// Agrega una clase a una Universidad.
        /// </summary>
        /// <param name="g">Universidad a verificar</param>
        /// <param name="clase">Clase a verificar</param>
        /// <returns>Una universidad con su Jornada, Profesor y su lista de Alumnos.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, g == clase);
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                    jornada.Alumnos.Add(alumno);
            }
            g.Jornadas.Add(jornada);
            return g;
        }
        /// <summary>
        /// Agrega un Alumno a una Universidad validando que no este previamente cargado.
        /// </summary>
        /// <param name="u">Universidad a verificar</param>
        /// <param name="a">Alumno a verificar</param>
        /// <returns>Una universidad con un alumno cargado, caso contrario lanzara una Excepcion.</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u == a)
                throw new AlumnoRepetidoException();
            u.Alumnos.Add(a);
            return u;
        }
        /// <summary>
        /// Agrega un Profesor a una Universidad validando que no este previamente cargado.
        /// </summary>
        /// <param name="u">Universidad a verificar</param>
        /// <param name="i">Profesor a verificar</param>
        /// <returns>Retorna una universidad con un Profesor si es correctamente cargado.</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
                u.Instructores.Add(i);
            return u;
        }

        #endregion
    }

}
