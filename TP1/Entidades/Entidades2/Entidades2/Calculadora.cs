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
            operador = ValidarOperador(operador);
            double resultado ;
            switch (operador)
            {
                case "-":
                  resultado = num1-num2;
                    break;
                case "*":
                    resultado = num1*num2;
                    break;

                case "/":
                    resultado = num1/num2;
                    break;

                default:
                    resultado = num1+num2;
                    break;
            }

            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default:
                    return"+";
            }
        }

        #endregion

    }
}
