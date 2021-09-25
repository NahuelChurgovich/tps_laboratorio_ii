using System;
using System.Text;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Propiedades

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        #endregion


        #region Constructores

        public Suv(EMarca marca, string chasis, ConsoleColor color)
          : base(marca, chasis, color)
        {
        }

        #endregion


        #region Métodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
