namespace MachineLearningGames
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddWalk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddCar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCycle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(114, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 624);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Walk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddWalk
            // 
            this.btnAddWalk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddWalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddWalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddWalk.BorderRadius = 0;
            this.btnAddWalk.ButtonText = "Add Walk";
            this.btnAddWalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWalk.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddWalk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddWalk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddWalk.Iconimage")));
            this.btnAddWalk.Iconimage_right = null;
            this.btnAddWalk.Iconimage_right_Selected = null;
            this.btnAddWalk.Iconimage_Selected = null;
            this.btnAddWalk.IconMarginLeft = 0;
            this.btnAddWalk.IconMarginRight = 0;
            this.btnAddWalk.IconRightVisible = true;
            this.btnAddWalk.IconRightZoom = 0D;
            this.btnAddWalk.IconVisible = true;
            this.btnAddWalk.IconZoom = 90D;
            this.btnAddWalk.IsTab = false;
            this.btnAddWalk.Location = new System.Drawing.Point(287, 646);
            this.btnAddWalk.Name = "btnAddWalk";
            this.btnAddWalk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddWalk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddWalk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddWalk.selected = false;
            this.btnAddWalk.Size = new System.Drawing.Size(162, 42);
            this.btnAddWalk.TabIndex = 1;
            this.btnAddWalk.Text = "Add Walk";
            this.btnAddWalk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWalk.Textcolor = System.Drawing.Color.White;
            this.btnAddWalk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWalk.Click += new System.EventHandler(this.btnAddWalk_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCar.BorderRadius = 0;
            this.btnAddCar.ButtonText = "Add Car";
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Iconimage")));
            this.btnAddCar.Iconimage_right = null;
            this.btnAddCar.Iconimage_right_Selected = null;
            this.btnAddCar.Iconimage_Selected = null;
            this.btnAddCar.IconMarginLeft = 0;
            this.btnAddCar.IconMarginRight = 0;
            this.btnAddCar.IconRightVisible = true;
            this.btnAddCar.IconRightZoom = 0D;
            this.btnAddCar.IconVisible = true;
            this.btnAddCar.IconZoom = 90D;
            this.btnAddCar.IsTab = false;
            this.btnAddCar.Location = new System.Drawing.Point(756, 646);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddCar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCar.selected = false;
            this.btnAddCar.Size = new System.Drawing.Size(162, 42);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.Textcolor = System.Drawing.Color.White;
            this.btnAddCar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(583, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 624);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddCycle
            // 
            this.btnAddCycle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCycle.BorderRadius = 0;
            this.btnAddCycle.ButtonText = "Add Cycle";
            this.btnAddCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCycle.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCycle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCycle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCycle.Iconimage")));
            this.btnAddCycle.Iconimage_right = null;
            this.btnAddCycle.Iconimage_right_Selected = null;
            this.btnAddCycle.Iconimage_Selected = null;
            this.btnAddCycle.IconMarginLeft = 0;
            this.btnAddCycle.IconMarginRight = 0;
            this.btnAddCycle.IconRightVisible = true;
            this.btnAddCycle.IconRightZoom = 0D;
            this.btnAddCycle.IconVisible = true;
            this.btnAddCycle.IconZoom = 90D;
            this.btnAddCycle.IsTab = false;
            this.btnAddCycle.Location = new System.Drawing.Point(1181, 646);
            this.btnAddCycle.Name = "btnAddCycle";
            this.btnAddCycle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCycle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddCycle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCycle.selected = false;
            this.btnAddCycle.Size = new System.Drawing.Size(162, 42);
            this.btnAddCycle.TabIndex = 5;
            this.btnAddCycle.Text = "Add Cycle";
            this.btnAddCycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCycle.Textcolor = System.Drawing.Color.White;
            this.btnAddCycle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1008, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(335, 624);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cycle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent; 
            this.BackgroundImage = global::MachineLearningGames.Properties.Resources._1500x705;
            this.Controls.Add(this.btnAddCycle);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnAddWalk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(1500, 705);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddWalk;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCycle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
    }
}
