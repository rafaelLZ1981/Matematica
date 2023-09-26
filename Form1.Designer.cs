namespace Matematica
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            adicaoEsquerdaLabel = new Label();
            adicaoDireitaLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            resultadoAdicao = new NumericUpDown();
            resultadoSubtracao = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            subtracaoDireitaLabel = new Label();
            subtracaoEsquerdaLabel = new Label();
            resultadoMultiplicacao = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            multiplicacaoDireitaLabel = new Label();
            multiplicacaoEsquerdaLabel = new Label();
            resultadoDivisao = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            divisaoDireitaLabel = new Label();
            divisaoEsquerdaLabel = new Label();
            comecarButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            okLabel = new Label();
            insucessoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)resultadoAdicao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoSubtracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoMultiplicacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoDivisao).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(547, 18);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(241, 33);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(385, 19);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 1;
            label1.Text = "Tempo restante";
            // 
            // adicaoEsquerdaLabel
            // 
            adicaoEsquerdaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            adicaoEsquerdaLabel.Location = new Point(22, 107);
            adicaoEsquerdaLabel.Name = "adicaoEsquerdaLabel";
            adicaoEsquerdaLabel.Size = new Size(148, 50);
            adicaoEsquerdaLabel.TabIndex = 2;
            adicaoEsquerdaLabel.Text = "?";
            adicaoEsquerdaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adicaoDireitaLabel
            // 
            adicaoDireitaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            adicaoDireitaLabel.Location = new Point(271, 107);
            adicaoDireitaLabel.Name = "adicaoDireitaLabel";
            adicaoDireitaLabel.Size = new Size(148, 50);
            adicaoDireitaLabel.TabIndex = 3;
            adicaoDireitaLabel.Text = "?";
            adicaoDireitaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(191, 107);
            label3.Name = "label3";
            label3.Size = new Size(44, 50);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(403, 107);
            label4.Name = "label4";
            label4.Size = new Size(44, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultadoAdicao
            // 
            resultadoAdicao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoAdicao.Location = new Point(547, 114);
            resultadoAdicao.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            resultadoAdicao.Name = "resultadoAdicao";
            resultadoAdicao.Size = new Size(241, 39);
            resultadoAdicao.TabIndex = 6;
            // 
            // resultadoSubtracao
            // 
            resultadoSubtracao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoSubtracao.Location = new Point(547, 176);
            resultadoSubtracao.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            resultadoSubtracao.Name = "resultadoSubtracao";
            resultadoSubtracao.Size = new Size(241, 39);
            resultadoSubtracao.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(403, 169);
            label2.Name = "label2";
            label2.Size = new Size(44, 50);
            label2.TabIndex = 10;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(191, 169);
            label5.Name = "label5";
            label5.Size = new Size(44, 50);
            label5.TabIndex = 9;
            label5.Text = "-";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtracaoDireitaLabel
            // 
            subtracaoDireitaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtracaoDireitaLabel.Location = new Point(271, 169);
            subtracaoDireitaLabel.Name = "subtracaoDireitaLabel";
            subtracaoDireitaLabel.Size = new Size(148, 50);
            subtracaoDireitaLabel.TabIndex = 8;
            subtracaoDireitaLabel.Text = "?";
            subtracaoDireitaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtracaoEsquerdaLabel
            // 
            subtracaoEsquerdaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtracaoEsquerdaLabel.Location = new Point(22, 169);
            subtracaoEsquerdaLabel.Name = "subtracaoEsquerdaLabel";
            subtracaoEsquerdaLabel.Size = new Size(148, 50);
            subtracaoEsquerdaLabel.TabIndex = 7;
            subtracaoEsquerdaLabel.Text = "?";
            subtracaoEsquerdaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultadoMultiplicacao
            // 
            resultadoMultiplicacao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoMultiplicacao.Location = new Point(547, 235);
            resultadoMultiplicacao.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            resultadoMultiplicacao.Name = "resultadoMultiplicacao";
            resultadoMultiplicacao.Size = new Size(241, 39);
            resultadoMultiplicacao.TabIndex = 16;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(403, 228);
            label8.Name = "label8";
            label8.Size = new Size(44, 50);
            label8.TabIndex = 15;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(191, 228);
            label9.Name = "label9";
            label9.Size = new Size(44, 50);
            label9.TabIndex = 14;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplicacaoDireitaLabel
            // 
            multiplicacaoDireitaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicacaoDireitaLabel.Location = new Point(271, 228);
            multiplicacaoDireitaLabel.Name = "multiplicacaoDireitaLabel";
            multiplicacaoDireitaLabel.Size = new Size(148, 50);
            multiplicacaoDireitaLabel.TabIndex = 13;
            multiplicacaoDireitaLabel.Text = "?";
            multiplicacaoDireitaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplicacaoEsquerdaLabel
            // 
            multiplicacaoEsquerdaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicacaoEsquerdaLabel.Location = new Point(22, 228);
            multiplicacaoEsquerdaLabel.Name = "multiplicacaoEsquerdaLabel";
            multiplicacaoEsquerdaLabel.Size = new Size(148, 50);
            multiplicacaoEsquerdaLabel.TabIndex = 12;
            multiplicacaoEsquerdaLabel.Text = "?";
            multiplicacaoEsquerdaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultadoDivisao
            // 
            resultadoDivisao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoDivisao.Location = new Point(547, 294);
            resultadoDivisao.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            resultadoDivisao.Name = "resultadoDivisao";
            resultadoDivisao.Size = new Size(241, 39);
            resultadoDivisao.TabIndex = 21;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(403, 287);
            label12.Name = "label12";
            label12.Size = new Size(44, 50);
            label12.TabIndex = 20;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(191, 287);
            label13.Name = "label13";
            label13.Size = new Size(44, 50);
            label13.TabIndex = 19;
            label13.Text = "/";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisaoDireitaLabel
            // 
            divisaoDireitaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divisaoDireitaLabel.Location = new Point(271, 287);
            divisaoDireitaLabel.Name = "divisaoDireitaLabel";
            divisaoDireitaLabel.Size = new Size(148, 50);
            divisaoDireitaLabel.TabIndex = 18;
            divisaoDireitaLabel.Text = "?";
            divisaoDireitaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisaoEsquerdaLabel
            // 
            divisaoEsquerdaLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divisaoEsquerdaLabel.Location = new Point(22, 287);
            divisaoEsquerdaLabel.Name = "divisaoEsquerdaLabel";
            divisaoEsquerdaLabel.Size = new Size(148, 50);
            divisaoEsquerdaLabel.TabIndex = 17;
            divisaoEsquerdaLabel.Text = "?";
            divisaoEsquerdaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comecarButton
            // 
            comecarButton.Location = new Point(311, 385);
            comecarButton.Name = "comecarButton";
            comecarButton.Size = new Size(136, 42);
            comecarButton.TabIndex = 22;
            comecarButton.Text = "Começar";
            comecarButton.UseVisualStyleBackColor = true;
            comecarButton.Click += comecarButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // okLabel
            // 
            okLabel.BackColor = Color.DeepSkyBlue;
            okLabel.Dock = DockStyle.Bottom;
            okLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            okLabel.Location = new Point(0, 487);
            okLabel.Name = "okLabel";
            okLabel.Size = new Size(800, 74);
            okLabel.TabIndex = 23;
            okLabel.Text = "Acertou!";
            okLabel.TextAlign = ContentAlignment.MiddleCenter;
            okLabel.Visible = false;
            // 
            // insucessoLabel
            // 
            insucessoLabel.BackColor = Color.Salmon;
            insucessoLabel.Dock = DockStyle.Bottom;
            insucessoLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            insucessoLabel.Location = new Point(0, 413);
            insucessoLabel.Name = "insucessoLabel";
            insucessoLabel.Size = new Size(800, 74);
            insucessoLabel.TabIndex = 24;
            insucessoLabel.Text = "Tempo acabou!";
            insucessoLabel.TextAlign = ContentAlignment.MiddleCenter;
            insucessoLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(insucessoLabel);
            Controls.Add(okLabel);
            Controls.Add(comecarButton);
            Controls.Add(resultadoDivisao);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(divisaoDireitaLabel);
            Controls.Add(divisaoEsquerdaLabel);
            Controls.Add(resultadoMultiplicacao);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(multiplicacaoDireitaLabel);
            Controls.Add(multiplicacaoEsquerdaLabel);
            Controls.Add(resultadoSubtracao);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(subtracaoDireitaLabel);
            Controls.Add(subtracaoEsquerdaLabel);
            Controls.Add(resultadoAdicao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(adicaoDireitaLabel);
            Controls.Add(adicaoEsquerdaLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultadoAdicao).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoSubtracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoMultiplicacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoDivisao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label adicaoEsquerdaLabel;
        private Label adicaoDireitaLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown resultadoAdicao;
        private NumericUpDown resultadoSubtracao;
        private Label label2;
        private Label label5;
        private Label subtracaoDireitaLabel;
        private Label subtracaoEsquerdaLabel;
        private NumericUpDown resultadoMultiplicacao;
        private Label label8;
        private Label label9;
        private Label multiplicacaoDireitaLabel;
        private Label multiplicacaoEsquerdaLabel;
        private NumericUpDown resultadoDivisao;
        private Label label12;
        private Label label13;
        private Label divisaoDireitaLabel;
        private Label divisaoEsquerdaLabel;
        private Button comecarButton;
        private System.Windows.Forms.Timer timer;
        private Label okLabel;
        private Label insucessoLabel;
    }
}