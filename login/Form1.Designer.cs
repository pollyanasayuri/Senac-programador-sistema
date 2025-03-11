namespace login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            labelResultado = new Label();
            pictureBox1 = new PictureBox();
            textBoxNovoUsuario = new TextBox();
            textBoxNovaSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cadastrarnovousuario = new Button();
            label5 = new Label();
            labelNovoUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.ForeColor = SystemColors.ControlText;
            buttonEntrar.Location = new Point(221, 278);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 23);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Acessar\r\n";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 186);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 233);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha ";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(196, 183);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 5;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(196, 230);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 6;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(159, 335);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            
            // 
            // textBoxNovoUsuario
            // 
            textBoxNovoUsuario.Location = new Point(396, 183);
            textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            textBoxNovoUsuario.Size = new Size(117, 23);
            textBoxNovoUsuario.TabIndex = 10;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Location = new Point(396, 229);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(117, 23);
            textBoxNovaSenha.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 186);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 12;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 234);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 13;
            label4.Text = "senha de acesso";
            // 
            // cadastrarnovousuario
            // 
            cadastrarnovousuario.Location = new Point(416, 278);
            cadastrarnovousuario.Name = "cadastrarnovousuario";
            cadastrarnovousuario.Size = new Size(75, 23);
            cadastrarnovousuario.TabIndex = 14;
            cadastrarnovousuario.Text = "cadastrar ";
            cadastrarnovousuario.UseVisualStyleBackColor = true;
            cadastrarnovousuario.Click += cadastrarnovousuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 121);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 15;
            label5.Text = "Login";
            // 
            // labelNovoUsuario
            // 
            labelNovoUsuario.AutoSize = true;
            labelNovoUsuario.Location = new Point(424, 121);
            labelNovoUsuario.Name = "labelNovoUsuario";
            labelNovoUsuario.Size = new Size(79, 15);
            labelNovoUsuario.TabIndex = 16;
            labelNovoUsuario.Text = "Novo Usuário";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 381);
            Controls.Add(labelNovoUsuario);
            Controls.Add(label5);
            Controls.Add(cadastrarnovousuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNovaSenha);
            Controls.Add(textBoxNovoUsuario);
            Controls.Add(labelResultado);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEntrar);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEntrar;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label labelResultado;
        private PictureBox pictureBox1;
        private TextBox textBoxNovoUsuario;
        private TextBox textBoxNovaSenha;
        private Label label3;
        private Label label4;
        private Button cadastrarnovousuario;
        private Label label5;
        private Label labelNovoUsuario;
    }
}
