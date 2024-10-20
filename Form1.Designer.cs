namespace Calculadora_Simples
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            rbtnAdicao = new RadioButton();
            rbtnSubtracao = new RadioButton();
            rbtnMultiplicacao = new RadioButton();
            rbtnDivisao = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(110, 145);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 0;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(279, 145);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 1;
            // 
            // rbtnAdicao
            // 
            rbtnAdicao.AutoSize = true;
            rbtnAdicao.Location = new Point(449, 148);
            rbtnAdicao.Name = "rbtnAdicao";
            rbtnAdicao.Size = new Size(77, 24);
            rbtnAdicao.TabIndex = 2;
            rbtnAdicao.TabStop = true;
            rbtnAdicao.Text = "Adição";
            rbtnAdicao.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtracao
            // 
            rbtnSubtracao.AutoSize = true;
            rbtnSubtracao.Location = new Point(449, 196);
            rbtnSubtracao.Name = "rbtnSubtracao";
            rbtnSubtracao.Size = new Size(97, 24);
            rbtnSubtracao.TabIndex = 3;
            rbtnSubtracao.TabStop = true;
            rbtnSubtracao.Text = "Subtração";
            rbtnSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplicacao
            // 
            rbtnMultiplicacao.AutoSize = true;
            rbtnMultiplicacao.Location = new Point(449, 239);
            rbtnMultiplicacao.Name = "rbtnMultiplicacao";
            rbtnMultiplicacao.Size = new Size(120, 24);
            rbtnMultiplicacao.TabIndex = 4;
            rbtnMultiplicacao.TabStop = true;
            rbtnMultiplicacao.Text = "Multiplicação";
            rbtnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbtnDivisao
            // 
            rbtnDivisao.AutoSize = true;
            rbtnDivisao.Location = new Point(449, 281);
            rbtnDivisao.Name = "rbtnDivisao";
            rbtnDivisao.Size = new Size(79, 24);
            rbtnDivisao.TabIndex = 5;
            rbtnDivisao.TabStop = true;
            rbtnDivisao.Text = "Divisão";
            rbtnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(215, 316);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(215, 241);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 467);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(rbtnDivisao);
            Controls.Add(rbtnMultiplicacao);
            Controls.Add(rbtnSubtracao);
            Controls.Add(rbtnAdicao);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private RadioButton rbtnAdicao;
        private RadioButton rbtnSubtracao;
        private RadioButton rbtnMultiplicacao;
        private RadioButton rbtnDivisao;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
