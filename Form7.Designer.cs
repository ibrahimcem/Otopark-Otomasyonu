namespace Otopark
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.aracPlakaSecGuncelle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aracPlakaSecGuncelle
            // 
            this.aracPlakaSecGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracPlakaSecGuncelle.Location = new System.Drawing.Point(48, 97);
            this.aracPlakaSecGuncelle.Multiline = true;
            this.aracPlakaSecGuncelle.Name = "aracPlakaSecGuncelle";
            this.aracPlakaSecGuncelle.Size = new System.Drawing.Size(345, 34);
            this.aracPlakaSecGuncelle.TabIndex = 22;
            this.aracPlakaSecGuncelle.TextChanged += new System.EventHandler(this.aracPlakaSecGuncelle_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(48, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Bilgileri Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 85);
            this.label1.TabIndex = 20;
            this.label1.Text = "Güncellenecek Aracın Plakasını Yazınız";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 237);
            this.Controls.Add(this.aracPlakaSecGuncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Araç Kaydı Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aracPlakaSecGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}