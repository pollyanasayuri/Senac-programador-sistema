namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == null || senha ==  "")
            {
                labelResultado.Text = "Usuario é Obrigatorio !!";
                labelResultado.ForeColor = Color.Red;
            }

            else if  (usuario == "Rafael.sousa" && senha == "12345")
            {
                labelResultado.Text = "Autenticado com sucesso!";
            }
            else
            {
                labelResultado.Text = "Usuario ou senha incorreto...";
            }
        }
    }
}
