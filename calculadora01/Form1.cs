using System.Configuration;

namespace calculadora01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bottonAdicao_Click(object sender, EventArgs e)
        {
            string num1 = textBoxNumber1.Text;
            string num2 = textBoxNumber2.Text;

            if (!num1.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 1 deve ser um numero";
                return;
            }
            if (!num2.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 2 deve ser um numero";
                return;
            }
            double doublenum1 = double.Parse(textBoxNumber1.Text);
            double doublenum2 = double.Parse(textBoxNumber2.Text);

            double resultado = doublenum1 + doublenum2; // faz soma 
            labelResultado.Text = resultado.ToString();




        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            string num1 = textBoxNumber1.Text;
            string num2 = textBoxNumber2.Text;

            if (!num1.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 1 deve ser um numero";
                return;
            }
            if (!num2.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 2 deve ser um numero";
                return;
            }
            double doublenum1 = double.Parse(textBoxNumber1.Text);
            double doublenum2 = double.Parse(textBoxNumber2.Text);

            double resultado = doublenum1 - doublenum2; // subtrair 
            labelResultado.Text = resultado.ToString();
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            string num1 = textBoxNumber1.Text;
            string num2 = textBoxNumber2.Text;

            if (!num1.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 1 deve ser um numero";
                return;
            }
            if (!num2.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 2 deve ser um numero";
                return;
            }
            double doublenum1 = double.Parse(textBoxNumber1.Text);
            double doublenum2 = double.Parse(textBoxNumber2.Text);

            double resultado = doublenum1 * doublenum2; // faz divisão 
            labelResultado.Text = resultado.ToString();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            string num1 = textBoxNumber1.Text;
            string num2 = textBoxNumber2.Text;

            if (!num1.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 1 deve ser um numero";
                return;
            }
            if (!num2.All(char.IsNumber))
            {
                labelResultado.Text = " O valor 2 deve ser um numero";
                return;
            }
            double doublenum1 = double.Parse(textBoxNumber1.Text);
            double doublenum2 = double.Parse(textBoxNumber2.Text);

            double resultado = doublenum1 / doublenum2; // Faz divisão 
            labelResultado.Text = resultado.ToString();
        }

        private void buttonMigrar_Click(object sender, EventArgs e)
        {
            Form2 trocarPagina = new Form2(); // troca para a segundo formulario.
            trocarPagina.Show();
            this.Hide(); // this = ele mesmo( no caso o proprio codigo)/ hide = ele se esconde para aparecer o segundo formulario.
        }
    }
}
