namespace MachineLearningGames.MakeMeHappy.Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            this.txtPositiveWord = new System.Windows.Forms.TextBox();
            this.lbPositiveWords = new System.Windows.Forms.ListBox();
            this.lblInputPositiveWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPositiveWord = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNegativeWord = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblInputNegativeWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNegativeWords = new System.Windows.Forms.ListBox();
            this.txtNegativeWord = new System.Windows.Forms.TextBox();
            this.lblPositiveWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNegativeWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRemovePositiveWords = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemoveNegativeWords = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtPositiveWord
            // 
            this.txtPositiveWord.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPositiveWord.Font = new System.Drawing.Font("TR Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositiveWord.Location = new System.Drawing.Point(87, 206);
            this.txtPositiveWord.Multiline = true;
            this.txtPositiveWord.Name = "txtPositiveWord";
            this.txtPositiveWord.Size = new System.Drawing.Size(308, 161);
            this.txtPositiveWord.TabIndex = 0;
            this.txtPositiveWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPositiveWord_KeyDown);
            this.txtPositiveWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPositiveWord_KeyUp);
            // 
            // lbPositiveWords
            // 
            this.lbPositiveWords.BackColor = System.Drawing.Color.Gainsboro;
            this.lbPositiveWords.Font = new System.Drawing.Font("TR Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPositiveWords.FormattingEnabled = true;
            this.lbPositiveWords.ItemHeight = 16;
            this.lbPositiveWords.Location = new System.Drawing.Point(414, 146);
            this.lbPositiveWords.Name = "lbPositiveWords";
            this.lbPositiveWords.Size = new System.Drawing.Size(308, 308);
            this.lbPositiveWords.TabIndex = 1;
            // 
            // lblInputPositiveWord
            // 
            this.lblInputPositiveWord.AutoSize = true;
            this.lblInputPositiveWord.BackColor = System.Drawing.Color.Transparent;
            this.lblInputPositiveWord.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPositiveWord.ForeColor = System.Drawing.Color.White;
            this.lblInputPositiveWord.Location = new System.Drawing.Point(158, 171);
            this.lblInputPositiveWord.Name = "lblInputPositiveWord";
            this.lblInputPositiveWord.Size = new System.Drawing.Size(168, 20);
            this.lblInputPositiveWord.TabIndex = 2;
            this.lblInputPositiveWord.Text = "Olumlu Cümlü Giriniz";
            // 
            // btnPositiveWord
            // 
            this.btnPositiveWord.ActiveBorderThickness = 1;
            this.btnPositiveWord.ActiveCornerRadius = 20;
            this.btnPositiveWord.ActiveFillColor = System.Drawing.Color.White;
            this.btnPositiveWord.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnPositiveWord.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPositiveWord.BackColor = System.Drawing.Color.Transparent;
            this.btnPositiveWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPositiveWord.BackgroundImage")));
            this.btnPositiveWord.ButtonText = "Cümleyi Ekle";
            this.btnPositiveWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPositiveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositiveWord.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPositiveWord.IdleBorderThickness = 3;
            this.btnPositiveWord.IdleCornerRadius = 20;
            this.btnPositiveWord.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnPositiveWord.IdleForecolor = System.Drawing.Color.White;
            this.btnPositiveWord.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPositiveWord.Location = new System.Drawing.Point(87, 375);
            this.btnPositiveWord.Margin = new System.Windows.Forms.Padding(5);
            this.btnPositiveWord.Name = "btnPositiveWord";
            this.btnPositiveWord.Size = new System.Drawing.Size(308, 41);
            this.btnPositiveWord.TabIndex = 3;
            this.btnPositiveWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPositiveWord.Click += new System.EventHandler(this.btnPositiveWord_Click);
            // 
            // btnNegativeWord
            // 
            this.btnNegativeWord.ActiveBorderThickness = 1;
            this.btnNegativeWord.ActiveCornerRadius = 20;
            this.btnNegativeWord.ActiveFillColor = System.Drawing.Color.White;
            this.btnNegativeWord.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnNegativeWord.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNegativeWord.BackColor = System.Drawing.Color.Transparent;
            this.btnNegativeWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNegativeWord.BackgroundImage")));
            this.btnNegativeWord.ButtonText = "Cümleyi Ekle";
            this.btnNegativeWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegativeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativeWord.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNegativeWord.IdleBorderThickness = 3;
            this.btnNegativeWord.IdleCornerRadius = 20;
            this.btnNegativeWord.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnNegativeWord.IdleForecolor = System.Drawing.Color.White;
            this.btnNegativeWord.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNegativeWord.Location = new System.Drawing.Point(1129, 375);
            this.btnNegativeWord.Margin = new System.Windows.Forms.Padding(5);
            this.btnNegativeWord.Name = "btnNegativeWord";
            this.btnNegativeWord.Size = new System.Drawing.Size(308, 41);
            this.btnNegativeWord.TabIndex = 7;
            this.btnNegativeWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNegativeWord.Click += new System.EventHandler(this.btnNegativeWord_Click);
            // 
            // lblInputNegativeWord
            // 
            this.lblInputNegativeWord.AutoSize = true;
            this.lblInputNegativeWord.BackColor = System.Drawing.Color.Transparent;
            this.lblInputNegativeWord.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputNegativeWord.ForeColor = System.Drawing.Color.White;
            this.lblInputNegativeWord.Location = new System.Drawing.Point(1200, 171);
            this.lblInputNegativeWord.Name = "lblInputNegativeWord";
            this.lblInputNegativeWord.Size = new System.Drawing.Size(178, 20);
            this.lblInputNegativeWord.TabIndex = 6;
            this.lblInputNegativeWord.Text = "Olumsuz Cümlü Giriniz";
            // 
            // lbNegativeWords
            // 
            this.lbNegativeWords.BackColor = System.Drawing.Color.Gainsboro;
            this.lbNegativeWords.Font = new System.Drawing.Font("TR Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNegativeWords.FormattingEnabled = true;
            this.lbNegativeWords.ItemHeight = 16;
            this.lbNegativeWords.Location = new System.Drawing.Point(800, 146);
            this.lbNegativeWords.Name = "lbNegativeWords";
            this.lbNegativeWords.Size = new System.Drawing.Size(308, 308);
            this.lbNegativeWords.TabIndex = 5;
            // 
            // txtNegativeWord
            // 
            this.txtNegativeWord.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNegativeWord.Font = new System.Drawing.Font("TR Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegativeWord.Location = new System.Drawing.Point(1129, 206);
            this.txtNegativeWord.Multiline = true;
            this.txtNegativeWord.Name = "txtNegativeWord";
            this.txtNegativeWord.Size = new System.Drawing.Size(308, 161);
            this.txtNegativeWord.TabIndex = 4;
            this.txtNegativeWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNegativeWord_KeyDown);
            this.txtNegativeWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNegativeWord_KeyUp);
            // 
            // lblPositiveWord
            // 
            this.lblPositiveWord.AutoSize = true;
            this.lblPositiveWord.BackColor = System.Drawing.Color.Transparent;
            this.lblPositiveWord.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositiveWord.ForeColor = System.Drawing.Color.White;
            this.lblPositiveWord.Location = new System.Drawing.Point(500, 110);
            this.lblPositiveWord.Name = "lblPositiveWord";
            this.lblPositiveWord.Size = new System.Drawing.Size(137, 20);
            this.lblPositiveWord.TabIndex = 8;
            this.lblPositiveWord.Text = "Olumlu Cümlüler";
            // 
            // lblNegativeWord
            // 
            this.lblNegativeWord.AutoSize = true;
            this.lblNegativeWord.BackColor = System.Drawing.Color.Transparent;
            this.lblNegativeWord.Font = new System.Drawing.Font("TR Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegativeWord.ForeColor = System.Drawing.Color.White;
            this.lblNegativeWord.Location = new System.Drawing.Point(870, 110);
            this.lblNegativeWord.Name = "lblNegativeWord";
            this.lblNegativeWord.Size = new System.Drawing.Size(147, 20);
            this.lblNegativeWord.TabIndex = 9;
            this.lblNegativeWord.Text = "Olumsuz Cümleler";
            // 
            // btnRemovePositiveWords
            // 
            this.btnRemovePositiveWords.ActiveBorderThickness = 1;
            this.btnRemovePositiveWords.ActiveCornerRadius = 20;
            this.btnRemovePositiveWords.ActiveFillColor = System.Drawing.Color.White;
            this.btnRemovePositiveWords.ActiveForecolor = System.Drawing.Color.Crimson;
            this.btnRemovePositiveWords.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemovePositiveWords.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePositiveWords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemovePositiveWords.BackgroundImage")));
            this.btnRemovePositiveWords.ButtonText = "Listeyi Boşalt";
            this.btnRemovePositiveWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePositiveWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePositiveWords.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRemovePositiveWords.IdleBorderThickness = 3;
            this.btnRemovePositiveWords.IdleCornerRadius = 20;
            this.btnRemovePositiveWords.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnRemovePositiveWords.IdleForecolor = System.Drawing.Color.White;
            this.btnRemovePositiveWords.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemovePositiveWords.Location = new System.Drawing.Point(414, 462);
            this.btnRemovePositiveWords.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemovePositiveWords.Name = "btnRemovePositiveWords";
            this.btnRemovePositiveWords.Size = new System.Drawing.Size(308, 41);
            this.btnRemovePositiveWords.TabIndex = 10;
            this.btnRemovePositiveWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemovePositiveWords.Click += new System.EventHandler(this.btnRemovePositiveWords_Click);
            // 
            // btnRemoveNegativeWords
            // 
            this.btnRemoveNegativeWords.ActiveBorderThickness = 1;
            this.btnRemoveNegativeWords.ActiveCornerRadius = 20;
            this.btnRemoveNegativeWords.ActiveFillColor = System.Drawing.Color.White;
            this.btnRemoveNegativeWords.ActiveForecolor = System.Drawing.Color.Crimson;
            this.btnRemoveNegativeWords.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveNegativeWords.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveNegativeWords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveNegativeWords.BackgroundImage")));
            this.btnRemoveNegativeWords.ButtonText = "Listeyi Boşalt";
            this.btnRemoveNegativeWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveNegativeWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNegativeWords.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRemoveNegativeWords.IdleBorderThickness = 3;
            this.btnRemoveNegativeWords.IdleCornerRadius = 20;
            this.btnRemoveNegativeWords.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnRemoveNegativeWords.IdleForecolor = System.Drawing.Color.White;
            this.btnRemoveNegativeWords.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveNegativeWords.Location = new System.Drawing.Point(800, 462);
            this.btnRemoveNegativeWords.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveNegativeWords.Name = "btnRemoveNegativeWords";
            this.btnRemoveNegativeWords.Size = new System.Drawing.Size(308, 41);
            this.btnRemoveNegativeWords.TabIndex = 11;
            this.btnRemoveNegativeWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveNegativeWords.Click += new System.EventHandler(this.btnRemoveNegativeWords_Click);
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnRemoveNegativeWords);
            this.Controls.Add(this.btnRemovePositiveWords);
            this.Controls.Add(this.lblNegativeWord);
            this.Controls.Add(this.lblPositiveWord);
            this.Controls.Add(this.btnNegativeWord);
            this.Controls.Add(this.lblInputNegativeWord);
            this.Controls.Add(this.lbNegativeWords);
            this.Controls.Add(this.txtNegativeWord);
            this.Controls.Add(this.btnPositiveWord);
            this.Controls.Add(this.lblInputPositiveWord);
            this.Controls.Add(this.lbPositiveWords);
            this.Controls.Add(this.txtPositiveWord);
            this.Name = "Train";
            this.Size = new System.Drawing.Size(1500, 605);
            this.Load += new System.EventHandler(this.Train_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPositiveWord;
        private System.Windows.Forms.ListBox lbPositiveWords;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInputPositiveWord;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPositiveWord;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNegativeWord;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInputNegativeWord;
        private System.Windows.Forms.ListBox lbNegativeWords;
        private System.Windows.Forms.TextBox txtNegativeWord;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPositiveWord;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNegativeWord;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemovePositiveWords;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveNegativeWords;
    }
}
