namespace MachineLearningGames.Snap.Tabs
{
    partial class LearnTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnTest));
            this.btnProgressAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pbClubs = new System.Windows.Forms.PictureBox();
            this.pbDiamonds = new System.Windows.Forms.PictureBox();
            this.lblDiamondsCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHeartsCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlSpadesCount = new System.Windows.Forms.Panel();
            this.pbSpades = new System.Windows.Forms.PictureBox();
            this.lblSpadesCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pnlHeartsCount = new System.Windows.Forms.Panel();
            this.lblProgress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlDiamondsCount = new System.Windows.Forms.Panel();
            this.prgssbLearnTest = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pnlClubsCount = new System.Windows.Forms.Panel();
            this.lblClubsCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLearnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlLearnTest = new System.Windows.Forms.Panel();
            this.tmrLearnTest = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamonds)).BeginInit();
            this.pnlSpadesCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            this.pnlHeartsCount.SuspendLayout();
            this.pnlDiamondsCount.SuspendLayout();
            this.pnlClubsCount.SuspendLayout();
            this.pnlLearnTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProgressAnimation
            // 
            this.btnProgressAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.btnProgressAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.btnProgressAnimation.DefaultAnimation = animation1;
            this.btnProgressAnimation.MaxAnimationTime = 1000;
            // 
            // pbClubs
            // 
            this.btnProgressAnimation.SetDecoration(this.pbClubs, BunifuAnimatorNS.DecorationType.None);
            this.pbClubs.Image = ((System.Drawing.Image)(resources.GetObject("pbClubs.Image")));
            this.pbClubs.Location = new System.Drawing.Point(8, 24);
            this.pbClubs.Name = "pbClubs";
            this.pbClubs.Size = new System.Drawing.Size(100, 100);
            this.pbClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClubs.TabIndex = 7;
            this.pbClubs.TabStop = false;
            // 
            // pbDiamonds
            // 
            this.btnProgressAnimation.SetDecoration(this.pbDiamonds, BunifuAnimatorNS.DecorationType.None);
            this.pbDiamonds.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamonds.Image")));
            this.pbDiamonds.Location = new System.Drawing.Point(8, 24);
            this.pbDiamonds.Name = "pbDiamonds";
            this.pbDiamonds.Size = new System.Drawing.Size(100, 100);
            this.pbDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiamonds.TabIndex = 7;
            this.pbDiamonds.TabStop = false;
            // 
            // lblDiamondsCount
            // 
            this.lblDiamondsCount.AutoSize = true;
            this.btnProgressAnimation.SetDecoration(this.lblDiamondsCount, BunifuAnimatorNS.DecorationType.None);
            this.lblDiamondsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiamondsCount.ForeColor = System.Drawing.Color.White;
            this.lblDiamondsCount.Location = new System.Drawing.Point(114, 58);
            this.lblDiamondsCount.Name = "lblDiamondsCount";
            this.lblDiamondsCount.Size = new System.Drawing.Size(29, 31);
            this.lblDiamondsCount.TabIndex = 2;
            this.lblDiamondsCount.Text = "0";
            // 
            // lblHeartsCount
            // 
            this.lblHeartsCount.AutoSize = true;
            this.btnProgressAnimation.SetDecoration(this.lblHeartsCount, BunifuAnimatorNS.DecorationType.None);
            this.lblHeartsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeartsCount.ForeColor = System.Drawing.Color.White;
            this.lblHeartsCount.Location = new System.Drawing.Point(114, 58);
            this.lblHeartsCount.Name = "lblHeartsCount";
            this.lblHeartsCount.Size = new System.Drawing.Size(29, 31);
            this.lblHeartsCount.TabIndex = 2;
            this.lblHeartsCount.Text = "0";
            // 
            // pnlSpadesCount
            // 
            this.pnlSpadesCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpadesCount.Controls.Add(this.pbSpades);
            this.pnlSpadesCount.Controls.Add(this.lblSpadesCount);
            this.btnProgressAnimation.SetDecoration(this.pnlSpadesCount, BunifuAnimatorNS.DecorationType.None);
            this.pnlSpadesCount.Location = new System.Drawing.Point(799, 88);
            this.pnlSpadesCount.Name = "pnlSpadesCount";
            this.pnlSpadesCount.Size = new System.Drawing.Size(150, 150);
            this.pnlSpadesCount.TabIndex = 8;
            // 
            // pbSpades
            // 
            this.btnProgressAnimation.SetDecoration(this.pbSpades, BunifuAnimatorNS.DecorationType.None);
            this.pbSpades.Image = ((System.Drawing.Image)(resources.GetObject("pbSpades.Image")));
            this.pbSpades.Location = new System.Drawing.Point(8, 24);
            this.pbSpades.Name = "pbSpades";
            this.pbSpades.Size = new System.Drawing.Size(100, 100);
            this.pbSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpades.TabIndex = 7;
            this.pbSpades.TabStop = false;
            // 
            // lblSpadesCount
            // 
            this.lblSpadesCount.AutoSize = true;
            this.btnProgressAnimation.SetDecoration(this.lblSpadesCount, BunifuAnimatorNS.DecorationType.None);
            this.lblSpadesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpadesCount.ForeColor = System.Drawing.Color.White;
            this.lblSpadesCount.Location = new System.Drawing.Point(114, 58);
            this.lblSpadesCount.Name = "lblSpadesCount";
            this.lblSpadesCount.Size = new System.Drawing.Size(29, 31);
            this.lblSpadesCount.TabIndex = 2;
            this.lblSpadesCount.Text = "0";
            // 
            // pbHearts
            // 
            this.btnProgressAnimation.SetDecoration(this.pbHearts, BunifuAnimatorNS.DecorationType.None);
            this.pbHearts.Image = ((System.Drawing.Image)(resources.GetObject("pbHearts.Image")));
            this.pbHearts.Location = new System.Drawing.Point(8, 24);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(100, 100);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 7;
            this.pbHearts.TabStop = false;
            // 
            // pnlHeartsCount
            // 
            this.pnlHeartsCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeartsCount.Controls.Add(this.pbHearts);
            this.pnlHeartsCount.Controls.Add(this.lblHeartsCount);
            this.btnProgressAnimation.SetDecoration(this.pnlHeartsCount, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeartsCount.Location = new System.Drawing.Point(331, 88);
            this.pnlHeartsCount.Name = "pnlHeartsCount";
            this.pnlHeartsCount.Size = new System.Drawing.Size(150, 150);
            this.pnlHeartsCount.TabIndex = 8;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.btnProgressAnimation.SetDecoration(this.lblProgress, BunifuAnimatorNS.DecorationType.None);
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(755, 508);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 20);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDiamondsCount
            // 
            this.pnlDiamondsCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiamondsCount.Controls.Add(this.pbDiamonds);
            this.pnlDiamondsCount.Controls.Add(this.lblDiamondsCount);
            this.btnProgressAnimation.SetDecoration(this.pnlDiamondsCount, BunifuAnimatorNS.DecorationType.None);
            this.pnlDiamondsCount.Location = new System.Drawing.Point(565, 87);
            this.pnlDiamondsCount.Name = "pnlDiamondsCount";
            this.pnlDiamondsCount.Size = new System.Drawing.Size(150, 150);
            this.pnlDiamondsCount.TabIndex = 8;
            // 
            // prgssbLearnTest
            // 
            this.prgssbLearnTest.animated = true;
            this.prgssbLearnTest.animationIterval = 5;
            this.prgssbLearnTest.animationSpeed = 300;
            this.prgssbLearnTest.BackColor = System.Drawing.Color.Transparent;
            this.prgssbLearnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prgssbLearnTest.BackgroundImage")));
            this.btnProgressAnimation.SetDecoration(this.prgssbLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.prgssbLearnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.prgssbLearnTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.prgssbLearnTest.LabelVisible = true;
            this.prgssbLearnTest.LineProgressThickness = 8;
            this.prgssbLearnTest.LineThickness = 5;
            this.prgssbLearnTest.Location = new System.Drawing.Point(655, 283);
            this.prgssbLearnTest.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.prgssbLearnTest.MaxValue = 100;
            this.prgssbLearnTest.Name = "prgssbLearnTest";
            this.prgssbLearnTest.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prgssbLearnTest.ProgressColor = System.Drawing.Color.SeaGreen;
            this.prgssbLearnTest.Size = new System.Drawing.Size(201, 201);
            this.prgssbLearnTest.TabIndex = 6;
            this.prgssbLearnTest.Value = 0;
            this.prgssbLearnTest.Visible = false;
            // 
            // pnlClubsCount
            // 
            this.pnlClubsCount.BackColor = System.Drawing.Color.Transparent;
            this.pnlClubsCount.Controls.Add(this.pbClubs);
            this.pnlClubsCount.Controls.Add(this.lblClubsCount);
            this.btnProgressAnimation.SetDecoration(this.pnlClubsCount, BunifuAnimatorNS.DecorationType.None);
            this.pnlClubsCount.Location = new System.Drawing.Point(1033, 88);
            this.pnlClubsCount.Name = "pnlClubsCount";
            this.pnlClubsCount.Size = new System.Drawing.Size(150, 150);
            this.pnlClubsCount.TabIndex = 8;
            // 
            // lblClubsCount
            // 
            this.lblClubsCount.AutoSize = true;
            this.btnProgressAnimation.SetDecoration(this.lblClubsCount, BunifuAnimatorNS.DecorationType.None);
            this.lblClubsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsCount.ForeColor = System.Drawing.Color.White;
            this.lblClubsCount.Location = new System.Drawing.Point(114, 58);
            this.lblClubsCount.Name = "lblClubsCount";
            this.lblClubsCount.Size = new System.Drawing.Size(29, 31);
            this.lblClubsCount.TabIndex = 2;
            this.lblClubsCount.Text = "0";
            // 
            // btnLearnTest
            // 
            this.btnLearnTest.ActiveBorderThickness = 3;
            this.btnLearnTest.ActiveCornerRadius = 20;
            this.btnLearnTest.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.btnLearnTest.ActiveForecolor = System.Drawing.Color.Silver;
            this.btnLearnTest.ActiveLineColor = System.Drawing.Color.ForestGreen;
            this.btnLearnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnLearnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLearnTest.BackgroundImage")));
            this.btnLearnTest.ButtonText = "Öğret ve Test Et";
            this.btnLearnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgressAnimation.SetDecoration(this.btnLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnLearnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearnTest.ForeColor = System.Drawing.Color.White;
            this.btnLearnTest.IdleBorderThickness = 3;
            this.btnLearnTest.IdleCornerRadius = 20;
            this.btnLearnTest.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLearnTest.IdleForecolor = System.Drawing.Color.Silver;
            this.btnLearnTest.IdleLineColor = System.Drawing.Color.Silver;
            this.btnLearnTest.Location = new System.Drawing.Point(648, 354);
            this.btnLearnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnLearnTest.Name = "btnLearnTest";
            this.btnLearnTest.Size = new System.Drawing.Size(214, 59);
            this.btnLearnTest.TabIndex = 4;
            this.btnLearnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLearnTest.Click += new System.EventHandler(this.btnLearnTest_Click);
            // 
            // pnlLearnTest
            // 
            this.pnlLearnTest.BackColor = System.Drawing.Color.Transparent;
            this.pnlLearnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLearnTest.BackgroundImage")));
            this.pnlLearnTest.Controls.Add(this.pnlSpadesCount);
            this.pnlLearnTest.Controls.Add(this.pnlHeartsCount);
            this.pnlLearnTest.Controls.Add(this.pnlDiamondsCount);
            this.pnlLearnTest.Controls.Add(this.pnlClubsCount);
            this.pnlLearnTest.Controls.Add(this.btnLearnTest);
            this.pnlLearnTest.Controls.Add(this.prgssbLearnTest);
            this.pnlLearnTest.Controls.Add(this.lblProgress);
            this.btnProgressAnimation.SetDecoration(this.pnlLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.pnlLearnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLearnTest.Location = new System.Drawing.Point(0, 0);
            this.pnlLearnTest.Name = "pnlLearnTest";
            this.pnlLearnTest.Size = new System.Drawing.Size(1500, 605);
            this.pnlLearnTest.TabIndex = 8;
            // 
            // tmrLearnTest
            // 
            this.tmrLearnTest.Tick += new System.EventHandler(this.tmrLearnTest_Tick);
            // 
            // LearnTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlLearnTest);
            this.btnProgressAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "LearnTest";
            this.Size = new System.Drawing.Size(1500, 605);
            this.Load += new System.EventHandler(this.LearnTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamonds)).EndInit();
            this.pnlSpadesCount.ResumeLayout(false);
            this.pnlSpadesCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            this.pnlHeartsCount.ResumeLayout(false);
            this.pnlHeartsCount.PerformLayout();
            this.pnlDiamondsCount.ResumeLayout(false);
            this.pnlDiamondsCount.PerformLayout();
            this.pnlClubsCount.ResumeLayout(false);
            this.pnlClubsCount.PerformLayout();
            this.pnlLearnTest.ResumeLayout(false);
            this.pnlLearnTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition btnProgressAnimation;
        private System.Windows.Forms.PictureBox pbClubs;
        private System.Windows.Forms.PictureBox pbDiamonds;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDiamondsCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeartsCount;
        private System.Windows.Forms.Panel pnlSpadesCount;
        private System.Windows.Forms.PictureBox pbSpades;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSpadesCount;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Panel pnlHeartsCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProgress;
        private System.Windows.Forms.Panel pnlDiamondsCount;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prgssbLearnTest;
        private System.Windows.Forms.Panel pnlClubsCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblClubsCount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLearnTest;
        private System.Windows.Forms.Panel pnlLearnTest;
        private System.Windows.Forms.Timer tmrLearnTest;
        private System.Windows.Forms.Timer timer1;
    }
}
