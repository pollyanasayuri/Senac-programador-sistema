namespace Calculadora2
{
    partial class FormsNovo
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
            radioButtonArea = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonVolume = new RadioButton();
            textBoxAltura = new TextBox();
            textBoxLargura = new TextBox();
            textBoxComprimento = new TextBox();
            buttonCalcular = new Button();
            groupBoxQuadrado = new GroupBox();
            labelErro = new Label();
            textBoxResultado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            groupBoxRetangulo = new GroupBox();
            button1 = new Button();
            radioButtonArea2 = new RadioButton();
            radioButtonPerimentro2 = new RadioButton();
            radioButtonVolume2 = new RadioButton();
            textBox8 = new TextBox();
            labelLado = new Label();
            textBox7 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBoxCirculo = new GroupBox();
            buttonCalcularCirculo = new Button();
            textBoxResultadoRaio = new TextBox();
            textBoxRaio = new TextBox();
            label9 = new Label();
            labelRaio = new Label();
            radioButtonVolumeCirculo = new RadioButton();
            radioButtonAreaCirculo = new RadioButton();
            radioButtonPerimetroCirculo = new RadioButton();
            radioButtonDiametroCirculo = new RadioButton();
            groupBoxQuadrado.SuspendLayout();
            groupBoxRetangulo.SuspendLayout();
            groupBoxCirculo.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(236, 96);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 0;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Área";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButtonArea_CheckedChanged;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(236, 121);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 1;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perímetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            radioButtonPerimetro.CheckedChanged += radioButtonPerimetro_CheckedChanged;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(236, 146);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(68, 19);
            radioButtonVolume.TabIndex = 2;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume ";
            radioButtonVolume.UseVisualStyleBackColor = true;
            radioButtonVolume.CheckedChanged += radioButtonVolume_CheckedChanged;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(88, 51);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(100, 23);
            textBoxAltura.TabIndex = 3;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(88, 22);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(100, 23);
            textBoxLargura.TabIndex = 4;
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(88, 80);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(100, 23);
            textBoxComprimento.TabIndex = 5;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(254, 50);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 6;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(labelErro);
            groupBoxQuadrado.Controls.Add(textBoxResultado);
            groupBoxQuadrado.Controls.Add(buttonCalcular);
            groupBoxQuadrado.Controls.Add(label3);
            groupBoxQuadrado.Controls.Add(label2);
            groupBoxQuadrado.Controls.Add(label1);
            groupBoxQuadrado.Controls.Add(radioButtonVolume);
            groupBoxQuadrado.Controls.Add(radioButtonPerimetro);
            groupBoxQuadrado.Controls.Add(radioButtonArea);
            groupBoxQuadrado.Controls.Add(textBoxComprimento);
            groupBoxQuadrado.Controls.Add(textBoxLargura);
            groupBoxQuadrado.Controls.Add(textBoxAltura);
            groupBoxQuadrado.Location = new Point(12, 42);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(355, 182);
            groupBoxQuadrado.TabIndex = 7;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Text = "Quadrado";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 261);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 8;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(88, 114);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 83);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 11;
            label3.Text = "Comprimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 9;
            label1.Text = "Largura:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quadrado", "Retangulo", "Circulo" });
            comboBox1.Location = new Point(18, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(button1);
            groupBoxRetangulo.Controls.Add(radioButtonArea2);
            groupBoxRetangulo.Controls.Add(radioButtonPerimentro2);
            groupBoxRetangulo.Controls.Add(radioButtonVolume2);
            groupBoxRetangulo.Controls.Add(textBox8);
            groupBoxRetangulo.Controls.Add(labelLado);
            groupBoxRetangulo.Controls.Add(textBox7);
            groupBoxRetangulo.Location = new Point(373, 42);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(415, 182);
            groupBoxRetangulo.TabIndex = 0;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Text = "Retangulo";
            // 
            // button1
            // 
            button1.Location = new Point(276, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea2
            // 
            radioButtonArea2.AutoSize = true;
            radioButtonArea2.Location = new Point(28, 96);
            radioButtonArea2.Name = "radioButtonArea2";
            radioButtonArea2.Size = new Size(49, 19);
            radioButtonArea2.TabIndex = 9;
            radioButtonArea2.TabStop = true;
            radioButtonArea2.Text = "Área";
            radioButtonArea2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimentro2
            // 
            radioButtonPerimentro2.AutoSize = true;
            radioButtonPerimentro2.Location = new Point(28, 121);
            radioButtonPerimentro2.Name = "radioButtonPerimentro2";
            radioButtonPerimentro2.Size = new Size(77, 19);
            radioButtonPerimentro2.TabIndex = 10;
            radioButtonPerimentro2.TabStop = true;
            radioButtonPerimentro2.Text = "Perímetro";
            radioButtonPerimentro2.UseVisualStyleBackColor = true;
            // 
            // radioButtonVolume2
            // 
            radioButtonVolume2.AutoSize = true;
            radioButtonVolume2.Location = new Point(28, 146);
            radioButtonVolume2.Name = "radioButtonVolume2";
            radioButtonVolume2.Size = new Size(65, 19);
            radioButtonVolume2.TabIndex = 11;
            radioButtonVolume2.TabStop = true;
            radioButtonVolume2.Text = "Volume";
            radioButtonVolume2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(115, 56);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 16;
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.Location = new Point(63, 25);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(36, 15);
            labelLado.TabIndex = 11;
            labelLado.Text = "Lado:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(115, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 267);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "diametro = 2 * r";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 314);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "area = Pi.r ^ 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 282);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 11;
            label6.Text = "perimetro = 2* Pi*r";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 329);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 12;
            label7.Text = "volume = 4/3 * Pi * r ^3";
            // 
            // groupBoxCirculo
            // 
            groupBoxCirculo.Controls.Add(buttonCalcularCirculo);
            groupBoxCirculo.Controls.Add(textBoxResultadoRaio);
            groupBoxCirculo.Controls.Add(textBoxRaio);
            groupBoxCirculo.Controls.Add(label9);
            groupBoxCirculo.Controls.Add(labelRaio);
            groupBoxCirculo.Controls.Add(radioButtonVolumeCirculo);
            groupBoxCirculo.Controls.Add(radioButtonAreaCirculo);
            groupBoxCirculo.Controls.Add(radioButtonPerimetroCirculo);
            groupBoxCirculo.Controls.Add(radioButtonDiametroCirculo);
            groupBoxCirculo.Location = new Point(15, 255);
            groupBoxCirculo.Name = "groupBoxCirculo";
            groupBoxCirculo.Size = new Size(326, 170);
            groupBoxCirculo.TabIndex = 13;
            groupBoxCirculo.TabStop = false;
            groupBoxCirculo.Text = "Circulo";
            // 
            // buttonCalcularCirculo
            // 
            buttonCalcularCirculo.Location = new Point(95, 128);
            buttonCalcularCirculo.Name = "buttonCalcularCirculo";
            buttonCalcularCirculo.Size = new Size(75, 23);
            buttonCalcularCirculo.TabIndex = 8;
            buttonCalcularCirculo.Text = "calcular";
            buttonCalcularCirculo.UseVisualStyleBackColor = true;
            buttonCalcularCirculo.Click += buttonCalcularCirculo_Click;
            // 
            // textBoxResultadoRaio
            // 
            textBoxResultadoRaio.Location = new Point(70, 69);
            textBoxResultadoRaio.Name = "textBoxResultadoRaio";
            textBoxResultadoRaio.Size = new Size(100, 23);
            textBoxResultadoRaio.TabIndex = 7;
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(70, 27);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 23);
            textBoxRaio.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 74);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 5;
            label9.Text = "Resultado:";
            // 
            // labelRaio
            // 
            labelRaio.AutoSize = true;
            labelRaio.Location = new Point(26, 30);
            labelRaio.Name = "labelRaio";
            labelRaio.Size = new Size(30, 15);
            labelRaio.TabIndex = 4;
            labelRaio.Text = "Raio";
            // 
            // radioButtonVolumeCirculo
            // 
            radioButtonVolumeCirculo.AutoSize = true;
            radioButtonVolumeCirculo.Location = new Point(216, 94);
            radioButtonVolumeCirculo.Name = "radioButtonVolumeCirculo";
            radioButtonVolumeCirculo.Size = new Size(65, 19);
            radioButtonVolumeCirculo.TabIndex = 3;
            radioButtonVolumeCirculo.TabStop = true;
            radioButtonVolumeCirculo.Text = "Volume";
            radioButtonVolumeCirculo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAreaCirculo
            // 
            radioButtonAreaCirculo.AutoSize = true;
            radioButtonAreaCirculo.Location = new Point(216, 69);
            radioButtonAreaCirculo.Name = "radioButtonAreaCirculo";
            radioButtonAreaCirculo.Size = new Size(49, 19);
            radioButtonAreaCirculo.TabIndex = 2;
            radioButtonAreaCirculo.TabStop = true;
            radioButtonAreaCirculo.Text = "Area";
            radioButtonAreaCirculo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetroCirculo
            // 
            radioButtonPerimetroCirculo.AutoSize = true;
            radioButtonPerimetroCirculo.Location = new Point(216, 46);
            radioButtonPerimetroCirculo.Name = "radioButtonPerimetroCirculo";
            radioButtonPerimetroCirculo.Size = new Size(77, 19);
            radioButtonPerimetroCirculo.TabIndex = 1;
            radioButtonPerimetroCirculo.TabStop = true;
            radioButtonPerimetroCirculo.Text = "Perimetro";
            radioButtonPerimetroCirculo.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiametroCirculo
            // 
            radioButtonDiametroCirculo.AutoSize = true;
            radioButtonDiametroCirculo.Location = new Point(216, 25);
            radioButtonDiametroCirculo.Name = "radioButtonDiametroCirculo";
            radioButtonDiametroCirculo.Size = new Size(73, 19);
            radioButtonDiametroCirculo.TabIndex = 0;
            radioButtonDiametroCirculo.TabStop = true;
            radioButtonDiametroCirculo.Text = "diametro";
            radioButtonDiametroCirculo.UseVisualStyleBackColor = true;
            // 
            // FormsNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCirculo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(groupBoxQuadrado);
            Controls.Add(comboBox1);
            Name = "FormsNovo";
            Text = "FormsNovo";
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            groupBoxCirculo.ResumeLayout(false);
            groupBoxCirculo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonArea;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonVolume;
        private TextBox textBoxAltura;
        private TextBox textBoxLargura;
        private TextBox textBoxComprimento;
        private Button buttonCalcular;
        private GroupBox groupBoxQuadrado;
        private GroupBox groupBoxRetangulo;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBoxResultado;
        private Label labelRaio;
        private Label label7;
        private Label label6;
        private Label labelLado;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label labelErro;
        private RadioButton radioButtonArea2;
        private RadioButton radioButtonPerimentro2;
        private RadioButton radioButtonVolume2;
        private Button button1;
        private Label label5;
        private GroupBox groupBoxCirculo;
        private RadioButton radioButtonVolumeCirculo;
        private RadioButton radioButtonAreaCirculo;
        private RadioButton radioButtonPerimetroCirculo;
        private RadioButton radioButtonDiametroCirculo;
        private TextBox textBoxResultadoRaio;
        private TextBox textBoxRaio;
        private Label label9;
        private Button buttonCalcularCirculo;
    }
}