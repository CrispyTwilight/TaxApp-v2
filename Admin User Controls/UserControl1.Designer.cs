namespace TaxApp_v2.Admin_User_Controls
{
    partial class UserControl1
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
            System.Windows.Forms.Label user_idLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label password_hashLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label userTitleLabel;
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.password_hashTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            user_idLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            password_hashLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            userTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(31, 80);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(60, 20);
            user_idLabel.TabIndex = 1;
            user_idLabel.Text = "user id:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(31, 112);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(84, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "username:";
            // 
            // password_hashLabel
            // 
            password_hashLabel.AutoSize = true;
            password_hashLabel.Location = new System.Drawing.Point(31, 144);
            password_hashLabel.Name = "password_hashLabel";
            password_hashLabel.Size = new System.Drawing.Size(120, 20);
            password_hashLabel.TabIndex = 5;
            password_hashLabel.Text = "password hash:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(31, 176);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(39, 20);
            roleLabel.TabIndex = 7;
            roleLabel.Text = "role:";
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.Location = new System.Drawing.Point(157, 77);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(100, 26);
            this.user_idTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(157, 109);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 26);
            this.usernameTextBox.TabIndex = 4;
            // 
            // password_hashTextBox
            // 
            this.password_hashTextBox.Location = new System.Drawing.Point(157, 141);
            this.password_hashTextBox.Name = "password_hashTextBox";
            this.password_hashTextBox.Size = new System.Drawing.Size(100, 26);
            this.password_hashTextBox.TabIndex = 6;
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(157, 173);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(100, 26);
            this.roleTextBox.TabIndex = 8;
            // 
            // userTitleLabel
            // 
            userTitleLabel.AutoSize = true;
            userTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userTitleLabel.Location = new System.Drawing.Point(20, 14);
            userTitleLabel.Name = "userTitleLabel";
            userTitleLabel.Size = new System.Drawing.Size(142, 52);
            userTitleLabel.TabIndex = 9;
            userTitleLabel.Text = "Users";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(userTitleLabel);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(password_hashLabel);
            this.Controls.Add(this.password_hashTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleTextBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(269, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_idTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox password_hashTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
    }
}
