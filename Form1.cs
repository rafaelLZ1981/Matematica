using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Matematica
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();
        int tempoRestante;

        public Form1()
        {
            InitializeComponent();
        }

        private void comecarButton_Click(object sender, EventArgs e)
        {
            ComecarQuiz();
            comecarButton.Enabled = false;
        }

        public void ComecarQuiz()
        {
            adicaoEsquerdaLabel.Text = randomizer.Next(51).ToString();
            adicaoDireitaLabel.Text = randomizer.Next(51).ToString();
            resultadoAdicao.Value = 0;

            int subtracaoEsquerda = randomizer.Next(1, 101);
            subtracaoEsquerdaLabel.Text = subtracaoEsquerda.ToString();
            subtracaoDireitaLabel.Text = randomizer.Next(1, subtracaoEsquerda).ToString();
            resultadoSubtracao.Value = 0;

            multiplicacaoEsquerdaLabel.Text = randomizer.Next(2, 11).ToString();
            multiplicacaoDireitaLabel.Text = randomizer.Next(2, 11).ToString();
            resultadoMultiplicacao.Value = 0;

            divisaoEsquerdaLabel.Text = randomizer.Next(2, 11).ToString();
            divisaoDireitaLabel.Text = randomizer.Next(2, 11).ToString();
            resultadoDivisao.Value = 0;

            int divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            int dividend = divisor * temporaryQuotient;
            divisaoEsquerdaLabel.Text = dividend.ToString();
            divisaoDireitaLabel.Text = divisor.ToString();
            resultadoDivisao.Value = 0;

            okLabel.Hide();
            insucessoLabel.Hide();

            tempoRestante = 30;
            timeLabel.Text = tempoRestante + " segundos";
            timer.Start();
        }

        private bool VerificarResultado()
        {
            return
               ((int.Parse(adicaoEsquerdaLabel.Text) + int.Parse(adicaoDireitaLabel.Text)) == resultadoAdicao.Value &&
               (int.Parse(subtracaoEsquerdaLabel.Text) - int.Parse(subtracaoDireitaLabel.Text)) == resultadoSubtracao.Value &&
               (int.Parse(multiplicacaoEsquerdaLabel.Text) * int.Parse(multiplicacaoDireitaLabel.Text)) == resultadoMultiplicacao.Value &&
               (int.Parse(divisaoEsquerdaLabel.Text) / int.Parse(divisaoDireitaLabel.Text)) == resultadoDivisao.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (VerificarResultado())
            {
                timer.Stop();
                okLabel.Show();
                comecarButton.Enabled = true;
            }
            else if (tempoRestante > 0)
            {
                tempoRestante = tempoRestante - 1;
                timeLabel.Text = tempoRestante + " segundos";
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Tempo acabou!";
                insucessoLabel.Show();

                resultadoAdicao.Value = (int.Parse(adicaoEsquerdaLabel.Text) + int.Parse(adicaoDireitaLabel.Text));
                resultadoSubtracao.Value = (int.Parse(subtracaoEsquerdaLabel.Text) - int.Parse(subtracaoDireitaLabel.Text));
                resultadoMultiplicacao.Value = (int.Parse(multiplicacaoEsquerdaLabel.Text) * int.Parse(multiplicacaoDireitaLabel.Text));
                resultadoDivisao.Value = (int.Parse(divisaoEsquerdaLabel.Text) / int.Parse(divisaoDireitaLabel.Text));
                comecarButton.Enabled = true;
            }
        }
    }
}