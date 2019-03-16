using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Handling the orientation Exif tag in images using C#
// http://cyotek.com/blog/handling-the-orientation-exif-tag-in-images-using-csharp
// Copyright © 2019 Cyotek Ltd. All Rights Reserved.

// This work is licensed under the Creative Commons Attribution 4.0 International License.
// To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

// Found this example useful? 
// https://www.paypal.me/cyotek

namespace Cyotek.Demo.ExifOrientation
{
  internal partial class MainForm : Form
  {
    #region Fields

    private Image _clonedImage;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Properties

    private string SamplePath
    {
      get { return Path.Combine(Application.StartupPath, "samples"); }
    }

    #endregion

    #region Methods

    public int GetExifOrientation(Image image)
    {
      int result;

      result = Array.IndexOf(image.PropertyIdList, ImageExtensions.ExifOrientationTagId) > -1 ? image.GetPropertyItem(ImageExtensions.ExifOrientationTagId).Value[0] : 0;

      return result;
    }

    public void OpenImage(string fileName)
    {
      Image image;
      Image rotatedImage;

      image = Image.FromFile(fileName);

      this.CleanUp();
      this.LoadFileInfo(image);

      rotatedImage = this.CreateRotatedImage(image);

      originalImageBox.Image = image;
      rotatedImageBox.Image = rotatedImage;

      originalImageBox.ZoomToFit();
      rotatedImageBox.ZoomToFit();

      rotatedImageBox.Text = rotatedImage != null ? string.Empty : "Orientation attribute not present";
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);

      if (!e.Cancel)
      {
        this.CleanUp();
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      if (!this.DesignMode)
      {
        this.Font = SystemFonts.DialogFont;
      }

      this.Text = Application.ProductName;
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      //new DemoBuilder().Build(Path.Combine(this.SamplePath, "Sample.jpg"), this.SamplePath);

      this.LoadSampleFilesList();

      if (sampleFilesListBox.Items.Count != 0)
      {
        sampleFilesListBox.SelectedIndex = 0;
      }
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        dialog.ShowDialog();
      }
    }

    private void CleanUp()
    {
      originalImageBox.Image = null;
      rotatedImageBox.Image = null;

      if (_clonedImage != null)
      {
        _clonedImage.Dispose();
        _clonedImage = null;
      }
    }

    private Image CreateRotatedImage(Image image)
    {
      Image result;

      if (this.GetExifOrientation(image) != 0)
      {
        result = (Image)image.Clone();
        result.NormalizeOrientation();
      }
      else
      {
        result = null;
      }

      return result;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      horizontalToolStripMenuItem.Checked = !horizontalToolStripMenuItem.Checked;

      previewSplitContainer.Orientation = horizontalToolStripMenuItem.Checked ? Orientation.Horizontal : Orientation.Vertical;
    }

    private void LoadFileInfo(Image image)
    {
      int orientation;
      string value;

      orientation = this.GetExifOrientation(image);
      value = orientation != 0 ? orientation.ToString() : "Not present";

      orientationLabel.Text = value;
    }

    private void LoadSampleFilesList()
    {
      string path;

      path = this.SamplePath;

      sampleFilesListBox.BeginUpdate();

      if (Directory.Exists(path))
      {
        foreach (string fileName in Directory.EnumerateFiles(path, "*.jpg"))
        {
          sampleFilesListBox.Items.Add(new FileInfo(fileName));
        }
      }

      sampleFilesListBox.EndUpdate();
    }

    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
    { }

    private void SampleFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (sampleFilesListBox.SelectedIndex != -1)
      {
        FileInfo fileInfo;

        fileInfo = (FileInfo)sampleFilesListBox.SelectedItem;

        this.OpenImage(fileInfo.FullPath);
      }
    }

    #endregion
  }
}
