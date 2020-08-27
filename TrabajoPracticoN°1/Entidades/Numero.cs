using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero; 
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad solo escritura. Inicializa un objeto de tipo numero y valida que sea correcto.
        /// </summary>
        public string SetNumero
        {
            set { numero = ValidarNumero(value); }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, instancia el objeto de tipo numero en 0.
        /// </summary>
        public Numero()
        {
            numero = 0;
        }
        /// <summary>
        /// Inicializa una instancia del tipo Numero recibiendo un numero del tipo double.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Inicializa una instancia del tipo Numero recibiendo un string validando que sea un valor correcto.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        #endregion

        #region Metodos
        /// <summary>
        ///  Metodo de clase que comprueba que el valor recibido sea numerico.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el valor recibido en formato double, caso contrario retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;
            if (Double.TryParse(strNumero, out retorno))
                return retorno;
            else
                return 0;
        }
        /// <summary>
        /// Valida que la cadena este compuesta solo por 0 o 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna True si la cadena es correcta, caso contrario False.</returns>
        private bool EsBinario(string binario)
        {
            if (binario == "0" || binario == "1")
                return true;
            else
                return false;
        }
        /// <summary>
        /// Convierte un dato de tipo string a un string en Decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna el resultado si es correcto, caso contrario retornara "Valor Inválido".</returns>
        public string BinarioDecimal(string binario)
        {
            foreach (char caracter in binario)
            {
                if (!EsBinario(Convert.ToString(caracter)))
                    return "Valor Inválido";
                else
                    return Convert.ToUInt64(binario, 2).ToString();
            }
            return binario;
        }
        /// <summary>
        /// Convierte un dato de tipo string a un string en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el resultado si logra hacer la conversion, caso contrario retorna "Valor invalido".</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDecimal;
            if (Double.TryParse(numero, out numeroDecimal))
                return DecimalBinario(numeroDecimal);
            else
                return "Valor Inválido";
        }
        /// <summary>
        /// Convierte un dato de tipo double a un string binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna el resultado de la conversion.</returns>
        public string DecimalBinario(double numero)
        {
            long sinSigno = Convert.ToInt64(Math.Abs(numero));
            if (numero > 0)
                return Convert.ToString(sinSigno, 2);
            else
                return "Valor Inválido";
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Metodo estatico suma dos atributos entre dos objetos del tipo numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la suma de los atributos.</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Metodo estatico resta dos atributos entre dos objetos del tipo numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la resta de los atributos.</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Metodo estatico multiplica dos atributos entre dos objetos del tipo numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la multiplicacion de los atributos.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Metodo estatico divide dos atributos entre dos objetos del tipo numero.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el resultado de la division de los atributos si el segundo operando no es 0, </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }
        #endregion

    }
}
