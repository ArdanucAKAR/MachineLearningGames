﻿namespace MachineLearningGames.Snap.Tabs
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnNewTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.lblResult = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlMake = new System.Windows.Forms.Panel();
            this.transitionResult = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.pnlTest.SuspendLayout();
            this.pnlMake.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.transitionResult.SetDecoration(this.lblDescription, BunifuAnimatorNS.DecorationType.None);
            this.lblDescription.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(94, 194);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(453, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Butona Basarak Resim Ekle ve Sonucu Görüntüle";
            // 
            // btnTest
            // 
            this.btnTest.ActiveBorderThickness = 3;
            this.btnTest.ActiveCornerRadius = 20;
            this.btnTest.ActiveFillColor = System.Drawing.Color.Gainsboro;
            this.btnTest.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnTest.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.ButtonText = "Resim Ekle";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionResult.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.IdleBorderThickness = 3;
            this.btnTest.IdleCornerRadius = 20;
            this.btnTest.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnTest.IdleForecolor = System.Drawing.Color.White;
            this.btnTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.Location = new System.Drawing.Point(265, 279);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(111, 84);
            this.btnTest.TabIndex = 4;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.btnNewTest);
            this.pnlResult.Controls.Add(this.pbResult);
            this.transitionResult.SetDecoration(this.pnlResult, BunifuAnimatorNS.DecorationType.None);
            this.pnlResult.Location = new System.Drawing.Point(103, 28);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(629, 548);
            this.pnlResult.TabIndex = 5;
            this.pnlResult.Visible = false;
            // 
            // btnNewTest
            // 
            this.btnNewTest.ActiveBorderThickness = 1;
            this.btnNewTest.ActiveCornerRadius = 20;
            this.btnNewTest.ActiveFillColor = System.Drawing.Color.White;
            this.btnNewTest.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTest.BackgroundImage")));
            this.btnNewTest.ButtonText = "Yeni Resim Test Et";
            this.btnNewTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionResult.SetDecoration(this.btnNewTest, BunifuAnimatorNS.DecorationType.None);
            this.btnNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.IdleBorderThickness = 3;
            this.btnNewTest.IdleCornerRadius = 20;
            this.btnNewTest.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.IdleForecolor = System.Drawing.Color.White;
            this.btnNewTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.Location = new System.Drawing.Point(160, 453);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(308, 72);
            this.btnNewTest.TabIndex = 11;
            this.btnNewTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Transparent;
            this.transitionResult.SetDecoration(this.pbResult, BunifuAnimatorNS.DecorationType.None);
            this.pbResult.Location = new System.Drawing.Point(42, 23);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(544, 378);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 10;
            this.pbResult.TabStop = false;
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.Transparent;
            this.pnlTest.Controls.Add(this.btnTest);
            this.pnlTest.Controls.Add(this.lblDescription);
            this.transitionResult.SetDecoration(this.pnlTest, BunifuAnimatorNS.DecorationType.None);
            this.pnlTest.Location = new System.Drawing.Point(759, 28);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(629, 548);
            this.pnlTest.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.transitionResult.SetDecoration(this.lblResult, BunifuAnimatorNS.DecorationType.None);
            this.lblResult.Font = new System.Drawing.Font("TR Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(281, 420);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 22);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Sonuç";
            // 
            // pnlMake
            // 
            this.pnlMake.Controls.Add(this.pnlResult);
            this.pnlMake.Controls.Add(this.pnlTest);
            this.transitionResult.SetDecoration(this.pnlMake, BunifuAnimatorNS.DecorationType.None);
            this.pnlMake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMake.Location = new System.Drawing.Point(0, 0);
            this.pnlMake.Name = "pnlMake";
            this.pnlMake.Size = new System.Drawing.Size(1500, 605);
            this.pnlMake.TabIndex = 11;
            // 
            // transitionResult
            // 
            this.transitionResult.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionResult.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.transitionResult.DefaultAnimation = animation2;
            // 
            // Make
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlMake);
            this.transitionResult.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Make";
            this.Size = new System.Drawing.Size(1500, 605);
            this.Load += new System.EventHandler(this.Make_Load);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            this.pnlMake.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTest;
        private System.Windows.Forms.Panel pnlResult;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewTest;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Panel pnlTest;
        private Bunifu.Framework.UI.BunifuCustomLabel lblResult;
        private System.Windows.Forms.Panel pnlMake;
        private BunifuAnimatorNS.BunifuTransition transitionResult;
    }
}
