using System;
using System.Text;

namespace Entidades
{
    public class Sedan : Vehiculo
    {

        #region Atributos

        private ETipo tipo;

        #endregion


        #region Constructor

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, Sedan.ETipo.CuatroPuertas)
        {
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        #endregion


        #region Propiedades

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion


        #region Métodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TIPO : " + this.tipo);  
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion


        #region Enumerados

        public enum ETipo { CuatroPuertas, CincoPuertas }

        #endregion

    }
}
