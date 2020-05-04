namespace MachineLearningGames.Mehmetcik.Tabs
{
    partial class PicturesTrain3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturesTrain3));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadNormal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadLarry = new Bunifu.Framework.UI.BunifuThinButton2();
            this.childrensBookList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1500, 605);
            this.bunifuCards1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnUploadNormal);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(730, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 425);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal";
            // 
            // btnUploadNormal
            // 
            this.btnUploadNormal.ActiveBorderThickness = 3;
            this.btnUploadNormal.ActiveCornerRadius = 20;
            this.btnUploadNormal.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadNormal.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadNormal.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadNormal.BackgroundImage")));
            this.btnUploadNormal.ButtonText = "Resim Yükle";
            this.btnUploadNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadNormal.ForeColor = System.Drawing.Color.White;
            this.btnUploadNormal.IdleBorderThickness = 3;
            this.btnUploadNormal.IdleCornerRadius = 20;
            this.btnUploadNormal.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadNormal.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadNormal.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadNormal.Location = new System.Drawing.Point(60, 370);
            this.btnUploadNormal.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadNormal.Name = "btnUploadNormal";
            this.btnUploadNormal.Size = new System.Drawing.Size(131, 55);
            this.btnUploadNormal.TabIndex = 2;
            this.btnUploadNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadNormal.Click += new System.EventHandler(this.btnUploadNormal_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Thistle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(212, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUploadLarry);
            this.groupBox1.Controls.Add(this.childrensBookList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(384, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Larry";
            // 
            // btnUploadLarry
            // 
            this.btnUploadLarry.ActiveBorderThickness = 3;
            this.btnUploadLarry.ActiveCornerRadius = 20;
            this.btnUploadLarry.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadLarry.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadLarry.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadLarry.BackColor = System.Drawing.Color.Transparent;
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
            this.btnUploadLarry.Location = new System.Drawing.Point(60, 370);
            this.btnUploadLarry.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadLarry.Name = "btnUploadLarry";
            this.btnUploadLarry.Size = new System.Drawing.Size(131, 55);
            this.btnUploadLarry.TabIndex = 2;
            this.btnUploadLarry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadLarry.Click += new System.EventHandler(this.btnUploadLarry_Click);
            // 
            // childrensBookList
            // 
            this.childrensBookList.BackColor = System.Drawing.Color.Thistle;
            this.childrensBookList.HideSelection = false;
            this.childrensBookList.Location = new System.Drawing.Point(17, 28);
            this.childrensBookList.Name = "childrensBookList";
            this.childrensBookList.Size = new System.Drawing.Size(212, 339);
            this.childrensBookList.TabIndex = 0;
            this.childrensBookList.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // PicturesTrain3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "PicturesTrain3";
            this.Size = new System.Drawing.Size(1500, 605);
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadNormal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadLarry;
        private System.Windows.Forms.ListView childrensBookList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
