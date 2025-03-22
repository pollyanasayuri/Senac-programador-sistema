using System.Drawing.Text;

namespace cadastro_clientes
{
    public partial class CriarCliente : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];
        public CriarCliente()
        {   
            // ex. de clientes já cadastrados 
            InitializeComponent();
            EnderecoCliente enderecoRafael = new EnderecoCliente() { Logradouro = "Rua do Rafael", Numero = "10", Bairro = "Jardim do Futebol", Complemento = "casa", CEP = "12345-300", Municipio = "São Paulo", Estado = "SP" };

            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Silva", DataNascimento = "31/08/1991", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoRafael, Email = "rafaeljr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(rafael);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;

            comboBoxGenero.Items.Add("Feminino");
            comboBoxGenero.Items.Add("Masculino");
            comboBoxGenero.Items.Add("Transgenero");
            comboBoxGenero.Items.Add("Não binario");

            comboBoxEtniaCliente.Items.Add("Branco");
            comboBoxEtniaCliente.Items.Add("Preto");
            comboBoxEtniaCliente.Items.Add("Pardo");
            comboBoxEtniaCliente.Items.Add("Amarelo");
            comboBoxEtniaCliente.Items.Add("Indigena");


        }

        private bool ValidarCampo(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                labelRetorno.Text = "Campo" + nomeCampo + " é obrigatorio e sem espaços em branco";
                return false;
            }
            return true;
        }
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo" + nomeCampo + " não pode conter números";
                return false;
            }
            return true;
        }
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas números.";
                return false; // Campo inválido
            }
            return true; // campo valido
        }
        private bool ValidarNascimento(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataNascimento) || dataNascimento > DateTime.Now)
            {
                labelRetorno.Text = "Data inválida! Use formato 00/00/0000 e verifique se não é futura.";
                return false; // campo invalido
            }
            return true;
        }
       
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O e-mail deve estar em um formato válido (ex: usuario@gmail.com).";
                return false; // Campo inválido
            }
            return true;
        }
        private bool ValidarNumeroUnico(string valor, string tipo, List<Cliente> clientes)
        {
            if (tipo == "Email" && clientes.Any(cliente => cliente.Email == valor))
            {
                labelRetorno.Text = "Erro: E-mail já cadastrado.";
                return false;
            }

            if (tipo == "Telefone" && clientes.Any(c => c.Telefone == valor))
            {
                labelRetorno.Text = "Erro: Telefone já cadastrado.";
                return false;
            }

            return true;
        }
        private bool ValidarCheckBoxEstrangeiro(CheckBox checkBoxSim, CheckBox checkBoxNao)
        {

            if (checkBoxSim.Checked && checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione apenas uma opção para 'Estrangeiro'.";
                return false;
            }

            // Verifica se nenhuma está marcada
            if (!checkBoxSim.Checked && !checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione uma opção para SIM ou NÃO";
                return false;
            }

            return true;
        }
        private int GerarNovoId(List<Cliente> clientes)
        {
            return clientes.Count == 0 ? 1 : clientes.Max(cliente => cliente.Id) + 1;
        }

        private bool EmailJaExiste(string email, List<Cliente> clientes)
        {
            return clientes.Any(cliente => cliente.Email == email);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do Cliente") || !ValidarSemNumeros(textBoxNomeCliente.Text, "Nome do Cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }
            // Validação do e-mail
            if (!ValidarCampo(textBoxEmail.Text, "E-mail") || !ValidarEmail(textBoxEmail.Text) || !ValidarNumeroUnico(textBoxEmail.Text, "Email", Clientes))
            {
                textBoxEmail.Focus();
                return;
            }

            // Validação do telefone
            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone") || !ValidarNumeroUnico(maskedTextBoxTelefone.Text, "Telefone", Clientes))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            // Validação da data de nascimento
            if (!ValidarCampo(maskedTextBoxDatadeNascimento.Text, "Data de Nascimento") || !ValidarNascimento(maskedTextBoxDatadeNascimento.Text))
            {
                maskedTextBoxDatadeNascimento.Focus();
                return;
            }
            // Validação Estrangeiro
            if (!ValidarCheckBoxEstrangeiro(checkBoxSim, checkBoxNao))
            {
                return;
            }

            // Validação Genero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelRetorno.Text = "Erro: Selecione um gênero válido.";
                comboBoxGenero.Focus();
                return;
            }

            // Gera um novo ID único
            int novoId = GerarNovoId(Clientes);

            if (EmailJaExiste(textBoxEmail.Text, Clientes))
            {
                labelRetorno.Text = "Erro: E-mail já cadastrado.";
                textBoxEmail.Focus();
                return;
            }

            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone"))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            // Cria o endereço do cliente
            EnderecoCliente endereco = new EnderecoCliente
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Bairro = textBoxBairro.Text,
                Complemento = textBoxComplemento.Text,
                CEP = maskedTextBoxCEP.Text,
                Municipio = textBoxMunicipio.Text,
                Estado = textBoxEstado.Text // Supondo que o estado está em um ComboBox
            };

            // Cria o novo cliente
            Cliente novoCliente = new Cliente
            {
                Id = novoId, // Usa o ID gerado
                Nome = textBoxNomeCliente.Text,
                Email = textBoxEmail.Text,
                Telefone = maskedTextBoxTelefone.Text,
                DataNascimento = maskedTextBoxDatadeNascimento.Text,
                Genero = (GeneroCliente)comboBoxGenero.SelectedItem,
                Etnia = (EtniaCliente)comboBoxEtniaCliente.SelectedItem,
                Estrangeiro = checkBoxSim.Checked,
                Endereco = endereco
            };


            Clientes.Add(novoCliente);


         labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }


        private void buttonMostrarClientes_Click(object sender, EventArgs e)
        {

            BindingSource.ResetBindings(false);
        }
    }

}
