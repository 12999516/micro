namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_squadra_casa = new System.Windows.Forms.Label();
            this.lbl_squadra_trasferta = new System.Windows.Forms.Label();
            this.lbl_gol_casa = new System.Windows.Forms.Label();
            this.lbl_gol_trasferta = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.lst_visualizza = new System.Windows.Forms.ListBox();
            this.txt_squadra_casa = new System.Windows.Forms.TextBox();
            this.txt_squadra_trasferta = new System.Windows.Forms.TextBox();
            this.txt_gol_casa = new System.Windows.Forms.TextBox();
            this.txt_gol_trasferta = new System.Windows.Forms.TextBox();
            this.btn_squadra_max = new System.Windows.Forms.Button();
            this.btn_totale_gol = new System.Windows.Forms.Button();
            this.btn_partita_piu_gol = new System.Windows.Forms.Button();
            this.btn_cerca_squadra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_squadra_casa
            // 
            this.lbl_squadra_casa.Location = new System.Drawing.Point(15, 25);
            this.lbl_squadra_casa.Name = "lbl_squadra_casa";
            this.lbl_squadra_casa.Size = new System.Drawing.Size(107, 20);
            this.lbl_squadra_casa.TabIndex = 0;
            this.lbl_squadra_casa.Text = "squadra di casa";
            // 
            // lbl_squadra_trasferta
            // 
            this.lbl_squadra_trasferta.Location = new System.Drawing.Point(166, 25);
            this.lbl_squadra_trasferta.Name = "lbl_squadra_trasferta";
            this.lbl_squadra_trasferta.Size = new System.Drawing.Size(169, 20);
            this.lbl_squadra_trasferta.TabIndex = 1;
            this.lbl_squadra_trasferta.Text = "squadra in trasferta";
            // 
            // lbl_gol_casa
            // 
            this.lbl_gol_casa.Location = new System.Drawing.Point(318, 23);
            this.lbl_gol_casa.Name = "lbl_gol_casa";
            this.lbl_gol_casa.Size = new System.Drawing.Size(108, 20);
            this.lbl_gol_casa.TabIndex = 2;
            this.lbl_gol_casa.Text = "gol squadra casa";
            this.lbl_gol_casa.Click += new System.EventHandler(this.lbl_gol_casa_Click);
            // 
            // lbl_gol_trasferta
            // 
            this.lbl_gol_trasferta.Location = new System.Drawing.Point(460, 25);
            this.lbl_gol_trasferta.Name = "lbl_gol_trasferta";
            this.lbl_gol_trasferta.Size = new System.Drawing.Size(117, 20);
            this.lbl_gol_trasferta.TabIndex = 3;
            this.lbl_gol_trasferta.Text = "gol squadra in trasferta";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(645, 75);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(85, 60);
            this.btn_aggiungi.TabIndex = 4;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // lst_visualizza
            // 
            this.lst_visualizza.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_visualizza.FormattingEnabled = true;
            this.lst_visualizza.ItemHeight = 12;
            this.lst_visualizza.Location = new System.Drawing.Point(18, 75);
            this.lst_visualizza.Name = "lst_visualizza";
            this.lst_visualizza.Size = new System.Drawing.Size(604, 364);
            this.lst_visualizza.TabIndex = 5;
            // 
            // txt_squadra_casa
            // 
            this.txt_squadra_casa.Location = new System.Drawing.Point(19, 48);
            this.txt_squadra_casa.Name = "txt_squadra_casa";
            this.txt_squadra_casa.Size = new System.Drawing.Size(120, 20);
            this.txt_squadra_casa.TabIndex = 6;
            // 
            // txt_squadra_trasferta
            // 
            this.txt_squadra_trasferta.Location = new System.Drawing.Point(169, 48);
            this.txt_squadra_trasferta.Name = "txt_squadra_trasferta";
            this.txt_squadra_trasferta.Size = new System.Drawing.Size(129, 20);
            this.txt_squadra_trasferta.TabIndex = 7;
            // 
            // txt_gol_casa
            // 
            this.txt_gol_casa.Location = new System.Drawing.Point(321, 48);
            this.txt_gol_casa.Name = "txt_gol_casa";
            this.txt_gol_casa.Size = new System.Drawing.Size(131, 20);
            this.txt_gol_casa.TabIndex = 8;
            // 
            // txt_gol_trasferta
            // 
            this.txt_gol_trasferta.Location = new System.Drawing.Point(463, 48);
            this.txt_gol_trasferta.Name = "txt_gol_trasferta";
            this.txt_gol_trasferta.Size = new System.Drawing.Size(114, 20);
            this.txt_gol_trasferta.TabIndex = 9;
            // 
            // btn_squadra_max
            // 
            this.btn_squadra_max.Location = new System.Drawing.Point(645, 150);
            this.btn_squadra_max.Name = "btn_squadra_max";
            this.btn_squadra_max.Size = new System.Drawing.Size(85, 60);
            this.btn_squadra_max.TabIndex = 10;
            this.btn_squadra_max.Text = "squadra che ha segnato maggior gol\r\n";
            this.btn_squadra_max.UseVisualStyleBackColor = true;
            this.btn_squadra_max.Click += new System.EventHandler(this.btn_squadra_max_Click);
            // 
            // btn_totale_gol
            // 
            this.btn_totale_gol.Location = new System.Drawing.Point(645, 225);
            this.btn_totale_gol.Name = "btn_totale_gol";
            this.btn_totale_gol.Size = new System.Drawing.Size(85, 60);
            this.btn_totale_gol.TabIndex = 11;
            this.btn_totale_gol.Text = "totale gol\r\n";
            this.btn_totale_gol.UseVisualStyleBackColor = true;
            this.btn_totale_gol.Click += new System.EventHandler(this.btn_totale_gol_Click);
            // 
            // btn_partita_piu_gol
            // 
            this.btn_partita_piu_gol.Location = new System.Drawing.Point(645, 300);
            this.btn_partita_piu_gol.Name = "btn_partita_piu_gol";
            this.btn_partita_piu_gol.Size = new System.Drawing.Size(85, 60);
            this.btn_partita_piu_gol.TabIndex = 12;
            this.btn_partita_piu_gol.Text = "partita con il maggior gol\r\n";
            this.btn_partita_piu_gol.UseVisualStyleBackColor = true;
            this.btn_partita_piu_gol.Click += new System.EventHandler(this.btn_partita_piu_gol_Click);
            // 
            // btn_cerca_squadra
            // 
            this.btn_cerca_squadra.Location = new System.Drawing.Point(645, 378);
            this.btn_cerca_squadra.Name = "btn_cerca_squadra";
            this.btn_cerca_squadra.Size = new System.Drawing.Size(85, 60);
            this.btn_cerca_squadra.TabIndex = 13;
            this.btn_cerca_squadra.Text = "cerca la squadra\r\n";
            this.btn_cerca_squadra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerca_squadra);
            this.Controls.Add(this.btn_partita_piu_gol);
            this.Controls.Add(this.btn_totale_gol);
            this.Controls.Add(this.btn_squadra_max);
            this.Controls.Add(this.txt_gol_trasferta);
            this.Controls.Add(this.txt_gol_casa);
            this.Controls.Add(this.txt_squadra_trasferta);
            this.Controls.Add(this.txt_squadra_casa);
            this.Controls.Add(this.lst_visualizza);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.lbl_gol_trasferta);
            this.Controls.Add(this.lbl_gol_casa);
            this.Controls.Add(this.lbl_squadra_trasferta);
            this.Controls.Add(this.lbl_squadra_casa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_squadra_casa;
        private System.Windows.Forms.Label lbl_squadra_trasferta;
        private System.Windows.Forms.Label lbl_gol_casa;
        private System.Windows.Forms.Label lbl_gol_trasferta;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.ListBox lst_visualizza;
        private System.Windows.Forms.TextBox txt_squadra_casa;
        private System.Windows.Forms.TextBox txt_squadra_trasferta;
        private System.Windows.Forms.TextBox txt_gol_casa;
        private System.Windows.Forms.TextBox txt_gol_trasferta;
        private System.Windows.Forms.Button btn_squadra_max;
        private System.Windows.Forms.Button btn_totale_gol;
        private System.Windows.Forms.Button btn_partita_piu_gol;
        private System.Windows.Forms.Button btn_cerca_squadra;
    }
}

