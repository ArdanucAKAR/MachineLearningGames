namespace MachineLearningGames.Ayberk
{
    partial class ChatBotTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotTrain));
            this.trainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.konularCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soruekleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.soruTextbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.konuekleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.konuTextbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.konuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cevapBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cevapTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.trainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trainPanel
            // 
            this.trainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trainPanel.BackgroundImage")));
            this.trainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainPanel.Controls.Add(this.cevapBtn);
            this.trainPanel.Controls.Add(this.cevapTextBox);
            this.trainPanel.Controls.Add(this.label4);
            this.trainPanel.Controls.Add(this.button1);
            this.trainPanel.Controls.Add(this.konularCombo);
            this.trainPanel.Controls.Add(this.label3);
            this.trainPanel.Controls.Add(this.soruekleBtn);
            this.trainPanel.Controls.Add(this.soruTextbox);
            this.trainPanel.Controls.Add(this.label2);
            this.trainPanel.Controls.Add(this.konuekleBtn);
            this.trainPanel.Controls.Add(this.konuTextbox);
            this.trainPanel.Controls.Add(this.label1);
            this.trainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainPanel.GradientBottomLeft = System.Drawing.Color.Aquamarine;
            this.trainPanel.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.trainPanel.GradientTopLeft = System.Drawing.Color.Maroon;
            this.trainPanel.GradientTopRight = System.Drawing.Color.PaleGreen;
            this.trainPanel.Location = new System.Drawing.Point(0, 0);
            this.trainPanel.Name = "trainPanel";
            this.trainPanel.Quality = 10;
            this.trainPanel.Size = new System.Drawing.Size(775, 532);
            this.trainPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // konularCombo
            // 
            this.konularCombo.FormattingEnabled = true;
            this.konularCombo.Location = new System.Drawing.Point(491, 157);
            this.konularCombo.Name = "konularCombo";
            this.konularCombo.Size = new System.Drawing.Size(121, 21);
            this.konularCombo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(511, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konu seç";
            // 
            // soruekleBtn
            // 
            this.soruekleBtn.Activecolor = System.Drawing.Color.Transparent;
            this.soruekleBtn.BackColor = System.Drawing.Color.DarkGray;
            this.soruekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soruekleBtn.BorderRadius = 0;
            this.soruekleBtn.ButtonText = "Soru ekle";
            this.soruekleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soruekleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.soruekleBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruekleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.soruekleBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("soruekleBtn.Iconimage")));
            this.soruekleBtn.Iconimage_right = null;
            this.soruekleBtn.Iconimage_right_Selected = null;
            this.soruekleBtn.Iconimage_Selected = null;
            this.soruekleBtn.IconMarginLeft = 2;
            this.soruekleBtn.IconMarginRight = 190;
            this.soruekleBtn.IconRightVisible = true;
            this.soruekleBtn.IconRightZoom = 0D;
            this.soruekleBtn.IconVisible = true;
            this.soruekleBtn.IconZoom = 100D;
            this.soruekleBtn.IsTab = false;
            this.soruekleBtn.Location = new System.Drawing.Point(448, 240);
            this.soruekleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soruekleBtn.Name = "soruekleBtn";
            this.soruekleBtn.Normalcolor = System.Drawing.Color.DarkGray;
            this.soruekleBtn.OnHovercolor = System.Drawing.Color.LightGray;
            this.soruekleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.soruekleBtn.selected = false;
            this.soruekleBtn.Size = new System.Drawing.Size(208, 25);
            this.soruekleBtn.TabIndex = 5;
            this.soruekleBtn.Text = "Soru ekle";
            this.soruekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soruekleBtn.Textcolor = System.Drawing.Color.Black;
            this.soruekleBtn.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruekleBtn.Click += new System.EventHandler(this.soruekleBtn_Click);
            // 
            // soruTextbox
            // 
            this.soruTextbox.BackColor = System.Drawing.Color.LightGray;
            this.soruTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruTextbox.BackgroundImage")));
            this.soruTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soruTextbox.ForeColor = System.Drawing.Color.Black;
            this.soruTextbox.Icon = ((System.Drawing.Image)(resources.GetObject("soruTextbox.Icon")));
            this.soruTextbox.Location = new System.Drawing.Point(416, 207);
            this.soruTextbox.Name = "soruTextbox";
            this.soruTextbox.Size = new System.Drawing.Size(267, 26);
            this.soruTextbox.TabIndex = 4;
            this.soruTextbox.text = "Soru giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(447, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konuyla ilgili sorularını ekle:\r\n";
            // 
            // konuekleBtn
            // 
            this.konuekleBtn.Activecolor = System.Drawing.Color.Transparent;
            this.konuekleBtn.BackColor = System.Drawing.Color.DarkGray;
            this.konuekleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.konuekleBtn.BorderRadius = 0;
            this.konuekleBtn.ButtonText = "Konu  ekle";
            this.konuekleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konuekleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.konuekleBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konuekleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.konuekleBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("konuekleBtn.Iconimage")));
            this.konuekleBtn.Iconimage_right = null;
            this.konuekleBtn.Iconimage_right_Selected = null;
            this.konuekleBtn.Iconimage_Selected = null;
            this.konuekleBtn.IconMarginLeft = 2;
            this.konuekleBtn.IconMarginRight = 190;
            this.konuekleBtn.IconRightVisible = true;
            this.konuekleBtn.IconRightZoom = 0D;
            this.konuekleBtn.IconVisible = true;
            this.konuekleBtn.IconZoom = 100D;
            this.konuekleBtn.IsTab = false;
            this.konuekleBtn.Location = new System.Drawing.Point(85, 185);
            this.konuekleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.konuekleBtn.Name = "konuekleBtn";
            this.konuekleBtn.Normalcolor = System.Drawing.Color.DarkGray;
            this.konuekleBtn.OnHovercolor = System.Drawing.Color.LightGray;
            this.konuekleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.konuekleBtn.selected = false;
            this.konuekleBtn.Size = new System.Drawing.Size(208, 25);
            this.konuekleBtn.TabIndex = 2;
            this.konuekleBtn.Text = "Konu  ekle";
            this.konuekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.konuekleBtn.Textcolor = System.Drawing.Color.Black;
            this.konuekleBtn.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konuekleBtn.Click += new System.EventHandler(this.konuekleBtn_Click);
            // 
            // konuTextbox
            // 
            this.konuTextbox.BackColor = System.Drawing.Color.LightGray;
            this.konuTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("konuTextbox.BackgroundImage")));
            this.konuTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.konuTextbox.ForeColor = System.Drawing.Color.Black;
            this.konuTextbox.Icon = ((System.Drawing.Image)(resources.GetObject("konuTextbox.Icon")));
            this.konuTextbox.Location = new System.Drawing.Point(60, 152);
            this.konuTextbox.Name = "konuTextbox";
            this.konuTextbox.Size = new System.Drawing.Size(267, 26);
            this.konuTextbox.TabIndex = 1;
            this.konuTextbox.text = "Konu giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aslanla ilgili konular ekle:";
            // 
            // konuBindingSource
            // 
            this.konuBindingSource.DataSource = typeof(MachineLearningGames.Ayberk.Konu);
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
            this.cevapBtn.IconZoom = 100D;
            this.cevapBtn.IsTab = false;
            this.cevapBtn.Location = new System.Drawing.Point(85, 288);
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
            this.cevapTextBox.Location = new System.Drawing.Point(60, 255);
            this.cevapTextBox.Name = "cevapTextBox";
            this.cevapTextBox.Size = new System.Drawing.Size(267, 26);
            this.cevapTextBox.TabIndex = 10;
            this.cevapTextBox.text = "Aslanlarla ilgili bir şeyler girin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cevapları ekle:";
            // 
            // ChatBotTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainPanel);
            this.Name = "ChatBotTrain";
            this.Size = new System.Drawing.Size(775, 532);
            this.Load += new System.EventHandler(this.ChatBotTrain_Load);
            this.trainPanel.ResumeLayout(false);
            this.trainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.konuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel trainPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton konuekleBtn;
        private Bunifu.Framework.UI.BunifuTextbox konuTextbox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox soruTextbox;
        private Bunifu.Framework.UI.BunifuFlatButton soruekleBtn;
        private System.Windows.Forms.ComboBox konularCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource konuBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton cevapBtn;
        private Bunifu.Framework.UI.BunifuTextbox cevapTextBox;
        private System.Windows.Forms.Label label4;
    }
}
