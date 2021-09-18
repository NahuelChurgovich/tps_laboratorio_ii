namespace Entidades
{
    public static class Calculadora
    {
        #region Métodos
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            return '+';
        }
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
