namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado = 0;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                if (rbtnAdicao.Checked)
                {
                    resultado = numero1 + numero2;
                }
                else if (rbtnSubtracao.Checked)
                {
                    resultado = numero1 - numero2;
                }
                else if (rbtnMultiplicacao.Checked)
                {
                    resultado = numero1 * numero2;
                }
                else if (rbtnDivisao.Checked)
                {
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        return;
                    }
                }

                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }
    }
}
