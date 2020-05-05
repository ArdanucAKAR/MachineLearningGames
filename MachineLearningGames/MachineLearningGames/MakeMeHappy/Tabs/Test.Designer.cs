namespace MachineLearningGames.MakeMeHappy.Tabs
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.lblWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnNewTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.btnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.transitionResult = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.pnlTest.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.transitionResult.SetDecoration(this.lblWord, BunifuAnimatorNS.DecorationType.None);
            this.lblWord.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(219, 150);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(193, 20);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "Lütfen Cümleniniz Giriniz";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.Gainsboro;
            this.transitionResult.SetDecoration(this.txtWord, BunifuAnimatorNS.DecorationType.None);
            this.txtWord.Font = new System.Drawing.Font("TR Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(161, 185);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(308, 161);
            this.txtWord.TabIndex = 4;
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Transparent;
            this.transitionResult.SetDecoration(this.pbResult, BunifuAnimatorNS.DecorationType.None);
            this.pbResult.Location = new System.Drawing.Point(38, 25);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(544, 422);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 7;
            this.pbResult.TabStop = false;
            // 
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.Transparent;
            this.pnlResult.Controls.Add(this.btnNewTest);
            this.pnlResult.Controls.Add(this.pbResult);
            this.transitionResult.SetDecoration(this.pnlResult, BunifuAnimatorNS.DecorationType.None);
            this.pnlResult.Location = new System.Drawing.Point(103, 28);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(629, 548);
            this.pnlResult.TabIndex = 8;
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
            this.btnNewTest.ButtonText = "Cümleyi Ekle";
            this.btnNewTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionResult.SetDecoration(this.btnNewTest, BunifuAnimatorNS.DecorationType.None);
            this.btnNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.IdleBorderThickness = 3;
            this.btnNewTest.IdleCornerRadius = 20;
            this.btnNewTest.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.IdleForecolor = System.Drawing.Color.White;
            this.btnNewTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNewTest.Location = new System.Drawing.Point(165, 455);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(308, 72);
            this.btnNewTest.TabIndex = 9;
            this.btnNewTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.Transparent;
            this.pnlTest.Controls.Add(this.btnTest);
            this.pnlTest.Controls.Add(this.lblWord);
            this.pnlTest.Controls.Add(this.txtWord);
            this.transitionResult.SetDecoration(this.pnlTest, BunifuAnimatorNS.DecorationType.None);
            this.pnlTest.Location = new System.Drawing.Point(759, 28);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(629, 548);
            this.pnlTest.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.ActiveBorderThickness = 1;
            this.btnTest.ActiveCornerRadius = 20;
            this.btnTest.ActiveFillColor = System.Drawing.Color.White;
            this.btnTest.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnTest.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.ButtonText = "Cümleyi Ekle";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionResult.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTest.IdleBorderThickness = 3;
            this.btnTest.IdleCornerRadius = 20;
            this.btnTest.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnTest.IdleForecolor = System.Drawing.Color.White;
            this.btnTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.Location = new System.Drawing.Point(161, 354);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(308, 41);
            this.btnTest.TabIndex = 6;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlResult);
            this.pnlMain.Controls.Add(this.pnlTest);
            this.transitionResult.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.TabIndex = 10;
            // 
            // transitionResult
            // 
            this.transitionResult.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionResult.Cursor = null;
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
            this.transitionResult.DefaultAnimation = animation1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlMain);
            this.transitionResult.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Test";
            this.Size = new System.Drawing.Size(1500, 605);
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlTest.ResumeLayout(false);
            this.pnlTest.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Panel pnlTest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNewTest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTest;
        private System.Windows.Forms.Panel pnlMain;
        private BunifuAnimatorNS.BunifuTransition transitionResult;
    }
}
