namespace Entidades
{
    public static class Calculadora
    {
        #region Métodos
        /// <summary>
        /// Valida que el carácter pasado por parámetro sea ('+', '-', '*' o '/')
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador validado o en su defecto '0' por default</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            return '+';
        }
        /// <summary>
        /// Realiza la operación indicada en el 3er parámetro entre el 1er y 2do parámetros.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (ValidarOperador(operador))
            {
                case '*':
                    return num1 * num2;
                case '-':
                    return num1 - num2;
                case '/':
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }
        #endregion
    }
}
