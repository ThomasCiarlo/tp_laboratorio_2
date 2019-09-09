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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void TxtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);

            string result;
            double resultado = Calculadora.Operar(num1, num2, cmbOperador.Text);

            result = resultado.ToString();

            lblResultado.Text = result;
                     
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
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
        }

        private void BntConverBinario_Click(object sender, EventArgs e)
        {
            string binario;

            Numero numBinario = new Numero();

            binario = numBinario.decimalBinario(lblResultado.Text);

            lblResultado.Text = binario;


        }
    }
}
