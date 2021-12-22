
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
            this.dataGridView_Proizvod = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Proizvod
            // 
            this.dataGridView_Proizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Proizvod.Location = new System.Drawing.Point(54, 49);
            this.dataGridView_Proizvod.Name = "dataGridView_Proizvod";
            this.dataGridView_Proizvod.RowHeadersWidth = 51;
            this.dataGridView_Proizvod.RowTemplate.Height = 24;
            this.dataGridView_Proizvod.Size = new System.Drawing.Size(552, 235);
            this.dataGridView_Proizvod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Garancija";
            // 
            // textBox_Naziv
            // 
            this.textBox_Naziv.Location = new System.Drawing.Point(745, 49);
            this.textBox_Naziv.Name = "textBox_Naziv";
            this.textBox_Naziv.Size = new System.Drawing.Size(181, 22);
            this.textBox_Naziv.TabIndex = 5;
            // 
            // textBox_Marka
            // 
            this.textBox_Marka.Location = new System.Drawing.Point(745, 84);
            this.textBox_Marka.Name = "textBox_Marka";
            this.textBox_Marka.Size = new System.Drawing.Size(181, 22);
            this.textBox_Marka.TabIndex = 6;
            // 
            // textBox_Cena
            // 
            this.textBox_Cena.Location = new System.Drawing.Point(745, 121);
            this.textBox_Cena.Name = "textBox_Cena";
            this.textBox_Cena.Size = new System.Drawing.Size(181, 22);
            this.textBox_Cena.TabIndex = 7;
            // 
            // textBox_Garancija
            // 
            this.textBox_Garancija.Location = new System.Drawing.Point(745, 157);
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
            this.button_Obrisi.Location = new System.Drawing.Point(256, 323);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(75, 23);
            this.button_Obrisi.TabIndex = 10;
            this.button_Obrisi.Text = "Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = true;
            // 
            // button_Izmeni
            // 
            this.button_Izmeni.Location = new System.Drawing.Point(679, 323);
            this.button_Izmeni.Name = "button_Izmeni";
            this.button_Izmeni.Size = new System.Drawing.Size(75, 23);
            this.button_Izmeni.TabIndex = 11;
            this.button_Izmeni.Text = "Izmeni";
            this.button_Izmeni.UseVisualStyleBackColor = true;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(809, 323);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_Dodaj.TabIndex = 12;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            // 
            // FormaProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 491);
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
            this.Controls.Add(this.dataGridView_Proizvod);
            this.Name = "FormaProdavac";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.FormaProdavac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Proizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Proizvod;
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
    }
}

