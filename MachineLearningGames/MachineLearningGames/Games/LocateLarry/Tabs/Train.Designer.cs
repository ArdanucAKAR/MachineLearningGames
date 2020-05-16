namespace MachineLearningGames.LocateLarry.Tabs
{
    partial class Train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.KingsList = new System.Windows.Forms.ListView();
            this.btnKingsUpload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GoldenList = new System.Windows.Forms.ListView();
            this.btnGoldenUpload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LadyList = new System.Windows.Forms.ListView();
            this.btnLadyUpload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LilyList = new System.Windows.Forms.ListView();
            this.btnLilyUpload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LarryList = new System.Windows.Forms.ListView();
            this.btnLarryUpload = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 605);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.KingsList);
            this.groupBox5.Controls.Add(this.btnKingsUpload);
            this.groupBox5.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox5.Location = new System.Drawing.Point(1102, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 367);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kings";
            // 
            // KingsList
            // 
            this.KingsList.BackColor = System.Drawing.Color.Red;
            this.KingsList.HideSelection = false;
            this.KingsList.Location = new System.Drawing.Point(42, 42);
            this.KingsList.Name = "KingsList";
            this.KingsList.Size = new System.Drawing.Size(138, 224);
            this.KingsList.TabIndex = 3;
            this.KingsList.UseCompatibleStateImageBehavior = false;
            // 
            // btnKingsUpload
            // 
            this.btnKingsUpload.ActiveBorderThickness = 1;
            this.btnKingsUpload.ActiveCornerRadius = 20;
            this.btnKingsUpload.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnKingsUpload.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnKingsUpload.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnKingsUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnKingsUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKingsUpload.BackgroundImage")));
            this.btnKingsUpload.ButtonText = "Kings";
            this.btnKingsUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKingsUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKingsUpload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKingsUpload.IdleBorderThickness = 1;
            this.btnKingsUpload.IdleCornerRadius = 20;
            this.btnKingsUpload.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnKingsUpload.IdleForecolor = System.Drawing.Color.Red;
            this.btnKingsUpload.IdleLineColor = System.Drawing.Color.Red;
            this.btnKingsUpload.Location = new System.Drawing.Point(42, 300);
            this.btnKingsUpload.Margin = new System.Windows.Forms.Padding(5);
            this.btnKingsUpload.Name = "btnKingsUpload";
            this.btnKingsUpload.Size = new System.Drawing.Size(122, 59);
            this.btnKingsUpload.TabIndex = 1;
            this.btnKingsUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKingsUpload.Click += new System.EventHandler(this.btnKingsUpload_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.GoldenList);
            this.groupBox4.Controls.Add(this.btnGoldenUpload);
            this.groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Location = new System.Drawing.Point(852, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 367);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Golden";
            // 
            // GoldenList
            // 
            this.GoldenList.BackColor = System.Drawing.Color.PeachPuff;
            this.GoldenList.HideSelection = false;
            this.GoldenList.Location = new System.Drawing.Point(42, 42);
            this.GoldenList.Name = "GoldenList";
            this.GoldenList.Size = new System.Drawing.Size(138, 224);
            this.GoldenList.TabIndex = 3;
            this.GoldenList.UseCompatibleStateImageBehavior = false;
            // 
            // btnGoldenUpload
            // 
            this.btnGoldenUpload.ActiveBorderThickness = 1;
            this.btnGoldenUpload.ActiveCornerRadius = 20;
            this.btnGoldenUpload.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnGoldenUpload.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnGoldenUpload.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnGoldenUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnGoldenUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoldenUpload.BackgroundImage")));
            this.btnGoldenUpload.ButtonText = "Golden";
            this.btnGoldenUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoldenUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoldenUpload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGoldenUpload.IdleBorderThickness = 1;
            this.btnGoldenUpload.IdleCornerRadius = 20;
            this.btnGoldenUpload.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnGoldenUpload.IdleForecolor = System.Drawing.Color.PeachPuff;
            this.btnGoldenUpload.IdleLineColor = System.Drawing.Color.PeachPuff;
            this.btnGoldenUpload.Location = new System.Drawing.Point(42, 300);
            this.btnGoldenUpload.Margin = new System.Windows.Forms.Padding(5);
            this.btnGoldenUpload.Name = "btnGoldenUpload";
            this.btnGoldenUpload.Size = new System.Drawing.Size(122, 59);
            this.btnGoldenUpload.TabIndex = 1;
            this.btnGoldenUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoldenUpload.Click += new System.EventHandler(this.btnGoldenUpload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.LadyList);
            this.groupBox3.Controls.Add(this.btnLadyUpload);
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(602, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 367);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lady";
            // 
            // LadyList
            // 
            this.LadyList.BackColor = System.Drawing.Color.DarkOrange;
            this.LadyList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LadyList.HideSelection = false;
            this.LadyList.Location = new System.Drawing.Point(42, 42);
            this.LadyList.Name = "LadyList";
            this.LadyList.Size = new System.Drawing.Size(138, 224);
            this.LadyList.TabIndex = 3;
            this.LadyList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLadyUpload
            // 
            this.btnLadyUpload.ActiveBorderThickness = 1;
            this.btnLadyUpload.ActiveCornerRadius = 20;
            this.btnLadyUpload.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLadyUpload.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnLadyUpload.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnLadyUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnLadyUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLadyUpload.BackgroundImage")));
            this.btnLadyUpload.ButtonText = "Lady";
            this.btnLadyUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLadyUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadyUpload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLadyUpload.IdleBorderThickness = 1;
            this.btnLadyUpload.IdleCornerRadius = 20;
            this.btnLadyUpload.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLadyUpload.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.btnLadyUpload.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.btnLadyUpload.Location = new System.Drawing.Point(42, 300);
            this.btnLadyUpload.Margin = new System.Windows.Forms.Padding(5);
            this.btnLadyUpload.Name = "btnLadyUpload";
            this.btnLadyUpload.Size = new System.Drawing.Size(122, 59);
            this.btnLadyUpload.TabIndex = 1;
            this.btnLadyUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLadyUpload.Click += new System.EventHandler(this.btnLadyUpload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LilyList);
            this.groupBox2.Controls.Add(this.btnLilyUpload);
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(352, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 367);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lily";
            // 
            // LilyList
            // 
            this.LilyList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LilyList.HideSelection = false;
            this.LilyList.Location = new System.Drawing.Point(42, 42);
            this.LilyList.Name = "LilyList";
            this.LilyList.Size = new System.Drawing.Size(138, 224);
            this.LilyList.TabIndex = 3;
            this.LilyList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLilyUpload
            // 
            this.btnLilyUpload.ActiveBorderThickness = 1;
            this.btnLilyUpload.ActiveCornerRadius = 20;
            this.btnLilyUpload.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLilyUpload.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnLilyUpload.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnLilyUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnLilyUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLilyUpload.BackgroundImage")));
            this.btnLilyUpload.ButtonText = "Lily";
            this.btnLilyUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLilyUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLilyUpload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLilyUpload.IdleBorderThickness = 1;
            this.btnLilyUpload.IdleCornerRadius = 20;
            this.btnLilyUpload.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLilyUpload.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnLilyUpload.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnLilyUpload.Location = new System.Drawing.Point(42, 300);
            this.btnLilyUpload.Margin = new System.Windows.Forms.Padding(5);
            this.btnLilyUpload.Name = "btnLilyUpload";
            this.btnLilyUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLilyUpload.Size = new System.Drawing.Size(122, 59);
            this.btnLilyUpload.TabIndex = 1;
            this.btnLilyUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLilyUpload.Click += new System.EventHandler(this.btnLilyUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LarryList);
            this.groupBox1.Controls.Add(this.btnLarryUpload);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(102, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 367);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Larry";
            // 
            // LarryList
            // 
            this.LarryList.BackColor = System.Drawing.Color.OrangeRed;
            this.LarryList.HideSelection = false;
            this.LarryList.Location = new System.Drawing.Point(33, 42);
            this.LarryList.Name = "LarryList";
            this.LarryList.Size = new System.Drawing.Size(138, 224);
            this.LarryList.TabIndex = 2;
            this.LarryList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLarryUpload
            // 
            this.btnLarryUpload.ActiveBorderThickness = 1;
            this.btnLarryUpload.ActiveCornerRadius = 20;
            this.btnLarryUpload.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLarryUpload.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnLarryUpload.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnLarryUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnLarryUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLarryUpload.BackgroundImage")));
            this.btnLarryUpload.ButtonText = "Larry";
            this.btnLarryUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLarryUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarryUpload.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLarryUpload.IdleBorderThickness = 1;
            this.btnLarryUpload.IdleCornerRadius = 20;
            this.btnLarryUpload.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLarryUpload.IdleForecolor = System.Drawing.Color.OrangeRed;
            this.btnLarryUpload.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnLarryUpload.Location = new System.Drawing.Point(42, 300);
            this.btnLarryUpload.Margin = new System.Windows.Forms.Padding(5);
            this.btnLarryUpload.Name = "btnLarryUpload";
            this.btnLarryUpload.Size = new System.Drawing.Size(122, 59);
            this.btnLarryUpload.TabIndex = 1;
            this.btnLarryUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLarryUpload.Click += new System.EventHandler(this.btnLarryUpload_Click);
            // 
            // LocateLarryTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Name = "LocateLarryTrain";
            this.Size = new System.Drawing.Size(1500, 605);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView KingsList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKingsUpload;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView GoldenList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGoldenUpload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LadyList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLadyUpload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LilyList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLilyUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LarryList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLarryUpload;
    }
}
