namespace Placa_App
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            pcbTimeB = new PictureBox();
            pcbTimeA = new PictureBox();
            lblCronometro = new Label();
            btnGolTimeA = new Button();
            btnAnuladoTimeA = new Button();
            btnGolTimeB = new Button();
            btnAnuladoTimeB = new Button();
            lblTimeA = new Label();
            lblTimeB = new Label();
            lblNomeTimaA = new Label();
            lblNomeTimaB = new Label();
            cronometro = new System.Windows.Forms.Timer(components);
            lblTempo = new Label();
            btnComecar = new Button();
            panel1 = new Panel();
            cmbTimeB = new ComboBox();
            cmbTimeA = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbTimeB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTimeA).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pcbTimeB
            // 
            pcbTimeB.Anchor = AnchorStyles.None;
            pcbTimeB.Location = new Point(398, 55);
            pcbTimeB.Name = "pcbTimeB";
            pcbTimeB.Size = new Size(224, 176);
            pcbTimeB.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTimeB.TabIndex = 0;
            pcbTimeB.TabStop = false;
            // 
            // pcbTimeA
            // 
            pcbTimeA.Anchor = AnchorStyles.None;
            pcbTimeA.Location = new Point(12, 55);
            pcbTimeA.Name = "pcbTimeA";
            pcbTimeA.Size = new Size(232, 176);
            pcbTimeA.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTimeA.TabIndex = 1;
            pcbTimeA.TabStop = false;
            // 
            // lblCronometro
            // 
            lblCronometro.Anchor = AnchorStyles.None;
            lblCronometro.BackColor = Color.Transparent;
            lblCronometro.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCronometro.ForeColor = SystemColors.ActiveCaptionText;
            lblCronometro.Location = new Point(250, 128);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(142, 65);
            lblCronometro.TabIndex = 2;
            lblCronometro.Text = "00:00";
            // 
            // btnGolTimeA
            // 
            btnGolTimeA.Anchor = AnchorStyles.None;
            btnGolTimeA.BackColor = Color.Transparent;
            btnGolTimeA.Enabled = false;
            btnGolTimeA.FlatStyle = FlatStyle.Flat;
            btnGolTimeA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGolTimeA.ForeColor = SystemColors.ActiveCaptionText;
            btnGolTimeA.Location = new Point(12, 367);
            btnGolTimeA.Name = "btnGolTimeA";
            btnGolTimeA.Size = new Size(75, 35);
            btnGolTimeA.TabIndex = 3;
            btnGolTimeA.Text = "GOL";
            btnGolTimeA.UseVisualStyleBackColor = false;
            btnGolTimeA.Click += btnGolTimeA_Click;
            // 
            // btnAnuladoTimeA
            // 
            btnAnuladoTimeA.Anchor = AnchorStyles.None;
            btnAnuladoTimeA.BackColor = Color.Transparent;
            btnAnuladoTimeA.Enabled = false;
            btnAnuladoTimeA.FlatStyle = FlatStyle.Flat;
            btnAnuladoTimeA.ForeColor = SystemColors.ActiveCaptionText;
            btnAnuladoTimeA.Location = new Point(137, 367);
            btnAnuladoTimeA.Name = "btnAnuladoTimeA";
            btnAnuladoTimeA.Size = new Size(75, 35);
            btnAnuladoTimeA.TabIndex = 4;
            btnAnuladoTimeA.Text = "ANULADO";
            btnAnuladoTimeA.UseVisualStyleBackColor = false;
            btnAnuladoTimeA.Click += btnAnuladoTimeA_Click;
            // 
            // btnGolTimeB
            // 
            btnGolTimeB.Anchor = AnchorStyles.None;
            btnGolTimeB.BackColor = Color.Transparent;
            btnGolTimeB.Enabled = false;
            btnGolTimeB.FlatStyle = FlatStyle.Flat;
            btnGolTimeB.ForeColor = SystemColors.ActiveCaptionText;
            btnGolTimeB.Location = new Point(422, 368);
            btnGolTimeB.Name = "btnGolTimeB";
            btnGolTimeB.Size = new Size(75, 35);
            btnGolTimeB.TabIndex = 5;
            btnGolTimeB.Text = "GOL";
            btnGolTimeB.UseVisualStyleBackColor = false;
            btnGolTimeB.Click += btnGolTimeB_Click;
            // 
            // btnAnuladoTimeB
            // 
            btnAnuladoTimeB.Anchor = AnchorStyles.None;
            btnAnuladoTimeB.BackColor = Color.Transparent;
            btnAnuladoTimeB.Enabled = false;
            btnAnuladoTimeB.FlatStyle = FlatStyle.Flat;
            btnAnuladoTimeB.ForeColor = SystemColors.ActiveCaptionText;
            btnAnuladoTimeB.Location = new Point(547, 368);
            btnAnuladoTimeB.Name = "btnAnuladoTimeB";
            btnAnuladoTimeB.Size = new Size(75, 35);
            btnAnuladoTimeB.TabIndex = 6;
            btnAnuladoTimeB.Text = "ANULADO";
            btnAnuladoTimeB.UseVisualStyleBackColor = false;
            btnAnuladoTimeB.Click += btnAnuladoTimeB_Click;
            // 
            // lblTimeA
            // 
            lblTimeA.Anchor = AnchorStyles.None;
            lblTimeA.BackColor = Color.Transparent;
            lblTimeA.FlatStyle = FlatStyle.Flat;
            lblTimeA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeA.ForeColor = SystemColors.ActiveCaptionText;
            lblTimeA.Location = new Point(104, 321);
            lblTimeA.Name = "lblTimeA";
            lblTimeA.Size = new Size(19, 21);
            lblTimeA.TabIndex = 7;
            lblTimeA.Text = "0";
            lblTimeA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeB
            // 
            lblTimeB.Anchor = AnchorStyles.None;
            lblTimeB.BackColor = Color.Transparent;
            lblTimeB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeB.ForeColor = SystemColors.ActiveCaptionText;
            lblTimeB.Location = new Point(518, 321);
            lblTimeB.Name = "lblTimeB";
            lblTimeB.Size = new Size(19, 21);
            lblTimeB.TabIndex = 8;
            lblTimeB.Text = "0";
            // 
            // lblNomeTimaA
            // 
            lblNomeTimaA.Anchor = AnchorStyles.None;
            lblNomeTimaA.BackColor = Color.Transparent;
            lblNomeTimaA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeTimaA.ForeColor = SystemColors.ActiveCaptionText;
            lblNomeTimaA.Location = new Point(36, 282);
            lblNomeTimaA.Name = "lblNomeTimaA";
            lblNomeTimaA.Size = new Size(154, 21);
            lblNomeTimaA.TabIndex = 9;
            lblNomeTimaA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeTimaB
            // 
            lblNomeTimaB.Anchor = AnchorStyles.None;
            lblNomeTimaB.BackColor = Color.Transparent;
            lblNomeTimaB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeTimaB.ForeColor = SystemColors.ActiveCaptionText;
            lblNomeTimaB.Location = new Point(474, 282);
            lblNomeTimaB.Name = "lblNomeTimaB";
            lblNomeTimaB.RightToLeft = RightToLeft.No;
            lblNomeTimaB.Size = new Size(120, 21);
            lblNomeTimaB.TabIndex = 10;
            lblNomeTimaB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cronometro
            // 
            cronometro.Interval = 1000;
            cronometro.Tick += cronometro_Tick;
            // 
            // lblTempo
            // 
            lblTempo.Anchor = AnchorStyles.None;
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTempo.ForeColor = SystemColors.ActiveCaptionText;
            lblTempo.Location = new Point(279, 193);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(67, 19);
            lblTempo.TabIndex = 12;
            lblTempo.Text = "1 TEMPO";
            // 
            // btnComecar
            // 
            btnComecar.Anchor = AnchorStyles.None;
            btnComecar.BackColor = Color.Transparent;
            btnComecar.FlatStyle = FlatStyle.Flat;
            btnComecar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnComecar.ForeColor = SystemColors.ActiveCaptionText;
            btnComecar.Location = new Point(250, 249);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(142, 54);
            btnComecar.TabIndex = 13;
            btnComecar.Text = "Começar Jogo";
            btnComecar.UseVisualStyleBackColor = false;
            btnComecar.Click += btnComecar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(cmbTimeB);
            panel1.Controls.Add(lblNomeTimaA);
            panel1.Controls.Add(lblNomeTimaB);
            panel1.Controls.Add(lblTempo);
            panel1.Controls.Add(cmbTimeA);
            panel1.Controls.Add(lblTimeA);
            panel1.Controls.Add(lblTimeB);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 461);
            panel1.TabIndex = 14;
            // 
            // cmbTimeB
            // 
            cmbTimeB.Anchor = AnchorStyles.None;
            cmbTimeB.FlatStyle = FlatStyle.Flat;
            cmbTimeB.FormattingEnabled = true;
            cmbTimeB.Items.AddRange(new object[] { "Grupo de Apoio", "Comando e Controle", "Sargenteacao", "Licitacoes", "Manutencao", "Rancho" });
            cmbTimeB.Location = new Point(422, 249);
            cmbTimeB.Name = "cmbTimeB";
            cmbTimeB.Size = new Size(200, 23);
            cmbTimeB.TabIndex = 17;
            cmbTimeB.SelectedIndexChanged += cmbTimeB_SelectedIndexChanged;
            // 
            // cmbTimeA
            // 
            cmbTimeA.Anchor = AnchorStyles.None;
            cmbTimeA.FlatStyle = FlatStyle.Flat;
            cmbTimeA.FormattingEnabled = true;
            cmbTimeA.Items.AddRange(new object[] { "Grupo de Apoio", "Comando e Controle", "Sargenteacao", "Licitacoes", "Manutencao", "Rancho" });
            cmbTimeA.Location = new Point(12, 249);
            cmbTimeA.Name = "cmbTimeA";
            cmbTimeA.Size = new Size(200, 23);
            cmbTimeA.TabIndex = 16;
            cmbTimeA.SelectedIndexChanged += cmb_TimeA_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(634, 461);
            Controls.Add(btnComecar);
            Controls.Add(btnAnuladoTimeB);
            Controls.Add(btnGolTimeB);
            Controls.Add(btnAnuladoTimeA);
            Controls.Add(btnGolTimeA);
            Controls.Add(lblCronometro);
            Controls.Add(pcbTimeA);
            Controls.Add(pcbTimeB);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(650, 500);
            Name = "Main_menu";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campeonato 17º Pelotão de Comunicações de Selva";
            ((System.ComponentModel.ISupportInitialize)pcbTimeB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTimeA).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbTimeB;
        private PictureBox pcbTimeA;
        private Label lblCronometro;
        private Button btnGolTimeA;
        private Button btnAnuladoTimeA;
        private Button btnGolTimeB;
        private Button btnAnuladoTimeB;
        private Label lblTimeA;
        private Label lblTimeB;
        private Label lblNomeTimaA;
        private Label lblNomeTimaB;
        private System.Windows.Forms.Timer cronometro;
        private Label lblTempo;
        private Button btnComecar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox cmbTimeA;
        private ComboBox cmbTimeB;
    }
}