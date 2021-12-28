
namespace PresentationLayer
{
    partial class FormaProdavac
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Naziv = new System.Windows.Forms.TextBox();
            this.textBox_Marka = new System.Windows.Forms.TextBox();
            this.textBox_Cena = new System.Windows.Forms.TextBox();
            this.textBox_Garancija = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Obrisi = new System.Windows.Forms.Button();
            this.button_Izmeni = new System.Windows.Forms.Button();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.dataGridView_Proizvod = new System.Windows.Forms.DataGridView();
            this.dataGridView_PoruceniProizvodi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Osvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PoruceniProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Garancija";
            // 
            // textBox_Naziv
            // 
            this.textBox_Naziv.Location = new System.Drawing.Point(145, 288);
            this.textBox_Naziv.Name = "textBox_Naziv";
            this.textBox_Naziv.Size = new System.Drawing.Size(181, 22);
            this.textBox_Naziv.TabIndex = 5;
            // 
            // textBox_Marka
            // 
            this.textBox_Marka.Location = new System.Drawing.Point(145, 323);
            this.textBox_Marka.Name = "textBox_Marka";
            this.textBox_Marka.Size = new System.Drawing.Size(181, 22);
            this.textBox_Marka.TabIndex = 6;
            // 
            // textBox_Cena
            // 
            this.textBox_Cena.Location = new System.Drawing.Point(145, 360);
            this.textBox_Cena.Name = "textBox_Cena";
            this.textBox_Cena.Size = new System.Drawing.Size(181, 22);
            this.textBox_Cena.TabIndex = 7;
            // 
            // textBox_Garancija
            // 
            this.textBox_Garancija.Location = new System.Drawing.Point(145, 396);
            this.textBox_Garancija.Name = "textBox_Garancija";
            this.textBox_Garancija.Size = new System.Drawing.Size(181, 22);
            this.textBox_Garancija.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lista dostupnih proizvoda u prodavnici";
            // 
            // button_Obrisi
            // 
            this.button_Obrisi.Location = new System.Drawing.Point(54, 465);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(97, 45);
            this.button_Obrisi.TabIndex = 10;
            this.button_Obrisi.Text = "Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = true;
            this.button_Obrisi.Click += new System.EventHandler(this.button_Obrisi_Click);
            // 
            // button_Izmeni
            // 
            this.button_Izmeni.Location = new System.Drawing.Point(157, 465);
            this.button_Izmeni.Name = "button_Izmeni";
            this.button_Izmeni.Size = new System.Drawing.Size(97, 45);
            this.button_Izmeni.TabIndex = 11;
            this.button_Izmeni.Text = "Izmeni";
            this.button_Izmeni.UseVisualStyleBackColor = true;
            this.button_Izmeni.Click += new System.EventHandler(this.button_Izmeni_Click);
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(260, 465);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(106, 45);
            this.button_Dodaj.TabIndex = 12;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // dataGridView_Proizvod
            // 
            this.dataGridView_Proizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Proizvod.Location = new System.Drawing.Point(22, 48);
            this.dataGridView_Proizvod.Name = "dataGridView_Proizvod";
            this.dataGridView_Proizvod.RowHeadersWidth = 51;
            this.dataGridView_Proizvod.RowTemplate.Height = 24;
            this.dataGridView_Proizvod.Size = new System.Drawing.Size(690, 223);
            this.dataGridView_Proizvod.TabIndex = 13;
            this.dataGridView_Proizvod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Proizvod_CellContentClick);
            // 
            // dataGridView_PoruceniProizvodi
            // 
            this.dataGridView_PoruceniProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PoruceniProizvodi.Location = new System.Drawing.Point(741, 48);
            this.dataGridView_PoruceniProizvodi.Name = "dataGridView_PoruceniProizvodi";
            this.dataGridView_PoruceniProizvodi.RowHeadersWidth = 51;
            this.dataGridView_PoruceniProizvodi.RowTemplate.Height = 24;
            this.dataGridView_PoruceniProizvodi.Size = new System.Drawing.Size(273, 223);
            this.dataGridView_PoruceniProizvodi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lista poručenih proizvoda";
            // 
            // button_Osvezi
            // 
            this.button_Osvezi.Location = new System.Drawing.Point(806, 291);
            this.button_Osvezi.Name = "button_Osvezi";
            this.button_Osvezi.Size = new System.Drawing.Size(144, 50);
            this.button_Osvezi.TabIndex = 16;
            this.button_Osvezi.Text = "Osveži";
            this.button_Osvezi.UseVisualStyleBackColor = true;
            this.button_Osvezi.Click += new System.EventHandler(this.button_Osvezi_Click);
            // 
            // FormaProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 542);
            this.Controls.Add(this.button_Osvezi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_PoruceniProizvodi);
            this.Controls.Add(this.dataGridView_Proizvod);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.button_Izmeni);
            this.Controls.Add(this.button_Obrisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Garancija);
            this.Controls.Add(this.textBox_Cena);
            this.Controls.Add(this.textBox_Marka);
            this.Controls.Add(this.textBox_Naziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaProdavac";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.FormaProdavac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PoruceniProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Naziv;
        private System.Windows.Forms.TextBox textBox_Marka;
        private System.Windows.Forms.TextBox textBox_Cena;
        private System.Windows.Forms.TextBox textBox_Garancija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Obrisi;
        private System.Windows.Forms.Button button_Izmeni;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.DataGridView dataGridView_Proizvod;
        private System.Windows.Forms.DataGridView dataGridView_PoruceniProizvodi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Osvezi;
    }
}

