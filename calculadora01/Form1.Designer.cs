namespace calculadora01
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
            textBoxNumber1 = new TextBox();
            textBoxNumber2 = new TextBox();
            bottonAdicao = new Button();
            buttonSubtracao = new Button();
            buttonMultiplicacao = new Button();
            buttonDivisao = new Button();
            buttonMigrar = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(254, 53);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(126, 23);
            textBoxNumber1.TabIndex = 0;
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(254, 126);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(126, 23);
            textBoxNumber2.TabIndex = 1;
            // 
            // bottonAdicao
            // 
            bottonAdicao.Location = new Point(444, 53);
            bottonAdicao.Name = "bottonAdicao";
            bottonAdicao.Size = new Size(75, 23);
            bottonAdicao.TabIndex = 2;
            bottonAdicao.Text = "Adição";
            bottonAdicao.UseVisualStyleBackColor = true;
            bottonAdicao.Click += bottonAdicao_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Location = new Point(555, 53);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(75, 23);
            buttonSubtracao.TabIndex = 5;
            buttonSubtracao.Text = "Subtração";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.Click += buttonSubtracao_Click;
            // 
            // buttonMultiplicacao
            // 
            buttonMultiplicacao.Location = new Point(432, 125);
            buttonMultiplicacao.Name = "buttonMultiplicacao";
            buttonMultiplicacao.Size = new Size(96, 23);
            buttonMultiplicacao.TabIndex = 6;
            buttonMultiplicacao.Text = "Multiplicação";
            buttonMultiplicacao.UseVisualStyleBackColor = true;
            buttonMultiplicacao.Click += buttonMultiplicacao_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Location = new Point(555, 126);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(75, 23);
            buttonDivisao.TabIndex = 7;
            buttonDivisao.Text = "Divisão";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // buttonMigrar
            // 
            buttonMigrar.Location = new Point(515, 289);
            buttonMigrar.Name = "buttonMigrar";
            buttonMigrar.Size = new Size(115, 61);
            buttonMigrar.TabIndex = 8;
            buttonMigrar.Text = "Migrar para o segundo formulario";
            buttonMigrar.UseVisualStyleBackColor = true;
            buttonMigrar.Click += buttonMigrar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(316, 289);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(62, 15);
            labelResultado.TabIndex = 9;
            labelResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 426);
            Controls.Add(labelResultado);
            Controls.Add(buttonMigrar);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonMultiplicacao);
            Controls.Add(buttonSubtracao);
            Controls.Add(bottonAdicao);
            Controls.Add(textBoxNumber2);
            Controls.Add(textBoxNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private Button bottonAdicao;
        private Button buttonSubtracao;
        private Button buttonMultiplicacao;
        private Button buttonDivisao;
        private Button buttonMigrar;
        private Label labelResultado;
    }
}
