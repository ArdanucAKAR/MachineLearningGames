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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlSchoolLibraryMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSchoolLibraryMain
            // 
            this.pnlSchoolLibraryMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSchoolLibraryMain.BackgroundImage")));
            this.pnlSchoolLibraryMain.Controls.Add(this.pnlBottom);
            this.pnlSchoolLibraryMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchoolLibraryMain.Location = new System.Drawing.Point(0, 0);
            this.pnlSchoolLibraryMain.Name = "pnlSchoolLibraryMain";
            this.pnlSchoolLibraryMain.Size = new System.Drawing.Size(1500, 750);
            this.pnlSchoolLibraryMain.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.pnlBottom.Controls.Add(this.btnHome);
            this.pnlBottom.Controls.Add(this.btnTest);
            this.pnlBottom.Controls.Add(this.btnTrain);
            this.pnlBottom.Location = new System.Drawing.Point(0, 705);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1500, 45);
            this.pnlBottom.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.color = System.Drawing.Color.Transparent;
            this.btnHome.colorActive = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImagePosition = 18;
            this.btnHome.ImageZoom = 45;
            this.btnHome.LabelPosition = 36;
            this.btnHome.LabelText = "";
            this.btnHome.Location = new System.Drawing.Point(672, -19);
            this.btnHome.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 88);
            this.btnHome.TabIndex = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.color = System.Drawing.Color.Transparent;
            this.btnTest.colorActive = System.Drawing.Color.Transparent;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImagePosition = 18;
            this.btnTest.ImageZoom = 50;
            this.btnTest.LabelPosition = 36;
            this.btnTest.LabelText = "";
            this.btnTest.Location = new System.Drawing.Point(891, -19);
            this.btnTest.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(81, 88);
            this.btnTest.TabIndex = 4;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.color = System.Drawing.Color.Transparent;
            this.btnTrain.colorActive = System.Drawing.Color.Transparent;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImagePosition = 18;
            this.btnTrain.ImageZoom = 50;
            this.btnTrain.LabelPosition = 36;
            this.btnTrain.LabelText = "";
            this.btnTrain.Location = new System.Drawing.Point(782, -19);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(81, 88);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // SchoolLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSchoolLibraryMain);
            this.Name = "SchoolLibrary";
            this.Size = new System.Drawing.Size(1500, 750);
            this.pnlSchoolLibraryMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSchoolLibraryMain;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        private Bunifu.Framework.UI.BunifuTileButton btnTest;
        private Bunifu.Framework.UI.BunifuTileButton btnTrain;
    }
}
