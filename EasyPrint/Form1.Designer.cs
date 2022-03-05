namespace EasyPrint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeCB = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dirButton = new System.Windows.Forms.Button();
            this.dirlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.hlabel = new System.Windows.Forms.Label();
            this.wlabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Snap (F8)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Minimized";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "This works";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "Maximize";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // minimizeCB
            // 
            this.minimizeCB.AutoSize = true;
            this.minimizeCB.Location = new System.Drawing.Point(12, 12);
            this.minimizeCB.Name = "minimizeCB";
            this.minimizeCB.Size = new System.Drawing.Size(169, 17);
            this.minimizeCB.TabIndex = 1;
            this.minimizeCB.Text = "Minimize to tray when closing?";
            this.minimizeCB.UseVisualStyleBackColor = true;
            this.minimizeCB.CheckedChanged += new System.EventHandler(this.minimizeCB_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // dirButton
            // 
            this.dirButton.Location = new System.Drawing.Point(12, 48);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(159, 23);
            this.dirButton.TabIndex = 2;
            this.dirButton.Text = "Save to...";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.dirButton_Click);
            // 
            // dirlabel
            // 
            this.dirlabel.AutoSize = true;
            this.dirlabel.Location = new System.Drawing.Point(12, 32);
            this.dirlabel.Name = "dirlabel";
            this.dirlabel.Size = new System.Drawing.Size(0, 13);
            this.dirlabel.TabIndex = 3;
            this.dirlabel.TextChanged += new System.EventHandler(this.dirlabel_TextChanged);
            this.dirlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select custom area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Fullscreen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(27, 101);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(32, 13);
            this.xlabel.TabIndex = 6;
            this.xlabel.Text = "X = 0";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(27, 114);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(32, 13);
            this.ylabel.TabIndex = 7;
            this.ylabel.Text = "Y = 0";
            this.ylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // hlabel
            // 
            this.hlabel.AutoSize = true;
            this.hlabel.Location = new System.Drawing.Point(97, 101);
            this.hlabel.Name = "hlabel";
            this.hlabel.Size = new System.Drawing.Size(56, 13);
            this.hlabel.TabIndex = 8;
            this.hlabel.Text = "Height = 0";
            // 
            // wlabel
            // 
            this.wlabel.AutoSize = true;
            this.wlabel.Location = new System.Drawing.Point(97, 114);
            this.wlabel.Name = "wlabel";
            this.wlabel.Size = new System.Drawing.Size(53, 13);
            this.wlabel.TabIndex = 9;
            this.wlabel.Text = "Width = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 212);
            this.Controls.Add(this.wlabel);
            this.Controls.Add(this.hlabel);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dirlabel);
            this.Controls.Add(this.dirButton);
            this.Controls.Add(this.minimizeCB);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "EasySnap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox minimizeCB;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.Label dirlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label hlabel;
        private System.Windows.Forms.Label wlabel;
    }
}

