namespace TaxApp_v2.TaxForms
{
    partial class Form1098_E
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
            rTINTB = new TextBox();
            label1 = new Label();
            bTINTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            rlTB = new TextBox();
            label5 = new Label();
            slirblTB = new TextBox();
            label6 = new Label();
            anTB = new TextBox();
            SuspendLayout();
            // 
            // rTINTB
            // 
            rTINTB.BorderStyle = BorderStyle.FixedSingle;
            rTINTB.Location = new Point(3, 197);
            rTINTB.Margin = new Padding(3, 4, 3, 4);
            rTINTB.Name = "rTINTB";
            rTINTB.Size = new Size(173, 23);
            rTINTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 178);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Recipient's TIN";
            // 
            // bTINTB
            // 
            bTINTB.BorderStyle = BorderStyle.FixedSingle;
            bTINTB.Location = new Point(222, 194);
            bTINTB.Margin = new Padding(3, 4, 3, 4);
            bTINTB.Name = "bTINTB";
            bTINTB.Size = new Size(173, 23);
            bTINTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 175);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Borrower'sTIN";
            // 
            // label4
            // 
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(399, 32);
            label4.TabIndex = 6;
            label4.Text = "RECIPIENT’S/LENDER’S name, street address, city or town, state or province, country, ZIP or foreign postal code, and telephone number";
            // 
            // rlTB
            // 
            rlTB.BorderStyle = BorderStyle.FixedSingle;
            rlTB.Location = new Point(3, 41);
            rlTB.Margin = new Padding(3, 4, 3, 4);
            rlTB.Multiline = true;
            rlTB.Name = "rlTB";
            rlTB.Size = new Size(392, 130);
            rlTB.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 223);
            label5.Name = "label5";
            label5.Size = new Size(218, 15);
            label5.TabIndex = 8;
            label5.Text = "Student Loan Interest recieved by lender";
            // 
            // slirblTB
            // 
            slirblTB.BorderStyle = BorderStyle.FixedSingle;
            slirblTB.Location = new Point(3, 241);
            slirblTB.Margin = new Padding(3, 4, 3, 4);
            slirblTB.Name = "slirblTB";
            slirblTB.Size = new Size(392, 23);
            slirblTB.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 277);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 10;
            label6.Text = "Account number";
            // 
            // anTB
            // 
            anTB.BorderStyle = BorderStyle.FixedSingle;
            anTB.Location = new Point(3, 292);
            anTB.Margin = new Padding(3, 4, 3, 4);
            anTB.Name = "anTB";
            anTB.Size = new Size(392, 23);
            anTB.TabIndex = 9;
            // 
            // Form1098_E
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(anTB);
            Controls.Add(label5);
            Controls.Add(slirblTB);
            Controls.Add(label4);
            Controls.Add(rlTB);
            Controls.Add(label3);
            Controls.Add(bTINTB);
            Controls.Add(label1);
            Controls.Add(rTINTB);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1098_E";
            Size = new Size(397, 317);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox rTINTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bTINTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rlTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox slirblTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox anTB;
    }
}
