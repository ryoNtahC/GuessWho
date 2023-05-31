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
            this.SuspendLayout();
            // 
            // typ_vlastnosti
            // 
            this.typ_vlastnosti.FormattingEnabled = true;
            this.typ_vlastnosti.Items.AddRange(new object[] {
            "ahoj"});
            this.typ_vlastnosti.Location = new System.Drawing.Point(261, 78);
            this.typ_vlastnosti.Margin = new System.Windows.Forms.Padding(4);
            this.typ_vlastnosti.Name = "typ_vlastnosti";
            this.typ_vlastnosti.Size = new System.Drawing.Size(160, 24);
            this.typ_vlastnosti.TabIndex = 0;
            // 
            // vlastnosť
            // 
            this.vlastnosť.FormattingEnabled = true;
            this.vlastnosť.Items.AddRange(new object[] {
            "cus"});
            this.vlastnosť.Location = new System.Drawing.Point(467, 78);
            this.vlastnosť.Margin = new System.Windows.Forms.Padding(4);
            this.vlastnosť.Name = "vlastnosť";
            this.vlastnosť.Size = new System.Drawing.Size(160, 24);
            this.vlastnosť.TabIndex = 1;
            // 
            // otazka
            // 
            this.otazka.AutoSize = true;
            this.otazka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otazka.Location = new System.Drawing.Point(223, 217);
            this.otazka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otazka.Name = "otazka";
            this.otazka.Size = new System.Drawing.Size(115, 39);
            this.otazka.TabIndex = 2;
            this.otazka.Text = "label1";
            this.otazka.Visible = false;
            // 
            // ano
            // 
            this.ano.Location = new System.Drawing.Point(261, 303);
            this.ano.Margin = new System.Windows.Forms.Padding(4);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(100, 28);
            this.ano.TabIndex = 3;
            this.ano.Text = "Áno";
            this.ano.UseVisualStyleBackColor = true;
            this.ano.Click += new System.EventHandler(this.ano_Click);
            // 
            // nie
            // 
            this.nie.Location = new System.Drawing.Point(528, 303);
            this.nie.Margin = new System.Windows.Forms.Padding(4);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(100, 28);
            this.nie.TabIndex = 4;
            this.nie.Text = "Nie";
            this.nie.UseVisualStyleBackColor = true;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(16, 444);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.spat);
            // 
            // odpoved
            // 
            this.odpoved.AutoSize = true;
            this.odpoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odpoved.Location = new System.Drawing.Point(388, 367);
            this.odpoved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odpoved.Name = "odpoved";
            this.odpoved.Size = new System.Drawing.Size(115, 39);
            this.odpoved.TabIndex = 6;
            this.odpoved.Text = "label2";
            this.odpoved.Visible = false;
            // 
            // spytaj
            // 
            this.spytaj.Location = new System.Drawing.Point(403, 154);
            this.spytaj.Margin = new System.Windows.Forms.Padding(4);
            this.spytaj.Name = "spytaj";
            this.spytaj.Size = new System.Drawing.Size(100, 28);
            this.spytaj.TabIndex = 7;
            this.spytaj.Text = "Spýtať sa";
            this.spytaj.UseVisualStyleBackColor = true;
            this.spytaj.Click += new System.EventHandler(this.spytaj_Click);
            // 
            // Qstion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 487);
            this.Controls.Add(this.spytaj);
            this.Controls.Add(this.odpoved);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.nie);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.otazka);
            this.Controls.Add(this.vlastnosť);
            this.Controls.Add(this.typ_vlastnosti);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}