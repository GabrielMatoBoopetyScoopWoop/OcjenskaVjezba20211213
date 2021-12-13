namespace ZadatakZaOcjenuXMLERDGabrielMatosevic20211213
{
    partial class Form1
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
            this.UnosKorisnikaButun = new System.Windows.Forms.Button();
            this.UnosKnjigeButun = new System.Windows.Forms.Button();
            this.UnosPosudivanjaButun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnosKorisnikaButun
            // 
            this.UnosKorisnikaButun.Location = new System.Drawing.Point(249, 96);
            this.UnosKorisnikaButun.Name = "UnosKorisnikaButun";
            this.UnosKorisnikaButun.Size = new System.Drawing.Size(206, 23);
            this.UnosKorisnikaButun.TabIndex = 0;
            this.UnosKorisnikaButun.Text = "Unos Korisnika";
            this.UnosKorisnikaButun.UseVisualStyleBackColor = true;
            this.UnosKorisnikaButun.Click += new System.EventHandler(this.UnosKorisnikaButun_Click);
            // 
            // UnosKnjigeButun
            // 
            this.UnosKnjigeButun.Location = new System.Drawing.Point(249, 125);
            this.UnosKnjigeButun.Name = "UnosKnjigeButun";
            this.UnosKnjigeButun.Size = new System.Drawing.Size(206, 23);
            this.UnosKnjigeButun.TabIndex = 1;
            this.UnosKnjigeButun.Text = "Unos Knjige";
            this.UnosKnjigeButun.UseVisualStyleBackColor = true;
            this.UnosKnjigeButun.Click += new System.EventHandler(this.UnosKnjigeButun_Click);
            // 
            // UnosPosudivanjaButun
            // 
            this.UnosPosudivanjaButun.Location = new System.Drawing.Point(249, 154);
            this.UnosPosudivanjaButun.Name = "UnosPosudivanjaButun";
            this.UnosPosudivanjaButun.Size = new System.Drawing.Size(206, 23);
            this.UnosPosudivanjaButun.TabIndex = 2;
            this.UnosPosudivanjaButun.Text = "Unos Posudivanja/Vracanja";
            this.UnosPosudivanjaButun.UseVisualStyleBackColor = true;
            this.UnosPosudivanjaButun.Click += new System.EventHandler(this.UnosPosudivanjaButun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnosPosudivanjaButun);
            this.Controls.Add(this.UnosKnjigeButun);
            this.Controls.Add(this.UnosKorisnikaButun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnosKorisnikaButun;
        private System.Windows.Forms.Button UnosKnjigeButun;
        private System.Windows.Forms.Button UnosPosudivanjaButun;
    }
}

