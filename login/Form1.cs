using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        // Construtor da classe
        public Form1()

        {
            InitializeComponent();
        }

        // Método executado ao clicar no botão Entrar
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            // Busca o usuário e senha digitados
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            // Verifica se o usuário foi digitado
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario é Obrigatorio !!";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execução do método
                return;
            }
            // Verifica se a senha foi digitada
            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Usuario é Obrigatorio !!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            // Verifica se o usuário e senha estão corretos
            // Inicializa a variável autenticado como false

            bool autenticado = false;

            try
            {
                Connection.Open();
                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }
            // Verifica se o usuário e senha não foram encontrados
            if (!autenticado)
            {
                labelResultado.Text = "Usuario ou senha incorretos...";
                labelResultado.ForeColor= Color.Red;
                return;
            }
            // Se o usuário e senha foram encontrados, exibe mensagem de sucesso
            labelResultado.Text = "Usuario ou senha incorretos...";
            labelResultado.ForeColor= Color.Green;

            // Limpa os campos de texto
            textBoxUsuario.Clear();
            textBoxSenha.Clear();

        }


        private void cadastrarnovousuario_Click(object sender, EventArgs e)
        {
            // Busca o novo usuário e senha digitados
            string novoUsuario = textBoxNovoUsuario.Text;
            string novaSenha = textBoxNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelResultado.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            if (!novaSenha.Any(char.IsNumber))
            {
                labelResultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                labelResultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelResultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }
            
        }

       
    }
}
