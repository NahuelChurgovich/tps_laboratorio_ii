using System;
using System.Text;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {

        #region Propiedades

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion


        #region Constructores
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }

        #endregion


        #region Métodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
