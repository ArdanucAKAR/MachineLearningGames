namespace MachineLearningGames.Alihan.Tabs
{
    partial class TitanicTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitanicTrain));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.pnlMain = new System.Windows.Forms.Panel();
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
            this.pnlNotSurvived = new System.Windows.Forms.Panel();
            this.itemListNotSurvived = new System.Windows.Forms.ListBox();
            this.pnlSurvived = new System.Windows.Forms.Panel();
            this.itemListSurvived = new System.Windows.Forms.ListBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlList.SuspendLayout();
            this.pnlNotSurvived.SuspendLayout();
            this.pnlSurvived.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
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
            this.bunifuTransition1.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Coral;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2000, 745);
            this.pnlMain.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(776, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblModeTraining
            // 
            this.lblModeTraining.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblModeTraining, BunifuAnimatorNS.DecorationType.None);
            this.lblModeTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModeTraining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblModeTraining.Location = new System.Drawing.Point(917, 411);
            this.lblModeTraining.Name = "lblModeTraining";
            this.lblModeTraining.Size = new System.Drawing.Size(158, 25);
            this.lblModeTraining.TabIndex = 33;
            this.lblModeTraining.Text = "Model Eğitiliyor...";
            this.lblModeTraining.Visible = false;
            // 
            // lblNotSurvived
            // 
            this.lblNotSurvived.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblNotSurvived, BunifuAnimatorNS.DecorationType.None);
            this.lblNotSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotSurvived.ForeColor = System.Drawing.Color.Red;
            this.lblNotSurvived.Location = new System.Drawing.Point(1417, 338);
            this.lblNotSurvived.Name = "lblNotSurvived";
            this.lblNotSurvived.Size = new System.Drawing.Size(295, 32);
            this.lblNotSurvived.TabIndex = 30;
            this.lblNotSurvived.Text = "Hayatta Kalamayanlar";
            // 
            // lblSurvived
            // 
            this.lblSurvived.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSurvived, BunifuAnimatorNS.DecorationType.None);
            this.lblSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurvived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSurvived.Location = new System.Drawing.Point(367, 338);
            this.lblSurvived.Name = "lblSurvived";
            this.lblSurvived.Size = new System.Drawing.Size(226, 32);
            this.lblSurvived.TabIndex = 29;
            this.lblSurvived.Text = "Hayatta Kalanlar";
            // 
            // drpState
            // 
            this.drpState.BackColor = System.Drawing.Color.Transparent;
            this.drpState.BorderRadius = 3;
            this.drpState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.drpState, BunifuAnimatorNS.DecorationType.None);
            this.drpState.DisabledColor = System.Drawing.Color.Gray;
            this.drpState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpState.ForeColor = System.Drawing.Color.Black;
            this.drpState.Items = new string[] {
        "Hayatta kaldı",
        "Hayatta kalamadı"};
            this.drpState.Location = new System.Drawing.Point(1666, 93);
            this.drpState.Margin = new System.Windows.Forms.Padding(4);
            this.drpState.Name = "drpState";
            this.drpState.NomalColor = System.Drawing.Color.Silver;
            this.drpState.onHoverColor = System.Drawing.Color.White;
            this.drpState.selectedIndex = 0;
            this.drpState.Size = new System.Drawing.Size(282, 43);
            this.drpState.TabIndex = 25;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblState, BunifuAnimatorNS.DecorationType.None);
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(1550, 101);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 29);
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
            this.bunifuTransition1.SetDecoration(this.btnStartTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnStartTrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTrain.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStartTrain.IdleBorderThickness = 1;
            this.btnStartTrain.IdleCornerRadius = 20;
            this.btnStartTrain.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnStartTrain.IdleForecolor = System.Drawing.Color.Orange;
            this.btnStartTrain.IdleLineColor = System.Drawing.Color.Orange;
            this.btnStartTrain.Location = new System.Drawing.Point(1586, 244);
            this.btnStartTrain.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(319, 67);
            this.btnStartTrain.TabIndex = 9;
            this.btnStartTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblItemCount, BunifuAnimatorNS.DecorationType.None);
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemCount.Location = new System.Drawing.Point(180, 279);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(31, 32);
            this.lblItemCount.TabIndex = 24;
            this.lblItemCount.Text = "0";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblDataCount, BunifuAnimatorNS.DecorationType.None);
            this.lblDataCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDataCount.Location = new System.Drawing.Point(27, 279);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(160, 32);
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
            this.bunifuTransition1.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Orange;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Orange;
            this.btnAdd.Location = new System.Drawing.Point(1586, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(319, 67);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.pnlNotSurvived);
            this.pnlList.Controls.Add(this.pnlSurvived);
            this.bunifuTransition1.SetDecoration(this.pnlList, BunifuAnimatorNS.DecorationType.None);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(0, 373);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(2000, 372);
            this.pnlList.TabIndex = 21;
            // 
            // pnlNotSurvived
            // 
            this.pnlNotSurvived.Controls.Add(this.itemListNotSurvived);
            this.bunifuTransition1.SetDecoration(this.pnlNotSurvived, BunifuAnimatorNS.DecorationType.None);
            this.pnlNotSurvived.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotSurvived.Location = new System.Drawing.Point(1000, 0);
            this.pnlNotSurvived.Name = "pnlNotSurvived";
            this.pnlNotSurvived.Size = new System.Drawing.Size(1000, 372);
            this.pnlNotSurvived.TabIndex = 1;
            // 
            // itemListNotSurvived
            // 
            this.itemListNotSurvived.BackColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.itemListNotSurvived, BunifuAnimatorNS.DecorationType.None);
            this.itemListNotSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListNotSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListNotSurvived.ForeColor = System.Drawing.Color.White;
            this.itemListNotSurvived.FormattingEnabled = true;
            this.itemListNotSurvived.ItemHeight = 18;
            this.itemListNotSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListNotSurvived.Name = "itemListNotSurvived";
            this.itemListNotSurvived.Size = new System.Drawing.Size(1000, 372);
            this.itemListNotSurvived.TabIndex = 1;
            // 
            // pnlSurvived
            // 
            this.pnlSurvived.Controls.Add(this.itemListSurvived);
            this.bunifuTransition1.SetDecoration(this.pnlSurvived, BunifuAnimatorNS.DecorationType.None);
            this.pnlSurvived.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSurvived.Location = new System.Drawing.Point(0, 0);
            this.pnlSurvived.Name = "pnlSurvived";
            this.pnlSurvived.Size = new System.Drawing.Size(1000, 372);
            this.pnlSurvived.TabIndex = 0;
            // 
            // itemListSurvived
            // 
            this.itemListSurvived.BackColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.itemListSurvived, BunifuAnimatorNS.DecorationType.None);
            this.itemListSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListSurvived.ForeColor = System.Drawing.Color.White;
            this.itemListSurvived.FormattingEnabled = true;
            this.itemListSurvived.ItemHeight = 18;
            this.itemListSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListSurvived.Name = "itemListSurvived";
            this.itemListSurvived.Size = new System.Drawing.Size(1000, 372);
            this.itemListSurvived.TabIndex = 0;
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.BackgroundImage")));
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtTickerFare, BunifuAnimatorNS.DecorationType.None);
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(1019, 138);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(10);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(282, 43);
            this.txtTickerFare.TabIndex = 6;
            this.txtTickerFare.text = "";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAge.BackgroundImage")));
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.txtAge, BunifuAnimatorNS.DecorationType.None);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(204, 138);
            this.txtAge.Margin = new System.Windows.Forms.Padding(10);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 43);
            this.txtAge.TabIndex = 3;
            this.txtAge.text = "";
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
            this.drpEmbarked.Location = new System.Drawing.Point(1666, 42);
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = 0;
            this.drpEmbarked.Size = new System.Drawing.Size(282, 43);
            this.drpEmbarked.TabIndex = 7;
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
            this.drpGender.Location = new System.Drawing.Point(204, 87);
            this.drpGender.Margin = new System.Windows.Forms.Padding(4);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = 0;
            this.drpGender.Size = new System.Drawing.Size(282, 43);
            this.drpGender.TabIndex = 2;
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
            this.drpTicketClass.Location = new System.Drawing.Point(204, 36);
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = 0;
            this.drpTicketClass.Size = new System.Drawing.Size(282, 43);
            this.drpTicketClass.TabIndex = 1;
            // 
            // lblEmbarked
            // 
            this.lblEmbarked.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblEmbarked, BunifuAnimatorNS.DecorationType.None);
            this.lblEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmbarked.Location = new System.Drawing.Point(1471, 50);
            this.lblEmbarked.Name = "lblEmbarked";
            this.lblEmbarked.Size = new System.Drawing.Size(192, 29);
            this.lblEmbarked.TabIndex = 13;
            this.lblEmbarked.Text = "Gideceğiniz yer :";
            // 
            // lblTicketFare
            // 
            this.lblTicketFare.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTicketFare, BunifuAnimatorNS.DecorationType.None);
            this.lblTicketFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFare.Location = new System.Drawing.Point(868, 138);
            this.lblTicketFare.Name = "lblTicketFare";
            this.lblTicketFare.Size = new System.Drawing.Size(138, 29);
            this.lblTicketFare.TabIndex = 11;
            this.lblTicketFare.Text = "Bilet ücreti :";
            // 
            // lblParentOrChildren
            // 
            this.lblParentOrChildren.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblParentOrChildren, BunifuAnimatorNS.DecorationType.None);
            this.lblParentOrChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParentOrChildren.Location = new System.Drawing.Point(690, 87);
            this.lblParentOrChildren.Name = "lblParentOrChildren";
            this.lblParentOrChildren.Size = new System.Drawing.Size(316, 29);
            this.lblParentOrChildren.TabIndex = 9;
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
            this.txtParentOrChildren.Location = new System.Drawing.Point(1019, 85);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(10);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(282, 43);
            this.txtParentOrChildren.TabIndex = 5;
            this.txtParentOrChildren.text = "";
            // 
            // lblSiblingsOrSpouse
            // 
            this.lblSiblingsOrSpouse.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSiblingsOrSpouse, BunifuAnimatorNS.DecorationType.None);
            this.lblSiblingsOrSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiblingsOrSpouse.Location = new System.Drawing.Point(749, 36);
            this.lblSiblingsOrSpouse.Name = "lblSiblingsOrSpouse";
            this.lblSiblingsOrSpouse.Size = new System.Drawing.Size(257, 29);
            this.lblSiblingsOrSpouse.TabIndex = 7;
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
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(1019, 34);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(10);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(282, 43);
            this.txtSiblingsOrSpouse.TabIndex = 4;
            this.txtSiblingsOrSpouse.text = "";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblAge, BunifuAnimatorNS.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(131, 138);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 29);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Yaş :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblGender, BunifuAnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(87, 87);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 29);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Cinsiyet :";
            // 
            // lblTicketClass
            // 
            this.lblTicketClass.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTicketClass, BunifuAnimatorNS.DecorationType.None);
            this.lblTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketClass.Location = new System.Drawing.Point(65, 36);
            this.lblTicketClass.Name = "lblTicketClass";
            this.lblTicketClass.Size = new System.Drawing.Size(132, 29);
            this.lblTicketClass.TabIndex = 1;
            this.lblTicketClass.Text = "Bilet Sınıfı :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // 
            // TitanicTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "TitanicTrain";
            this.Size = new System.Drawing.Size(2000, 745);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlNotSurvived.ResumeLayout(false);
            this.pnlSurvived.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAge;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGender;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketClass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmbarked;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketFare;
        private Bunifu.Framework.UI.BunifuCustomLabel lblParentOrChildren;
        private Bunifu.Framework.UI.BunifuTextbox txtParentOrChildren;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuTextbox txtSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuDropdown drpEmbarked;
        private Bunifu.Framework.UI.BunifuDropdown drpGender;
        private Bunifu.Framework.UI.BunifuDropdown drpTicketClass;
        private Bunifu.Framework.UI.BunifuTextbox txtAge;
        private System.Windows.Forms.Panel pnlList;
        private Bunifu.Framework.UI.BunifuTextbox txtTickerFare;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblItemCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDataCount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartTrain;
        private System.Windows.Forms.Panel pnlNotSurvived;
        private System.Windows.Forms.ListBox itemListNotSurvived;
        private System.Windows.Forms.Panel pnlSurvived;
        private System.Windows.Forms.ListBox itemListSurvived;
        private Bunifu.Framework.UI.BunifuDropdown drpState;
        private Bunifu.Framework.UI.BunifuCustomLabel lblState;
        private Bunifu.Framework.UI.BunifuCustomLabel lblModeTraining;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNotSurvived;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSurvived;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
