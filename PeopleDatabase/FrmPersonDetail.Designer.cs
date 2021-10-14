namespace PeopleDatabase
{
  partial class FrmPersonDetail
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
      this.propertyGrid = new System.Windows.Forms.PropertyGrid();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.txtNameSurname = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // propertyGrid
      // 
      this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.propertyGrid.Location = new System.Drawing.Point(12, 12);
      this.propertyGrid.Name = "propertyGrid";
      this.propertyGrid.Size = new System.Drawing.Size(525, 345);
      this.propertyGrid.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 569);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Jméno";
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Name", true));
      this.textBox1.Location = new System.Drawing.Point(93, 566);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(224, 20);
      this.textBox1.TabIndex = 2;
      // 
      // personBindingSource
      // 
      this.personBindingSource.DataSource = typeof(PeopleDatabase.Person);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 370);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Jméno i příjmení:";
      // 
      // txtNameSurname
      // 
      this.txtNameSurname.Location = new System.Drawing.Point(107, 367);
      this.txtNameSurname.Name = "txtNameSurname";
      this.txtNameSurname.Size = new System.Drawing.Size(430, 20);
      this.txtNameSurname.TabIndex = 4;
      // 
      // FrmPersonDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 598);
      this.Controls.Add(this.txtNameSurname);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.propertyGrid);
      this.Name = "FrmPersonDetail";
      this.Text = "FrmPersonDetail";
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PropertyGrid propertyGrid;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.BindingSource personBindingSource;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNameSurname;
  }
}