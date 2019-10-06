using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        #region Constructor
        public Snacks(EMarca marca, string codigoDeBarra, ConsoleColor colorEmpaque) : base(codigoDeBarra, marca, colorEmpaque)
        {
        }

        #endregion

        #region propiedades
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
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

            sb.AppendLine("SNACKS");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

    }
}
