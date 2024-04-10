namespace TaxApp_v2.Admin_User_Controls
{
    partial class InvoiceControl
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
            invoice_idLabel = new Label();
            client_idLabel = new Label();
            employee_idLabel = new Label();
            invoice_dateLabel = new Label();
            due_dateLabel = new Label();
            amountLabel = new Label();
            paidLabel = new Label();
            payment_dateLabel = new Label();
            invoiceTitleLabel = new Label();
            invoice_idTextBox = new TextBox();
            client_idTextBox = new TextBox();
            employee_idTextBox = new TextBox();
            invoice_dateDateTimePicker = new DateTimePicker();
            due_dateDateTimePicker = new DateTimePicker();
            amountTextBox = new TextBox();
            paidRadioButton = new RadioButton();
            payment_dateDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // invoice_idLabel
            // 
            invoice_idLabel.AutoSize = true;
            invoice_idLabel.Location = new Point(23, 64);
            invoice_idLabel.Margin = new Padding(2, 0, 2, 0);
            invoice_idLabel.Name = "invoice_idLabel";
            invoice_idLabel.Size = new Size(61, 15);
            invoice_idLabel.TabIndex = 0;
            invoice_idLabel.Text = "invoice id:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new Point(23, 88);
            client_idLabel.Margin = new Padding(2, 0, 2, 0);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new Size(52, 15);
            client_idLabel.TabIndex = 2;
            client_idLabel.Text = "client id:";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new Point(23, 112);
            employee_idLabel.Margin = new Padding(2, 0, 2, 0);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new Size(75, 15);
            employee_idLabel.TabIndex = 4;
            employee_idLabel.Text = "employee id:";
            // 
            // invoice_dateLabel
            // 
            invoice_dateLabel.AutoSize = true;
            invoice_dateLabel.Location = new Point(23, 136);
            invoice_dateLabel.Margin = new Padding(2, 0, 2, 0);
            invoice_dateLabel.Name = "invoice_dateLabel";
            invoice_dateLabel.Size = new Size(74, 15);
            invoice_dateLabel.TabIndex = 6;
            invoice_dateLabel.Text = "invoice date:";
            // 
            // due_dateLabel
            // 
            due_dateLabel.AutoSize = true;
            due_dateLabel.Location = new Point(23, 160);
            due_dateLabel.Margin = new Padding(2, 0, 2, 0);
            due_dateLabel.Name = "due_dateLabel";
            due_dateLabel.Size = new Size(56, 15);
            due_dateLabel.TabIndex = 8;
            due_dateLabel.Text = "due date:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(23, 184);
            amountLabel.Margin = new Padding(2, 0, 2, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(52, 15);
            amountLabel.TabIndex = 10;
            amountLabel.Text = "amount:";
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.Location = new Point(23, 210);
            paidLabel.Margin = new Padding(2, 0, 2, 0);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new Size(33, 15);
            paidLabel.TabIndex = 12;
            paidLabel.Text = "paid:";
            // 
            // payment_dateLabel
            // 
            payment_dateLabel.AutoSize = true;
            payment_dateLabel.Location = new Point(23, 232);
            payment_dateLabel.Margin = new Padding(2, 0, 2, 0);
            payment_dateLabel.Name = "payment_dateLabel";
            payment_dateLabel.Size = new Size(83, 15);
            payment_dateLabel.TabIndex = 14;
            payment_dateLabel.Text = "payment date:";
            // 
            // invoiceTitleLabel
            // 
            invoiceTitleLabel.AutoSize = true;
            invoiceTitleLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceTitleLabel.Location = new Point(19, 13);
            invoiceTitleLabel.Margin = new Padding(2, 0, 2, 0);
            invoiceTitleLabel.Name = "invoiceTitleLabel";
            invoiceTitleLabel.Size = new Size(133, 36);
            invoiceTitleLabel.TabIndex = 16;
            invoiceTitleLabel.Text = "Invoices";
            // 
            // invoice_idTextBox
            // 
            invoice_idTextBox.Location = new Point(113, 62);
            invoice_idTextBox.Margin = new Padding(2, 2, 2, 2);
            invoice_idTextBox.Name = "invoice_idTextBox";
            invoice_idTextBox.Size = new Size(156, 23);
            invoice_idTextBox.TabIndex = 1;
            // 
            // client_idTextBox
            // 
            client_idTextBox.Location = new Point(113, 86);
            client_idTextBox.Margin = new Padding(2, 2, 2, 2);
            client_idTextBox.Name = "client_idTextBox";
            client_idTextBox.Size = new Size(156, 23);
            client_idTextBox.TabIndex = 3;
            // 
            // employee_idTextBox
            // 
            employee_idTextBox.Location = new Point(113, 110);
            employee_idTextBox.Margin = new Padding(2, 2, 2, 2);
            employee_idTextBox.Name = "employee_idTextBox";
            employee_idTextBox.Size = new Size(156, 23);
            employee_idTextBox.TabIndex = 5;
            // 
            // invoice_dateDateTimePicker
            // 
            invoice_dateDateTimePicker.Format = DateTimePickerFormat.Short;
            invoice_dateDateTimePicker.Location = new Point(113, 134);
            invoice_dateDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            invoice_dateDateTimePicker.Name = "invoice_dateDateTimePicker";
            invoice_dateDateTimePicker.Size = new Size(156, 23);
            invoice_dateDateTimePicker.TabIndex = 7;
            // 
            // due_dateDateTimePicker
            // 
            due_dateDateTimePicker.Format = DateTimePickerFormat.Short;
            due_dateDateTimePicker.Location = new Point(113, 158);
            due_dateDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            due_dateDateTimePicker.Name = "due_dateDateTimePicker";
            due_dateDateTimePicker.Size = new Size(156, 23);
            due_dateDateTimePicker.TabIndex = 9;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(113, 182);
            amountTextBox.Margin = new Padding(2, 2, 2, 2);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(156, 23);
            amountTextBox.TabIndex = 11;
            // 
            // paidRadioButton
            // 
            paidRadioButton.Location = new Point(113, 206);
            paidRadioButton.Margin = new Padding(2, 2, 2, 2);
            paidRadioButton.Name = "paidRadioButton";
            paidRadioButton.Size = new Size(156, 18);
            paidRadioButton.TabIndex = 13;
            paidRadioButton.TabStop = true;
            paidRadioButton.Text = "radioButton1";
            paidRadioButton.UseVisualStyleBackColor = true;
            // 
            // payment_dateDateTimePicker
            // 
            payment_dateDateTimePicker.Format = DateTimePickerFormat.Short;
            payment_dateDateTimePicker.Location = new Point(113, 230);
            payment_dateDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            payment_dateDateTimePicker.Name = "payment_dateDateTimePicker";
            payment_dateDateTimePicker.Size = new Size(156, 23);
            payment_dateDateTimePicker.TabIndex = 15;
            // 
            // InvoiceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(invoiceTitleLabel);
            Controls.Add(invoice_idLabel);
            Controls.Add(invoice_idTextBox);
            Controls.Add(client_idLabel);
            Controls.Add(client_idTextBox);
            Controls.Add(employee_idLabel);
            Controls.Add(employee_idTextBox);
            Controls.Add(invoice_dateLabel);
            Controls.Add(invoice_dateDateTimePicker);
            Controls.Add(due_dateLabel);
            Controls.Add(due_dateDateTimePicker);
            Controls.Add(amountLabel);
            Controls.Add(amountTextBox);
            Controls.Add(paidLabel);
            Controls.Add(paidRadioButton);
            Controls.Add(payment_dateLabel);
            Controls.Add(payment_dateDateTimePicker);
            Margin = new Padding(2, 2, 2, 2);
            Name = "InvoiceControl";
            Size = new Size(296, 285);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox invoice_idTextBox;
        private System.Windows.Forms.TextBox client_idTextBox;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private System.Windows.Forms.DateTimePicker invoice_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker due_dateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.RadioButton paidRadioButton;
        private System.Windows.Forms.DateTimePicker payment_dateDateTimePicker;
        private Label invoice_idLabel;
        private Label client_idLabel;
        private Label employee_idLabel;
        private Label invoice_dateLabel;
        private Label due_dateLabel;
        private Label amountLabel;
        private Label paidLabel;
        private Label payment_dateLabel;
        private Label invoiceTitleLabel;
    }
}
