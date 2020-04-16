namespace MachineLearningGames
{
    partial class Snap
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
            BunifuAnimatorNS.Animation animation22 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snap));
            BunifuAnimatorNS.Animation animation23 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation24 = new BunifuAnimatorNS.Animation();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMake = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLearnTest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bnfTabAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bnfLogoAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bnfSideAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).BeginInit();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnIcon);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.bnfTabAnimation.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1060, 45);
            this.pnlTop.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTabAnimation.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1020, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTabAnimation.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(984, 0);
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
            this.btnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTabAnimation.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.btnIcon, BunifuAnimatorNS.DecorationType.None);
            this.btnIcon.Image = ((System.Drawing.Image)(resources.GetObject("btnIcon.Image")));
            this.btnIcon.ImageActive = null;
            this.btnIcon.Location = new System.Drawing.Point(16, 7);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(30, 30);
            this.btnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIcon.TabIndex = 6;
            this.btnIcon.TabStop = false;
            this.btnIcon.Zoom = 10;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.bnfSideAnimation.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this.lblHeader, BunifuAnimatorNS.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(61, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(211, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "SNAP! - Makine Öğrenmesi";
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Black;
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.Controls.Add(this.btnMake);
            this.pnlSide.Controls.Add(this.btnLearnTest);
            this.pnlSide.Controls.Add(this.btnTrain);
            this.pnlSide.Controls.Add(this.btnMenu);
            this.bnfTabAnimation.SetDecoration(this.pnlSide, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.pnlSide, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.pnlSide, BunifuAnimatorNS.DecorationType.None);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 45);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(75, 667);
            this.pnlSide.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfSideAnimation.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(80, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(209, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            this.pbLogo.Visible = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnMake
            // 
            this.btnMake.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnMake.BackColor = System.Drawing.Color.Black;
            this.btnMake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMake.BorderRadius = 0;
            this.btnMake.ButtonText = "Yap";
            this.btnMake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfSideAnimation.SetDecoration(this.btnMake, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnMake, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this.btnMake, BunifuAnimatorNS.DecorationType.None);
            this.btnMake.DisabledColor = System.Drawing.Color.Gray;
            this.btnMake.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMake.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMake.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMake.Iconimage")));
            this.btnMake.Iconimage_right = null;
            this.btnMake.Iconimage_right_Selected = null;
            this.btnMake.Iconimage_Selected = null;
            this.btnMake.IconMarginLeft = 15;
            this.btnMake.IconMarginRight = 0;
            this.btnMake.IconRightVisible = true;
            this.btnMake.IconRightZoom = 0D;
            this.btnMake.IconVisible = true;
            this.btnMake.IconZoom = 90D;
            this.btnMake.IsTab = true;
            this.btnMake.Location = new System.Drawing.Point(0, 259);
            this.btnMake.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMake.Name = "btnMake";
            this.btnMake.Normalcolor = System.Drawing.Color.Black;
            this.btnMake.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.btnMake.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMake.selected = false;
            this.btnMake.Size = new System.Drawing.Size(301, 60);
            this.btnMake.TabIndex = 9;
            this.btnMake.Text = "Yap";
            this.btnMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMake.Textcolor = System.Drawing.Color.Silver;
            this.btnMake.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnLearnTest
            // 
            this.btnLearnTest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnLearnTest.BackColor = System.Drawing.Color.Black;
            this.btnLearnTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLearnTest.BorderRadius = 0;
            this.btnLearnTest.ButtonText = "Öğrenme ve Test";
            this.btnLearnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfSideAnimation.SetDecoration(this.btnLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this.btnLearnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnLearnTest.DisabledColor = System.Drawing.Color.Gray;
            this.btnLearnTest.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearnTest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLearnTest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLearnTest.Iconimage")));
            this.btnLearnTest.Iconimage_right = null;
            this.btnLearnTest.Iconimage_right_Selected = null;
            this.btnLearnTest.Iconimage_Selected = null;
            this.btnLearnTest.IconMarginLeft = 15;
            this.btnLearnTest.IconMarginRight = 0;
            this.btnLearnTest.IconRightVisible = true;
            this.btnLearnTest.IconRightZoom = 0D;
            this.btnLearnTest.IconVisible = true;
            this.btnLearnTest.IconZoom = 90D;
            this.btnLearnTest.IsTab = true;
            this.btnLearnTest.Location = new System.Drawing.Point(0, 193);
            this.btnLearnTest.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLearnTest.Name = "btnLearnTest";
            this.btnLearnTest.Normalcolor = System.Drawing.Color.Black;
            this.btnLearnTest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.btnLearnTest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLearnTest.selected = false;
            this.btnLearnTest.Size = new System.Drawing.Size(301, 60);
            this.btnLearnTest.TabIndex = 8;
            this.btnLearnTest.Text = "Öğrenme ve Test";
            this.btnLearnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLearnTest.Textcolor = System.Drawing.Color.Silver;
            this.btnLearnTest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLearnTest.Click += new System.EventHandler(this.btnLearnTest_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(21)))), ((int)(((byte)(29)))));
            this.btnTrain.BackColor = System.Drawing.Color.Black;
            this.btnTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrain.BorderRadius = 0;
            this.btnTrain.ButtonText = "Eğitme";
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfSideAnimation.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrain.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrain.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrain.Iconimage")));
            this.btnTrain.Iconimage_right = null;
            this.btnTrain.Iconimage_right_Selected = null;
            this.btnTrain.Iconimage_Selected = null;
            this.btnTrain.IconMarginLeft = 15;
            this.btnTrain.IconMarginRight = 0;
            this.btnTrain.IconRightVisible = false;
            this.btnTrain.IconRightZoom = 0D;
            this.btnTrain.IconVisible = true;
            this.btnTrain.IconZoom = 90D;
            this.btnTrain.IsTab = true;
            this.btnTrain.Location = new System.Drawing.Point(0, 127);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Normalcolor = System.Drawing.Color.Black;
            this.btnTrain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.btnTrain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTrain.selected = false;
            this.btnTrain.Size = new System.Drawing.Size(301, 60);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Eğitme";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrain.Textcolor = System.Drawing.Color.Silver;
            this.btnTrain.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTabAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(15, 41);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 45);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 6;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bnfTabAnimation.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.bnfSideAnimation.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(75, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(985, 667);
            this.pnlMain.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bnfTabAnimation
            // 
            this.bnfTabAnimation.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bnfTabAnimation.Cursor = null;
            animation22.AnimateOnlyDifferences = true;
            animation22.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.BlindCoeff")));
            animation22.LeafCoeff = 0F;
            animation22.MaxTime = 1F;
            animation22.MinTime = 0F;
            animation22.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.MosaicCoeff")));
            animation22.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation22.MosaicShift")));
            animation22.MosaicSize = 0;
            animation22.Padding = new System.Windows.Forms.Padding(0);
            animation22.RotateCoeff = 0F;
            animation22.RotateLimit = 0F;
            animation22.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.ScaleCoeff")));
            animation22.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation22.SlideCoeff")));
            animation22.TimeCoeff = 0F;
            animation22.TransparencyCoeff = 0F;
            this.bnfTabAnimation.DefaultAnimation = animation22;
            // 
            // bnfLogoAnimation
            // 
            this.bnfLogoAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bnfLogoAnimation.Cursor = null;
            animation23.AnimateOnlyDifferences = true;
            animation23.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.BlindCoeff")));
            animation23.LeafCoeff = 0F;
            animation23.MaxTime = 1F;
            animation23.MinTime = 0F;
            animation23.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicCoeff")));
            animation23.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation23.MosaicShift")));
            animation23.MosaicSize = 0;
            animation23.Padding = new System.Windows.Forms.Padding(0);
            animation23.RotateCoeff = 0F;
            animation23.RotateLimit = 0F;
            animation23.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.ScaleCoeff")));
            animation23.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation23.SlideCoeff")));
            animation23.TimeCoeff = 0F;
            animation23.TransparencyCoeff = 0F;
            this.bnfLogoAnimation.DefaultAnimation = animation23;
            // 
            // bnfSideAnimation
            // 
            this.bnfSideAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bnfSideAnimation.Cursor = null;
            animation24.AnimateOnlyDifferences = true;
            animation24.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.BlindCoeff")));
            animation24.LeafCoeff = 1F;
            animation24.MaxTime = 1F;
            animation24.MinTime = 0F;
            animation24.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicCoeff")));
            animation24.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation24.MosaicShift")));
            animation24.MosaicSize = 0;
            animation24.Padding = new System.Windows.Forms.Padding(0);
            animation24.RotateCoeff = 0F;
            animation24.RotateLimit = 0F;
            animation24.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.ScaleCoeff")));
            animation24.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation24.SlideCoeff")));
            animation24.TimeCoeff = 0F;
            animation24.TransparencyCoeff = 0F;
            this.bnfSideAnimation.DefaultAnimation = animation24;
            // 
            // Snap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1060, 712);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlTop);
            this.bnfSideAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bnfTabAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bnfLogoAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Snap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snap";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).EndInit();
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnMake;
        private Bunifu.Framework.UI.BunifuFlatButton btnLearnTest;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrain;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private BunifuAnimatorNS.BunifuTransition bnfTabAnimation;
        private BunifuAnimatorNS.BunifuTransition bnfLogoAnimation;
        private BunifuAnimatorNS.BunifuTransition bnfSideAnimation;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}