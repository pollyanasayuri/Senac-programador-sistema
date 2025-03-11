namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "Brun@123", "12345Abc!", "Sete7Sete" };

        Usuario neymar = new Usuario() { Email = "neymar.jr@gmail.com", Senha = "Brun@123" };
        Usuario pablo = new Usuario() { Email = "pablo.vitar@gmail.com", Senha = "12345Abc!" };
        Usuario sukuna = new Usuario() { Email = "sukuna.silva@gmail.com", Senha = "Sete7Sete" };

        List<Usuario> usuarios = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
            usuarios.Add(neymar);
            usuarios.Add(pablo);
            usuarios.Add(sukuna);
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;


            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuario é Obrigatorio !!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Usuario é Obrigatorio !!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuario[i] == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;
                }
            }
            if (posicaoUsuarioEncontrado > -1 || senha != listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }

            labelResultado.Text = "Usuario ou senha incorreto...";
            labelResultado.ForeColor = Color.Red;
            textBoxUsuario.Clear();
            textBoxSenha.Clear();

        }


        private void cadastrarnovousuario_Click(object sender, EventArgs e)
        {
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

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }

            listaUsuarios.Add(novoUsuario);
            listaSenhas.Add(novaSenha);
            labelResultado.Text = "Usuário cadastrado com sucesso!";
            textBoxNovoUsuario.Clear();
            textBoxNovaSenha.Clear();
        }

       
    }
}
