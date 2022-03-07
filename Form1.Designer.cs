
namespace Karmaşık_Analizi
{
    partial class S
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListBox lsbAnaliz;
            this.btnbruteForce = new System.Windows.Forms.Button();
            this.BtnBruteForceUpdate = new System.Windows.Forms.Button();
            this.btnDogrusal = new System.Windows.Forms.Button();
            this.BtnSureKarsilastir = new System.Windows.Forms.Button();
            lsbAnaliz = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbAnaliz
            // 
            lsbAnaliz.IntegralHeight = false;
            lsbAnaliz.ItemHeight = 16;
            lsbAnaliz.Location = new System.Drawing.Point(13, 322);
            lsbAnaliz.Name = "lsbAnaliz";
            lsbAnaliz.Size = new System.Drawing.Size(361, 212);
            lsbAnaliz.TabIndex = 5;
            // 
            // btnbruteForce
            // 
            this.btnbruteForce.Location = new System.Drawing.Point(12, 12);
            this.btnbruteForce.Name = "btnbruteForce";
            this.btnbruteForce.Size = new System.Drawing.Size(362, 52);
            this.btnbruteForce.TabIndex = 0;
            this.btnbruteForce.Text = "1. BruteForce ";
            this.btnbruteForce.UseVisualStyleBackColor = true;
            // 
            // BtnBruteForceUpdate
            // 
            this.BtnBruteForceUpdate.Location = new System.Drawing.Point(13, 87);
            this.BtnBruteForceUpdate.Name = "BtnBruteForceUpdate";
            this.BtnBruteForceUpdate.Size = new System.Drawing.Size(361, 51);
            this.BtnBruteForceUpdate.TabIndex = 1;
            this.BtnBruteForceUpdate.Text = "2. BruteForce Update";
            this.BtnBruteForceUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDogrusal
            // 
            this.btnDogrusal.Location = new System.Drawing.Point(13, 165);
            this.btnDogrusal.Name = "btnDogrusal";
            this.btnDogrusal.Size = new System.Drawing.Size(361, 51);
            this.btnDogrusal.TabIndex = 2;
            this.btnDogrusal.Text = "3. Doğrusal";
            this.btnDogrusal.UseVisualStyleBackColor = true;
            // 
            // BtnSureKarsilastir
            // 
            this.BtnSureKarsilastir.Location = new System.Drawing.Point(84, 241);
            this.BtnSureKarsilastir.Name = "BtnSureKarsilastir";
            this.BtnSureKarsilastir.Size = new System.Drawing.Size(224, 51);
            this.BtnSureKarsilastir.TabIndex = 3;
            this.BtnSureKarsilastir.Text = "Süreleri Karşılaştırma";
            this.BtnSureKarsilastir.UseVisualStyleBackColor = true;
            this.BtnSureKarsilastir.Click += new System.EventHandler(this.BtnSureKarsilastir_Click);
            // 
            // S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 556);
            this.Controls.Add(lsbAnaliz);
            this.Controls.Add(this.BtnSureKarsilastir);
            this.Controls.Add(this.btnDogrusal);
            this.Controls.Add(this.BtnBruteForceUpdate);
            this.Controls.Add(this.btnbruteForce);
            this.Name = "S";
            this.Text = "Analiz";
            this.Load += new System.EventHandler(this.S_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbruteForce;
        private System.Windows.Forms.Button BtnBruteForceUpdate;
        private System.Windows.Forms.Button btnDogrusal;
        private System.Windows.Forms.Button BtnSureKarsilastir;
    }
}

