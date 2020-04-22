namespace MachineLearningGames
{
    partial class SchoolLibrary
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolLibrary));
            this.pnlSchoolLibraryMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSchoolLibraryMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSchoolLibraryMain
            // 
            this.pnlSchoolLibraryMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlSchoolLibraryMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSchoolLibraryMain.BackgroundImage")));
            this.pnlSchoolLibraryMain.Controls.Add(this.label1);
            this.pnlSchoolLibraryMain.Location = new System.Drawing.Point(0, 0);
            this.pnlSchoolLibraryMain.Name = "pnlSchoolLibraryMain";
            this.pnlSchoolLibraryMain.Size = new System.Drawing.Size(1500, 705);
            this.pnlSchoolLibraryMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.panel2.Location = new System.Drawing.Point(0, 705);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 45);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(497, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCHOOL LIBRARY OYUNU";
            // 
            // SchoolLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSchoolLibraryMain);
            this.Name = "SchoolLibrary";
            this.Size = new System.Drawing.Size(1500, 750);
            this.pnlSchoolLibraryMain.ResumeLayout(false);
            this.pnlSchoolLibraryMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSchoolLibraryMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
