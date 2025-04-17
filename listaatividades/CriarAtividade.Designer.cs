namespace listaatividades
{
    partial class CriarAtividade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            labelErro = new Label();
            textBoxTitulo = new TextBox();
            buttonCriar = new Button();
            buttondescartar = new Button();
            labelTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(buttondescartar);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 414);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "label2";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(278, 203);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 3;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(328, 232);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 2;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // buttondescartar
            // 
            buttondescartar.Location = new Point(247, 232);
            buttondescartar.Name = "buttondescartar";
            buttondescartar.Size = new Size(75, 23);
            buttondescartar.TabIndex = 1;
            buttondescartar.Text = "Descartar";
            buttondescartar.UseVisualStyleBackColor = true;
            buttondescartar.Click += buttondescartar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(310, 176);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Titulo";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelErro;
        private TextBox textBoxTitulo;
        private Button buttonCriar;
        private Button buttondescartar;
        private Label labelTitulo;
    }
}