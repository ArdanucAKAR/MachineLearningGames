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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.makeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.trainButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.mainPanels = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.mainPanels.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.mainPanel.Controls.Add(this.bunifuGradientPanel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.mainPanel.GradientBottomRight = System.Drawing.Color.White;
            this.mainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.mainPanel.GradientTopRight = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Quality = 10;
            this.mainPanel.Size = new System.Drawing.Size(1500, 750);
            this.mainPanel.TabIndex = 2;
            // 
            // makeButton
            // 
            this.makeButton.Activecolor = System.Drawing.Color.Silver;
            this.makeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.makeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeButton.BorderRadius = 0;
            this.makeButton.ButtonText = "";
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
            this.makeButton.Location = new System.Drawing.Point(877, 0);
            this.makeButton.Margin = new System.Windows.Forms.Padding(0);
            this.makeButton.Name = "makeButton";
            this.makeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.makeButton.OnHovercolor = System.Drawing.Color.Black;
            this.makeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.makeButton.selected = false;
            this.makeButton.Size = new System.Drawing.Size(53, 100);
            this.makeButton.TabIndex = 4;
            this.makeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makeButton.Textcolor = System.Drawing.Color.White;
            this.makeButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Activecolor = System.Drawing.Color.Silver;
            this.trainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.trainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainButton.BorderRadius = 0;
            this.trainButton.ButtonText = "";
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
            this.trainButton.Location = new System.Drawing.Point(776, 0);
            this.trainButton.Margin = new System.Windows.Forms.Padding(0);
            this.trainButton.Name = "trainButton";
            this.trainButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.trainButton.OnHovercolor = System.Drawing.Color.Black;
            this.trainButton.OnHoverTextColor = System.Drawing.Color.White;
            this.trainButton.selected = false;
            this.trainButton.Size = new System.Drawing.Size(50, 100);
            this.trainButton.TabIndex = 2;
            this.trainButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trainButton.Textcolor = System.Drawing.Color.White;
            this.trainButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.mainPanels);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1500, 750);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // mainPanels
            // 
            this.mainPanels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanels.BackgroundImage")));
            this.mainPanels.Controls.Add(this.panel2);
            this.mainPanels.Controls.Add(this.label1);
            this.mainPanels.Controls.Add(this.pictureBox1);
            this.mainPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanels.Location = new System.Drawing.Point(0, 0);
            this.mainPanels.Name = "mainPanels";
            this.mainPanels.Size = new System.Drawing.Size(1500, 750);
            this.mainPanels.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(639, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aslan Chatbot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.trainButton);
            this.panel2.Controls.Add(this.makeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 100);
            this.panel2.TabIndex = 5;
            // 
            // homeButton
            // 
            this.homeButton.Activecolor = System.Drawing.Color.Silver;
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.BorderRadius = 0;
            this.homeButton.ButtonText = "";
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.DisabledColor = System.Drawing.Color.Gray;
            this.homeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.homeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("homeButton.Iconimage")));
            this.homeButton.Iconimage_right = null;
            this.homeButton.Iconimage_right_Selected = null;
            this.homeButton.Iconimage_Selected = null;
            this.homeButton.IconMarginLeft = 1;
            this.homeButton.IconMarginRight = 1;
            this.homeButton.IconRightVisible = true;
            this.homeButton.IconRightZoom = 0D;
            this.homeButton.IconVisible = true;
            this.homeButton.IconZoom = 90D;
            this.homeButton.IsTab = false;
            this.homeButton.Location = new System.Drawing.Point(666, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.homeButton.OnHovercolor = System.Drawing.Color.Black;
            this.homeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.homeButton.selected = false;
            this.homeButton.Size = new System.Drawing.Size(45, 100);
            this.homeButton.TabIndex = 5;
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeButton.Textcolor = System.Drawing.Color.White;
            this.homeButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // ChatbotMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatbotMainForm";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.mainPanels.ResumeLayout(false);
            this.mainPanels.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton trainButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton makeButton;
        private Bunifu.Framework.UI.BunifuGradientPanel mainPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel mainPanels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton homeButton;
    }
}