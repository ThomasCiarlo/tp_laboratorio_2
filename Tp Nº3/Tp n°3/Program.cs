using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Instanciables;
using Clases_Abstractas;


namespace Tp_n_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor profe = new Profesor(1, "123542", "asda1231", "41589039", Persona.ENacionalidad.Argentino);
            Console.WriteLine(profe.ToString());

            Console.ReadKey();
            
        }
    }
}
