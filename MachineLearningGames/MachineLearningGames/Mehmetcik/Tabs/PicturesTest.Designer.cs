namespace MachineLearningGames.Mehmetcik.Tabs
{
    partial class PicturesTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturesTest));
            this.pictureLarry = new System.Windows.Forms.PictureBox();
            this.pictureNotLarry1 = new System.Windows.Forms.PictureBox();
            this.pictureNotLarry3 = new System.Windows.Forms.PictureBox();
            this.pictureNotLarry2 = new System.Windows.Forms.PictureBox();
            this.btnUploadLarry = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbGuess = new System.Windows.Forms.GroupBox();
            this.lblGuess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry2)).BeginInit();
            this.gbGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLarry
            // 
            this.pictureLarry.Location = new System.Drawing.Point(58, 184);
            this.pictureLarry.Name = "pictureLarry";
            this.pictureLarry.Size = new System.Drawing.Size(177, 185);
            this.pictureLarry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLarry.TabIndex = 6;
            this.pictureLarry.TabStop = false;
            this.pictureLarry.Click += new System.EventHandler(this.pictureLarry_Click);
            // 
            // pictureNotLarry1
            // 
            this.pictureNotLarry1.Location = new System.Drawing.Point(305, 184);
            this.pictureNotLarry1.Name = "pictureNotLarry1";
            this.pictureNotLarry1.Size = new System.Drawing.Size(177, 185);
            this.pictureNotLarry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNotLarry1.TabIndex = 7;
            this.pictureNotLarry1.TabStop = false;
            this.pictureNotLarry1.Click += new System.EventHandler(this.pictureNotLarry1_Click);
            // 
            // pictureNotLarry3
            // 
            this.pictureNotLarry3.Location = new System.Drawing.Point(798, 184);
            this.pictureNotLarry3.Name = "pictureNotLarry3";
            this.pictureNotLarry3.Size = new System.Drawing.Size(177, 185);
            this.pictureNotLarry3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNotLarry3.TabIndex = 8;
            this.pictureNotLarry3.TabStop = false;
            this.pictureNotLarry3.Click += new System.EventHandler(this.pictureNotLarry3_Click);
            // 
            // pictureNotLarry2
            // 
            this.pictureNotLarry2.Location = new System.Drawing.Point(564, 184);
            this.pictureNotLarry2.Name = "pictureNotLarry2";
            this.pictureNotLarry2.Size = new System.Drawing.Size(177, 185);
            this.pictureNotLarry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNotLarry2.TabIndex = 9;
            this.pictureNotLarry2.TabStop = false;
            this.pictureNotLarry2.Click += new System.EventHandler(this.pictureNotLarry2_Click);
            // 
            // btnUploadLarry
            // 
            this.btnUploadLarry.ActiveBorderThickness = 3;
            this.btnUploadLarry.ActiveCornerRadius = 20;
            this.btnUploadLarry.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadLarry.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadLarry.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadLarry.BackColor = System.Drawing.SystemColors.Control;
            this.btnUploadLarry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadLarry.BackgroundImage")));
            this.btnUploadLarry.ButtonText = "Resim Yükle";
            this.btnUploadLarry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadLarry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadLarry.ForeColor = System.Drawing.Color.White;
            this.btnUploadLarry.IdleBorderThickness = 3;
            this.btnUploadLarry.IdleCornerRadius = 20;
            this.btnUploadLarry.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadLarry.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadLarry.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadLarry.Location = new System.Drawing.Point(82, 441);
            this.btnUploadLarry.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadLarry.Name = "btnUploadLarry";
            this.btnUploadLarry.Size = new System.Drawing.Size(131, 55);
            this.btnUploadLarry.TabIndex = 10;
            this.btnUploadLarry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadLarry.Click += new System.EventHandler(this.btnUploadLarry_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 3;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Resim Yükle";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 3;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.Location = new System.Drawing.Point(305, 441);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(131, 55);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 3;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Resim Yükle";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 3;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.Location = new System.Drawing.Point(582, 441);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(131, 55);
            this.bunifuThinButton22.TabIndex = 12;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 3;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Resim Yükle";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 3;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Silver;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Silver;
            this.bunifuThinButton23.Location = new System.Drawing.Point(823, 428);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(131, 55);
            this.bunifuThinButton23.TabIndex = 13;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbGuess
            // 
            this.gbGuess.Controls.Add(this.lblGuess);
            this.gbGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGuess.ForeColor = System.Drawing.Color.White;
            this.gbGuess.Location = new System.Drawing.Point(322, 504);
            this.gbGuess.Name = "gbGuess";
            this.gbGuess.Size = new System.Drawing.Size(419, 110);
            this.gbGuess.TabIndex = 14;
            this.gbGuess.TabStop = false;
            this.gbGuess.Text = "Makine Tahmini";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.ForeColor = System.Drawing.Color.White;
            this.lblGuess.Location = new System.Drawing.Point(91, 49);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(60, 24);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "label1";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicturesTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbGuess);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btnUploadLarry);
            this.Controls.Add(this.pictureNotLarry2);
            this.Controls.Add(this.pictureNotLarry3);
            this.Controls.Add(this.pictureNotLarry1);
            this.Controls.Add(this.pictureLarry);
            this.Name = "PicturesTest";
            this.Size = new System.Drawing.Size(1500, 705);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNotLarry2)).EndInit();
            this.gbGuess.ResumeLayout(false);
            this.gbGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureLarry;
        private System.Windows.Forms.PictureBox pictureNotLarry1;
        private System.Windows.Forms.PictureBox pictureNotLarry3;
        private System.Windows.Forms.PictureBox pictureNotLarry2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadLarry;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbGuess;
        private System.Windows.Forms.Label lblGuess;
    }
}
