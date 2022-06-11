using Calculadora.Models;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            lbError.Visible = false;  
            lbError.Text = "Valor inválido";
        }

        int valor1 = 0;
        int valor2 = 0;

        static Operacoes operacoes = new Operacoes();


        Calcular somar = new Calcular(operacoes.Somar);
        Calcular subtrair = new Calcular(operacoes.Subtrair);
        Calcular multiplicar = new Calcular(operacoes.Multiplicar);
        Calcular dividir = new Calcular(operacoes.Divisao);

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);
                txtResultado.Text = somar(valor1, valor2).ToString();
            }
            catch
            {                
                lbError.Visible = true;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);
                txtResultado.Text = subtrair(valor1, valor2).ToString();
            }
            catch
            {
                lbError.Visible = true;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);
                txtResultado.Text = multiplicar(valor1, valor2).ToString();
            }
            catch
            {
                lbError.Visible = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);
                txtResultado.Text = dividir(valor1, valor2).ToString();
            }
            catch
            {
                lbError.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtResultado.Text = String.Empty;
            lbError.Visible = false;
        }
    }
}