namespace guesswho
{
    partial class Qstion
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
            this.typ_vlastnosti = new System.Windows.Forms.ComboBox();
            this.vlastnosť = new System.Windows.Forms.ComboBox();
            this.otazka = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.Button();
            this.nie = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.odpoved = new System.Windows.Forms.Label();
            this.spytaj = new System.Windows.Forms.Button();
            this.potvrdenie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typ_vlastnosti
            // 
            this.typ_vlastnosti.FormattingEnabled = true;
            this.typ_vlastnosti.Items.AddRange(new object[] {
            "pohlavie",
            "vlasy",
            "oči",
            "čiapku",
            "doplnok",
            "fúzy"});
            this.typ_vlastnosti.Location = new System.Drawing.Point(196, 63);
            this.typ_vlastnosti.Name = "typ_vlastnosti";
            this.typ_vlastnosti.Size = new System.Drawing.Size(121, 21);
            this.typ_vlastnosti.TabIndex = 0;
            // 
            // vlastnosť
            // 
            this.vlastnosť.FormattingEnabled = true;
            this.vlastnosť.Items.AddRange(new object[] {
            "cus"});
            this.vlastnosť.Location = new System.Drawing.Point(350, 63);
            this.vlastnosť.Name = "vlastnosť";
            this.vlastnosť.Size = new System.Drawing.Size(121, 21);
            this.vlastnosť.TabIndex = 1;
            // 
            // otazka
            // 
            this.otazka.AutoSize = true;
            this.otazka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otazka.Location = new System.Drawing.Point(167, 176);
            this.otazka.Name = "otazka";
            this.otazka.Size = new System.Drawing.Size(92, 31);
            this.otazka.TabIndex = 2;
            this.otazka.Text = "label1";
            this.otazka.Visible = false;
            // 
            // ano
            // 
            this.ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ano.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ano.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ano.Location = new System.Drawing.Point(196, 236);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(75, 33);
            this.ano.TabIndex = 3;
            this.ano.Text = "Áno";
            this.ano.UseVisualStyleBackColor = false;
            this.ano.Click += new System.EventHandler(this.ano_Click);
            // 
            // nie
            // 
            this.nie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nie.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nie.ForeColor = System.Drawing.Color.White;
            this.nie.Location = new System.Drawing.Point(396, 236);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(75, 33);
            this.nie.TabIndex = 4;
            this.nie.Text = "Nie";
            this.nie.UseVisualStyleBackColor = false;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.Back.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(12, 357);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 27);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.spat);
            // 
            // odpoved
            // 
            this.odpoved.AutoSize = true;
            this.odpoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odpoved.Location = new System.Drawing.Point(291, 298);
            this.odpoved.Name = "odpoved";
            this.odpoved.Size = new System.Drawing.Size(92, 31);
            this.odpoved.TabIndex = 6;
            this.odpoved.Text = "label2";
            this.odpoved.Visible = false;
            // 
            // spytaj
            // 
            this.spytaj.Location = new System.Drawing.Point(302, 160);
            this.spytaj.Name = "spytaj";
            this.spytaj.Size = new System.Drawing.Size(75, 23);
            this.spytaj.TabIndex = 7;
            this.spytaj.Text = "Spýtať sa";
            this.spytaj.UseVisualStyleBackColor = true;
            this.spytaj.Click += new System.EventHandler(this.spytaj_Click);
            // 
            // potvrdenie
            // 
            this.potvrdenie.Location = new System.Drawing.Point(302, 101);
            this.potvrdenie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.potvrdenie.Name = "potvrdenie";
            this.potvrdenie.Size = new System.Drawing.Size(75, 19);
            this.potvrdenie.TabIndex = 8;
            this.potvrdenie.Text = "Potvrdiť typ";
            this.potvrdenie.UseVisualStyleBackColor = true;
            this.potvrdenie.Click += new System.EventHandler(this.potvrdenie_Click);
            // 
            // Qstion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(671, 396);
            this.Controls.Add(this.potvrdenie);
            this.Controls.Add(this.spytaj);
            this.Controls.Add(this.odpoved);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.nie);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.otazka);
            this.Controls.Add(this.vlastnosť);
            this.Controls.Add(this.typ_vlastnosti);
            this.Name = "Qstion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qstion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typ_vlastnosti;
        private System.Windows.Forms.ComboBox vlastnosť;
        private System.Windows.Forms.Label otazka;
        private System.Windows.Forms.Button ano;
        private System.Windows.Forms.Button nie;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label odpoved;
        private System.Windows.Forms.Button spytaj;
        private System.Windows.Forms.Button potvrdenie;
    }
}