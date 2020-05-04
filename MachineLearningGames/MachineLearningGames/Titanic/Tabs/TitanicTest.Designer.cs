namespace MachineLearningGames.Alihan.Tabs
{
    partial class TitanicTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitanicTest));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
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
            this.btnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.pnlUp);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2000, 745);
            this.pnlMain.TabIndex = 0;
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
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(2000, 449);
            this.pnlUp.TabIndex = 0;
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.BackgroundImage")));
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(1013, 255);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(10);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(282, 43);
            this.txtTickerFare.TabIndex = 35;
            this.txtTickerFare.text = "0";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAge.BackgroundImage")));
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(198, 255);
            this.txtAge.Margin = new System.Windows.Forms.Padding(10);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 43);
            this.txtAge.TabIndex = 30;
            this.txtAge.text = "0";
            // 
            // drpEmbarked
            // 
            this.drpEmbarked.BackColor = System.Drawing.Color.Transparent;
            this.drpEmbarked.BorderRadius = 3;
            this.drpEmbarked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpEmbarked.DisabledColor = System.Drawing.Color.Gray;
            this.drpEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpEmbarked.ForeColor = System.Drawing.Color.Black;
            this.drpEmbarked.Items = new string[] {
        "Cherbourg (France)",
        "Southampton (England)",
        "Queenstown (Ireland)"};
            this.drpEmbarked.Location = new System.Drawing.Point(1660, 159);
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = 0;
            this.drpEmbarked.Size = new System.Drawing.Size(282, 43);
            this.drpEmbarked.TabIndex = 36;
            // 
            // drpGender
            // 
            this.drpGender.BackColor = System.Drawing.Color.Transparent;
            this.drpGender.BorderRadius = 3;
            this.drpGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpGender.DisabledColor = System.Drawing.Color.Gray;
            this.drpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpGender.ForeColor = System.Drawing.Color.Black;
            this.drpGender.Items = new string[] {
        "Erkek",
        "Kadın"};
            this.drpGender.Location = new System.Drawing.Point(198, 204);
            this.drpGender.Margin = new System.Windows.Forms.Padding(4);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = 0;
            this.drpGender.Size = new System.Drawing.Size(282, 43);
            this.drpGender.TabIndex = 29;
            // 
            // drpTicketClass
            // 
            this.drpTicketClass.BackColor = System.Drawing.Color.Transparent;
            this.drpTicketClass.BorderRadius = 3;
            this.drpTicketClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpTicketClass.DisabledColor = System.Drawing.Color.Gray;
            this.drpTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpTicketClass.ForeColor = System.Drawing.Color.Black;
            this.drpTicketClass.Items = new string[] {
        "1",
        "2",
        "3"};
            this.drpTicketClass.Location = new System.Drawing.Point(198, 153);
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = 0;
            this.drpTicketClass.Size = new System.Drawing.Size(282, 43);
            this.drpTicketClass.TabIndex = 27;
            // 
            // lblEmbarked
            // 
            this.lblEmbarked.AutoSize = true;
            this.lblEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmbarked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmbarked.Location = new System.Drawing.Point(1465, 167);
            this.lblEmbarked.Name = "lblEmbarked";
            this.lblEmbarked.Size = new System.Drawing.Size(192, 29);
            this.lblEmbarked.TabIndex = 40;
            this.lblEmbarked.Text = "Gideceğiniz yer :";
            // 
            // lblTicketFare
            // 
            this.lblTicketFare.AutoSize = true;
            this.lblTicketFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTicketFare.Location = new System.Drawing.Point(862, 255);
            this.lblTicketFare.Name = "lblTicketFare";
            this.lblTicketFare.Size = new System.Drawing.Size(138, 29);
            this.lblTicketFare.TabIndex = 39;
            this.lblTicketFare.Text = "Bilet ücreti :";
            // 
            // lblParentOrChildren
            // 
            this.lblParentOrChildren.AutoSize = true;
            this.lblParentOrChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParentOrChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblParentOrChildren.Location = new System.Drawing.Point(684, 204);
            this.lblParentOrChildren.Name = "lblParentOrChildren";
            this.lblParentOrChildren.Size = new System.Drawing.Size(316, 29);
            this.lblParentOrChildren.TabIndex = 38;
            this.lblParentOrChildren.Text = "Ebeveyn ya da çocuk sayısı :";
            // 
            // txtParentOrChildren
            // 
            this.txtParentOrChildren.BackColor = System.Drawing.Color.Silver;
            this.txtParentOrChildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.BackgroundImage")));
            this.txtParentOrChildren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtParentOrChildren.ForeColor = System.Drawing.Color.Black;
            this.txtParentOrChildren.Icon = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.Icon")));
            this.txtParentOrChildren.Location = new System.Drawing.Point(1013, 202);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(10);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(282, 43);
            this.txtParentOrChildren.TabIndex = 33;
            this.txtParentOrChildren.text = "0";
            // 
            // lblSiblingsOrSpouse
            // 
            this.lblSiblingsOrSpouse.AutoSize = true;
            this.lblSiblingsOrSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiblingsOrSpouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSiblingsOrSpouse.Location = new System.Drawing.Point(743, 153);
            this.lblSiblingsOrSpouse.Name = "lblSiblingsOrSpouse";
            this.lblSiblingsOrSpouse.Size = new System.Drawing.Size(257, 29);
            this.lblSiblingsOrSpouse.TabIndex = 37;
            this.lblSiblingsOrSpouse.Text = "Kardeş ya da eş sayısı:";
            // 
            // txtSiblingsOrSpouse
            // 
            this.txtSiblingsOrSpouse.BackColor = System.Drawing.Color.Silver;
            this.txtSiblingsOrSpouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.BackgroundImage")));
            this.txtSiblingsOrSpouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSiblingsOrSpouse.ForeColor = System.Drawing.Color.Black;
            this.txtSiblingsOrSpouse.Icon = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.Icon")));
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(1013, 151);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(10);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(282, 43);
            this.txtSiblingsOrSpouse.TabIndex = 32;
            this.txtSiblingsOrSpouse.text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAge.Location = new System.Drawing.Point(125, 255);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 29);
            this.lblAge.TabIndex = 34;
            this.lblAge.Text = "Yaş :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(81, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 29);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "Cinsiyet :";
            // 
            // lblTicketClass
            // 
            this.lblTicketClass.AutoSize = true;
            this.lblTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTicketClass.Location = new System.Drawing.Point(59, 153);
            this.lblTicketClass.Name = "lblTicketClass";
            this.lblTicketClass.Size = new System.Drawing.Size(132, 29);
            this.lblTicketClass.TabIndex = 28;
            this.lblTicketClass.Text = "Bilet Sınıfı :";
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
            this.btnTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTest.IdleBorderThickness = 1;
            this.btnTest.IdleCornerRadius = 20;
            this.btnTest.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTest.IdleForecolor = System.Drawing.Color.Black;
            this.btnTest.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTest.Location = new System.Drawing.Point(1623, 236);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(300, 62);
            this.btnTest.TabIndex = 41;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(738, 567);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 69);
            this.lblResult.TabIndex = 1;
            // 
            // TitanicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "TitanicTest";
            this.Size = new System.Drawing.Size(2000, 745);
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
    }
}
