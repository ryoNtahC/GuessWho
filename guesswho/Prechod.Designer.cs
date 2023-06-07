
namespace guesswho
{
    partial class Prechod
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
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.text.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text.ForeColor = System.Drawing.Color.Blue;
            this.text.Location = new System.Drawing.Point(39, 87);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(521, 51);
            this.text.TabIndex = 35;
            this.text.Text = "Na ťahu je hráč číslo 2";
            // 
            // pokracovanie
            // 
            this.pokracovanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pokracovanie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pokracovanie.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pokracovanie.ForeColor = System.Drawing.Color.White;
            this.pokracovanie.Location = new System.Drawing.Point(228, 230);
            this.pokracovanie.Name = "pokracovanie";
            this.pokracovanie.Size = new System.Drawing.Size(119, 60);
            this.pokracovanie.TabIndex = 34;
            this.pokracovanie.Text = "Pokračovať";
            this.pokracovanie.UseVisualStyleBackColor = false;
            this.pokracovanie.Click += new System.EventHandler(this.pokracuj);
            // 
            // Prechod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(599, 377);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pokracovanie);
            this.Name = "Prechod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prechod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button pokracovanie;
    }
}