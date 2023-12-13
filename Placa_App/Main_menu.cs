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
        int min = 0; int seg = 0;
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
            if (min == 10 && seg == 0)
                cronometro.Enabled = false;
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            cronometro.Enabled = true;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            cronometro.Stop();
        }
    }
}