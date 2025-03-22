namespace cadastro_clientes
{
    partial class CriarCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrar = new Button();
            labelNome = new Label();
            labelEmail = new Label();
            labelNomeSocial = new Label();
            label4 = new Label();
            labelEtnia = new Label();
            labelLogradouro = new Label();
            textBoxNomeCliente = new TextBox();
            textBoxNomeSocial = new TextBox();
            textBoxEmail = new TextBox();
            textBoxBairro = new TextBox();
            textBoxLogradouro = new TextBox();
            comboBoxGenero = new ComboBox();
            comboBoxEtniaCliente = new ComboBox();
            labelBairro = new Label();
            labelMunicipio = new Label();
            labelCEP = new Label();
            labelDataDeNascimento = new Label();
            labelTelefone = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            labelEstado = new Label();
            labelEstrangeiro = new Label();
            textBoxNumero = new TextBox();
            textBoxEstado = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxMunicipio = new TextBox();
            maskedTextBoxDatadeNascimento = new MaskedTextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            checkBoxSim = new CheckBox();
            checkBoxNao = new CheckBox();
            dataGridView1 = new DataGridView();
            buttonMostrarClientes = new Button();
            labelRetorno = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(319, 285);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(5, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(5, 46);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.Location = new Point(5, 83);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(74, 15);
            labelNomeSocial.TabIndex = 3;
            labelNomeSocial.Text = "Nome Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 111);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Gênero";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Location = new Point(5, 143);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(33, 15);
            labelEtnia.TabIndex = 5;
            labelEtnia.Text = "Etnia";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(295, 9);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 6;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(56, 6);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(205, 23);
            textBoxNomeCliente.TabIndex = 7;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(81, 78);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(180, 23);
            textBoxNomeSocial.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(56, 43);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(339, 69);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(128, 23);
            textBoxBairro.TabIndex = 10;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(370, 6);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(97, 23);
            textBoxLogradouro.TabIndex = 11;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(56, 108);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(205, 23);
            comboBoxGenero.TabIndex = 12;
            // 
            // comboBoxEtniaCliente
            // 
            comboBoxEtniaCliente.FormattingEnabled = true;
            comboBoxEtniaCliente.Location = new Point(56, 140);
            comboBoxEtniaCliente.Name = "comboBoxEtniaCliente";
            comboBoxEtniaCliente.Size = new Size(205, 23);
            comboBoxEtniaCliente.TabIndex = 13;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(295, 78);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 14;
            labelBairro.Text = "Bairro";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(295, 138);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(61, 15);
            labelMunicipio.TabIndex = 15;
            labelMunicipio.Text = "Municipio";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(305, 210);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(28, 15);
            labelCEP.TabIndex = 16;
            labelCEP.Text = "CEP";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Location = new Point(5, 180);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(117, 15);
            labelDataDeNascimento.TabIndex = 17;
            labelDataDeNascimento.Text = "Data de Nascimento ";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(5, 210);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 18;
            labelTelefone.Text = "Telefone";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(295, 43);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 19;
            labelNumero.Text = "Número";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(295, 108);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 20;
            labelComplemento.Text = "Complemento";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(295, 168);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 21;
            labelEstado.Text = "Estado";
            // 
            // labelEstrangeiro
            // 
            labelEstrangeiro.AutoSize = true;
            labelEstrangeiro.Location = new Point(13, 260);
            labelEstrangeiro.Name = "labelEstrangeiro";
            labelEstrangeiro.Size = new Size(83, 15);
            labelEstrangeiro.TabIndex = 22;
            labelEstrangeiro.Text = "É estrangeiro ?";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(352, 40);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(115, 23);
            textBoxNumero.TabIndex = 25;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(339, 165);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(128, 23);
            textBoxEstado.TabIndex = 26;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(385, 100);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(82, 23);
            textBoxComplemento.TabIndex = 27;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(362, 135);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(105, 23);
            textBoxMunicipio.TabIndex = 28;
            // 
            // maskedTextBoxDatadeNascimento
            // 
            maskedTextBoxDatadeNascimento.Location = new Point(119, 177);
            maskedTextBoxDatadeNascimento.Mask = "00/00/0000";
            maskedTextBoxDatadeNascimento.Name = "maskedTextBoxDatadeNascimento";
            maskedTextBoxDatadeNascimento.Size = new Size(73, 23);
            maskedTextBoxDatadeNascimento.TabIndex = 29;
            maskedTextBoxDatadeNascimento.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(339, 202);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(67, 23);
            maskedTextBoxCEP.TabIndex = 30;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(62, 210);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(94, 23);
            maskedTextBoxTelefone.TabIndex = 31;
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Location = new Point(10, 289);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(46, 19);
            checkBoxSim.TabIndex = 32;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            // 
            // checkBoxNao
            // 
            checkBoxNao.AutoSize = true;
            checkBoxNao.Location = new Point(74, 289);
            checkBoxNao.Name = "checkBoxNao";
            checkBoxNao.Size = new Size(48, 19);
            checkBoxNao.TabIndex = 33;
            checkBoxNao.Text = "Não";
            checkBoxNao.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 150);
            dataGridView1.TabIndex = 34;
            // 
            // buttonMostrarClientes
            // 
            buttonMostrarClientes.Location = new Point(550, 269);
            buttonMostrarClientes.Name = "buttonMostrarClientes";
            buttonMostrarClientes.Size = new Size(123, 23);
            buttonMostrarClientes.TabIndex = 35;
            buttonMostrarClientes.Text = "Mostrar clientes";
            buttonMostrarClientes.UseVisualStyleBackColor = true;
            buttonMostrarClientes.Click += buttonMostrarClientes_Click;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.Location = new Point(64, 359);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(32, 15);
            labelRetorno.TabIndex = 36;
            labelRetorno.Text = "error";
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRetorno);
            Controls.Add(buttonMostrarClientes);
            Controls.Add(dataGridView1);
            Controls.Add(checkBoxNao);
            Controls.Add(checkBoxSim);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(maskedTextBoxDatadeNascimento);
            Controls.Add(textBoxMunicipio);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxNumero);
            Controls.Add(labelEstrangeiro);
            Controls.Add(labelEstado);
            Controls.Add(labelComplemento);
            Controls.Add(labelNumero);
            Controls.Add(labelTelefone);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelCEP);
            Controls.Add(labelMunicipio);
            Controls.Add(labelBairro);
            Controls.Add(comboBoxEtniaCliente);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(labelLogradouro);
            Controls.Add(labelEtnia);
            Controls.Add(label4);
            Controls.Add(labelNomeSocial);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(buttonCadastrar);
            Name = "CriarCliente";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label labelNome;
        private Label labelEmail;
        private Label labelNomeSocial;
        private Label label4;
        private Label labelEtnia;
        private Label labelLogradouro;
        private TextBox textBoxNomeCliente;
        private TextBox textBoxNomeSocial;
        private TextBox textBoxEmail;
        private TextBox textBoxBairro;
        private TextBox textBoxLogradouro;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEtniaCliente;
        private Label labelBairro;
        private Label labelMunicipio;
        private Label labelCEP;
        private Label labelDataDeNascimento;
        private Label labelTelefone;
        private Label labelNumero;
        private Label labelComplemento;
        private Label labelEstado;
        private Label labelEstrangeiro;
        private TextBox textBoxNumero;
        private TextBox textBoxEstado;
        private TextBox textBoxComplemento;
        private TextBox textBoxMunicipio;
        private MaskedTextBox maskedTextBoxDatadeNascimento;
        private MaskedTextBox maskedTextBoxCEP;
        private MaskedTextBox maskedTextBoxTelefone;
        private CheckBox checkBoxSim;
        private CheckBox checkBoxNao;
        private DataGridView dataGridView1;
        private Button buttonMostrarClientes;
        private Label labelRetorno;
    }
}
