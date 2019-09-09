using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
   public class Calculadora
    {
        public Calculadora() {

        }

        private static string ValidarOperador(string operador) {

            if (!(operador == "+" || operador == "-" || operador == "*" || operador == "/")) {
                operador = "+";
            }

            return operador;
        }

        public static double Operar(Numero num1, Numero num2, string operador) {

            double total = 0;

            

            switch (ValidarOperador(operador)) {
                case "+":
                    total = num1 + num2;
                    break;
                case "-":
                    total = num1 - num2;
                    break;
                case "*":
                    total = num1 * num2;
                    break;
                case "/":
                    total = num1 / num2;
                    break;
            }

            return total;
        }


    }
}
