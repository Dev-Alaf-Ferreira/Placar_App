namespace Placa_App
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            //CarregarImagem(pcbTimeA, lblNomeTimaA.Text);
            // CarregarImagem(pcbTimeB, lblNomeTimaB.Text);
            CarregarImagemCmbBox(pcbTimeA, cmbTimeA.Text);
            CarregarImagemCmbBox(pcbTimeB, cmbTimeB.Text);
        }

        private void CarregarImagemCmbBox(PictureBox pcbTime, string text)
        {
            if (text.Equals("Comando e Controle"))
                pcbTime.Image = Properties.Resources.ComandoControle;
            else if (text.Equals("Grupo de Apoio"))
                pcbTime.Image = Properties.Resources.Grupo_de_Apoio;
            else if (text.Equals("Licitacoes"))
                pcbTime.Image = Properties.Resources.Licitacoes;
            else if (text.Equals("Rancho"))
                pcbTime.Image = Properties.Resources.Rancho;
            else if (text.Equals("Sergenteacao"))
                pcbTime.Image = Properties.Resources.Sargenteacao;
            else if (text.Equals("Manutencao"))
                pcbTime.Image = Properties.Resources.Manutencao;
        }

        /*private void CarregarImagem(PictureBox pcbTime, string text)
        {
            if (text.Equals("Comando e Controle"))
                pcbTime.Image = Properties.Resources.ComandoControle;
            else if (text.Equals("Grupo de Apoio"))
                pcbTime.Image = Properties.Resources.Grupo_de_Apoio;
            else if (text.Equals("Licitacões"))
                pcbTime.Image = Properties.Resources.Licitacoes;
            else if (text.Equals("Rancho"))
                pcbTime.Image = Properties.Resources.Rancho;
            else if (text.Equals("Sergenteacão"))
                pcbTime.Image = Properties.Resources.Sergenteacao;
            else if (text.Equals("Manutenção"))
                pcbTime.Image = Properties.Resources.Manutencao;

        }*/

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
        int min = 15; int seg = 55;
        private void cronometro_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            string texto = "";
            if (min < 8)
                texto += "0" + min;
            else
                texto += min;

            if (seg < 8)
                texto += ":0" + seg;
            else
                texto += ":" + seg;
            lblCronometro.Text = texto;
            if (min < 8)
                lblTempo.Text = "1º Tempo";
            else
                lblTempo.Text = "2º Tempo";


            if ((min == 8 && seg == 0) || (min == 16))
            {
                cronometro.Enabled = false;
                btnComecar.Visible = true;
                DesativarBotoes();

                if (min == 8)
                    btnComecar.Text = "Começar 2º Tempo";
                else if (min == 16)
                    btnComecar.Text = "Começar Novo Jogo";
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            if (cmbTimeA.Text == cmbTimeB.Text)
            {
                MessageBox.Show("Error!!! O Time não pode ser o mesmo.");
            }
            else if (min == 16)
            {
                min = 0;
                seg = 0;
                lblCronometro.Text = "00:00";
                btnComecar.Text = "Começar jogo";
                lblTimeA.Text = "0";
                lblTimeB.Text = "0";
                lblTempo.Text = "1º Tempo";
                cmbTimeA.Enabled = true;
                cmbTimeB.Enabled = true;
            }
            else
            {
                cmbTimeA.Enabled = false;
                cmbTimeB.Enabled = false;
                cronometro.Enabled = true;
                btnComecar.Visible = false;
                AtivarBotoes();
            }
        }

        private void AtivarBotoes()
        {
            btnGolTimeA.Enabled = true;
            btnGolTimeB.Enabled = true;
            btnAnuladoTimeA.Enabled = true;
            btnAnuladoTimeB.Enabled = true;
        }
        private void DesativarBotoes()
        {
            btnGolTimeA.Enabled = false;
            btnGolTimeB.Enabled = false;
            btnAnuladoTimeA.Enabled = false;
            btnAnuladoTimeB.Enabled = false;
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            cronometro.Enabled = false;
        }

        private void cmbTimeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarImagemCmbBox(pcbTimeB, cmbTimeB.Text);
        }

        private void cmb_TimeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarImagemCmbBox(pcbTimeA, cmbTimeA.Text);
        }
    }
}