namespace TaxApp_v2.Admin_User_Controls
{
    partial class AppointmentControl
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
            appointment_idLabel = new Label();
            client_idLabel = new Label();
            employee_idLabel = new Label();
            dateLabel = new Label();
            timeLabel = new Label();
            purposeLabel = new Label();
            appointmentsTitleLabel = new Label();
            appointment_idTextBox = new TextBox();
            client_idTextBox = new TextBox();
            employee_idTextBox = new TextBox();
            dateDateTimePicker = new DateTimePicker();
            timeDateTimePicker = new DateTimePicker();
            purposeTextBox = new TextBox();
            SuspendLayout();
            // 
            // appointment_idLabel
            // 
            appointment_idLabel.AutoSize = true;
            appointment_idLabel.Location = new Point(22, 58);
            appointment_idLabel.Margin = new Padding(2, 0, 2, 0);
            appointment_idLabel.Name = "appointment_idLabel";
            appointment_idLabel.Size = new Size(92, 15);
            appointment_idLabel.TabIndex = 0;
            appointment_idLabel.Text = "appointment id:";
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new Point(22, 82);
            client_idLabel.Margin = new Padding(2, 0, 2, 0);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new Size(52, 15);
            client_idLabel.TabIndex = 2;
            client_idLabel.Text = "client id:";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new Point(22, 106);
            employee_idLabel.Margin = new Padding(2, 0, 2, 0);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new Size(75, 15);
            employee_idLabel.TabIndex = 4;
            employee_idLabel.Text = "employee id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(22, 131);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(33, 15);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(22, 155);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(34, 15);
            timeLabel.TabIndex = 8;
            timeLabel.Text = "time:";
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new Point(22, 178);
            purposeLabel.Margin = new Padding(2, 0, 2, 0);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new Size(53, 15);
            purposeLabel.TabIndex = 10;
            purposeLabel.Text = "purpose:";
            // 
            // appointmentsTitleLabel
            // 
            appointmentsTitleLabel.AutoSize = true;
            appointmentsTitleLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentsTitleLabel.Location = new Point(15, 10);
            appointmentsTitleLabel.Margin = new Padding(2, 0, 2, 0);
            appointmentsTitleLabel.Name = "appointmentsTitleLabel";
            appointmentsTitleLabel.Size = new Size(210, 36);
            appointmentsTitleLabel.TabIndex = 12;
            appointmentsTitleLabel.Text = "Appointments";
            // 
            // appointment_idTextBox
            // 
            appointment_idTextBox.Location = new Point(119, 56);
            appointment_idTextBox.Margin = new Padding(2, 2, 2, 2);
            appointment_idTextBox.Name = "appointment_idTextBox";
            appointment_idTextBox.Size = new Size(156, 23);
            appointment_idTextBox.TabIndex = 1;
            // 
            // client_idTextBox
            // 
            client_idTextBox.Location = new Point(119, 80);
            client_idTextBox.Margin = new Padding(2, 2, 2, 2);
            client_idTextBox.Name = "client_idTextBox";
            client_idTextBox.Size = new Size(156, 23);
            client_idTextBox.TabIndex = 3;
            // 
            // employee_idTextBox
            // 
            employee_idTextBox.Location = new Point(119, 104);
            employee_idTextBox.Margin = new Padding(2, 2, 2, 2);
            employee_idTextBox.Name = "employee_idTextBox";
            employee_idTextBox.Size = new Size(156, 23);
            employee_idTextBox.TabIndex = 5;
            // 
            // dateDateTimePicker
            // 
            dateDateTimePicker.Format = DateTimePickerFormat.Short;
            dateDateTimePicker.Location = new Point(119, 128);
            dateDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            dateDateTimePicker.Name = "dateDateTimePicker";
            dateDateTimePicker.Size = new Size(156, 23);
            dateDateTimePicker.TabIndex = 7;
            // 
            // timeDateTimePicker
            // 
            timeDateTimePicker.Format = DateTimePickerFormat.Time;
            timeDateTimePicker.Location = new Point(119, 152);
            timeDateTimePicker.Margin = new Padding(2, 2, 2, 2);
            timeDateTimePicker.Name = "timeDateTimePicker";
            timeDateTimePicker.Size = new Size(156, 23);
            timeDateTimePicker.TabIndex = 9;
            // 
            // purposeTextBox
            // 
            purposeTextBox.Location = new Point(119, 176);
            purposeTextBox.Margin = new Padding(2, 2, 2, 2);
            purposeTextBox.Name = "purposeTextBox";
            purposeTextBox.Size = new Size(156, 23);
            purposeTextBox.TabIndex = 11;
            // 
            // AppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(appointmentsTitleLabel);
            Controls.Add(appointment_idLabel);
            Controls.Add(appointment_idTextBox);
            Controls.Add(client_idLabel);
            Controls.Add(client_idTextBox);
            Controls.Add(employee_idLabel);
            Controls.Add(employee_idTextBox);
            Controls.Add(dateLabel);
            Controls.Add(dateDateTimePicker);
            Controls.Add(timeLabel);
            Controls.Add(timeDateTimePicker);
            Controls.Add(purposeLabel);
            Controls.Add(purposeTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AppointmentControl";
            Size = new Size(304, 226);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox appointment_idTextBox;
        private System.Windows.Forms.TextBox client_idTextBox;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker;
        private System.Windows.Forms.TextBox purposeTextBox;
        private Label appointment_idLabel;
        private Label client_idLabel;
        private Label employee_idLabel;
        private Label dateLabel;
        private Label timeLabel;
        private Label purposeLabel;
        private Label appointmentsTitleLabel;
    }
}
