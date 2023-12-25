namespace string_metotlar_826
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnBuyut = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnSay = new System.Windows.Forms.Button();
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(180, 96);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(134, 13);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "merhaba dünya,ben kübra!";
            // 
            // btnBuyut
            // 
            this.btnBuyut.Location = new System.Drawing.Point(12, 132);
            this.btnBuyut.Name = "btnBuyut";
            this.btnBuyut.Size = new System.Drawing.Size(136, 44);
            this.btnBuyut.TabIndex = 1;
            this.btnBuyut.Text = "hepsini büyük yap";
            this.btnBuyut.UseVisualStyleBackColor = true;
            this.btnBuyut.Click += new System.EventHandler(this.btnBuyut_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(25, 89);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 20);
            this.txtMesaj.TabIndex = 2;
            // 
            // btnKucult
            // 
            this.btnKucult.Location = new System.Drawing.Point(165, 132);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(149, 44);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "hepsini küçük yap";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnSay
            // 
            this.btnSay.Location = new System.Drawing.Point(12, 198);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(136, 47);
            this.btnSay.TabIndex = 4;
            this.btnSay.Text = "karakter sayısını göster";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Location = new System.Drawing.Point(165, 198);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(136, 47);
            this.btnMesajVer.TabIndex = 5;
            this.btnMesajVer.Text = "karakter sayısını getir";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnBuyut);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnBuyut;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btnMesajVer;
    }
}

