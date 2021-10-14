namespace SemaphoreLib
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
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.semSemaphore = new SemaphoreLib.Semaphore();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(212, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(200, 35);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(12, 12);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(200, 35);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrder.Location = new System.Drawing.Point(12, 50);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(86, 31);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "label1";
            // 
            // semSemaphore
            // 
            this.semSemaphore.Location = new System.Drawing.Point(12, 84);
            this.semSemaphore.Mode = SemaphoreLib.Semaphore.EMode.Off;
            this.semSemaphore.Name = "semSemaphore";
            this.semSemaphore.Size = new System.Drawing.Size(400, 400);
            this.semSemaphore.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 496);
            this.Controls.Add(this.semSemaphore);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Name = "Form1";
            this.Text = "R19584";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnOff;
    private System.Windows.Forms.Button btnOn;
    private System.Windows.Forms.Label lblOrder;
        private Semaphore semSemaphore;
    }
}

