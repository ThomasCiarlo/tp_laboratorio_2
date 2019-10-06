using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        #region Constructor
        public Dulce(EMarca marca, string codigo, ConsoleColor color) : base(codigo, marca, color)
        {
        }


        #endregion


        #region propiedades
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

        #region Metodos


        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }
}
