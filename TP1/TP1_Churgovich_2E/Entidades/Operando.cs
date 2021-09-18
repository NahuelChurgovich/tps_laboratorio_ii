using System;

namespace Entidades
{
    public class Operando
    {
        #region Atributos

        private double numero;

        #endregion

        #region Constructor
        /// <summary>
        /// El constructor por defecto, inicializa el operador en cero.
        /// </summary>
        public Operando() : this(0)
        {
        }
        /// <summary>
        /// El constructor con parámetro asigna el valor del parámetro al objeto.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// La propiedad asigna el valor verificado.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Verifica que el string pasado por parámetro sea un numero.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El numero verificado o cero en su defecto</returns>
        private double ValidarOperando(string strNumero)
        {
            if (strNumero != null && double.TryParse(strNumero, out double auxNum))
            {
                return auxNum;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Verifica que el string solo este compuesto por ceros y unos.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Verdadero en caso de comprobar Falso en caso contrario.</returns>
        private bool EsBinario(string binario)
        {
            if (binario != null)
            {
                foreach (char digito in binario)
                {
                    if (digito != '0' && digito != '1')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// Convierte el string del parámetro (un numero binario) en un numero decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>El numero decimal obtenido o "Valor invalido" en el caso contrario</returns>
        public string BinarioDecimal(string binario)
        {
            double decima = 0;
            if (EsBinario(binario))
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);
                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        decima += (double)Math.Pow(2, i);
                    }
                }
                return decima.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
        /// <summary>
        /// Convierte el string del parámetro (un numero decimal) en un numero binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero binario obtenido o "Valor invalido" en el caso contrario</returns>
        public string DecimalBinario(double numero)
        {
            double decima = numero;
            string resto = "";
            char[] arrayAux = { ' ' };
            int i = 0;

            if (decima >= 0)
            {
                while (decima >= 1)
                {
                    decima = Math.Truncate(decima);
                    resto += (decima % 2).ToString();
                    decima /= 2;
                    i++;
                }
                arrayAux = resto.ToCharArray();
                Array.Reverse(arrayAux);
                return new string(arrayAux);
            }
            else
            {
                return "Valor inválido";
            }
        }

        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double aux))
            {
                return DecimalBinario(aux);
            }
            else
            {
                return "Valor inválido";
            }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Ejecuta una suma entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Ejecuta una resta entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Ejecuta una divicion entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación ó el valor mínimo posible si el segundo parámetro el cero</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        /// <summary>
        /// Ejecuta una multiplicación entre 2 objetos del tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>El resultado de la operación</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion

    }
}
