namespace Tax_Application.Forms
{
    partial class ScheduleD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.shortProceeds = new System.Windows.Forms.TextBox();
            this.shortCost = new System.Windows.Forms.TextBox();
            this.shortGainOrLoss = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.longGainOrLoss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lonCost = new System.Windows.Forms.TextBox();
            this.longProceeds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Totals for all short-term transactions reported on Form 1099-B for which basis wa" +
    "s reported to the IRS and for which you have no adjustments";
            // 
            // shortProceeds
            // 
            this.shortProceeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortProceeds.Location = new System.Drawing.Point(261, 22);
            this.shortProceeds.Multiline = true;
            this.shortProceeds.Name = "shortProceeds";
            this.shortProceeds.Size = new System.Drawing.Size(138, 40);
            this.shortProceeds.TabIndex = 1;
            // 
            // shortCost
            // 
            this.shortCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortCost.Location = new System.Drawing.Point(405, 22);
            this.shortCost.Multiline = true;
            this.shortCost.Name = "shortCost";
            this.shortCost.Size = new System.Drawing.Size(138, 40);
            this.shortCost.TabIndex = 2;
            // 
            // shortGainOrLoss
            // 
            this.shortGainOrLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shortGainOrLoss.Location = new System.Drawing.Point(549, 22);
            this.shortGainOrLoss.Multiline = true;
            this.shortGainOrLoss.Name = "shortGainOrLoss";
            this.shortGainOrLoss.Size = new System.Drawing.Size(138, 40);
            this.shortGainOrLoss.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.longGainOrLoss);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lonCost);
            this.panel1.Controls.Add(this.longProceeds);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.shortGainOrLoss);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shortCost);
            this.panel1.Controls.Add(this.shortProceeds);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 138);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "proceeds ( sales price)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gain or loss";
            // 
            // longGainOrLoss
            // 
            this.longGainOrLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longGainOrLoss.Location = new System.Drawing.Point(549, 81);
            this.longGainOrLoss.Multiline = true;
            this.longGainOrLoss.Name = "longGainOrLoss";
            this.longGainOrLoss.Size = new System.Drawing.Size(138, 40);
            this.longGainOrLoss.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Totals for all long-term transactions reported on Form 1099-B for which basis was" +
    " reported to the IRS and for which you have no adjustments";
            // 
            // lonCost
            // 
            this.lonCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonCost.Location = new System.Drawing.Point(405, 81);
            this.lonCost.Multiline = true;
            this.lonCost.Name = "lonCost";
            this.lonCost.Size = new System.Drawing.Size(138, 40);
            this.lonCost.TabIndex = 10;
            // 
            // longProceeds
            // 
            this.longProceeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longProceeds.Location = new System.Drawing.Point(261, 81);
            this.longProceeds.Multiline = true;
            this.longProceeds.Name = "longProceeds";
            this.longProceeds.Size = new System.Drawing.Size(138, 40);
            this.longProceeds.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(217, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // summary
            // 
            this.summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summary.Location = new System.Drawing.Point(63, 3);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(138, 20);
            this.summary.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.summary);
            this.panel2.Location = new System.Drawing.Point(3, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 29);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Summary:";
            // 
            // ScheduleD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleD";
            this.Size = new System.Drawing.Size(722, 194);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shortProceeds;
        private System.Windows.Forms.TextBox shortCost;
        private System.Windows.Forms.TextBox shortGainOrLoss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox longGainOrLoss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lonCost;
        private System.Windows.Forms.TextBox longProceeds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}
