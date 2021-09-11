using System;

namespace Entidades
{
    public class Operando
    {
        #region Atributos

        private double numero;

        #endregion

        #region Constructor

        public Operando() : this(0)
        {
        }

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

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Métodos

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

        private bool EsBinario(string binario)
        {
            if (binario != null)
            {
                foreach (char digito in binario)
                {
                    if (digito != '0' || digito != '1')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

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

        public string DecimalBinario(double numero)
        {
            const int dos = 2;
            double decima = numero;
            string resto = "";
            char[] arrayAux = { ' ' };
            int i = 0;

            if (decima >= 0)
            {
                while (decima >= 1)
                {
                    decima = Math.Truncate(decima);
                    resto += (decima % dos).ToString();
                    decima /= dos;
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

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

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

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion

    }
}
