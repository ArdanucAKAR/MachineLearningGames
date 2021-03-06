﻿namespace MachineLearningGames.Titanic.Tabs
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTickerFare = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuTextbox();
            this.drpEmbarked = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpGender = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpTicketClass = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblEmbarked = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketFare = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblParentOrChildren = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtParentOrChildren = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblSiblingsOrSpouse = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSiblingsOrSpouse = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblAge = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketClass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.pnlUp);
            this.bunifuTransition1.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblResult, BunifuAnimatorNS.DecorationType.None);
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(554, 461);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 55);
            this.lblResult.TabIndex = 1;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlUp.Controls.Add(this.btnTest);
            this.pnlUp.Controls.Add(this.txtTickerFare);
            this.pnlUp.Controls.Add(this.txtAge);
            this.pnlUp.Controls.Add(this.drpEmbarked);
            this.pnlUp.Controls.Add(this.drpGender);
            this.pnlUp.Controls.Add(this.drpTicketClass);
            this.pnlUp.Controls.Add(this.lblEmbarked);
            this.pnlUp.Controls.Add(this.lblTicketFare);
            this.pnlUp.Controls.Add(this.lblParentOrChildren);
            this.pnlUp.Controls.Add(this.txtParentOrChildren);
            this.pnlUp.Controls.Add(this.lblSiblingsOrSpouse);
            this.pnlUp.Controls.Add(this.txtSiblingsOrSpouse);
            this.pnlUp.Controls.Add(this.lblAge);
            this.pnlUp.Controls.Add(this.lblGender);
            this.pnlUp.Controls.Add(this.lblTicketClass);
            this.bunifuTransition1.SetDecoration(this.pnlUp, BunifuAnimatorNS.DecorationType.None);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1500, 365);
            this.pnlUp.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.ActiveBorderThickness = 1;
            this.btnTest.ActiveCornerRadius = 20;
            this.btnTest.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTest.ActiveForecolor = System.Drawing.Color.White;
            this.btnTest.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.ButtonText = "TEST ET";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTest.IdleBorderThickness = 1;
            this.btnTest.IdleCornerRadius = 20;
            this.btnTest.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTest.IdleForecolor = System.Drawing.Color.Black;
            this.btnTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.Location = new System.Drawing.Point(1217, 192);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(225, 50);
            this.btnTest.TabIndex = 41;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.BackgroundImage")));
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtTickerFare, BunifuAnimatorNS.DecorationType.None);
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(760, 207);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(8);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(212, 35);
            this.txtTickerFare.TabIndex = 35;
            this.txtTickerFare.text = "0";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAge.BackgroundImage")));
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtAge, BunifuAnimatorNS.DecorationType.None);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(148, 207);
            this.txtAge.Margin = new System.Windows.Forms.Padding(8);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(212, 35);
            this.txtAge.TabIndex = 30;
            this.txtAge.text = "0";
            // 
            // drpEmbarked
            // 
            this.drpEmbarked.BackColor = System.Drawing.Color.Transparent;
            this.drpEmbarked.BorderRadius = 3;
            this.drpEmbarked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.drpEmbarked, BunifuAnimatorNS.DecorationType.None);
            this.drpEmbarked.DisabledColor = System.Drawing.Color.Gray;
            this.drpEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpEmbarked.ForeColor = System.Drawing.Color.Black;
            this.drpEmbarked.Items = new string[] {
        "Cherbourg (France)",
        "Southampton (England)",
        "Queenstown (Ireland)"};
            this.drpEmbarked.Location = new System.Drawing.Point(1245, 129);
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = 0;
            this.drpEmbarked.Size = new System.Drawing.Size(212, 35);
            this.drpEmbarked.TabIndex = 36;
            // 
            // drpGender
            // 
            this.drpGender.BackColor = System.Drawing.Color.Transparent;
            this.drpGender.BorderRadius = 3;
            this.drpGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.drpGender, BunifuAnimatorNS.DecorationType.None);
            this.drpGender.DisabledColor = System.Drawing.Color.Gray;
            this.drpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpGender.ForeColor = System.Drawing.Color.Black;
            this.drpGender.Items = new string[] {
        "Erkek",
        "Kadın"};
            this.drpGender.Location = new System.Drawing.Point(148, 166);
            this.drpGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = 0;
            this.drpGender.Size = new System.Drawing.Size(212, 35);
            this.drpGender.TabIndex = 29;
            // 
            // drpTicketClass
            // 
            this.drpTicketClass.BackColor = System.Drawing.Color.Transparent;
            this.drpTicketClass.BorderRadius = 3;
            this.drpTicketClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.drpTicketClass, BunifuAnimatorNS.DecorationType.None);
            this.drpTicketClass.DisabledColor = System.Drawing.Color.Gray;
            this.drpTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpTicketClass.ForeColor = System.Drawing.Color.Black;
            this.drpTicketClass.Items = new string[] {
        "1",
        "2",
        "3"};
            this.drpTicketClass.Location = new System.Drawing.Point(148, 124);
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = 0;
            this.drpTicketClass.Size = new System.Drawing.Size(212, 35);
            this.drpTicketClass.TabIndex = 27;
            // 
            // lblEmbarked
            // 
            this.lblEmbarked.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblEmbarked, BunifuAnimatorNS.DecorationType.None);
            this.lblEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmbarked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmbarked.Location = new System.Drawing.Point(1099, 136);
            this.lblEmbarked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmbarked.Name = "lblEmbarked";
            this.lblEmbarked.Size = new System.Drawing.Size(151, 24);
            this.lblEmbarked.TabIndex = 40;
            this.lblEmbarked.Text = "Gideceğiniz yer :";
            // 
            // lblTicketFare
            // 
            this.lblTicketFare.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTicketFare, BunifuAnimatorNS.DecorationType.None);
            this.lblTicketFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTicketFare.Location = new System.Drawing.Point(646, 207);
            this.lblTicketFare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketFare.Name = "lblTicketFare";
            this.lblTicketFare.Size = new System.Drawing.Size(106, 24);
            this.lblTicketFare.TabIndex = 39;
            this.lblTicketFare.Text = "Bilet ücreti :";
            // 
            // lblParentOrChildren
            // 
            this.lblParentOrChildren.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblParentOrChildren, BunifuAnimatorNS.DecorationType.None);
            this.lblParentOrChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParentOrChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblParentOrChildren.Location = new System.Drawing.Point(513, 166);
            this.lblParentOrChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParentOrChildren.Name = "lblParentOrChildren";
            this.lblParentOrChildren.Size = new System.Drawing.Size(251, 24);
            this.lblParentOrChildren.TabIndex = 38;
            this.lblParentOrChildren.Text = "Ebeveyn ya da çocuk sayısı :";
            // 
            // txtParentOrChildren
            // 
            this.txtParentOrChildren.BackColor = System.Drawing.Color.Silver;
            this.txtParentOrChildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.BackgroundImage")));
            this.txtParentOrChildren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtParentOrChildren, BunifuAnimatorNS.DecorationType.None);
            this.txtParentOrChildren.ForeColor = System.Drawing.Color.Black;
            this.txtParentOrChildren.Icon = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.Icon")));
            this.txtParentOrChildren.Location = new System.Drawing.Point(760, 164);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(8);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(212, 35);
            this.txtParentOrChildren.TabIndex = 33;
            this.txtParentOrChildren.text = "0";
            // 
            // lblSiblingsOrSpouse
            // 
            this.lblSiblingsOrSpouse.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSiblingsOrSpouse, BunifuAnimatorNS.DecorationType.None);
            this.lblSiblingsOrSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiblingsOrSpouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSiblingsOrSpouse.Location = new System.Drawing.Point(557, 124);
            this.lblSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiblingsOrSpouse.Name = "lblSiblingsOrSpouse";
            this.lblSiblingsOrSpouse.Size = new System.Drawing.Size(199, 24);
            this.lblSiblingsOrSpouse.TabIndex = 37;
            this.lblSiblingsOrSpouse.Text = "Kardeş ya da eş sayısı:";
            // 
            // txtSiblingsOrSpouse
            // 
            this.txtSiblingsOrSpouse.BackColor = System.Drawing.Color.Silver;
            this.txtSiblingsOrSpouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.BackgroundImage")));
            this.txtSiblingsOrSpouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtSiblingsOrSpouse, BunifuAnimatorNS.DecorationType.None);
            this.txtSiblingsOrSpouse.ForeColor = System.Drawing.Color.Black;
            this.txtSiblingsOrSpouse.Icon = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.Icon")));
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(760, 123);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(8);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(212, 35);
            this.txtSiblingsOrSpouse.TabIndex = 32;
            this.txtSiblingsOrSpouse.text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAge, BunifuAnimatorNS.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAge.Location = new System.Drawing.Point(94, 207);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(51, 24);
            this.lblAge.TabIndex = 34;
            this.lblAge.Text = "Yaş :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblGender, BunifuAnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(61, 166);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 24);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "Cinsiyet :";
            // 
            // lblTicketClass
            // 
            this.lblTicketClass.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTicketClass, BunifuAnimatorNS.DecorationType.None);
            this.lblTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTicketClass.Location = new System.Drawing.Point(44, 124);
            this.lblTicketClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketClass.Name = "lblTicketClass";
            this.lblTicketClass.Size = new System.Drawing.Size(99, 24);
            this.lblTicketClass.TabIndex = 28;
            this.lblTicketClass.Text = "Bilet Sınıfı :";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Test";
            this.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTest;
        private Bunifu.Framework.UI.BunifuTextbox txtTickerFare;
        private Bunifu.Framework.UI.BunifuTextbox txtAge;
        private Bunifu.Framework.UI.BunifuDropdown drpEmbarked;
        private Bunifu.Framework.UI.BunifuDropdown drpGender;
        private Bunifu.Framework.UI.BunifuDropdown drpTicketClass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmbarked;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketFare;
        private Bunifu.Framework.UI.BunifuCustomLabel lblParentOrChildren;
        private Bunifu.Framework.UI.BunifuTextbox txtParentOrChildren;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuTextbox txtSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAge;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGender;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketClass;
        private System.Windows.Forms.Label lblResult;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
