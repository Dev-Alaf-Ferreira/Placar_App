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
            ((System.ComponentModel.ISupportInitialize)pcbTimeB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTimeA).BeginInit();
            SuspendLayout();
            // 
            // pcbTimeB
            // 
            pcbTimeB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbTimeB.Location = new Point(422, 81);
            pcbTimeB.Name = "pcbTimeB";
            pcbTimeB.Size = new Size(200, 150);
            pcbTimeB.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTimeB.TabIndex = 0;
            pcbTimeB.TabStop = false;
            // 
            // pcbTimeA
            // 
            pcbTimeA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcbTimeA.Location = new Point(12, 81);
            pcbTimeA.Name = "pcbTimeA";
            pcbTimeA.Size = new Size(200, 150);
            pcbTimeA.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTimeA.TabIndex = 1;
            pcbTimeA.TabStop = false;
            // 
            // lblCronometro
            // 
            lblCronometro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCronometro.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCronometro.Location = new Point(250, 128);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(142, 65);
            lblCronometro.TabIndex = 2;
            lblCronometro.Text = "00:00";
            // 
            // btnGolTimeA
            // 
            btnGolTimeA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGolTimeA.Enabled = false;
            btnGolTimeA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGolTimeA.Location = new Point(12, 358);
            btnGolTimeA.Name = "btnGolTimeA";
            btnGolTimeA.Size = new Size(75, 35);
            btnGolTimeA.TabIndex = 3;
            btnGolTimeA.Text = "GOL";
            btnGolTimeA.UseVisualStyleBackColor = true;
            btnGolTimeA.Click += btnGolTimeA_Click;
            // 
            // btnAnuladoTimeA
            // 
            btnAnuladoTimeA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnuladoTimeA.Enabled = false;
            btnAnuladoTimeA.Location = new Point(137, 358);
            btnAnuladoTimeA.Name = "btnAnuladoTimeA";
            btnAnuladoTimeA.Size = new Size(75, 35);
            btnAnuladoTimeA.TabIndex = 4;
            btnAnuladoTimeA.Text = "ANULADO";
            btnAnuladoTimeA.UseVisualStyleBackColor = true;
            btnAnuladoTimeA.Click += btnAnuladoTimeA_Click;
            // 
            // btnGolTimeB
            // 
            btnGolTimeB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGolTimeB.Enabled = false;
            btnGolTimeB.Location = new Point(422, 359);
            btnGolTimeB.Name = "btnGolTimeB";
            btnGolTimeB.Size = new Size(75, 35);
            btnGolTimeB.TabIndex = 5;
            btnGolTimeB.Text = "GOL";
            btnGolTimeB.UseVisualStyleBackColor = true;
            btnGolTimeB.Click += btnGolTimeB_Click;
            // 
            // btnAnuladoTimeB
            // 
            btnAnuladoTimeB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnuladoTimeB.Enabled = false;
            btnAnuladoTimeB.Location = new Point(547, 359);
            btnAnuladoTimeB.Name = "btnAnuladoTimeB";
            btnAnuladoTimeB.Size = new Size(75, 35);
            btnAnuladoTimeB.TabIndex = 6;
            btnAnuladoTimeB.Text = "ANULADO";
            btnAnuladoTimeB.UseVisualStyleBackColor = true;
            btnAnuladoTimeB.Click += btnAnuladoTimeB_Click;
            // 
            // lblTimeA
            // 
            lblTimeA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeA.Location = new Point(100, 311);
            lblTimeA.Name = "lblTimeA";
            lblTimeA.Size = new Size(19, 21);
            lblTimeA.TabIndex = 7;
            lblTimeA.Text = "0";
            // 
            // lblTimeB
            // 
            lblTimeB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeB.Location = new Point(518, 311);
            lblTimeB.Name = "lblTimeB";
            lblTimeB.Size = new Size(19, 21);
            lblTimeB.TabIndex = 8;
            lblTimeB.Text = "0";
            // 
            // lblNomeTimaA
            // 
            lblNomeTimaA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeTimaA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeTimaA.Location = new Point(36, 265);
            lblNomeTimaA.Name = "lblNomeTimaA";
            lblNomeTimaA.Size = new Size(154, 21);
            lblNomeTimaA.TabIndex = 9;
            lblNomeTimaA.Text = "Comando e Controle";
            lblNomeTimaA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeTimaB
            // 
            lblNomeTimaB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeTimaB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeTimaB.Location = new Point(469, 265);
            lblNomeTimaB.Name = "lblNomeTimaB";
            lblNomeTimaB.RightToLeft = RightToLeft.No;
            lblNomeTimaB.Size = new Size(120, 21);
            lblNomeTimaB.TabIndex = 10;
            lblNomeTimaB.Text = "Grupo de Apoio";
            lblNomeTimaB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cronometro
            // 
            cronometro.Interval = 1000;
            cronometro.Tick += cronometro_Tick;
            // 
            // lblTempo
            // 
            lblTempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTempo.Location = new Point(285, 193);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(67, 19);
            lblTempo.TabIndex = 12;
            lblTempo.Text = "1 TEMPO";
            // 
            // btnComecar
            // 
            btnComecar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnComecar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnComecar.Location = new Point(250, 249);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(142, 54);
            btnComecar.TabIndex = 13;
            btnComecar.Text = "Começar Jogo";
            btnComecar.UseVisualStyleBackColor = true;
            btnComecar.Click += btnComecar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 461);
            panel1.TabIndex = 14;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(btnComecar);
            Controls.Add(lblTempo);
            Controls.Add(lblNomeTimaB);
            Controls.Add(lblNomeTimaA);
            Controls.Add(lblTimeB);
            Controls.Add(lblTimeA);
            Controls.Add(btnAnuladoTimeB);
            Controls.Add(btnGolTimeB);
            Controls.Add(btnAnuladoTimeA);
            Controls.Add(btnGolTimeA);
            Controls.Add(lblCronometro);
            Controls.Add(pcbTimeA);
            Controls.Add(pcbTimeB);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(650, 500);
            Name = "Main_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campeonato 17º Pelotão de Comunicações de Selva";
            ((System.ComponentModel.ISupportInitialize)pcbTimeB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTimeA).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}