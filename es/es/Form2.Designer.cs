namespace es
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_testo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_testo
            // 
            this.lbl_testo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_testo.Location = new System.Drawing.Point(100, 27);
            this.lbl_testo.Name = "lbl_testo";
            this.lbl_testo.Size = new System.Drawing.Size(431, 43);
            this.lbl_testo.TabIndex = 0;
            this.lbl_testo.Text = "scrivi la squadra che vuoi cercare";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Location = new System.Drawing.Point(410, 175);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(121, 46);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "cancella";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(105, 175);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(138, 46);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "invia";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 295);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_testo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_testo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_ok;
    }
}