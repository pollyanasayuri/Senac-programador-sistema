namespace Calculadora2
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
            comboBox = new ComboBox();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            textBoxResultado = new TextBox();
            labelOperador = new Label();
            buttonCalcular = new Button();
            labelIgual = new Label();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(230, 150);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 0;
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(102, 77);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(100, 23);
            textBoxValor1.TabIndex = 1;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(235, 77);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(100, 23);
            textBoxValor2.TabIndex = 2;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(367, 77);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 3;
            // 
            // labelOperador
            // 
            labelOperador.AutoSize = true;
            labelOperador.Font = new Font("Segoe UI", 12F);
            labelOperador.Location = new Point(208, 77);
            labelOperador.Name = "labelOperador";
            labelOperador.Size = new Size(0, 21);
            labelOperador.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(260, 219);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Location = new Point(346, 80);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(15, 15);
            labelIgual.TabIndex = 6;
            labelIgual.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelIgual);
            Controls.Add(buttonCalcular);
            Controls.Add(labelOperador);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(comboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox;
        private TextBox textBoxValor1;
        private TextBox textBoxValor2;
        private TextBox textBoxResultado;
        private Label labelOperador;
        private Button buttonCalcular;
        private Label labelIgual;
    }
}
