namespace RegistrationServicePlatform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.register_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.search_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.browser_toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.calculator_toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.about_toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.exit_toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.process1 = new System.Diagnostics.Process();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.register_toolStripButton1,
            this.toolStripSeparator2,
            this.search_toolStripButton2,
            this.toolStripSeparator3,
            this.browser_toolStripButton3,
            this.toolStripSeparator4,
            this.calculator_toolStripButton4,
            this.toolStripSeparator1,
            this.about_toolStripButton5,
            this.exit_toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // register_toolStripButton1
            // 
            this.register_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("register_toolStripButton1.Image")));
            this.register_toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.register_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.register_toolStripButton1.Name = "register_toolStripButton1";
            this.register_toolStripButton1.Size = new System.Drawing.Size(133, 55);
            this.register_toolStripButton1.Text = "Register Data | F1";
            this.register_toolStripButton1.Click += new System.EventHandler(this.register_toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // search_toolStripButton2
            // 
            this.search_toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("search_toolStripButton2.Image")));
            this.search_toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.search_toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_toolStripButton2.Name = "search_toolStripButton2";
            this.search_toolStripButton2.Size = new System.Drawing.Size(99, 55);
            this.search_toolStripButton2.Text = "Search | F2";
            this.search_toolStripButton2.Click += new System.EventHandler(this.search_toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // browser_toolStripButton3
            // 
            this.browser_toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("browser_toolStripButton3.Image")));
            this.browser_toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.browser_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browser_toolStripButton3.Name = "browser_toolStripButton3";
            this.browser_toolStripButton3.Size = new System.Drawing.Size(106, 55);
            this.browser_toolStripButton3.Text = "Browser | F3";
            this.browser_toolStripButton3.Click += new System.EventHandler(this.browser_toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // calculator_toolStripButton4
            // 
            this.calculator_toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("calculator_toolStripButton4.Image")));
            this.calculator_toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.calculator_toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calculator_toolStripButton4.Name = "calculator_toolStripButton4";
            this.calculator_toolStripButton4.Size = new System.Drawing.Size(111, 55);
            this.calculator_toolStripButton4.Text = "Calculator | F4";
            this.calculator_toolStripButton4.Click += new System.EventHandler(this.calculator_toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // about_toolStripButton5
            // 
            this.about_toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("about_toolStripButton5.Image")));
            this.about_toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_toolStripButton5.Name = "about_toolStripButton5";
            this.about_toolStripButton5.Size = new System.Drawing.Size(97, 55);
            this.about_toolStripButton5.Text = "About | F5";
            this.about_toolStripButton5.Click += new System.EventHandler(this.about_toolStripButton5_Click);
            // 
            // exit_toolStripButton6
            // 
            this.exit_toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("exit_toolStripButton6.Image")));
            this.exit_toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exit_toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit_toolStripButton6.Name = "exit_toolStripButton6";
            this.exit_toolStripButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exit_toolStripButton6.Size = new System.Drawing.Size(91, 55);
            this.exit_toolStripButton6.Text = "Exit | ESC";
            this.exit_toolStripButton6.Click += new System.EventHandler(this.exit_toolStripButton6_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Service Platform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton register_toolStripButton1;
        private System.Windows.Forms.ToolStripButton search_toolStripButton2;
        private System.Windows.Forms.ToolStripButton browser_toolStripButton3;
        private System.Windows.Forms.ToolStripButton calculator_toolStripButton4;
        private System.Windows.Forms.ToolStripButton about_toolStripButton5;
        private System.Windows.Forms.ToolStripButton exit_toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Diagnostics.Process process1;
    }
}

