namespace MachineLearningGames.Main
{
    partial class GameMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.lblGameDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGameName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.transitionTabs = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pbMain);
            this.pnlMain.Controls.Add(this.lblGameDescription);
            this.pnlMain.Controls.Add(this.lblGameName);
            this.transitionTabs.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.TabIndex = 3;
            // 
            // pbMain
            // 
            this.transitionTabs.SetDecoration(this.pbMain, BunifuAnimatorNS.DecorationType.None);
            this.pbMain.Location = new System.Drawing.Point(460, 71);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(587, 305);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 5;
            this.pbMain.TabStop = false;
            // 
            // lblGameDescription
            // 
            this.lblGameDescription.AutoSize = true;
            this.transitionTabs.SetDecoration(this.lblGameDescription, BunifuAnimatorNS.DecorationType.None);
            this.lblGameDescription.Font = new System.Drawing.Font("TR Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDescription.ForeColor = System.Drawing.Color.White;
            this.lblGameDescription.Location = new System.Drawing.Point(692, 457);
            this.lblGameDescription.Name = "lblGameDescription";
            this.lblGameDescription.Size = new System.Drawing.Size(123, 28);
            this.lblGameDescription.TabIndex = 6;
            this.lblGameDescription.Text = "Açıklama";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.transitionTabs.SetDecoration(this.lblGameName, BunifuAnimatorNS.DecorationType.None);
            this.lblGameName.Font = new System.Drawing.Font("TR Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(669, 399);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(162, 38);
            this.lblGameName.TabIndex = 6;
            this.lblGameName.Text = "Oyun Adı";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnHome);
            this.pnlBottom.Controls.Add(this.btnTest);
            this.pnlBottom.Controls.Add(this.btnTrain);
            this.transitionTabs.SetDecoration(this.pnlBottom, BunifuAnimatorNS.DecorationType.None);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 605);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1500, 100);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.color = System.Drawing.Color.Transparent;
            this.btnHome.colorActive = System.Drawing.Color.DarkCyan;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImagePosition = 18;
            this.btnHome.ImageZoom = 50;
            this.btnHome.LabelPosition = 36;
            this.btnHome.LabelText = "";
            this.btnHome.Location = new System.Drawing.Point(588, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.TabIndex = 2;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.color = System.Drawing.Color.Transparent;
            this.btnTest.colorActive = System.Drawing.Color.DarkCyan;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImagePosition = 18;
            this.btnTest.ImageZoom = 50;
            this.btnTest.LabelPosition = 36;
            this.btnTest.LabelText = "";
            this.btnTest.Location = new System.Drawing.Point(812, 0);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 100);
            this.btnTest.TabIndex = 1;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseHover += new System.EventHandler(this.btnTest_MouseHover);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.color = System.Drawing.Color.Transparent;
            this.btnTrain.colorActive = System.Drawing.Color.DarkCyan;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImagePosition = 18;
            this.btnTrain.ImageZoom = 50;
            this.btnTrain.LabelPosition = 36;
            this.btnTrain.LabelText = "";
            this.btnTrain.Location = new System.Drawing.Point(700, 0);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(100, 100);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            this.btnTrain.MouseLeave += new System.EventHandler(this.btnTrain_MouseLeave);
            this.btnTrain.MouseHover += new System.EventHandler(this.btnTrain_MouseHover);
            // 
            // transitionTabs
            // 
            this.transitionTabs.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionTabs.Cursor = null;
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
            this.transitionTabs.DefaultAnimation = animation1;
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.transitionTabs.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "GameMain";
            this.Size = new System.Drawing.Size(1500, 705);
            this.Load += new System.EventHandler(this.GameMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private BunifuAnimatorNS.BunifuTransition transitionTabs;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        public Bunifu.Framework.UI.BunifuTileButton btnTest;
        public Bunifu.Framework.UI.BunifuTileButton btnTrain;
        public System.Windows.Forms.PictureBox pbMain;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGameDescription;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGameName;
    }
}
