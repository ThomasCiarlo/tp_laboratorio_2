using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
       public Snacks(EMarca marca, string codigoDeBarra, ConsoleColor colorEmpaque):base(codigoDeBarra,marca,colorEmpaque)          
        {
        }
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

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine($"Codigo de barra: {base.codigoDeBarras}\nColor: {base.colorPrimarioEmpaque}\nMarca: {base.marca}");
            sb.AppendLine($"CALORIAS : {this.CantidadCalorias}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
