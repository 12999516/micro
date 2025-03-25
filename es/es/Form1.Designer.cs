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
            this.SuspendLayout();
            // 
            // lbl_squadra_casa
            // 
            this.lbl_squadra_casa.Location = new System.Drawing.Point(20, 31);
            this.lbl_squadra_casa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_squadra_casa.Name = "lbl_squadra_casa";
            this.lbl_squadra_casa.Size = new System.Drawing.Size(143, 25);
            this.lbl_squadra_casa.TabIndex = 0;
            this.lbl_squadra_casa.Text = "squadra di casa";
            // 
            // lbl_squadra_trasferta
            // 
            this.lbl_squadra_trasferta.Location = new System.Drawing.Point(221, 31);
            this.lbl_squadra_trasferta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_squadra_trasferta.Name = "lbl_squadra_trasferta";
            this.lbl_squadra_trasferta.Size = new System.Drawing.Size(225, 25);
            this.lbl_squadra_trasferta.TabIndex = 1;
            this.lbl_squadra_trasferta.Text = "squadra in trasferta";
            // 
            // lbl_gol_casa
            // 
            this.lbl_gol_casa.Location = new System.Drawing.Point(424, 28);
            this.lbl_gol_casa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gol_casa.Name = "lbl_gol_casa";
            this.lbl_gol_casa.Size = new System.Drawing.Size(144, 25);
            this.lbl_gol_casa.TabIndex = 2;
            this.lbl_gol_casa.Text = "gol squadra casa";
            this.lbl_gol_casa.Click += new System.EventHandler(this.lbl_gol_casa_Click);
            // 
            // lbl_gol_trasferta
            // 
            this.lbl_gol_trasferta.Location = new System.Drawing.Point(613, 31);
            this.lbl_gol_trasferta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gol_trasferta.Name = "lbl_gol_trasferta";
            this.lbl_gol_trasferta.Size = new System.Drawing.Size(156, 25);
            this.lbl_gol_trasferta.TabIndex = 3;
            this.lbl_gol_trasferta.Text = "gol squadra in trasferta";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(793, 43);
            this.btn_aggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(100, 28);
            this.btn_aggiungi.TabIndex = 4;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // lst_visualizza
            // 
            this.lst_visualizza.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_visualizza.FormattingEnabled = true;
            this.lst_visualizza.ItemHeight = 15;
            this.lst_visualizza.Location = new System.Drawing.Point(24, 92);
            this.lst_visualizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_visualizza.Name = "lst_visualizza";
            this.lst_visualizza.Size = new System.Drawing.Size(868, 394);
            this.lst_visualizza.TabIndex = 5;
            // 
            // txt_squadra_casa
            // 
            this.txt_squadra_casa.Location = new System.Drawing.Point(25, 59);
            this.txt_squadra_casa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_squadra_casa.Name = "txt_squadra_casa";
            this.txt_squadra_casa.Size = new System.Drawing.Size(159, 22);
            this.txt_squadra_casa.TabIndex = 6;
            // 
            // txt_squadra_trasferta
            // 
            this.txt_squadra_trasferta.Location = new System.Drawing.Point(225, 59);
            this.txt_squadra_trasferta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_squadra_trasferta.Name = "txt_squadra_trasferta";
            this.txt_squadra_trasferta.Size = new System.Drawing.Size(171, 22);
            this.txt_squadra_trasferta.TabIndex = 7;
            // 
            // txt_gol_casa
            // 
            this.txt_gol_casa.Location = new System.Drawing.Point(428, 59);
            this.txt_gol_casa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gol_casa.Name = "txt_gol_casa";
            this.txt_gol_casa.Size = new System.Drawing.Size(173, 22);
            this.txt_gol_casa.TabIndex = 8;
            // 
            // txt_gol_trasferta
            // 
            this.txt_gol_trasferta.Location = new System.Drawing.Point(617, 59);
            this.txt_gol_trasferta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gol_trasferta.Name = "txt_gol_trasferta";
            this.txt_gol_trasferta.Size = new System.Drawing.Size(151, 22);
            this.txt_gol_trasferta.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

