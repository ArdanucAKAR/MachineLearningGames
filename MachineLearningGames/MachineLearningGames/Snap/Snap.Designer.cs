namespace MachineLearningGames.Snap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snap));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlSnapMain = new System.Windows.Forms.Panel();
            this.pbSnap = new System.Windows.Forms.PictureBox();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSnap = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.transitionTabs = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlBottom.SuspendLayout();
            this.pnlSnapMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnap)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBottom.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.color = System.Drawing.Color.Transparent;
            this.btnHome.colorActive = System.Drawing.Color.Silver;
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
            this.btnTest.colorActive = System.Drawing.Color.Silver;
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
            this.btnTrain.colorActive = System.Drawing.Color.Silver;
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
            // pnlSnapMain
            // 
            this.pnlSnapMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlSnapMain.Controls.Add(this.pbSnap);
            this.pnlSnapMain.Controls.Add(this.lblDescription);
            this.pnlSnapMain.Controls.Add(this.lblSnap);
            this.transitionTabs.SetDecoration(this.pnlSnapMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlSnapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSnapMain.Location = new System.Drawing.Point(0, 0);
            this.pnlSnapMain.Name = "pnlSnapMain";
            this.pnlSnapMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlSnapMain.TabIndex = 1;
            // 
            // pbSnap
            // 
            this.transitionTabs.SetDecoration(this.pbSnap, BunifuAnimatorNS.DecorationType.None);
            this.pbSnap.Image = ((System.Drawing.Image)(resources.GetObject("pbSnap.Image")));
            this.pbSnap.Location = new System.Drawing.Point(460, 71);
            this.pbSnap.Name = "pbSnap";
            this.pbSnap.Size = new System.Drawing.Size(587, 305);
            this.pbSnap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSnap.TabIndex = 5;
            this.pbSnap.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.transitionTabs.SetDecoration(this.lblDescription, BunifuAnimatorNS.DecorationType.None);
            this.lblDescription.Font = new System.Drawing.Font("TR Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(692, 457);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 28);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Açıklama";
            // 
            // lblSnap
            // 
            this.lblSnap.AutoSize = true;
            this.transitionTabs.SetDecoration(this.lblSnap, BunifuAnimatorNS.DecorationType.None);
            this.lblSnap.Font = new System.Drawing.Font("TR Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnap.ForeColor = System.Drawing.Color.White;
            this.lblSnap.Location = new System.Drawing.Point(540, 400);
            this.lblSnap.Name = "lblSnap";
            this.lblSnap.Size = new System.Drawing.Size(427, 38);
            this.lblSnap.TabIndex = 6;
            this.lblSnap.Text = "SNAP! - Makine Öğrenmesi";
            // 
            // transitionTabs
            // 
            this.transitionTabs.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
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
            animation4.TransparencyCoeff = 1F;
            this.transitionTabs.DefaultAnimation = animation4;
            this.transitionTabs.MaxAnimationTime = 1250;
            // 
            // Snap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlSnapMain);
            this.Controls.Add(this.pnlBottom);
            this.transitionTabs.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Snap";
            this.Size = new System.Drawing.Size(1500, 705);
            this.Load += new System.EventHandler(this.Snap_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlSnapMain.ResumeLayout(false);
            this.pnlSnapMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSnapMain;
        private System.Windows.Forms.PictureBox pbSnap;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSnap;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        private BunifuAnimatorNS.BunifuTransition transitionTabs;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        public Bunifu.Framework.UI.BunifuTileButton btnTrain;
        public Bunifu.Framework.UI.BunifuTileButton btnTest;
    }
}
