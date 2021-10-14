namespace PeopleDatabase
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
      this.grd = new System.Windows.Forms.DataGridView();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // grd
      // 
      this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grd.AutoGenerateColumns = false;
      this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
      this.grd.DataSource = this.personBindingSource;
      this.grd.Location = new System.Drawing.Point(12, 12);
      this.grd.Name = "grd";
      this.grd.Size = new System.Drawing.Size(950, 573);
      this.grd.TabIndex = 0;
      this.grd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grd_RowHeaderMouseClick);
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // surnameDataGridViewTextBoxColumn
      // 
      this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
      this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
      this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
      // 
      // ageDataGridViewTextBoxColumn
      // 
      this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
      this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
      this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
      // 
      // personBindingSource
      // 
      this.personBindingSource.DataSource = typeof(PeopleDatabase.Person);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(974, 597);
      this.Controls.Add(this.grd);
      this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView grd;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource personBindingSource;
  }
}

