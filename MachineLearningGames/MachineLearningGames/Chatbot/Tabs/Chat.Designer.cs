namespace MachineLearningGames.Chatbot.Tabs
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.btnAskLion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.soruTextbx = new Bunifu.Framework.UI.BunifuTextbox();
            this.cvpLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAskLion
            // 
            this.btnAskLion.Activecolor = System.Drawing.Color.Gray;
            this.btnAskLion.BackColor = System.Drawing.Color.Gray;
            this.btnAskLion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAskLion.BorderRadius = 0;
            this.btnAskLion.ButtonText = "Aslana sor";
            this.btnAskLion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAskLion.DisabledColor = System.Drawing.Color.Gray;
            this.btnAskLion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAskLion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAskLion.Iconimage")));
            this.btnAskLion.Iconimage_right = null;
            this.btnAskLion.Iconimage_right_Selected = null;
            this.btnAskLion.Iconimage_Selected = null;
            this.btnAskLion.IconMarginLeft = 0;
            this.btnAskLion.IconMarginRight = 0;
            this.btnAskLion.IconRightVisible = true;
            this.btnAskLion.IconRightZoom = 0D;
            this.btnAskLion.IconVisible = true;
            this.btnAskLion.IconZoom = 90D;
            this.btnAskLion.IsTab = false;
            this.btnAskLion.Location = new System.Drawing.Point(648, 440);
            this.btnAskLion.Name = "btnAskLion";
            this.btnAskLion.Normalcolor = System.Drawing.Color.Gray;
            this.btnAskLion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAskLion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAskLion.selected = false;
            this.btnAskLion.Size = new System.Drawing.Size(241, 28);
            this.btnAskLion.TabIndex = 3;
            this.btnAskLion.Text = "Aslana sor";
            this.btnAskLion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAskLion.Textcolor = System.Drawing.Color.White;
            this.btnAskLion.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAskLion.Click += new System.EventHandler(this.btnAskLion_Click);
            // 
            // soruTextbx
            // 
            this.soruTextbx.BackColor = System.Drawing.Color.Silver;
            this.soruTextbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soruTextbx.BackgroundImage")));
            this.soruTextbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soruTextbx.ForeColor = System.Drawing.Color.Black;
            this.soruTextbx.Icon = ((System.Drawing.Image)(resources.GetObject("soruTextbx.Icon")));
            this.soruTextbx.Location = new System.Drawing.Point(635, 179);
            this.soruTextbx.Name = "soruTextbx";
            this.soruTextbx.Size = new System.Drawing.Size(263, 34);
            this.soruTextbx.TabIndex = 2;
            this.soruTextbx.text = "Sormak istediğini buraya yaz.";
            // 
            // cvpLabel
            // 
            this.cvpLabel.BackColor = System.Drawing.Color.Silver;
            this.cvpLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cvpLabel.Location = new System.Drawing.Point(470, 229);
            this.cvpLabel.Name = "cvpLabel";
            this.cvpLabel.Size = new System.Drawing.Size(575, 183);
            this.cvpLabel.TabIndex = 1;
            this.cvpLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cvpLabel.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1246, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 650);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAskLion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cvpLabel);
            this.panel1.Controls.Add(this.soruTextbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 650);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 650);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(1500, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cvpLabel;
        private Bunifu.Framework.UI.BunifuTextbox soruTextbx;
        private Bunifu.Framework.UI.BunifuFlatButton btnAskLion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
