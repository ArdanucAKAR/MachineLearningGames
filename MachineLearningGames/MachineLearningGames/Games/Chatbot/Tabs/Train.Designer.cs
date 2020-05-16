namespace MachineLearningGames.Chatbot.Tabs
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
            this.cevapBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cevapTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbmainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cbmainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cevapBtn
            // 
            this.cevapBtn.Activecolor = System.Drawing.Color.Transparent;
            this.cevapBtn.BackColor = System.Drawing.Color.DarkGray;
            this.cevapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cevapBtn.BorderRadius = 0;
            this.cevapBtn.ButtonText = "Cevaplar ekle";
            this.cevapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cevapBtn.DisabledColor = System.Drawing.Color.Gray;
            this.cevapBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cevapBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("cevapBtn.Iconimage")));
            this.cevapBtn.Iconimage_right = null;
            this.cevapBtn.Iconimage_right_Selected = null;
            this.cevapBtn.Iconimage_Selected = null;
            this.cevapBtn.IconMarginLeft = 2;
            this.cevapBtn.IconMarginRight = 190;
            this.cevapBtn.IconRightVisible = true;
            this.cevapBtn.IconRightZoom = 0D;
            this.cevapBtn.IconVisible = true;
            this.cevapBtn.IconZoom = 110D;
            this.cevapBtn.IsTab = false;
            this.cevapBtn.Location = new System.Drawing.Point(670, 355);
            this.cevapBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cevapBtn.Name = "cevapBtn";
            this.cevapBtn.Normalcolor = System.Drawing.Color.DarkGray;
            this.cevapBtn.OnHovercolor = System.Drawing.Color.LightGray;
            this.cevapBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cevapBtn.selected = false;
            this.cevapBtn.Size = new System.Drawing.Size(208, 25);
            this.cevapBtn.TabIndex = 11;
            this.cevapBtn.Text = "Cevaplar ekle";
            this.cevapBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cevapBtn.Textcolor = System.Drawing.Color.Black;
            this.cevapBtn.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapBtn.Click += new System.EventHandler(this.cevapBtn_Click);
            // 
            // cevapTextBox
            // 
            this.cevapTextBox.BackColor = System.Drawing.Color.LightGray;
            this.cevapTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cevapTextBox.BackgroundImage")));
            this.cevapTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cevapTextBox.ForeColor = System.Drawing.Color.Black;
            this.cevapTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("cevapTextBox.Icon")));
            this.cevapTextBox.Location = new System.Drawing.Point(637, 306);
            this.cevapTextBox.Name = "cevapTextBox";
            this.cevapTextBox.Size = new System.Drawing.Size(267, 26);
            this.cevapTextBox.TabIndex = 10;
            this.cevapTextBox.text = "Aslanlarla ilgili cümle girin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(544, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aslan hakkında bildiklerini yaz ve ekle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1246, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 650);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // cbmainPanel
            // 
            this.cbmainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmainPanel.BackgroundImage")));
            this.cbmainPanel.Controls.Add(this.pictureBox1);
            this.cbmainPanel.Controls.Add(this.pictureBox2);
            this.cbmainPanel.Controls.Add(this.cevapBtn);
            this.cbmainPanel.Controls.Add(this.label4);
            this.cbmainPanel.Controls.Add(this.cevapTextBox);
            this.cbmainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbmainPanel.Location = new System.Drawing.Point(0, 0);
            this.cbmainPanel.Name = "cbmainPanel";
            this.cbmainPanel.Size = new System.Drawing.Size(1500, 650);
            this.cbmainPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 650);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ChatBotTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbmainPanel);
            this.Name = "ChatBotTrain";
            this.Size = new System.Drawing.Size(1500, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cbmainPanel.ResumeLayout(false);
            this.cbmainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton cevapBtn;
        private Bunifu.Framework.UI.BunifuTextbox cevapTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel cbmainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
