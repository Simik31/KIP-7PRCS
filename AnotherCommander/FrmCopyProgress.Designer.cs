namespace AnotherCommander
{
  partial class FrmCopyProgress
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
            this.lblFolder = new System.Windows.Forms.Label();
            this.prgFiles = new System.Windows.Forms.ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.prgBytes = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(13, 13);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(10, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "-";
            // 
            // prgFiles
            // 
            this.prgFiles.Location = new System.Drawing.Point(13, 30);
            this.prgFiles.Name = "prgFiles";
            this.prgFiles.Size = new System.Drawing.Size(660, 23);
            this.prgFiles.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(16, 60);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(10, 13);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "-";
            // 
            // prgBytes
            // 
            this.prgBytes.Location = new System.Drawing.Point(13, 77);
            this.prgBytes.Name = "prgBytes";
            this.prgBytes.Size = new System.Drawing.Size(660, 23);
            this.prgBytes.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(624, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(10, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "-";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCopyProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 118);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.prgBytes);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.prgFiles);
            this.Controls.Add(this.lblFolder);
            this.Name = "FrmCopyProgress";
            this.Text = "Probíhá kopírování...";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFolder;
    private System.Windows.Forms.ProgressBar prgFiles;
    private System.Windows.Forms.Label lblFile;
    private System.Windows.Forms.ProgressBar prgBytes;
        private System.Windows.Forms.Label lblTime;
    }
}