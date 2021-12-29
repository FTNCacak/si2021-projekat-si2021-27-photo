
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KorisnickoIme = new System.Windows.Forms.TextBox();
            this.textBox_Sifra = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_Kupac = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // textBox_KorisnickoIme
            // 
            this.textBox_KorisnickoIme.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_KorisnickoIme.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_KorisnickoIme.Location = new System.Drawing.Point(112, 335);
            this.textBox_KorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KorisnickoIme.Name = "textBox_KorisnickoIme";
            this.textBox_KorisnickoIme.Size = new System.Drawing.Size(219, 27);
            this.textBox_KorisnickoIme.TabIndex = 3;
            // 
            // textBox_Sifra
            // 
            this.textBox_Sifra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_Sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sifra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_Sifra.Location = new System.Drawing.Point(112, 399);
            this.textBox_Sifra.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Sifra.Name = "textBox_Sifra";
            this.textBox_Sifra.PasswordChar = '*';
            this.textBox_Sifra.Size = new System.Drawing.Size(219, 27);
            this.textBox_Sifra.TabIndex = 4;
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_LogIn.Location = new System.Drawing.Point(112, 453);
            this.button_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(219, 51);
            this.button_LogIn.TabIndex = 5;
            this.button_LogIn.Text = "Prijavi se";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_Kupac
            // 
            this.button_Kupac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Kupac.Location = new System.Drawing.Point(112, 512);
            this.button_Kupac.Margin = new System.Windows.Forms.Padding(4);
            this.button_Kupac.Name = "button_Kupac";
            this.button_Kupac.Size = new System.Drawing.Size(219, 56);
            this.button_Kupac.TabIndex = 6;
            this.button_Kupac.Text = "Nastavite kao kupac";
            this.button_Kupac.UseVisualStyleBackColor = false;
            this.button_Kupac.Click += new System.EventHandler(this.button_Kupac_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Šifra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Kupac);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Sifra);
            this.Controls.Add(this.textBox_KorisnickoIme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KorisnickoIme;
        private System.Windows.Forms.TextBox textBox_Sifra;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_Kupac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}