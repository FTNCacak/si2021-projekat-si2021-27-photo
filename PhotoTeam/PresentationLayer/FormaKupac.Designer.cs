
namespace PresentationLayer
{
    partial class FormaKupac
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
            this.dataGridView_ListaDostupnihProizvoda = new System.Windows.Forms.DataGridView();
            this.button_Kupovina = new System.Windows.Forms.Button();
            this.button_Izadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaDostupnihProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dostupnih proizvoda";
            // 
            // dataGridView_ListaDostupnihProizvoda
            // 
            this.dataGridView_ListaDostupnihProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListaDostupnihProizvoda.Location = new System.Drawing.Point(54, 94);
            this.dataGridView_ListaDostupnihProizvoda.Name = "dataGridView_ListaDostupnihProizvoda";
            this.dataGridView_ListaDostupnihProizvoda.RowHeadersWidth = 51;
            this.dataGridView_ListaDostupnihProizvoda.RowTemplate.Height = 24;
            this.dataGridView_ListaDostupnihProizvoda.Size = new System.Drawing.Size(600, 225);
            this.dataGridView_ListaDostupnihProizvoda.TabIndex = 1;
            // 
            // button_Kupovina
            // 
            this.button_Kupovina.Location = new System.Drawing.Point(113, 359);
            this.button_Kupovina.Name = "button_Kupovina";
            this.button_Kupovina.Size = new System.Drawing.Size(204, 48);
            this.button_Kupovina.TabIndex = 2;
            this.button_Kupovina.Text = "Kupovina";
            this.button_Kupovina.UseVisualStyleBackColor = true;
            this.button_Kupovina.Click += new System.EventHandler(this.button_Kupovina_Click);
            // 
            // button_Izadji
            // 
            this.button_Izadji.Location = new System.Drawing.Point(388, 359);
            this.button_Izadji.Name = "button_Izadji";
            this.button_Izadji.Size = new System.Drawing.Size(207, 48);
            this.button_Izadji.TabIndex = 3;
            this.button_Izadji.Text = "Izadji";
            this.button_Izadji.UseVisualStyleBackColor = true;
            this.button_Izadji.Click += new System.EventHandler(this.button_Izadji_Click);
            // 
            // FormaKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.button_Izadji);
            this.Controls.Add(this.button_Kupovina);
            this.Controls.Add(this.dataGridView_ListaDostupnihProizvoda);
            this.Controls.Add(this.label1);
            this.Name = "FormaKupac";
            this.Text = "FormaKupac";
            this.Load += new System.EventHandler(this.FormaKupac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListaDostupnihProizvoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_ListaDostupnihProizvoda;
        private System.Windows.Forms.Button button_Kupovina;
        private System.Windows.Forms.Button button_Izadji;
    }
}