using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class FormsNovo : Form
    {
        public FormsNovo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Quadrado")
            {
                groupBoxQuadrado.Visible = true;
                groupBoxRetangulo.Visible = false;
                groupBoxQuadrado.BringToFront();
                groupBoxRetangulo.SendToBack();
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Retangulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = true;
                groupBoxQuadrado.SendToBack();
                groupBoxRetangulo.BringToFront();
                return;
            }


        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            if (radioButtonPerimetro.Checked)
            {
                string largura = textBoxAltura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                double resultado = (Convert.ToDouble(altura) * 2) + (Convert.ToDouble(largura) * 2);

                textBoxResultado.Text = resultado.ToString();
                return;
            }

            if (radioButtonArea.Checked)
            {
                string largura = textBoxAltura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura);

                textBoxResultado.Text = resultado.ToString();
                return;
            }

            if (radioButtonVolume.Checked)
            {
                string largura = textBoxLargura.Text;
                string altura = textBoxAltura.Text;
                string comprimento = textBoxComprimento.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura valida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(comprimento) || !comprimento.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma comprimento valida.";
                    return;
                }
                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura) * Convert.ToDouble(comprimento);

                textBoxResultado.Text = resultado.ToString();
                return;
            }


        }

        private void buttonCalcularCirculo_Click(object sender, EventArgs e)
        {
            labelErro.Text = "Selecione uma operacao.";
            return;

            if (!radioButtonAreaCirculo.Checked &&
                !radioButtonPerimetroCirculo.Checked &&
                !radioButtonDiametroCirculo.Checked &&
                !radioButtonVolumeCirculo.Checked)
            {
                labelErro.Text = "Selecione uma opção";
            }

            string raio = textBoxRaio.Text;

            double raioDoNumero = double.Parse(textBoxRaio.Text);

            if (radioButtonDiametroCirculo.Checked)
            {
                textBoxResultado = 2 * raio;
            }
        }
    }

}



