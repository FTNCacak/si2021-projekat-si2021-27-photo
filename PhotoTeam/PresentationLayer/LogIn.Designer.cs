
namespace PresentationLayer
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBox_Sifra = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_Kupac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prodavac";
            // 
            // textBox_KorisnickoIme
            // 
            this.textBox_KorisnickoIme.Location = new System.Drawing.Point(147, 113);
            this.textBox_KorisnickoIme.Name = "textBox_KorisnickoIme";
            this.textBox_KorisnickoIme.Size = new System.Drawing.Size(171, 22);
            this.textBox_KorisnickoIme.TabIndex = 3;
            // 
            // textBox_Sifra
            // 
            this.textBox_Sifra.Location = new System.Drawing.Point(147, 162);
            this.textBox_Sifra.Name = "textBox_Sifra";
            this.textBox_Sifra.PasswordChar = '*';
            this.textBox_Sifra.Size = new System.Drawing.Size(171, 22);
            this.textBox_Sifra.TabIndex = 4;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(157, 220);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(125, 41);
            this.button_LogIn.TabIndex = 5;
            this.button_LogIn.Text = "Prijavi se";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_Kupac
            // 
            this.button_Kupac.Location = new System.Drawing.Point(215, 386);
            this.button_Kupac.Name = "button_Kupac";
            this.button_Kupac.Size = new System.Drawing.Size(221, 45);
            this.button_Kupac.TabIndex = 6;
            this.button_Kupac.Text = "Nastavite kao kupac";
            this.button_Kupac.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Šifra";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Kupac);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Sifra);
            this.Controls.Add(this.textBox_KorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_KorisnickoIme;
        private System.Windows.Forms.TextBox textBox_Sifra;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_Kupac;
        private System.Windows.Forms.Label label2;
    }
}