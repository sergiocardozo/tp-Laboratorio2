using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Metodo que valida que el operador sea una suma, resta, multiplicacion o division.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el operador convertido en string caso contrario retornara +</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')

                return Convert.ToString(operador);
            else
                return "+";
        }
        /// <summary>
        /// Metodo de clase realiza la operacion pedida entre dos operandos
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resulta de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char operar = Convert.ToChar(operador);
            switch (ValidarOperador(operar))
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        } 
        #endregion
    }
}
