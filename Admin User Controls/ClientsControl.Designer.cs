namespace TaxApp_v2.Admin_User_Controls
{
    partial class ClientsControl
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
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.WagesTipsOtherCompensationTextBox = new System.Windows.Forms.TextBox();
            this.ClientsLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.AllowUserToOrderColumns = true;
            this.ClientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Location = new System.Drawing.Point(0, 67);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.Size = new System.Drawing.Size(1202, 372);
            this.ClientsDataGridView.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(25, 44);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search:";
            // 
            // WagesTipsOtherCompensationTextBox
            // 
            this.WagesTipsOtherCompensationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WagesTipsOtherCompensationTextBox.Location = new System.Drawing.Point(75, 42);
            this.WagesTipsOtherCompensationTextBox.Name = "WagesTipsOtherCompensationTextBox";
            this.WagesTipsOtherCompensationTextBox.Size = new System.Drawing.Size(218, 20);
            this.WagesTipsOtherCompensationTextBox.TabIndex = 3;
            // 
            // ClientsLabel
            // 
            this.ClientsLabel.AutoSize = true;
            this.ClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLabel.Location = new System.Drawing.Point(3, 3);
            this.ClientsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ClientsLabel.Name = "ClientsLabel";
            this.ClientsLabel.Size = new System.Drawing.Size(112, 33);
            this.ClientsLabel.TabIndex = 4;
            this.ClientsLabel.Text = "Clients";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(671, 446);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(752, 446);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "&Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(347, 446);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "&Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(428, 446);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 8;
            this.ReadButton.Text = "&Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(509, 446);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "&Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(590, 446);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ClientsLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.WagesTipsOtherCompensationTextBox);
            this.Controls.Add(this.ClientsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(1205, 479);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox WagesTipsOtherCompensationTextBox;
        private System.Windows.Forms.Label ClientsLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
