using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Numero
    {

        private double numero;

        public double SetNumero
        {
            set { this.numero = ValidarNumero(value.ToString()); }
        }

        #region Constructores
        public Numero(double num)
        {

            this.numero = num;

        }

        public Numero() : this(0) { }

        public Numero(string strNumero) : this(Convert.ToDouble(strNumero))
        {

        }
        #endregion

        #region validaciones
        private double ValidarNumero(string strNumero)
        {

            double numero;

            if (!(double.TryParse(strNumero, out numero)))
            {
                numero = 0;
            }

            return numero;
        }
        #endregion

        #region conversion
        public string BinarioDecimal(string Binario)
        {


            string x = "";
            double bin = 0;
            int exp = 0;
            bool EsBinario = true;

            for (int j = 0; j < Binario.Length; j++)
            {

                if (Binario[j] != '1')
                {
                    if (Binario[j] != '0')
                    {
                        EsBinario = false;
                        x = "No es Valido";
                    }
                }

            }
            if (EsBinario)
            {
                for (int i = Binario.Length - 1; i >= 0; i--)
                {

                    if (Binario[i] == '1')
                    {

                        bin += Math.Pow(2, exp);

                    }
                    exp++;
                }
                x = bin.ToString();
            }



            return x;
        }

        public string DecimalBinario(double Decimal)
        {

            string binario = "";
            int oper = Convert.ToInt32(Decimal);
            string dec = Decimal.ToString();
            bool todoOk = true;



            for (int x = 0; x < dec.Length; x++)
            {
                if (dec[x] == '-' || dec[x] == ',')
                {
                    todoOk = false;
                    binario = "No es valido";
                }

            }



            if (todoOk)
            {
                while (oper > 0)
                {
                    binario = oper % 2 + binario;
                    oper = oper / 2;

                }

            }

            return binario;

        }


        public string DecimalBinario(string Decimal)
        {

            double numero;
            string retorno = "No es Valido";

            if (double.TryParse(Decimal, out numero))
            {
                retorno = DecimalBinario(numero);
            }

            return retorno;

        }
        #endregion

        #region sobre carga de operadores
        public static double operator +(Numero a, Numero b)
        {

            double total = a.numero + b.numero;

            return total;

        }

        public static double operator -(Numero a, Numero b)
        {

            double total = a.numero - b.numero;

            return total;
        }

        public static double operator *(Numero a, Numero b)
        {

            double total = a.numero * b.numero;

            return total;

        }

        public static double operator /(Numero a, Numero b)
        {

            double total;

            if (b.numero > 0)
            {
                total = a.numero / b.numero;
            }
            else
            {
                total = double.MinValue;
            }

            return total;
        }
        #endregion

    }
}
