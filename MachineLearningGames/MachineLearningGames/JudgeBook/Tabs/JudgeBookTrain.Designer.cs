namespace MachineLearningGames.JudgeBook.Tabs
{
    partial class JudgeBookTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JudgeBookTrain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUploadChildren = new Bunifu.Framework.UI.BunifuThinButton2();
            this.childrensBookList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.romanceBookList = new System.Windows.Forms.ListView();
            this.btnUploadRomance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thrillerBookList = new System.Windows.Forms.ListView();
            this.btnUploadThriller = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scifiBookList = new System.Windows.Forms.ListView();
            this.btnUploadScifi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlJudgeBookTrain = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlJudgeBookTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUploadChildren);
            this.groupBox1.Controls.Add(this.childrensBookList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(108, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çocuk";
            // 
            // btnUploadChildren
            // 
            this.btnUploadChildren.ActiveBorderThickness = 3;
            this.btnUploadChildren.ActiveCornerRadius = 20;
            this.btnUploadChildren.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadChildren.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadChildren.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadChildren.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadChildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadChildren.BackgroundImage")));
            this.btnUploadChildren.ButtonText = "Resim Yükle";
            this.btnUploadChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadChildren.ForeColor = System.Drawing.Color.White;
            this.btnUploadChildren.IdleBorderThickness = 3;
            this.btnUploadChildren.IdleCornerRadius = 20;
            this.btnUploadChildren.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadChildren.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadChildren.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadChildren.Location = new System.Drawing.Point(60, 370);
            this.btnUploadChildren.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadChildren.Name = "btnUploadChildren";
            this.btnUploadChildren.Size = new System.Drawing.Size(131, 55);
            this.btnUploadChildren.TabIndex = 2;
            this.btnUploadChildren.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadChildren.Click += new System.EventHandler(this.btnUploadChildren_Click);
            // 
            // childrensBookList
            // 
            this.childrensBookList.BackColor = System.Drawing.Color.Thistle;
            this.childrensBookList.HideSelection = false;
            this.childrensBookList.Location = new System.Drawing.Point(17, 28);
            this.childrensBookList.Name = "childrensBookList";
            this.childrensBookList.Size = new System.Drawing.Size(212, 339);
            this.childrensBookList.TabIndex = 0;
            this.childrensBookList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.romanceBookList);
            this.groupBox2.Controls.Add(this.btnUploadRomance);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(416, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Romantik";
            // 
            // romanceBookList
            // 
            this.romanceBookList.BackColor = System.Drawing.Color.Plum;
            this.romanceBookList.HideSelection = false;
            this.romanceBookList.Location = new System.Drawing.Point(19, 28);
            this.romanceBookList.Name = "romanceBookList";
            this.romanceBookList.Size = new System.Drawing.Size(212, 339);
            this.romanceBookList.TabIndex = 3;
            this.romanceBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btnUploadRomance
            // 
            this.btnUploadRomance.ActiveBorderThickness = 3;
            this.btnUploadRomance.ActiveCornerRadius = 20;
            this.btnUploadRomance.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadRomance.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadRomance.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadRomance.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadRomance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadRomance.BackgroundImage")));
            this.btnUploadRomance.ButtonText = "Resim Yükle";
            this.btnUploadRomance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadRomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadRomance.ForeColor = System.Drawing.Color.White;
            this.btnUploadRomance.IdleBorderThickness = 3;
            this.btnUploadRomance.IdleCornerRadius = 20;
            this.btnUploadRomance.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadRomance.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadRomance.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadRomance.Location = new System.Drawing.Point(64, 370);
            this.btnUploadRomance.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadRomance.Name = "btnUploadRomance";
            this.btnUploadRomance.Size = new System.Drawing.Size(131, 55);
            this.btnUploadRomance.TabIndex = 3;
            this.btnUploadRomance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadRomance.Click += new System.EventHandler(this.btnUploadRomance_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnUploadThriller);
            this.groupBox3.Controls.Add(this.thrillerBookList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(729, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Korku";
            // 
            // thrillerBookList
            // 
            this.thrillerBookList.BackColor = System.Drawing.Color.Violet;
            this.thrillerBookList.HideSelection = false;
            this.thrillerBookList.Location = new System.Drawing.Point(17, 28);
            this.thrillerBookList.Name = "thrillerBookList";
            this.thrillerBookList.Size = new System.Drawing.Size(212, 339);
            this.thrillerBookList.TabIndex = 4;
            this.thrillerBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btnUploadThriller
            // 
            this.btnUploadThriller.ActiveBorderThickness = 3;
            this.btnUploadThriller.ActiveCornerRadius = 20;
            this.btnUploadThriller.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadThriller.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadThriller.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadThriller.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadThriller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadThriller.BackgroundImage")));
            this.btnUploadThriller.ButtonText = "Resim Yükle";
            this.btnUploadThriller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadThriller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadThriller.ForeColor = System.Drawing.Color.White;
            this.btnUploadThriller.IdleBorderThickness = 3;
            this.btnUploadThriller.IdleCornerRadius = 20;
            this.btnUploadThriller.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadThriller.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadThriller.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadThriller.Location = new System.Drawing.Point(64, 370);
            this.btnUploadThriller.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadThriller.Name = "btnUploadThriller";
            this.btnUploadThriller.Size = new System.Drawing.Size(131, 55);
            this.btnUploadThriller.TabIndex = 4;
            this.btnUploadThriller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadThriller.Click += new System.EventHandler(this.btnUploadThriller_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.scifiBookList);
            this.groupBox4.Controls.Add(this.btnUploadScifi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1052, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 425);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilim Kurgu";
            // 
            // scifiBookList
            // 
            this.scifiBookList.BackColor = System.Drawing.Color.MediumOrchid;
            this.scifiBookList.HideSelection = false;
            this.scifiBookList.Location = new System.Drawing.Point(18, 28);
            this.scifiBookList.Name = "scifiBookList";
            this.scifiBookList.Size = new System.Drawing.Size(212, 339);
            this.scifiBookList.TabIndex = 5;
            this.scifiBookList.UseCompatibleStateImageBehavior = false;
            // 
            // btnUploadScifi
            // 
            this.btnUploadScifi.ActiveBorderThickness = 3;
            this.btnUploadScifi.ActiveCornerRadius = 20;
            this.btnUploadScifi.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadScifi.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadScifi.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadScifi.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadScifi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadScifi.BackgroundImage")));
            this.btnUploadScifi.ButtonText = "Resim Yükle";
            this.btnUploadScifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadScifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadScifi.ForeColor = System.Drawing.Color.White;
            this.btnUploadScifi.IdleBorderThickness = 3;
            this.btnUploadScifi.IdleCornerRadius = 20;
            this.btnUploadScifi.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadScifi.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadScifi.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadScifi.Location = new System.Drawing.Point(61, 370);
            this.btnUploadScifi.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadScifi.Name = "btnUploadScifi";
            this.btnUploadScifi.Size = new System.Drawing.Size(131, 55);
            this.btnUploadScifi.TabIndex = 5;
            this.btnUploadScifi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadScifi.Click += new System.EventHandler(this.btnUploadScifi_Click);
            // 
            // pnlJudgeBookTrain
            // 
            this.pnlJudgeBookTrain.BackColor = System.Drawing.Color.Transparent;
            this.pnlJudgeBookTrain.Controls.Add(this.groupBox1);
            this.pnlJudgeBookTrain.Controls.Add(this.groupBox2);
            this.pnlJudgeBookTrain.Controls.Add(this.groupBox3);
            this.pnlJudgeBookTrain.Controls.Add(this.groupBox4);
            this.pnlJudgeBookTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJudgeBookTrain.Location = new System.Drawing.Point(0, 0);
            this.pnlJudgeBookTrain.Name = "pnlJudgeBookTrain";
            this.pnlJudgeBookTrain.Size = new System.Drawing.Size(1500, 605);
            this.pnlJudgeBookTrain.TabIndex = 8;
            // 
            // JudgeBookTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlJudgeBookTrain);
            this.Name = "JudgeBookTrain";
            this.Size = new System.Drawing.Size(1500, 605);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.pnlJudgeBookTrain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView childrensBookList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadChildren;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadRomance;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadThriller;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadScifi;
        private System.Windows.Forms.ListView romanceBookList;
        private System.Windows.Forms.ListView thrillerBookList;
        private System.Windows.Forms.ListView scifiBookList;
        private System.Windows.Forms.Panel pnlJudgeBookTrain;
    }
}
