namespace Otopark
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aracPlakaGuncelle = new System.Windows.Forms.TextBox();
            this.aracCinsGuncelle = new System.Windows.Forms.TextBox();
            this.adSoyadGuncelle = new System.Windows.Forms.TextBox();
            this.cepTelefonuGuncelle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Araç Cinsi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cep Telefonu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Araç Plakası";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ad Soyad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aracPlakaGuncelle
            // 
            this.aracPlakaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracPlakaGuncelle.Location = new System.Drawing.Point(189, 61);
            this.aracPlakaGuncelle.Multiline = true;
            this.aracPlakaGuncelle.Name = "aracPlakaGuncelle";
            this.aracPlakaGuncelle.Size = new System.Drawing.Size(225, 34);
            this.aracPlakaGuncelle.TabIndex = 24;
            // 
            // aracCinsGuncelle
            // 
            this.aracCinsGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracCinsGuncelle.Location = new System.Drawing.Point(189, 101);
            this.aracCinsGuncelle.Multiline = true;
            this.aracCinsGuncelle.Name = "aracCinsGuncelle";
            this.aracCinsGuncelle.Size = new System.Drawing.Size(225, 34);
            this.aracCinsGuncelle.TabIndex = 25;
            // 
            // adSoyadGuncelle
            // 
            this.adSoyadGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadGuncelle.Location = new System.Drawing.Point(189, 141);
            this.adSoyadGuncelle.Multiline = true;
            this.adSoyadGuncelle.Name = "adSoyadGuncelle";
            this.adSoyadGuncelle.Size = new System.Drawing.Size(225, 34);
            this.adSoyadGuncelle.TabIndex = 26;
            // 
            // cepTelefonuGuncelle
            // 
            this.cepTelefonuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cepTelefonuGuncelle.Location = new System.Drawing.Point(189, 181);
            this.cepTelefonuGuncelle.MaxLength = 10;
            this.cepTelefonuGuncelle.Multiline = true;
            this.cepTelefonuGuncelle.Name = "cepTelefonuGuncelle";
            this.cepTelefonuGuncelle.Size = new System.Drawing.Size(225, 34);
            this.cepTelefonuGuncelle.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cepTelefonuGuncelle);
            this.Controls.Add(this.adSoyadGuncelle);
            this.Controls.Add(this.aracCinsGuncelle);
            this.Controls.Add(this.aracPlakaGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.Text = "Araç Kayıt Güncelle";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aracPlakaGuncelle;
        private System.Windows.Forms.TextBox aracCinsGuncelle;
        private System.Windows.Forms.TextBox adSoyadGuncelle;
        private System.Windows.Forms.TextBox cepTelefonuGuncelle;
        private System.Windows.Forms.Button button1;
    }
}