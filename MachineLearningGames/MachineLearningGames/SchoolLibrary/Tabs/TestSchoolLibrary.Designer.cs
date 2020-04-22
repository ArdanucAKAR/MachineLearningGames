namespace MachineLearningGames
{
    partial class TestSchoolLibrary
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSchoolLibrary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtPageTest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLineTest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtImageTest = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTestEt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblLineTest = new System.Windows.Forms.Label();
            this.lblImageTest = new System.Windows.Forms.Label();
            this.lblPageTest = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblSonuc);
            this.panel1.Controls.Add(this.lblImageTest);
            this.panel1.Controls.Add(this.lblPageTest);
            this.panel1.Controls.Add(this.lblLineTest);
            this.panel1.Controls.Add(this.btnTestEt);
            this.panel1.Controls.Add(this.txtImageTest);
            this.panel1.Controls.Add(this.txtLineTest);
            this.panel1.Controls.Add(this.txtPageTest);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 605);
            this.panel1.TabIndex = 1;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTest.Location = new System.Drawing.Point(528, 160);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(85, 39);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test";
            // 
            // txtPageTest
            // 
            this.txtPageTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPageTest.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPageTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPageTest.HintForeColor = System.Drawing.Color.Empty;
            this.txtPageTest.HintText = "";
            this.txtPageTest.isPassword = false;
            this.txtPageTest.LineFocusedColor = System.Drawing.Color.Black;
            this.txtPageTest.LineIdleColor = System.Drawing.Color.DarkRed;
            this.txtPageTest.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtPageTest.LineThickness = 3;
            this.txtPageTest.Location = new System.Drawing.Point(380, 223);
            this.txtPageTest.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageTest.Name = "txtPageTest";
            this.txtPageTest.Size = new System.Drawing.Size(379, 33);
            this.txtPageTest.TabIndex = 1;
            this.txtPageTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLineTest
            // 
            this.txtLineTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLineTest.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLineTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLineTest.HintForeColor = System.Drawing.Color.Empty;
            this.txtLineTest.HintText = "";
            this.txtLineTest.isPassword = false;
            this.txtLineTest.LineFocusedColor = System.Drawing.Color.Black;
            this.txtLineTest.LineIdleColor = System.Drawing.Color.DarkRed;
            this.txtLineTest.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtLineTest.LineThickness = 3;
            this.txtLineTest.Location = new System.Drawing.Point(380, 283);
            this.txtLineTest.Margin = new System.Windows.Forms.Padding(4);
            this.txtLineTest.Name = "txtLineTest";
            this.txtLineTest.Size = new System.Drawing.Size(379, 33);
            this.txtLineTest.TabIndex = 1;
            this.txtLineTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtImageTest
            // 
            this.txtImageTest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImageTest.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtImageTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtImageTest.HintForeColor = System.Drawing.Color.Empty;
            this.txtImageTest.HintText = "";
            this.txtImageTest.isPassword = false;
            this.txtImageTest.LineFocusedColor = System.Drawing.Color.Black;
            this.txtImageTest.LineIdleColor = System.Drawing.Color.DarkRed;
            this.txtImageTest.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtImageTest.LineThickness = 3;
            this.txtImageTest.Location = new System.Drawing.Point(380, 343);
            this.txtImageTest.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageTest.Name = "txtImageTest";
            this.txtImageTest.Size = new System.Drawing.Size(379, 33);
            this.txtImageTest.TabIndex = 1;
            this.txtImageTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTestEt
            // 
            this.btnTestEt.ActiveBorderThickness = 1;
            this.btnTestEt.ActiveCornerRadius = 20;
            this.btnTestEt.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.btnTestEt.ActiveForecolor = System.Drawing.Color.White;
            this.btnTestEt.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnTestEt.BackColor = System.Drawing.Color.Transparent;
            this.btnTestEt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTestEt.BackgroundImage")));
            this.btnTestEt.ButtonText = "TEST IT";
            this.btnTestEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestEt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestEt.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTestEt.IdleBorderThickness = 1;
            this.btnTestEt.IdleCornerRadius = 20;
            this.btnTestEt.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnTestEt.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnTestEt.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnTestEt.Location = new System.Drawing.Point(380, 405);
            this.btnTestEt.Margin = new System.Windows.Forms.Padding(5);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(388, 41);
            this.btnTestEt.TabIndex = 2;
            this.btnTestEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // lblLineTest
            // 
            this.lblLineTest.AutoSize = true;
            this.lblLineTest.BackColor = System.Drawing.Color.Transparent;
            this.lblLineTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLineTest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLineTest.Location = new System.Drawing.Point(318, 291);
            this.lblLineTest.Name = "lblLineTest";
            this.lblLineTest.Size = new System.Drawing.Size(39, 20);
            this.lblLineTest.TabIndex = 3;
            this.lblLineTest.Text = "Line";
            // 
            // lblImageTest
            // 
            this.lblImageTest.AutoSize = true;
            this.lblImageTest.BackColor = System.Drawing.Color.Transparent;
            this.lblImageTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImageTest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblImageTest.Location = new System.Drawing.Point(303, 350);
            this.lblImageTest.Name = "lblImageTest";
            this.lblImageTest.Size = new System.Drawing.Size(54, 20);
            this.lblImageTest.TabIndex = 3;
            this.lblImageTest.Text = "Image";
            // 
            // lblPageTest
            // 
            this.lblPageTest.AutoSize = true;
            this.lblPageTest.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageTest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPageTest.Location = new System.Drawing.Point(311, 230);
            this.lblPageTest.Name = "lblPageTest";
            this.lblPageTest.Size = new System.Drawing.Size(46, 20);
            this.lblPageTest.TabIndex = 3;
            this.lblPageTest.Text = "Page";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSonuc.Location = new System.Drawing.Point(1002, 281);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(77, 24);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "SONUÇ";
            // 
            // TestSchoolLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Name = "TestSchoolLibrary";
            this.Size = new System.Drawing.Size(1500, 605);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblImageTest;
        private System.Windows.Forms.Label lblPageTest;
        private System.Windows.Forms.Label lblLineTest;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTestEt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtImageTest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLineTest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPageTest;
        private System.Windows.Forms.Label lblTest;
    }
}
