
namespace guesswho
{
    partial class Prechod2
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
            this.text = new System.Windows.Forms.Label();
            this.pokracovanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text.Location = new System.Drawing.Point(108, 80);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(383, 39);
            this.text.TabIndex = 35;
            this.text.Text = "Na ťahu je hráč číslo 1";
            // 
            // pokracovanie
            // 
            this.pokracovanie.Location = new System.Drawing.Point(239, 236);
            this.pokracovanie.Name = "pokracovanie";
            this.pokracovanie.Size = new System.Drawing.Size(119, 60);
            this.pokracovanie.TabIndex = 34;
            this.pokracovanie.Text = "Pokračovať";
            this.pokracovanie.UseVisualStyleBackColor = true;
            this.pokracovanie.Click += new System.EventHandler(this.pokracuj);
            // 
            // Prechod2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 377);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pokracovanie);
            this.Name = "Prechod2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prechod2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button pokracovanie;
    }
}