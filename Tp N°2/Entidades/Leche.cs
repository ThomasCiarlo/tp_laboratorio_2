using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo tipo;

        #region construcores

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// 

        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo) : base(codigo, marca, color)
        {
            this.tipo = tipo;
        }

        public Leche(EMarca marca, string patente, ConsoleColor color) : this(marca, patente, color, ETipo.Entera)
        {
        }

        #endregion


        #region propiedades
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion


        #region Metodos
        public override string Mostrar()
        {

            /// <summary>
            /// Publica todos los datos del Producto.
            /// </summary>
            /// <returns></returns>
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias} TIPO: {this.tipo}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
