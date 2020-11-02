using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }

        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad lectura y escritura de Nombre. Valida antes de ingresarlo.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                    this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad Lectura y escritura de Apellido. Valida antes de ingresarlo.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                    this.apellido = value;
            }
        }
        /// <summary>
        /// Propiedad lectura y escritura. Valida DNI antes de ingresarlo
        /// </summary>
        public int DNI
        {
            get { return dni; }
            set
            {
                dni = ValidarDni(this.Nacionalidad, value);
            }
        }
        /// <summary>
        /// Propiedad lectura y escritura Nacionalidad de la persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Propiedad solo Escritura del DNI. Lo valida antes de ingresarlo
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.Nacionalidad, value); }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public Persona()
        {
        }
        /// <summary>
        /// Constructor inicializa atributos de la persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Constructor inicializa atributos de la persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">Dni de la persona solo numeros</param>
        /// <param name="nacionalidad">nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor inicializa atributos de la persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">Dni de la persona como string</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga de ToString que hace publico los datos de una persona.
        /// </summary>
        /// <returns>Retorna los datos de una persona en string.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}"));
            sb.AppendLine(string.Format($"NACIONALIDAD: {this.Nacionalidad}"));

            return sb.ToString();
        }
        /// <summary>
        /// Validacion del DNI en tipo int
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI a comprobar</param>
        /// <returns>Retorna el dni si es valido, caso contrario lanza excepcion.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && dato > 89999999)
                throw new NacionalidadInvalidaException();
            if (nacionalidad == ENacionalidad.Extranjero && dato < 90000000)
                throw new NacionalidadInvalidaException();
            if (dato < 1 || dato > 99999999)
                throw new DniInvalidoException();
            return dato;
        }
        /// <summary>
        /// Validacion del DNI en tipo String.
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI a comprobar</param>
        /// <returns>Retorna el dni si es valido, caso contrario lanza excepcion.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            if (!Int32.TryParse(dato, out int dni))
                throw new DniInvalidoException();
            else
                return ValidarDni(nacionalidad, dni);
        }
        /// <summary>
        /// Validacion del atributo Nombre y Apellido
        /// </summary>
        /// <param name="dato">Texto a comprobar.</param>
        /// <returns>Retorna el atributo si es correcto, caso contrario retorna null.</returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char letra in dato)
            {
                if (!(char.IsLetter(letra) || char.IsWhiteSpace(letra)))
                    return null;
            }
            return dato;
        }
        #endregion
    }
}
