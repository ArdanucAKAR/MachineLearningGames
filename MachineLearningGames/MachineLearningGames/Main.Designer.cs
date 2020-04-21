namespace MachineLearningGames
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.transitionLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transtionText = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionPages = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.drgTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnIcon);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.transitionLogo.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionPages.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1500, 45);
            this.pnlTop.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionLogo.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionPages.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1456, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 45);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionLogo.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.transitionPages.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1419, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 62);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionLogo.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.transitionPages.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.btnIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnIcon.Image")));
            this.btnIcon.ImageActive = null;
            this.btnIcon.Location = new System.Drawing.Point(16, 7);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(30, 30);
            this.btnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIcon.TabIndex = 6;
            this.btnIcon.TabStop = false;
            this.btnIcon.Zoom = 10;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.transitionPages.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.transitionLogo.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(674, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(141, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Makine Öğrenmesi";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblText);
            this.pnlMain.Controls.Add(this.pbLogo);
            this.transitionLogo.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.transitionPages.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 705);
            this.pnlMain.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.transitionPages.SetDecoration(this.lblText, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.lblText, BunifuAnimatorNS.DecorationType.None);
            this.transitionLogo.SetDecoration(this.lblText, BunifuAnimatorNS.DecorationType.None);
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(383, 285);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(957, 91);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Machine Learning for Kids";
            this.lblText.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.transitionPages.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.transitionLogo.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(124, 220);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(227, 227);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Visible = false;
            // 
            // transitionLogo
            // 
            this.transitionLogo.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionLogo.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.transitionLogo.DefaultAnimation = animation5;
            this.transitionLogo.MaxAnimationTime = 1000;
            // 
            // transtionText
            // 
            this.transtionText.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transtionText.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.transtionText.DefaultAnimation = animation6;
            this.transtionText.MaxAnimationTime = 1000;
            // 
            // transitionPages
            // 
            this.transitionPages.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionPages.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.transitionPages.DefaultAnimation = animation4;
            this.transitionPages.MaxAnimationTime = 1250;
            // 
            // drgTop
            // 
            this.drgTop.Fixed = true;
            this.drgTop.Horizontal = true;
            this.drgTop.TargetControl = this.pnlTop;
            this.drgTop.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.transitionPages.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transtionText.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel lblText;
        private BunifuAnimatorNS.BunifuTransition transitionLogo;
        private BunifuAnimatorNS.BunifuTransition transtionText;
        private System.Windows.Forms.PictureBox pbLogo;
        private BunifuAnimatorNS.BunifuTransition transitionPages;
        public System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuDragControl drgTop;
    }
}