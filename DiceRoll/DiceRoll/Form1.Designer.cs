
namespace DiceRoll
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
            this.BtnRoll = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.TextBox();
            this.history5 = new DiceRoll.Dice();
            this.history4 = new DiceRoll.Dice();
            this.history3 = new DiceRoll.Dice();
            this.history2 = new DiceRoll.Dice();
            this.history1 = new DiceRoll.Dice();
            this.dice7 = new DiceRoll.Dice();
            this.dice6 = new DiceRoll.Dice();
            this.dice5 = new DiceRoll.Dice();
            this.dice4 = new DiceRoll.Dice();
            this.dice3 = new DiceRoll.Dice();
            this.dice2 = new DiceRoll.Dice();
            this.history0 = new DiceRoll.Dice();
            this.dice1 = new DiceRoll.Dice();
            this.SuspendLayout();
            // 
            // BtnRoll
            // 
            this.BtnRoll.Font = new System.Drawing.Font("Consolas", 14F);
            this.BtnRoll.Location = new System.Drawing.Point(7, 224);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(205, 29);
            this.BtnRoll.TabIndex = 7;
            this.BtnRoll.Text = "Roll";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRoll_Click);
            // 
            // Label1
            // 
            this.Label1.Enabled = false;
            this.Label1.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label1.Location = new System.Drawing.Point(254, 48);
            this.Label1.Name = "Label1";
            this.Label1.ReadOnly = true;
            this.Label1.ShortcutsEnabled = false;
            this.Label1.Size = new System.Drawing.Size(174, 29);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "0 (  0.000%)";
            // 
            // Label4
            // 
            this.Label4.Enabled = false;
            this.Label4.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label4.Location = new System.Drawing.Point(254, 153);
            this.Label4.Name = "Label4";
            this.Label4.ReadOnly = true;
            this.Label4.ShortcutsEnabled = false;
            this.Label4.Size = new System.Drawing.Size(174, 29);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "0 (  0.000%)";
            // 
            // Label5
            // 
            this.Label5.Enabled = false;
            this.Label5.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label5.Location = new System.Drawing.Point(254, 188);
            this.Label5.Name = "Label5";
            this.Label5.ReadOnly = true;
            this.Label5.ShortcutsEnabled = false;
            this.Label5.Size = new System.Drawing.Size(174, 29);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "0 (  0.000%)";
            // 
            // Label6
            // 
            this.Label6.Enabled = false;
            this.Label6.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label6.Location = new System.Drawing.Point(254, 223);
            this.Label6.Name = "Label6";
            this.Label6.ReadOnly = true;
            this.Label6.ShortcutsEnabled = false;
            this.Label6.Size = new System.Drawing.Size(174, 29);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "0 (  0.000%)";
            // 
            // Label3
            // 
            this.Label3.Enabled = false;
            this.Label3.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label3.Location = new System.Drawing.Point(254, 118);
            this.Label3.Name = "Label3";
            this.Label3.ReadOnly = true;
            this.Label3.ShortcutsEnabled = false;
            this.Label3.Size = new System.Drawing.Size(174, 29);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "0 (  0.000%)";
            // 
            // Label2
            // 
            this.Label2.Enabled = false;
            this.Label2.Font = new System.Drawing.Font("Consolas", 14F);
            this.Label2.Location = new System.Drawing.Point(254, 83);
            this.Label2.Name = "Label2";
            this.Label2.ReadOnly = true;
            this.Label2.ShortcutsEnabled = false;
            this.Label2.Size = new System.Drawing.Size(174, 29);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "0 (  0.000%)";
            // 
            // history5
            // 
            this.history5.DiceDotSpacing = 0.03F;
            this.history5.Location = new System.Drawing.Point(398, 12);
            this.history5.Name = "history5";
            this.history5.Size = new System.Drawing.Size(30, 30);
            this.history5.State = DiceRoll.Dice.EState.DesigMode;
            this.history5.TabIndex = 15;
            this.history5.Value = 7;
            // 
            // history4
            // 
            this.history4.DiceDotSpacing = 0.03F;
            this.history4.Location = new System.Drawing.Point(362, 12);
            this.history4.Name = "history4";
            this.history4.Size = new System.Drawing.Size(30, 30);
            this.history4.State = DiceRoll.Dice.EState.DesigMode;
            this.history4.TabIndex = 15;
            this.history4.Value = 7;
            // 
            // history3
            // 
            this.history3.DiceDotSpacing = 0.03F;
            this.history3.Location = new System.Drawing.Point(326, 12);
            this.history3.Name = "history3";
            this.history3.Size = new System.Drawing.Size(30, 30);
            this.history3.State = DiceRoll.Dice.EState.DesigMode;
            this.history3.TabIndex = 15;
            this.history3.Value = 7;
            // 
            // history2
            // 
            this.history2.DiceDotSpacing = 0.03F;
            this.history2.Location = new System.Drawing.Point(290, 12);
            this.history2.Name = "history2";
            this.history2.Size = new System.Drawing.Size(30, 30);
            this.history2.State = DiceRoll.Dice.EState.DesigMode;
            this.history2.TabIndex = 15;
            this.history2.Value = 7;
            // 
            // history1
            // 
            this.history1.DiceDotSpacing = 0.03F;
            this.history1.Location = new System.Drawing.Point(254, 12);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(30, 30);
            this.history1.State = DiceRoll.Dice.EState.DesigMode;
            this.history1.TabIndex = 15;
            this.history1.Value = 7;
            // 
            // dice7
            // 
            this.dice7.DiceDotSpacing = 0.03F;
            this.dice7.Location = new System.Drawing.Point(218, 223);
            this.dice7.Name = "dice7";
            this.dice7.Size = new System.Drawing.Size(30, 30);
            this.dice7.State = DiceRoll.Dice.EState.six;
            this.dice7.TabIndex = 15;
            this.dice7.Value = 6;
            // 
            // dice6
            // 
            this.dice6.DiceDotSpacing = 0.03F;
            this.dice6.Location = new System.Drawing.Point(218, 190);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(30, 30);
            this.dice6.State = DiceRoll.Dice.EState.five;
            this.dice6.TabIndex = 15;
            this.dice6.Value = 5;
            // 
            // dice5
            // 
            this.dice5.DiceDotSpacing = 0.03F;
            this.dice5.Location = new System.Drawing.Point(218, 154);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(30, 30);
            this.dice5.State = DiceRoll.Dice.EState.four;
            this.dice5.TabIndex = 15;
            this.dice5.Value = 4;
            // 
            // dice4
            // 
            this.dice4.DiceDotSpacing = 0.03F;
            this.dice4.Location = new System.Drawing.Point(218, 118);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(30, 30);
            this.dice4.State = DiceRoll.Dice.EState.three;
            this.dice4.TabIndex = 15;
            this.dice4.Value = 3;
            // 
            // dice3
            // 
            this.dice3.DiceDotSpacing = 0.03F;
            this.dice3.Location = new System.Drawing.Point(218, 82);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(30, 30);
            this.dice3.State = DiceRoll.Dice.EState.two;
            this.dice3.TabIndex = 15;
            this.dice3.Value = 2;
            // 
            // dice2
            // 
            this.dice2.DiceDotSpacing = 0.03F;
            this.dice2.Location = new System.Drawing.Point(218, 47);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(30, 30);
            this.dice2.State = DiceRoll.Dice.EState.one;
            this.dice2.TabIndex = 15;
            this.dice2.Value = 1;
            // 
            // history0
            // 
            this.history0.DiceDotSpacing = 0.03F;
            this.history0.Location = new System.Drawing.Point(218, 12);
            this.history0.Name = "history0";
            this.history0.Size = new System.Drawing.Size(30, 30);
            this.history0.State = DiceRoll.Dice.EState.DesigMode;
            this.history0.TabIndex = 15;
            this.history0.Value = 7;
            // 
            // dice1
            // 
            this.dice1.DiceDotSpacing = 0.03F;
            this.dice1.Location = new System.Drawing.Point(7, 12);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(205, 205);
            this.dice1.State = DiceRoll.Dice.EState.DesigMode;
            this.dice1.TabIndex = 0;
            this.dice1.Value = 7;
            this.dice1.Load += new System.EventHandler(this.Dice1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.history5);
            this.Controls.Add(this.history4);
            this.Controls.Add(this.history3);
            this.Controls.Add(this.history2);
            this.Controls.Add(this.history1);
            this.Controls.Add(this.dice7);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.history0);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.dice1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roll The Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.TextBox Label1;
        private System.Windows.Forms.TextBox Label4;
        private System.Windows.Forms.TextBox Label5;
        private System.Windows.Forms.TextBox Label6;
        private System.Windows.Forms.TextBox Label3;
        private Dice dice1;
        private Dice history0;
        private Dice history1;
        private Dice history2;
        private Dice history3;
        private Dice history4;
        private Dice history5;
        private System.Windows.Forms.TextBox Label2;
        private Dice dice2;
        private Dice dice3;
        private Dice dice4;
        private Dice dice5;
        private Dice dice6;
        private Dice dice7;
    }
}

