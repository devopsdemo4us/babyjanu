namespace Cyotek.Demo.ExifOrientation
{
  partial class MainForm
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
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.dataSplitContainer = new System.Windows.Forms.SplitContainer();
      this.sampleFilesGroupBox = new System.Windows.Forms.GroupBox();
      this.sampleFilesListBox = new System.Windows.Forms.ListBox();
      this.attributesGroupBox = new System.Windows.Forms.GroupBox();
      this.orientationLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.previewSplitContainer = new System.Windows.Forms.SplitContainer();
      this.originalImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.label1 = new System.Windows.Forms.Label();
      this.rotatedImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.label2 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).BeginInit();
      this.dataSplitContainer.Panel1.SuspendLayout();
      this.dataSplitContainer.Panel2.SuspendLayout();
      this.dataSplitContainer.SuspendLayout();
      this.sampleFilesGroupBox.SuspendLayout();
      this.attributesGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).BeginInit();
      this.previewSplitContainer.Panel1.SuspendLayout();
      this.previewSplitContainer.Panel2.SuspendLayout();
      this.previewSplitContainer.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer.Location = new System.Drawing.Point(0, 24);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.dataSplitContainer);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.previewSplitContainer);
      this.splitContainer.Size = new System.Drawing.Size(1008, 705);
      this.splitContainer.SplitterDistance = 250;
      this.splitContainer.TabIndex = 0;
      // 
      // dataSplitContainer
      // 
      this.dataSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.dataSplitContainer.Name = "dataSplitContainer";
      this.dataSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // dataSplitContainer.Panel1
      // 
      this.dataSplitContainer.Panel1.Controls.Add(this.sampleFilesGroupBox);
      // 
      // dataSplitContainer.Panel2
      // 
      this.dataSplitContainer.Panel2.Controls.Add(this.attributesGroupBox);
      this.dataSplitContainer.Size = new System.Drawing.Size(250, 705);
      this.dataSplitContainer.SplitterDistance = 338;
      this.dataSplitContainer.TabIndex = 3;
      // 
      // sampleFilesGroupBox
      // 
      this.sampleFilesGroupBox.Controls.Add(this.sampleFilesListBox);
      this.sampleFilesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sampleFilesGroupBox.Location = new System.Drawing.Point(0, 0);
      this.sampleFilesGroupBox.Name = "sampleFilesGroupBox";
      this.sampleFilesGroupBox.Size = new System.Drawing.Size(250, 338);
      this.sampleFilesGroupBox.TabIndex = 2;
      this.sampleFilesGroupBox.TabStop = false;
      this.sampleFilesGroupBox.Text = "Sample Files";
      // 
      // sampleFilesListBox
      // 
      this.sampleFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sampleFilesListBox.FormattingEnabled = true;
      this.sampleFilesListBox.IntegralHeight = false;
      this.sampleFilesListBox.Location = new System.Drawing.Point(6, 19);
      this.sampleFilesListBox.Name = "sampleFilesListBox";
      this.sampleFilesListBox.Size = new System.Drawing.Size(238, 313);
      this.sampleFilesListBox.TabIndex = 1;
      this.sampleFilesListBox.SelectedIndexChanged += new System.EventHandler(this.SampleFilesListBox_SelectedIndexChanged);
      // 
      // attributesGroupBox
      // 
      this.attributesGroupBox.Controls.Add(this.orientationLabel);
      this.attributesGroupBox.Controls.Add(this.label3);
      this.attributesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.attributesGroupBox.Location = new System.Drawing.Point(0, 0);
      this.attributesGroupBox.Name = "attributesGroupBox";
      this.attributesGroupBox.Size = new System.Drawing.Size(250, 363);
      this.attributesGroupBox.TabIndex = 0;
      this.attributesGroupBox.TabStop = false;
      this.attributesGroupBox.Text = "File Information";
      // 
      // orientationLabel
      // 
      this.orientationLabel.AutoSize = true;
      this.orientationLabel.Location = new System.Drawing.Point(127, 23);
      this.orientationLabel.Name = "orientationLabel";
      this.orientationLabel.Size = new System.Drawing.Size(0, 13);
      this.orientationLabel.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(109, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Orientation EXIF Tag:";
      // 
      // previewSplitContainer
      // 
      this.previewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.previewSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.previewSplitContainer.Name = "previewSplitContainer";
      this.previewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // previewSplitContainer.Panel1
      // 
      this.previewSplitContainer.Panel1.Controls.Add(this.originalImageBox);
      this.previewSplitContainer.Panel1.Controls.Add(this.label1);
      // 
      // previewSplitContainer.Panel2
      // 
      this.previewSplitContainer.Panel2.Controls.Add(this.rotatedImageBox);
      this.previewSplitContainer.Panel2.Controls.Add(this.label2);
      this.previewSplitContainer.Size = new System.Drawing.Size(754, 705);
      this.previewSplitContainer.SplitterDistance = 361;
      this.previewSplitContainer.TabIndex = 0;
      // 
      // originalImageBox
      // 
      this.originalImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.originalImageBox.Location = new System.Drawing.Point(0, 0);
      this.originalImageBox.Name = "originalImageBox";
      this.originalImageBox.Size = new System.Drawing.Size(754, 328);
      this.originalImageBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.Info;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
      this.label1.Location = new System.Drawing.Point(0, 328);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(754, 33);
      this.label1.TabIndex = 1;
      this.label1.Text = "Orientation EXIF tag ignored";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rotatedImageBox
      // 
      this.rotatedImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rotatedImageBox.Location = new System.Drawing.Point(0, 0);
      this.rotatedImageBox.Name = "rotatedImageBox";
      this.rotatedImageBox.Size = new System.Drawing.Size(754, 307);
      this.rotatedImageBox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.Info;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
      this.label2.Location = new System.Drawing.Point(0, 307);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(754, 33);
      this.label2.TabIndex = 2;
      this.label2.Text = "Orientation EXIF tag handled";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.openToolStripMenuItem.Text = "&Open...";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // horizontalToolStripMenuItem
      // 
      this.horizontalToolStripMenuItem.Checked = true;
      this.horizontalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
      this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.horizontalToolStripMenuItem.Text = "Horizontal";
      this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "cyotek.com EXIF Orientation Demonstration";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
      this.splitContainer.ResumeLayout(false);
      this.dataSplitContainer.Panel1.ResumeLayout(false);
      this.dataSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).EndInit();
      this.dataSplitContainer.ResumeLayout(false);
      this.sampleFilesGroupBox.ResumeLayout(false);
      this.attributesGroupBox.ResumeLayout(false);
      this.attributesGroupBox.PerformLayout();
      this.previewSplitContainer.Panel1.ResumeLayout(false);
      this.previewSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.previewSplitContainer)).EndInit();
      this.previewSplitContainer.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.SplitContainer previewSplitContainer;
    private Cyotek.Windows.Forms.ImageBox originalImageBox;
    private Windows.Forms.ImageBox rotatedImageBox;
    private System.Windows.Forms.ListBox sampleFilesListBox;
    private System.Windows.Forms.SplitContainer dataSplitContainer;
    private System.Windows.Forms.GroupBox sampleFilesGroupBox;
    private System.Windows.Forms.GroupBox attributesGroupBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.Label orientationLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
  }
}

