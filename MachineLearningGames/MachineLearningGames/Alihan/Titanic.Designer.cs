namespace MachineLearningGames
{
    partial class Titanic
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titanic));
            this.transitionTabs = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblHome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // transitionTabs
            // 
            this.transitionTabs.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionTabs.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.transitionTabs.DefaultAnimation = animation4;
            this.transitionTabs.MaxAnimationTime = 1000;
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Controls.Add(this.pnlBottom);
            this.panel.Controls.Add(this.pnlMain);
            this.transitionTabs.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1500, 705);
            this.panel.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Controls.Add(this.btnHome);
            this.pnlBottom.Controls.Add(this.btnTest);
            this.pnlBottom.Controls.Add(this.btnTrain);
            this.transitionTabs.SetDecoration(this.pnlBottom, BunifuAnimatorNS.DecorationType.None);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 605);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1500, 100);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.color = System.Drawing.Color.Transparent;
            this.btnHome.colorActive = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImagePosition = 18;
            this.btnHome.ImageZoom = 50;
            this.btnHome.LabelPosition = 36;
            this.btnHome.LabelText = "";
            this.btnHome.Location = new System.Drawing.Point(588, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 100);
            this.btnHome.TabIndex = 5;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.color = System.Drawing.Color.Transparent;
            this.btnTest.colorActive = System.Drawing.Color.Transparent;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImagePosition = 18;
            this.btnTest.ImageZoom = 50;
            this.btnTest.LabelPosition = 36;
            this.btnTest.LabelText = "";
            this.btnTest.Location = new System.Drawing.Point(812, 0);
            this.btnTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 100);
            this.btnTest.TabIndex = 4;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.color = System.Drawing.Color.Transparent;
            this.btnTrain.colorActive = System.Drawing.Color.Transparent;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImagePosition = 18;
            this.btnTrain.ImageZoom = 50;
            this.btnTrain.LabelPosition = 36;
            this.btnTrain.LabelText = "";
            this.btnTrain.Location = new System.Drawing.Point(700, 0);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(100, 100);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblHome);
            this.pnlMain.Controls.Add(this.pbHome);
            this.transitionTabs.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.TabIndex = 0;
            // 
            // pbHome
            // 
            this.transitionTabs.SetDecoration(this.pbHome, BunifuAnimatorNS.DecorationType.None);
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHome.InitialImage")));
            this.pbHome.Location = new System.Drawing.Point(457, 119);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(587, 305);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 6;
            this.pbHome.TabStop = false;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.transitionTabs.SetDecoration(this.lblHome, BunifuAnimatorNS.DecorationType.None);
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(537, 448);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(446, 37);
            this.lblHome.TabIndex = 7;
            this.lblHome.Text = "TITANIC! - Makine Öğrenmesi";
            // 
            // Titanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.transitionTabs.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Titanic";
            this.Size = new System.Drawing.Size(1500, 705);
            this.panel.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition transitionTabs;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        private Bunifu.Framework.UI.BunifuTileButton btnTest;
        private Bunifu.Framework.UI.BunifuTileButton btnTrain;
        private System.Windows.Forms.PictureBox pbHome;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHome;
    }
}
