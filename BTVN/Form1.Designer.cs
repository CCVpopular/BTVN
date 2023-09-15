namespace BTVN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            scaleToFit = new ToolStripMenuItem();
            stretchToFit = new ToolStripMenuItem();
            actualSize = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            Label2 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { open, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // open
            // 
            open.Image = (Image)resources.GetObject("open.Image");
            open.Name = "open";
            open.ShortcutKeys = Keys.Control | Keys.O;
            open.Size = new Size(224, 26);
            open.Text = "Open";
            open.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scaleToFit, stretchToFit, actualSize });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(134, 26);
            imageToolStripMenuItem.Text = "Image";
            // 
            // scaleToFit
            // 
            scaleToFit.Checked = true;
            scaleToFit.CheckOnClick = true;
            scaleToFit.CheckState = CheckState.Checked;
            scaleToFit.Name = "scaleToFit";
            scaleToFit.RightToLeftAutoMirrorImage = true;
            scaleToFit.Size = new Size(176, 26);
            scaleToFit.Text = "Scale to Fit";
            scaleToFit.Click += scaleToFitToolStripMenuItem_Click;
            scaleToFit.DisplayStyleChanged += scaleToFitToolStripMenuItem_Click;
            // 
            // stretchToFit
            // 
            stretchToFit.Name = "stretchToFit";
            stretchToFit.Size = new Size(176, 26);
            stretchToFit.Text = "Stretch to Fit";
            stretchToFit.Click += stretchToFitToolStripMenuItem_Click;
            // 
            // actualSize
            // 
            actualSize.CheckOnClick = true;
            actualSize.Name = "actualSize";
            actualSize.Size = new Size(176, 26);
            actualSize.Text = "Actual Size";
            actualSize.Click += actualSizeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(887, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, Label2, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 426);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(887, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(329, 22);
            toolStripLabel1.Text = "                                                                                ";
            toolStripLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.Alignment = ToolStripItemAlignment.Right;
            Label2.Name = "Label2";
            Label2.Size = new Size(0, 22);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(93, 22);
            toolStripLabel2.Text = "                     ";
            toolStripLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 451);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem open;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem scaleToFit;
        private ToolStripMenuItem stretchToFit;
        private ToolStripMenuItem actualSize;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel Label2;
        private ToolStripLabel toolStripLabel2;
    }
}