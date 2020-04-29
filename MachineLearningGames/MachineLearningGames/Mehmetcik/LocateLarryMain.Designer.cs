namespace MachineLearningGames.Mehmetcik
{
    partial class LocateLarryMain1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocateLarryMain1));
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.color = System.Drawing.Color.Transparent;
            this.btnTrain.colorActive = System.Drawing.Color.Transparent;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImagePosition = 18;
            this.btnTrain.ImageZoom = 50;
            this.btnTrain.LabelPosition = 38;
            this.btnTrain.LabelText = "";
            this.btnTrain.Location = new System.Drawing.Point(463, 319);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(100, 100);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.color = System.Drawing.Color.Transparent;
            this.btnTest.colorActive = System.Drawing.Color.Transparent;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImagePosition = 18;
            this.btnTest.ImageZoom = 50;
            this.btnTest.LabelPosition = 38;
            this.btnTest.LabelText = "";
            this.btnTest.Location = new System.Drawing.Point(603, 319);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 100);
            this.btnTest.TabIndex = 3;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // LocateLarryMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrain);
            this.Name = "LocateLarryMain1";
            this.Size = new System.Drawing.Size(1500, 705);
            this.Load += new System.EventHandler(this.LocateLarryMain1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnTrain;
        private Bunifu.Framework.UI.BunifuTileButton btnTest;
    }
}
