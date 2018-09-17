using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades2
{
   public class Numero
    {
        private double _Numero;

    #region Propiedades

        public string SetNumero {                
            set
            {
                this._Numero = ValidarNumero(value); //la propiedad la pasa a la validacion
            }
         }
    #endregion

    #region Constructores

        public Numero(double numero) //constructo parametrizado
        {
            this._Numero = numero;
            
        }

        public Numero():this(0) //reutilizo el constructor, this 0
        {
           
        }

        public Numero(string strNumero) //si le paso un string
        {
            this.SetNumero = strNumero; //va a la propiedad 
        }

        #endregion

    #region Metodos  //funciones

        private static double ValidarNumero(string Numero) //la validacion toma un string y devuelve un doble
            {
                double num;

                if (double.TryParse(Numero, out num)) //entra Numero string //sale num doble
                {
                    return num;
                }

                return 0;
            }

        public static string BinarioDecimal(string binario)
        {
            double retorno = 0;
            int j = binario.Length;

            if (binario == null || binario == "") //validacion de NULL o Vacio
            {
                return "Error";
            }
            else
            {

                for (int i = 0; i < binario.Length; i++) //Validacion de caracteres invalidos
                {
                    if (binario[i] != '0' && binario[i] != '1')
                    {
                        return "Error";
                    }
                }
                                             
                for (int i = 0; i < binario.Length; i++) 
                {
                    if (binario[i] == '1')// cada elemento del array es 1
                    {
                        retorno += Math.Pow(2, j-1); //suma la potencia de 2 y 
                    }
                    j--;

                }
                return string.Format("{0}", retorno);
            }
                                         
        }



        public static string DecimalBinario(double numero)
        {
            string binario = "";

                if (numero < 0)
                {
                    return null;
                }
                while (numero > 0)
                {

                    if (numero % 2 == 1)
                    {
                        binario = '1' + binario;
                    }
                    else
                    {
                        binario = '0' + binario;
                    }

                    numero = (int)numero / 2;

                }
            return binario;
        }


        public static string DecimalBinario(string numero)
        {
            double Numero;
               Numero = ValidarNumero(numero);
            if (Numero!=0)
               return DecimalBinario(Numero);
            else
              return "Error";
        }
        
        #endregion

    #region Sobrecarga de Operadores

        public static double operator +(Numero num1, Numero num2)
        {  
           return num1._Numero + num2._Numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1._Numero - num2._Numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
           return num1._Numero * num2._Numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
           return num1._Numero / num2._Numero;
        }
       

        #endregion

    }
}
