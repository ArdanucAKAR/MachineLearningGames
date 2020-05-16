namespace MachineLearningGames.Titanic.Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.itemListSurvived = new System.Windows.Forms.ListBox();
            this.itemListNotSurvived = new System.Windows.Forms.ListBox();
            this.pnlNotSurvived = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblModeTraining = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNotSurvived = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSurvived = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drpState = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblState = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStartTrain = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblItemCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDataCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlSurvived = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNotSurvived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlList.SuspendLayout();
            this.pnlSurvived.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.BackgroundImage")));
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(764, 112);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(8);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(212, 35);
            this.txtTickerFare.TabIndex = 6;
            this.txtTickerFare.text = "0";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAge.BackgroundImage")));
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(153, 112);
            this.txtAge.Margin = new System.Windows.Forms.Padding(8);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(212, 35);
            this.txtAge.TabIndex = 3;
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
            this.drpEmbarked.Location = new System.Drawing.Point(1250, 34);
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = 0;
            this.drpEmbarked.Size = new System.Drawing.Size(212, 35);
            this.drpEmbarked.TabIndex = 7;
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
            this.drpGender.Location = new System.Drawing.Point(153, 71);
            this.drpGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = 0;
            this.drpGender.Size = new System.Drawing.Size(212, 35);
            this.drpGender.TabIndex = 2;
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
            this.drpTicketClass.Location = new System.Drawing.Point(153, 29);
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = 0;
            this.drpTicketClass.Size = new System.Drawing.Size(212, 35);
            this.drpTicketClass.TabIndex = 1;
            // 
            // lblEmbarked
            // 
            this.lblEmbarked.AutoSize = true;
            this.lblEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmbarked.Location = new System.Drawing.Point(1103, 41);
            this.lblEmbarked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmbarked.Name = "lblEmbarked";
            this.lblEmbarked.Size = new System.Drawing.Size(151, 24);
            this.lblEmbarked.TabIndex = 13;
            this.lblEmbarked.Text = "Gideceğiniz yer :";
            // 
            // lblTicketFare
            // 
            this.lblTicketFare.AutoSize = true;
            this.lblTicketFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFare.Location = new System.Drawing.Point(651, 112);
            this.lblTicketFare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketFare.Name = "lblTicketFare";
            this.lblTicketFare.Size = new System.Drawing.Size(106, 24);
            this.lblTicketFare.TabIndex = 11;
            this.lblTicketFare.Text = "Bilet ücreti :";
            // 
            // lblParentOrChildren
            // 
            this.lblParentOrChildren.AutoSize = true;
            this.lblParentOrChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParentOrChildren.Location = new System.Drawing.Point(518, 71);
            this.lblParentOrChildren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParentOrChildren.Name = "lblParentOrChildren";
            this.lblParentOrChildren.Size = new System.Drawing.Size(251, 24);
            this.lblParentOrChildren.TabIndex = 9;
            this.lblParentOrChildren.Text = "Ebeveyn ya da çocuk sayısı :";
            // 
            // txtParentOrChildren
            // 
            this.txtParentOrChildren.BackColor = System.Drawing.Color.Silver;
            this.txtParentOrChildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.BackgroundImage")));
            this.txtParentOrChildren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtParentOrChildren.ForeColor = System.Drawing.Color.Black;
            this.txtParentOrChildren.Icon = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.Icon")));
            this.txtParentOrChildren.Location = new System.Drawing.Point(764, 69);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(8);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(212, 35);
            this.txtParentOrChildren.TabIndex = 5;
            this.txtParentOrChildren.text = "0";
            // 
            // lblSiblingsOrSpouse
            // 
            this.lblSiblingsOrSpouse.AutoSize = true;
            this.lblSiblingsOrSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiblingsOrSpouse.Location = new System.Drawing.Point(562, 29);
            this.lblSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiblingsOrSpouse.Name = "lblSiblingsOrSpouse";
            this.lblSiblingsOrSpouse.Size = new System.Drawing.Size(199, 24);
            this.lblSiblingsOrSpouse.TabIndex = 7;
            this.lblSiblingsOrSpouse.Text = "Kardeş ya da eş sayısı:";
            // 
            // txtSiblingsOrSpouse
            // 
            this.txtSiblingsOrSpouse.BackColor = System.Drawing.Color.Silver;
            this.txtSiblingsOrSpouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.BackgroundImage")));
            this.txtSiblingsOrSpouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSiblingsOrSpouse.ForeColor = System.Drawing.Color.Black;
            this.txtSiblingsOrSpouse.Icon = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.Icon")));
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(764, 28);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(8);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(212, 35);
            this.txtSiblingsOrSpouse.TabIndex = 4;
            this.txtSiblingsOrSpouse.text = "0";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(98, 112);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(51, 24);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Yaş :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(65, 71);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 24);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Cinsiyet :";
            // 
            // lblTicketClass
            // 
            this.lblTicketClass.AutoSize = true;
            this.lblTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketClass.Location = new System.Drawing.Point(49, 29);
            this.lblTicketClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketClass.Name = "lblTicketClass";
            this.lblTicketClass.Size = new System.Drawing.Size(99, 24);
            this.lblTicketClass.TabIndex = 1;
            this.lblTicketClass.Text = "Bilet Sınıfı :";
            // 
            // itemListSurvived
            // 
            this.itemListSurvived.BackColor = System.Drawing.Color.Black;
            this.itemListSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListSurvived.ForeColor = System.Drawing.Color.White;
            this.itemListSurvived.FormattingEnabled = true;
            this.itemListSurvived.ItemHeight = 15;
            this.itemListSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListSurvived.Margin = new System.Windows.Forms.Padding(2);
            this.itemListSurvived.Name = "itemListSurvived";
            this.itemListSurvived.Size = new System.Drawing.Size(750, 302);
            this.itemListSurvived.TabIndex = 0;
            // 
            // itemListNotSurvived
            // 
            this.itemListNotSurvived.BackColor = System.Drawing.Color.Black;
            this.itemListNotSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListNotSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListNotSurvived.ForeColor = System.Drawing.Color.White;
            this.itemListNotSurvived.FormattingEnabled = true;
            this.itemListNotSurvived.ItemHeight = 15;
            this.itemListNotSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListNotSurvived.Margin = new System.Windows.Forms.Padding(2);
            this.itemListNotSurvived.Name = "itemListNotSurvived";
            this.itemListNotSurvived.Size = new System.Drawing.Size(750, 302);
            this.itemListNotSurvived.TabIndex = 1;
            // 
            // pnlNotSurvived
            // 
            this.pnlNotSurvived.Controls.Add(this.itemListNotSurvived);
            this.pnlNotSurvived.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotSurvived.Location = new System.Drawing.Point(750, 0);
            this.pnlNotSurvived.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNotSurvived.Name = "pnlNotSurvived";
            this.pnlNotSurvived.Size = new System.Drawing.Size(750, 302);
            this.pnlNotSurvived.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(582, 198);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblModeTraining
            // 
            this.lblModeTraining.AutoSize = true;
            this.lblModeTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModeTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblModeTraining.Location = new System.Drawing.Point(688, 334);
            this.lblModeTraining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTraining.Name = "lblModeTraining";
            this.lblModeTraining.Size = new System.Drawing.Size(126, 20);
            this.lblModeTraining.TabIndex = 33;
            this.lblModeTraining.Text = "Model Eğitiliyor...";
            this.lblModeTraining.Visible = false;
            // 
            // lblNotSurvived
            // 
            this.lblNotSurvived.AutoSize = true;
            this.lblNotSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotSurvived.ForeColor = System.Drawing.Color.Red;
            this.lblNotSurvived.Location = new System.Drawing.Point(1063, 275);
            this.lblNotSurvived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotSurvived.Name = "lblNotSurvived";
            this.lblNotSurvived.Size = new System.Drawing.Size(227, 26);
            this.lblNotSurvived.TabIndex = 30;
            this.lblNotSurvived.Text = "Hayatta Kalamayanlar";
            // 
            // lblSurvived
            // 
            this.lblSurvived.AutoSize = true;
            this.lblSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurvived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSurvived.Location = new System.Drawing.Point(275, 275);
            this.lblSurvived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurvived.Name = "lblSurvived";
            this.lblSurvived.Size = new System.Drawing.Size(173, 26);
            this.lblSurvived.TabIndex = 29;
            this.lblSurvived.Text = "Hayatta Kalanlar";
            // 
            // drpState
            // 
            this.drpState.BackColor = System.Drawing.Color.Transparent;
            this.drpState.BorderRadius = 3;
            this.drpState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpState.DisabledColor = System.Drawing.Color.Gray;
            this.drpState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpState.ForeColor = System.Drawing.Color.Black;
            this.drpState.Items = new string[] {
        "Hayatta kaldı",
        "Hayatta kalamadı"};
            this.drpState.Location = new System.Drawing.Point(1250, 76);
            this.drpState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpState.Name = "drpState";
            this.drpState.NomalColor = System.Drawing.Color.Silver;
            this.drpState.onHoverColor = System.Drawing.Color.White;
            this.drpState.selectedIndex = 0;
            this.drpState.Size = new System.Drawing.Size(212, 35);
            this.drpState.TabIndex = 25;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(1162, 82);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(88, 24);
            this.lblState.TabIndex = 26;
            this.lblState.Text = "Durumu :";
            // 
            // btnStartTrain
            // 
            this.btnStartTrain.ActiveBorderThickness = 1;
            this.btnStartTrain.ActiveCornerRadius = 20;
            this.btnStartTrain.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStartTrain.ActiveForecolor = System.Drawing.Color.White;
            this.btnStartTrain.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStartTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnStartTrain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartTrain.BackgroundImage")));
            this.btnStartTrain.ButtonText = "EĞİTİMİ BAŞLAT";
            this.btnStartTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTrain.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStartTrain.IdleBorderThickness = 1;
            this.btnStartTrain.IdleCornerRadius = 20;
            this.btnStartTrain.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnStartTrain.IdleForecolor = System.Drawing.Color.Orange;
            this.btnStartTrain.IdleLineColor = System.Drawing.Color.Orange;
            this.btnStartTrain.Location = new System.Drawing.Point(1190, 198);
            this.btnStartTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(239, 54);
            this.btnStartTrain.TabIndex = 9;
            this.btnStartTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemCount.Location = new System.Drawing.Point(135, 227);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(24, 26);
            this.lblItemCount.TabIndex = 24;
            this.lblItemCount.Text = "0";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDataCount.Location = new System.Drawing.Point(20, 227);
            this.lblDataCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(124, 26);
            this.lblDataCount.TabIndex = 23;
            this.lblDataCount.Text = "Veri sayısı :";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "EKLE";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Orange;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Orange;
            this.btnAdd.Location = new System.Drawing.Point(1190, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(239, 54);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.pnlNotSurvived);
            this.pnlList.Controls.Add(this.pnlSurvived);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(0, 303);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1500, 302);
            this.pnlList.TabIndex = 21;
            // 
            // pnlSurvived
            // 
            this.pnlSurvived.Controls.Add(this.itemListSurvived);
            this.pnlSurvived.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSurvived.Location = new System.Drawing.Point(0, 0);
            this.pnlSurvived.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSurvived.Name = "pnlSurvived";
            this.pnlSurvived.Size = new System.Drawing.Size(750, 302);
            this.pnlSurvived.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.lblModeTraining);
            this.pnlMain.Controls.Add(this.lblNotSurvived);
            this.pnlMain.Controls.Add(this.lblSurvived);
            this.pnlMain.Controls.Add(this.drpState);
            this.pnlMain.Controls.Add(this.lblState);
            this.pnlMain.Controls.Add(this.btnStartTrain);
            this.pnlMain.Controls.Add(this.lblItemCount);
            this.pnlMain.Controls.Add(this.lblDataCount);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.pnlList);
            this.pnlMain.Controls.Add(this.txtTickerFare);
            this.pnlMain.Controls.Add(this.txtAge);
            this.pnlMain.Controls.Add(this.drpEmbarked);
            this.pnlMain.Controls.Add(this.drpGender);
            this.pnlMain.Controls.Add(this.drpTicketClass);
            this.pnlMain.Controls.Add(this.lblEmbarked);
            this.pnlMain.Controls.Add(this.lblTicketFare);
            this.pnlMain.Controls.Add(this.lblParentOrChildren);
            this.pnlMain.Controls.Add(this.txtParentOrChildren);
            this.pnlMain.Controls.Add(this.lblSiblingsOrSpouse);
            this.pnlMain.Controls.Add(this.txtSiblingsOrSpouse);
            this.pnlMain.Controls.Add(this.lblAge);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblTicketClass);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Coral;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1500, 605);
            this.pnlMain.TabIndex = 1;
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlMain);
            this.Name = "Train";
            this.Size = new System.Drawing.Size(1500, 605);
            this.pnlNotSurvived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlSurvived.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.ListBox itemListSurvived;
        private System.Windows.Forms.ListBox itemListNotSurvived;
        private System.Windows.Forms.Panel pnlNotSurvived;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModeTraining;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNotSurvived;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSurvived;
        private Bunifu.Framework.UI.BunifuDropdown drpState;
        private Bunifu.Framework.UI.BunifuCustomLabel lblState;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartTrain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblItemCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDataCount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlSurvived;
        private System.Windows.Forms.Panel pnlMain;
    }
}
