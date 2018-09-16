using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades2
{
   public class Calculadora
    {
        #region Metodos

        public static double Operar(Numero num1, Numero num2, string operador)
        {

            switch (ValidarOperador(operador))
            {
                case "-":
                    return (num1-num2);
                case "*":
                    return (num1 * num2);
                case "/":
                    return (num1 / num2);
                default:
                    return (num1 + num2);
            }
        }

        private static string ValidarOperador(string operador)
        {
            switch (operador[0])
            {
                case '-':
                    return "-";
                case '*':
                    return "*";
                case '/':
                    return "*";
                default:
                    return"+";
            }
        }

        #endregion

    }
}
