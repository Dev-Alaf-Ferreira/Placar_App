namespace Placa_App
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            CarregarImagem(pcbTimeA, lblNomeTimaA.Text);
            CarregarImagem(pcbTimeB, lblNomeTimaB.Text);
        }

        private void CarregarImagem(PictureBox pcbTime, string text)
        {
            if (text.Equals("C2_FC"))
                pcbTime.Image = Properties.Resources.C2_FC;
            else if (text.Equals("Grupo_de_Apoio_FC"))
                pcbTime.Image = Properties.Resources.Grupo_de_Apoio_FC;
            else if (text.Equals("Licitacoes_FC"))
                pcbTime.Image = Properties.Resources.Licitacoes_FC;
            else if (text.Equals("Rancho_FC"))
                pcbTime.Image = Properties.Resources.Rancho_FC;
            else if (text.Equals("Sergenteacao_FC"))
                pcbTime.Image = Properties.Resources.Sergenteacao_FC;
            else if (text.Equals("Sub_Tenencia_FC"))
                pcbTime.Image = Properties.Resources.Sub_Tenencia_FC;

        }

        private void btnGolTimeA_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(lblTimeA.Text) + 1;
            lblTimeA.Text = resultado.ToString();
        }

        private void btnAnuladoTimeA_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(lblTimeA.Text);
            if (resultado > 0)
            {
                resultado--;
                lblTimeA.Text = resultado.ToString();
            }
        }

        private void btnGolTimeB_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(lblTimeB.Text) + 1;
            lblTimeB.Text = resultado.ToString();
        }

        private void btnAnuladoTimeB_Click(object sender, EventArgs e)
        {
            int resultado = int.Parse(lblTimeB.Text);
            if (resultado > 0)
            {
                resultado--;
                lblTimeB.Text = resultado.ToString();
            }

        }
        int min = 19; int seg = 55;
        private void cronometro_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            string texto = "";
            if (min < 10)
                texto += "0" + min;
            else
                texto += min;

            if (seg < 10)
                texto += ":0" + seg;
            else
                texto += ":" + seg;
            lblCronometro.Text = texto;
            if (min < 10)
                lblTempo.Text = "1º Tempo";
            else
                lblTempo.Text = "2º Tempo";


            if ((min == 10 && seg == 0) || (min == 20))
            {
                cronometro.Enabled = false;
                btnComecar.Visible = true;

                if (min == 10)
                    btnComecar.Text = "Começar 2ª parte";
                else if (min == 20)
                    btnComecar.Text = "Gravar e recomeçar";
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (min == 20)
            {
                min = 0;
                seg = 0;
                lblCronometro.Text = "00:00";
                btnComecar.Text = "Começar jogo";
            }
            cronometro.Enabled = true;
            btnComecar.Visible = false;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            cronometro.Enabled = false;
        }
    }
}