namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox.Items.Add("Somar");
            comboBox.Items.Add("Subrair");
            comboBox.Items.Add("Multiplicar");
            comboBox.Items.Add("Dividir");

            comboBox.SelectedItem = "Somar";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text; 

            if(!double.TryParse(valor1, out double doubleValor1) || !double.TryParse(valor2, out double doubleValor2))
            {
                textBoxResultado.Text = "Os valores digitados devem ser números validos";
                return;
            }
            double resultado = 0;

            switch (comboBox.SelectedItem.ToString())
            {
                case "Somar":
                    labelOperador.Text = "+";
                    resultado = doubleValor1 + doubleValor2;
                    break;

                case "Subtrair":
                    labelOperador.Text = "-";
                    resultado = doubleValor1 - doubleValor2;
                    break;

                case "Multiplicar":
                    labelOperador.Text = "*";
                    resultado = doubleValor1 * doubleValor2;
                    break;

                case "Dividir":
                    labelOperador.Text = "/";

                    if (doubleValor1 == 0 && doubleValor2 == 0)
                    {
                        textBoxResultado.Text = "Não é possivel dividir por zero.";
                        return;
                    }
                    resultado = doubleValor1 / doubleValor2;
                    break;

                default:
                    labelOperador.Text = "";
                    textBoxResultado.Text = "Selecione uma operação válida.";
                    return;
            }
            textBoxResultado.Text = resultado.ToString();

        }
    }
}
