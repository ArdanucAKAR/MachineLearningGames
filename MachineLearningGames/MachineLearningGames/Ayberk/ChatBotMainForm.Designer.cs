namespace MachineLearningGames
{
    partial class ChatbotMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatbotMainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.makeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.testButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.trainButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Snow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gainsboro;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Peru;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1000, 43);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Talk to the Lion";
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.makeButton);
            this.bunifuGradientPanel2.Controls.Add(this.testButton);
            this.bunifuGradientPanel2.Controls.Add(this.trainButton);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Orange;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 43);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(225, 532);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // makeButton
            // 
            this.makeButton.Activecolor = System.Drawing.Color.Silver;
            this.makeButton.BackColor = System.Drawing.Color.Indigo;
            this.makeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeButton.BorderRadius = 0;
            this.makeButton.ButtonText = "MAKE";
            this.makeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeButton.DisabledColor = System.Drawing.Color.Gray;
            this.makeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.makeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("makeButton.Iconimage")));
            this.makeButton.Iconimage_right = null;
            this.makeButton.Iconimage_right_Selected = null;
            this.makeButton.Iconimage_Selected = null;
            this.makeButton.IconMarginLeft = 1;
            this.makeButton.IconMarginRight = 180;
            this.makeButton.IconRightVisible = true;
            this.makeButton.IconRightZoom = 0D;
            this.makeButton.IconVisible = true;
            this.makeButton.IconZoom = 90D;
            this.makeButton.IsTab = false;
            this.makeButton.Location = new System.Drawing.Point(-3, 385);
            this.makeButton.Margin = new System.Windows.Forms.Padding(0);
            this.makeButton.Name = "makeButton";
            this.makeButton.Normalcolor = System.Drawing.Color.Indigo;
            this.makeButton.OnHovercolor = System.Drawing.Color.Black;
            this.makeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.makeButton.selected = false;
            this.makeButton.Size = new System.Drawing.Size(228, 37);
            this.makeButton.TabIndex = 4;
            this.makeButton.Text = "MAKE";
            this.makeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makeButton.Textcolor = System.Drawing.Color.White;
            this.makeButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // testButton
            // 
            this.testButton.Activecolor = System.Drawing.Color.Silver;
            this.testButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testButton.BorderRadius = 0;
            this.testButton.ButtonText = "TEST";
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.DisabledColor = System.Drawing.Color.Gray;
            this.testButton.Iconcolor = System.Drawing.Color.Transparent;
            this.testButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("testButton.Iconimage")));
            this.testButton.Iconimage_right = null;
            this.testButton.Iconimage_right_Selected = null;
            this.testButton.Iconimage_Selected = null;
            this.testButton.IconMarginLeft = 1;
            this.testButton.IconMarginRight = 180;
            this.testButton.IconRightVisible = true;
            this.testButton.IconRightZoom = 0D;
            this.testButton.IconVisible = true;
            this.testButton.IconZoom = 90D;
            this.testButton.IsTab = false;
            this.testButton.Location = new System.Drawing.Point(0, 305);
            this.testButton.Margin = new System.Windows.Forms.Padding(0);
            this.testButton.Name = "testButton";
            this.testButton.Normalcolor = System.Drawing.Color.Indigo;
            this.testButton.OnHovercolor = System.Drawing.Color.Black;
            this.testButton.OnHoverTextColor = System.Drawing.Color.White;
            this.testButton.selected = false;
            this.testButton.Size = new System.Drawing.Size(228, 37);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "TEST";
            this.testButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testButton.Textcolor = System.Drawing.Color.White;
            this.testButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Activecolor = System.Drawing.Color.Silver;
            this.trainButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainButton.BorderRadius = 0;
            this.trainButton.ButtonText = "TRAIN";
            this.trainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainButton.DisabledColor = System.Drawing.Color.Gray;
            this.trainButton.Iconcolor = System.Drawing.Color.Transparent;
            this.trainButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("trainButton.Iconimage")));
            this.trainButton.Iconimage_right = null;
            this.trainButton.Iconimage_right_Selected = null;
            this.trainButton.Iconimage_Selected = null;
            this.trainButton.IconMarginLeft = 1;
            this.trainButton.IconMarginRight = 180;
            this.trainButton.IconRightVisible = true;
            this.trainButton.IconRightZoom = 0D;
            this.trainButton.IconVisible = true;
            this.trainButton.IconZoom = 90D;
            this.trainButton.IsTab = false;
            this.trainButton.Location = new System.Drawing.Point(0, 231);
            this.trainButton.Margin = new System.Windows.Forms.Padding(0);
            this.trainButton.Name = "trainButton";
            this.trainButton.Normalcolor = System.Drawing.Color.Indigo;
            this.trainButton.OnHovercolor = System.Drawing.Color.Black;
            this.trainButton.OnHoverTextColor = System.Drawing.Color.White;
            this.trainButton.selected = false;
            this.trainButton.Size = new System.Drawing.Size(228, 37);
            this.trainButton.TabIndex = 2;
            this.trainButton.Text = "TRAIN";
            this.trainButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trainButton.Textcolor = System.Drawing.Color.White;
            this.trainButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.mainPanel.GradientBottomRight = System.Drawing.Color.White;
            this.mainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.mainPanel.GradientTopRight = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(225, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Quality = 10;
            this.mainPanel.Size = new System.Drawing.Size(775, 532);
            this.mainPanel.TabIndex = 2;
            // 
            // ChatbotMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 575);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatbotMainForm";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton trainButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton makeButton;
        private Bunifu.Framework.UI.BunifuFlatButton testButton;
        private Bunifu.Framework.UI.BunifuGradientPanel mainPanel;
    }
}