using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace tp1
{
    public partial class FromCalculadora : Form
    {
        public FromCalculadora()
        {
            InitializeComponent();
        }

        private void FromCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {


            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

            bntConverBinario.Enabled = true;
            btnConverDecimal.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConverDecimal_Click(object sender, EventArgs e)
        {
            string conver;

            Numero numDecimal = new Numero();

            conver = numDecimal.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = conver;
            btnConverDecimal.Enabled = false;
        }

        private void BntConverBinario_Click(object sender, EventArgs e)
        {
            string binario;

            Numero numBinario = new Numero();

            binario = numBinario.DecimalBinario(lblResultado.Text);

            lblResultado.Text = binario;

            bntConverBinario.Enabled = false;


        }

        private void Limpiar()
        {

            cmbOperador.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            btnConverDecimal.Enabled = true;
            bntConverBinario.Enabled = true;

        }

        private static double Operar(string numero1, string numero2, string oper)
        {

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            double resultado = Calculadora.Operar(num1, num2, oper);

            return resultado;

        }
    }
}
