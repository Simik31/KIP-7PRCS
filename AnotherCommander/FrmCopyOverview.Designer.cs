namespace AnotherCommander
{
  partial class FrmCopyOverview
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
      this.plnBottom = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnLater = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.lvwRequests = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.plnBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // plnBottom
      // 
      this.plnBottom.Controls.Add(this.btnCancel);
      this.plnBottom.Controls.Add(this.btnLater);
      this.plnBottom.Controls.Add(this.btnStart);
      this.plnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.plnBottom.Location = new System.Drawing.Point(0, 402);
      this.plnBottom.Name = "plnBottom";
      this.plnBottom.Size = new System.Drawing.Size(800, 48);
      this.plnBottom.TabIndex = 0;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Location = new System.Drawing.Point(521, 6);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(85, 30);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnLater
      // 
      this.btnLater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLater.Location = new System.Drawing.Point(612, 6);
      this.btnLater.Name = "btnLater";
      this.btnLater.Size = new System.Drawing.Size(85, 30);
      this.btnLater.TabIndex = 1;
      this.btnLater.Text = "&Later";
      this.btnLater.UseVisualStyleBackColor = true;
      this.btnLater.Click += new System.EventHandler(this.btnLater_Click);
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.Location = new System.Drawing.Point(703, 6);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(85, 30);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "&Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lvwRequests
      // 
      this.lvwRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.lvwRequests.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvwRequests.HideSelection = false;
      this.lvwRequests.Location = new System.Drawing.Point(0, 0);
      this.lvwRequests.Name = "lvwRequests";
      this.lvwRequests.Size = new System.Drawing.Size(800, 402);
      this.lvwRequests.TabIndex = 1;
      this.lvwRequests.UseCompatibleStateImageBehavior = false;
      this.lvwRequests.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 360;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Size";
      this.columnHeader2.Width = 120;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Source";
      this.columnHeader3.Width = 300;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Target";
      this.columnHeader4.Width = 300;
      // 
      // FrmCopyOverview
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lvwRequests);
      this.Controls.Add(this.plnBottom);
      this.Name = "FrmCopyOverview";
      this.Text = "Kopírovací fronta";
      this.plnBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel plnBottom;
    private System.Windows.Forms.ListView lvwRequests;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnLater;
    private System.Windows.Forms.Button btnStart;
  }
}