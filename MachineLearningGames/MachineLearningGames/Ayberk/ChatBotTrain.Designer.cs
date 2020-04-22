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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotTrain));
            this.trainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainPanel
            // 
            this.trainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trainPanel.BackgroundImage")));
            this.trainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to know?";
            // 
            // ChatBotTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trainPanel);
            this.Name = "ChatBotTrain";
            this.Size = new System.Drawing.Size(775, 532);
            this.trainPanel.ResumeLayout(false);
            this.trainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel trainPanel;
        private System.Windows.Forms.Label label1;
    }
}
