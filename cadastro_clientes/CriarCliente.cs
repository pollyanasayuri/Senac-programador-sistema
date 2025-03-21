namespace cadastro_clientes
{
    public partial class CriarCliente : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];
        public CriarCliente()
        {
            InitializeComponent();
            EnderecoCliente enderecoRafael = new EnderecoCliente() { Logradouro = "Rua do Rafael", Numero = "10", Bairro = "Jardim do Futebol", Complemento = "casa", CEP = "12345-300", Municipio = "São Paulo", Estado = "SP" };

            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Silva", DataNascimento = "31/08/1991", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoRafael, Email = "rafaeljr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(rafael);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;

        }

        private void buttonMostrarClientes_Click(object sender, EventArgs e)
        {   

            BindingSource.ResetBindings(false);
        }
    }

}
