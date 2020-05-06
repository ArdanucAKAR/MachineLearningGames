namespace MachineLearningGames.Snap.Tabs
{
    partial class Train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gbHearts = new System.Windows.Forms.GroupBox();
            this.btnUploadHearts = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardHearts = new Bunifu.Framework.UI.BunifuCards();
            this.btnUploadDiamonds = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbDiamonds = new System.Windows.Forms.GroupBox();
            this.cardDiamonds = new Bunifu.Framework.UI.BunifuCards();
            this.gbClubs = new System.Windows.Forms.GroupBox();
            this.btnUploadClubs = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardClubs = new Bunifu.Framework.UI.BunifuCards();
            this.btnUploadSpades = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cardSpades = new Bunifu.Framework.UI.BunifuCards();
            this.gbSpades = new System.Windows.Forms.GroupBox();
            this.pnlTrain = new System.Windows.Forms.Panel();
            this.btnTrain = new Bunifu.Framework.UI.BunifuThinButton2();
            this.transitionTrain = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gbHearts.SuspendLayout();
            this.gbDiamonds.SuspendLayout();
            this.gbClubs.SuspendLayout();
            this.gbSpades.SuspendLayout();
            this.pnlTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.transitionTrain.SetDecoration(this.lblDescription, BunifuAnimatorNS.DecorationType.None);
            this.lblDescription.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(709, 18);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Açıklama";
            // 
            // gbHearts
            // 
            this.gbHearts.Controls.Add(this.btnUploadHearts);
            this.gbHearts.Controls.Add(this.cardHearts);
            this.transitionTrain.SetDecoration(this.gbHearts, BunifuAnimatorNS.DecorationType.None);
            this.gbHearts.Font = new System.Drawing.Font("TR Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHearts.ForeColor = System.Drawing.Color.White;
            this.gbHearts.Location = new System.Drawing.Point(32, 41);
            this.gbHearts.Name = "gbHearts";
            this.gbHearts.Size = new System.Drawing.Size(1437, 117);
            this.gbHearts.TabIndex = 2;
            this.gbHearts.TabStop = false;
            this.gbHearts.Text = "KALP 🖤";
            // 
            // btnUploadHearts
            // 
            this.btnUploadHearts.ActiveBorderThickness = 3;
            this.btnUploadHearts.ActiveCornerRadius = 20;
            this.btnUploadHearts.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnUploadHearts.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnUploadHearts.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadHearts.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadHearts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadHearts.BackgroundImage")));
            this.btnUploadHearts.ButtonText = "Resim Ekle";
            this.btnUploadHearts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTrain.SetDecoration(this.btnUploadHearts, BunifuAnimatorNS.DecorationType.None);
            this.btnUploadHearts.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadHearts.ForeColor = System.Drawing.Color.White;
            this.btnUploadHearts.IdleBorderThickness = 3;
            this.btnUploadHearts.IdleCornerRadius = 20;
            this.btnUploadHearts.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnUploadHearts.IdleForecolor = System.Drawing.Color.White;
            this.btnUploadHearts.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadHearts.Location = new System.Drawing.Point(1320, 25);
            this.btnUploadHearts.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadHearts.Name = "btnUploadHearts";
            this.btnUploadHearts.Size = new System.Drawing.Size(109, 84);
            this.btnUploadHearts.TabIndex = 1;
            this.btnUploadHearts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadHearts.Click += new System.EventHandler(this.btnUploadHearts_Click);
            // 
            // cardHearts
            // 
            this.cardHearts.BackColor = System.Drawing.Color.Gainsboro;
            this.cardHearts.BorderRadius = 5;
            this.cardHearts.BottomSahddow = true;
            this.cardHearts.color = System.Drawing.Color.Red;
            this.transitionTrain.SetDecoration(this.cardHearts, BunifuAnimatorNS.DecorationType.None);
            this.cardHearts.LeftSahddow = false;
            this.cardHearts.Location = new System.Drawing.Point(6, 25);
            this.cardHearts.Name = "cardHearts";
            this.cardHearts.RightSahddow = true;
            this.cardHearts.ShadowDepth = 20;
            this.cardHearts.Size = new System.Drawing.Size(1306, 86);
            this.cardHearts.TabIndex = 0;
            // 
            // btnUploadDiamonds
            // 
            this.btnUploadDiamonds.ActiveBorderThickness = 3;
            this.btnUploadDiamonds.ActiveCornerRadius = 20;
            this.btnUploadDiamonds.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnUploadDiamonds.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnUploadDiamonds.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadDiamonds.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadDiamonds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadDiamonds.BackgroundImage")));
            this.btnUploadDiamonds.ButtonText = "Resim Ekle";
            this.btnUploadDiamonds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTrain.SetDecoration(this.btnUploadDiamonds, BunifuAnimatorNS.DecorationType.None);
            this.btnUploadDiamonds.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadDiamonds.ForeColor = System.Drawing.Color.White;
            this.btnUploadDiamonds.IdleBorderThickness = 3;
            this.btnUploadDiamonds.IdleCornerRadius = 20;
            this.btnUploadDiamonds.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnUploadDiamonds.IdleForecolor = System.Drawing.Color.White;
            this.btnUploadDiamonds.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadDiamonds.Location = new System.Drawing.Point(1320, 25);
            this.btnUploadDiamonds.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadDiamonds.Name = "btnUploadDiamonds";
            this.btnUploadDiamonds.Size = new System.Drawing.Size(109, 86);
            this.btnUploadDiamonds.TabIndex = 2;
            this.btnUploadDiamonds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadDiamonds.Click += new System.EventHandler(this.btnUploadDiamonds_Click);
            // 
            // gbDiamonds
            // 
            this.gbDiamonds.Controls.Add(this.btnUploadDiamonds);
            this.gbDiamonds.Controls.Add(this.cardDiamonds);
            this.transitionTrain.SetDecoration(this.gbDiamonds, BunifuAnimatorNS.DecorationType.None);
            this.gbDiamonds.Font = new System.Drawing.Font("TR Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiamonds.ForeColor = System.Drawing.Color.White;
            this.gbDiamonds.Location = new System.Drawing.Point(32, 293);
            this.gbDiamonds.Name = "gbDiamonds";
            this.gbDiamonds.Size = new System.Drawing.Size(1437, 119);
            this.gbDiamonds.TabIndex = 3;
            this.gbDiamonds.TabStop = false;
            this.gbDiamonds.Text = "KARO ♦️";
            // 
            // cardDiamonds
            // 
            this.cardDiamonds.BackColor = System.Drawing.Color.Gainsboro;
            this.cardDiamonds.BorderRadius = 5;
            this.cardDiamonds.BottomSahddow = true;
            this.cardDiamonds.color = System.Drawing.Color.Red;
            this.transitionTrain.SetDecoration(this.cardDiamonds, BunifuAnimatorNS.DecorationType.None);
            this.cardDiamonds.LeftSahddow = false;
            this.cardDiamonds.Location = new System.Drawing.Point(6, 25);
            this.cardDiamonds.Name = "cardDiamonds";
            this.cardDiamonds.RightSahddow = true;
            this.cardDiamonds.ShadowDepth = 20;
            this.cardDiamonds.Size = new System.Drawing.Size(1306, 86);
            this.cardDiamonds.TabIndex = 0;
            // 
            // gbClubs
            // 
            this.gbClubs.Controls.Add(this.btnUploadClubs);
            this.gbClubs.Controls.Add(this.cardClubs);
            this.transitionTrain.SetDecoration(this.gbClubs, BunifuAnimatorNS.DecorationType.None);
            this.gbClubs.Font = new System.Drawing.Font("TR Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClubs.ForeColor = System.Drawing.Color.White;
            this.gbClubs.Location = new System.Drawing.Point(32, 164);
            this.gbClubs.Name = "gbClubs";
            this.gbClubs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbClubs.Size = new System.Drawing.Size(1437, 123);
            this.gbClubs.TabIndex = 3;
            this.gbClubs.TabStop = false;
            this.gbClubs.Text = "SİNEK ♣️";
            // 
            // btnUploadClubs
            // 
            this.btnUploadClubs.ActiveBorderThickness = 3;
            this.btnUploadClubs.ActiveCornerRadius = 20;
            this.btnUploadClubs.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnUploadClubs.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnUploadClubs.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadClubs.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadClubs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadClubs.BackgroundImage")));
            this.btnUploadClubs.ButtonText = "Resim Ekle";
            this.btnUploadClubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTrain.SetDecoration(this.btnUploadClubs, BunifuAnimatorNS.DecorationType.None);
            this.btnUploadClubs.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadClubs.ForeColor = System.Drawing.Color.White;
            this.btnUploadClubs.IdleBorderThickness = 3;
            this.btnUploadClubs.IdleCornerRadius = 20;
            this.btnUploadClubs.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnUploadClubs.IdleForecolor = System.Drawing.Color.White;
            this.btnUploadClubs.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadClubs.Location = new System.Drawing.Point(1320, 25);
            this.btnUploadClubs.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadClubs.Name = "btnUploadClubs";
            this.btnUploadClubs.Size = new System.Drawing.Size(109, 86);
            this.btnUploadClubs.TabIndex = 4;
            this.btnUploadClubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadClubs.Click += new System.EventHandler(this.btnUploadClubs_Click);
            // 
            // cardClubs
            // 
            this.cardClubs.BackColor = System.Drawing.Color.Gainsboro;
            this.cardClubs.BorderRadius = 5;
            this.cardClubs.BottomSahddow = true;
            this.cardClubs.color = System.Drawing.Color.Black;
            this.transitionTrain.SetDecoration(this.cardClubs, BunifuAnimatorNS.DecorationType.None);
            this.cardClubs.LeftSahddow = false;
            this.cardClubs.Location = new System.Drawing.Point(6, 25);
            this.cardClubs.Name = "cardClubs";
            this.cardClubs.RightSahddow = true;
            this.cardClubs.ShadowDepth = 20;
            this.cardClubs.Size = new System.Drawing.Size(1306, 86);
            this.cardClubs.TabIndex = 0;
            // 
            // btnUploadSpades
            // 
            this.btnUploadSpades.ActiveBorderThickness = 3;
            this.btnUploadSpades.ActiveCornerRadius = 20;
            this.btnUploadSpades.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnUploadSpades.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnUploadSpades.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadSpades.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadSpades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadSpades.BackgroundImage")));
            this.btnUploadSpades.ButtonText = "Resim Ekle";
            this.btnUploadSpades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTrain.SetDecoration(this.btnUploadSpades, BunifuAnimatorNS.DecorationType.None);
            this.btnUploadSpades.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadSpades.ForeColor = System.Drawing.Color.White;
            this.btnUploadSpades.IdleBorderThickness = 3;
            this.btnUploadSpades.IdleCornerRadius = 20;
            this.btnUploadSpades.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnUploadSpades.IdleForecolor = System.Drawing.Color.White;
            this.btnUploadSpades.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUploadSpades.Location = new System.Drawing.Point(1320, 25);
            this.btnUploadSpades.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadSpades.Name = "btnUploadSpades";
            this.btnUploadSpades.Size = new System.Drawing.Size(111, 84);
            this.btnUploadSpades.TabIndex = 3;
            this.btnUploadSpades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadSpades.Click += new System.EventHandler(this.btnUploadSpades_Click);
            // 
            // cardSpades
            // 
            this.cardSpades.BackColor = System.Drawing.Color.Gainsboro;
            this.cardSpades.BorderRadius = 5;
            this.cardSpades.BottomSahddow = true;
            this.cardSpades.color = System.Drawing.Color.Black;
            this.transitionTrain.SetDecoration(this.cardSpades, BunifuAnimatorNS.DecorationType.None);
            this.cardSpades.LeftSahddow = false;
            this.cardSpades.Location = new System.Drawing.Point(6, 25);
            this.cardSpades.Name = "cardSpades";
            this.cardSpades.RightSahddow = true;
            this.cardSpades.ShadowDepth = 20;
            this.cardSpades.Size = new System.Drawing.Size(1306, 86);
            this.cardSpades.TabIndex = 0;
            // 
            // gbSpades
            // 
            this.gbSpades.Controls.Add(this.btnUploadSpades);
            this.gbSpades.Controls.Add(this.cardSpades);
            this.transitionTrain.SetDecoration(this.gbSpades, BunifuAnimatorNS.DecorationType.None);
            this.gbSpades.Font = new System.Drawing.Font("TR Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSpades.ForeColor = System.Drawing.Color.White;
            this.gbSpades.Location = new System.Drawing.Point(32, 418);
            this.gbSpades.Name = "gbSpades";
            this.gbSpades.Size = new System.Drawing.Size(1437, 117);
            this.gbSpades.TabIndex = 3;
            this.gbSpades.TabStop = false;
            this.gbSpades.Text = "MAÇA ♠️";
            // 
            // pnlTrain
            // 
            this.pnlTrain.BackColor = System.Drawing.Color.Transparent;
            this.pnlTrain.Controls.Add(this.btnTrain);
            this.pnlTrain.Controls.Add(this.lblDescription);
            this.pnlTrain.Controls.Add(this.gbHearts);
            this.pnlTrain.Controls.Add(this.gbClubs);
            this.pnlTrain.Controls.Add(this.gbSpades);
            this.pnlTrain.Controls.Add(this.gbDiamonds);
            this.transitionTrain.SetDecoration(this.pnlTrain, BunifuAnimatorNS.DecorationType.None);
            this.pnlTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrain.Location = new System.Drawing.Point(0, 0);
            this.pnlTrain.Name = "pnlTrain";
            this.pnlTrain.Size = new System.Drawing.Size(1500, 605);
            this.pnlTrain.TabIndex = 6;
            // 
            // btnTrain
            // 
            this.btnTrain.ActiveBorderThickness = 3;
            this.btnTrain.ActiveCornerRadius = 20;
            this.btnTrain.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnTrain.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnTrain.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrain.BackgroundImage")));
            this.btnTrain.ButtonText = "Eğitim Aşaması";
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTrain.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.IdleBorderThickness = 3;
            this.btnTrain.IdleCornerRadius = 20;
            this.btnTrain.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnTrain.IdleForecolor = System.Drawing.Color.White;
            this.btnTrain.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTrain.Location = new System.Drawing.Point(635, 543);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(230, 46);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // transitionTrain
            // 
            this.transitionTrain.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionTrain.Cursor = null;
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
            this.transitionTrain.DefaultAnimation = animation1;
            this.transitionTrain.MaxAnimationTime = 1250;
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlTrain);
            this.transitionTrain.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Train";
            this.Size = new System.Drawing.Size(1500, 605);
            this.Load += new System.EventHandler(this.Train_Load);
            this.gbHearts.ResumeLayout(false);
            this.gbDiamonds.ResumeLayout(false);
            this.gbClubs.ResumeLayout(false);
            this.gbSpades.ResumeLayout(false);
            this.pnlTrain.ResumeLayout(false);
            this.pnlTrain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private System.Windows.Forms.GroupBox gbHearts;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadHearts;
        private Bunifu.Framework.UI.BunifuCards cardHearts;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadDiamonds;
        private System.Windows.Forms.GroupBox gbDiamonds;
        private Bunifu.Framework.UI.BunifuCards cardDiamonds;
        private System.Windows.Forms.GroupBox gbClubs;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadClubs;
        private Bunifu.Framework.UI.BunifuCards cardClubs;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadSpades;
        private Bunifu.Framework.UI.BunifuCards cardSpades;
        private System.Windows.Forms.GroupBox gbSpades;
        private System.Windows.Forms.Panel pnlTrain;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrain;
        private BunifuAnimatorNS.BunifuTransition transitionTrain;
    }
}
