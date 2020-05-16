namespace MachineLearningGames.JudgeBook.Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.pnlTest = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTest = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUploadPicture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbUploadPicture = new System.Windows.Forms.PictureBox();
            this.gbGuess = new System.Windows.Forms.GroupBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.pnlTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadPicture)).BeginInit();
            this.gbGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.Transparent;
            this.pnlTest.Controls.Add(this.gbGuess);
            this.pnlTest.Controls.Add(this.groupBox1);
            this.pnlTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTest.Location = new System.Drawing.Point(0, 0);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(1500, 605);
            this.pnlTest.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnUploadPicture);
            this.groupBox1.Controls.Add(this.pbUploadPicture);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(316, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim Ekle";
            // 
            // btnTest
            // 
            this.btnTest.ActiveBorderThickness = 3;
            this.btnTest.ActiveCornerRadius = 20;
            this.btnTest.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnTest.ActiveForecolor = System.Drawing.Color.Black;
            this.btnTest.ActiveLineColor = System.Drawing.Color.Black;
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.ButtonText = "Test Et";
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.IdleBorderThickness = 3;
            this.btnTest.IdleCornerRadius = 20;
            this.btnTest.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnTest.IdleForecolor = System.Drawing.Color.Silver;
            this.btnTest.IdleLineColor = System.Drawing.Color.Silver;
            this.btnTest.Location = new System.Drawing.Point(174, 469);
            this.btnTest.Margin = new System.Windows.Forms.Padding(5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 55);
            this.btnTest.TabIndex = 5;
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.ActiveBorderThickness = 3;
            this.btnUploadPicture.ActiveCornerRadius = 20;
            this.btnUploadPicture.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnUploadPicture.ActiveForecolor = System.Drawing.Color.Black;
            this.btnUploadPicture.ActiveLineColor = System.Drawing.Color.Black;
            this.btnUploadPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadPicture.BackgroundImage")));
            this.btnUploadPicture.ButtonText = "Resim Yükle";
            this.btnUploadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadPicture.ForeColor = System.Drawing.Color.White;
            this.btnUploadPicture.IdleBorderThickness = 3;
            this.btnUploadPicture.IdleCornerRadius = 20;
            this.btnUploadPicture.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnUploadPicture.IdleForecolor = System.Drawing.Color.Silver;
            this.btnUploadPicture.IdleLineColor = System.Drawing.Color.Silver;
            this.btnUploadPicture.Location = new System.Drawing.Point(45, 469);
            this.btnUploadPicture.Margin = new System.Windows.Forms.Padding(5);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(131, 55);
            this.btnUploadPicture.TabIndex = 4;
            this.btnUploadPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // pbUploadPicture
            // 
            this.pbUploadPicture.Location = new System.Drawing.Point(45, 40);
            this.pbUploadPicture.Name = "pbUploadPicture";
            this.pbUploadPicture.Size = new System.Drawing.Size(237, 421);
            this.pbUploadPicture.TabIndex = 0;
            this.pbUploadPicture.TabStop = false;
            // 
            // gbGuess
            // 
            this.gbGuess.Controls.Add(this.lblGuess);
            this.gbGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGuess.ForeColor = System.Drawing.Color.White;
            this.gbGuess.Location = new System.Drawing.Point(779, 211);
            this.gbGuess.Name = "gbGuess";
            this.gbGuess.Size = new System.Drawing.Size(419, 109);
            this.gbGuess.TabIndex = 1;
            this.gbGuess.TabStop = false;
            this.gbGuess.Text = "Makine Tahmini";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.ForeColor = System.Drawing.Color.White;
            this.lblGuess.Location = new System.Drawing.Point(91, 49);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(60, 24);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "label1";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JudgeBookTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlTest);
            this.Name = "JudgeBookTest";
            this.Size = new System.Drawing.Size(1500, 605);
            this.pnlTest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUploadPicture)).EndInit();
            this.gbGuess.ResumeLayout(false);
            this.gbGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbUploadPicture;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUploadPicture;
        private System.Windows.Forms.GroupBox gbGuess;
        private System.Windows.Forms.Label lblGuess;
    }
}
