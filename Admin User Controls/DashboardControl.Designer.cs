using Tax_Application.Forms;
using TaxApp_v2.TaxForms;

namespace TaxApp_v2.Admin_User_Controls
{
    partial class DashboardControl
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
            MenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            fullscreenToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SearchToolStripTextBox = new ToolStripTextBox();
            UserPanel = new Panel();
            UsernameLabel = new Label();
            UserPictureBox = new PictureBox();
            ButtonPanel = new Panel();
            UsersButton = new Button();
            EmployeesButton = new Button();
            InvoicesButton = new Button();
            ClientsButton = new Button();
            AppointmentsButton = new Button();
            LogOutButton = new Button();
            HelpButton = new Button();
            SidebarPanel = new Panel();
            AdminPanel = new Panel();
            ScheduleDTabPage = new TabPage();
            scheduleD1 = new ScheduleD();
            Form1098_ETabPage = new TabPage();
            form1098_E1 = new Form1098_E();
            ScheduleK_1TabPage = new TabPage();
            scheduleK_11 = new ScheduleK_1();
            FormW2TabPage = new TabPage();
            TaxFormsTabControl = new TabControl();
            w2UserControl1 = new W2UserControl();
            Form1040TabPage = new TabPage();
            MenuStrip.SuspendLayout();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).BeginInit();
            ButtonPanel.SuspendLayout();
            SidebarPanel.SuspendLayout();
            ScheduleDTabPage.SuspendLayout();
            Form1098_ETabPage.SuspendLayout();
            ScheduleK_1TabPage.SuspendLayout();
            FormW2TabPage.SuspendLayout();
            TaxFormsTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(24, 24);
            MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, EditToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem, SearchToolStripTextBox });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(7, 2, 0, 2);
            MenuStrip.Size = new Size(2667, 35);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, ExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 31);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(158, 34);
            NewToolStripMenuItem.Text = "New";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(158, 34);
            OpenToolStripMenuItem.Text = "Open";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(158, 34);
            SaveToolStripMenuItem.Text = "Save";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(158, 34);
            ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, undoToolStripMenuItem, redoToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(58, 31);
            EditToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(158, 34);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(158, 34);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(158, 34);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(158, 34);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(158, 34);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, fullscreenToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 31);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(197, 34);
            zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(197, 34);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // fullscreenToolStripMenuItem
            // 
            fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            fullscreenToolStripMenuItem.Size = new Size(197, 34);
            fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 31);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(200, 34);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(200, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // SearchToolStripTextBox
            // 
            SearchToolStripTextBox.Name = "SearchToolStripTextBox";
            SearchToolStripTextBox.Size = new Size(222, 31);
            SearchToolStripTextBox.Text = "Search";
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(UsernameLabel);
            UserPanel.Controls.Add(UserPictureBox);
            UserPanel.Dock = DockStyle.Top;
            UserPanel.Location = new Point(0, 0);
            UserPanel.Margin = new Padding(5, 6, 5, 6);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(333, 308);
            UserPanel.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.WhiteSmoke;
            UsernameLabel.Location = new Point(0, 223);
            UsernameLabel.Margin = new Padding(5, 0, 5, 0);
            UsernameLabel.MaximumSize = new Size(333, 40);
            UsernameLabel.MinimumSize = new Size(333, 40);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(333, 40);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            UserPictureBox.Location = new Point(0, 92);
            UserPictureBox.Margin = new Padding(5, 6, 5, 6);
            UserPictureBox.Name = "UserPictureBox";
            UserPictureBox.Size = new Size(333, 125);
            UserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            UserPictureBox.TabIndex = 29;
            UserPictureBox.TabStop = false;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(UsersButton);
            ButtonPanel.Controls.Add(EmployeesButton);
            ButtonPanel.Controls.Add(InvoicesButton);
            ButtonPanel.Controls.Add(ClientsButton);
            ButtonPanel.Controls.Add(AppointmentsButton);
            ButtonPanel.Controls.Add(LogOutButton);
            ButtonPanel.Controls.Add(HelpButton);
            ButtonPanel.Location = new Point(0, 308);
            ButtonPanel.Margin = new Padding(5, 6, 5, 6);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(333, 1375);
            ButtonPanel.TabIndex = 30;
            // 
            // UsersButton
            // 
            UsersButton.Cursor = Cursors.Hand;
            UsersButton.Dock = DockStyle.Top;
            UsersButton.FlatAppearance.BorderSize = 0;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.ForeColor = Color.WhiteSmoke;
            UsersButton.Location = new Point(0, 324);
            UsersButton.Margin = new Padding(5, 6, 5, 6);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(333, 81);
            UsersButton.TabIndex = 3;
            UsersButton.Text = "&USERS";
            UsersButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            UsersButton.UseVisualStyleBackColor = false;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Cursor = Cursors.Hand;
            EmployeesButton.Dock = DockStyle.Top;
            EmployeesButton.FlatAppearance.BorderSize = 0;
            EmployeesButton.FlatStyle = FlatStyle.Flat;
            EmployeesButton.ForeColor = Color.WhiteSmoke;
            EmployeesButton.Location = new Point(0, 243);
            EmployeesButton.Margin = new Padding(5, 6, 5, 6);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(333, 81);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "&EMPLOYEES";
            EmployeesButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            EmployeesButton.UseVisualStyleBackColor = false;
            // 
            // InvoicesButton
            // 
            InvoicesButton.Cursor = Cursors.Hand;
            InvoicesButton.Dock = DockStyle.Top;
            InvoicesButton.FlatAppearance.BorderSize = 0;
            InvoicesButton.FlatStyle = FlatStyle.Flat;
            InvoicesButton.ForeColor = Color.WhiteSmoke;
            InvoicesButton.Location = new Point(0, 162);
            InvoicesButton.Margin = new Padding(5, 6, 5, 6);
            InvoicesButton.Name = "InvoicesButton";
            InvoicesButton.Size = new Size(333, 81);
            InvoicesButton.TabIndex = 4;
            InvoicesButton.Text = "&INVOICES";
            InvoicesButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            InvoicesButton.UseVisualStyleBackColor = false;
            // 
            // ClientsButton
            // 
            ClientsButton.Cursor = Cursors.Hand;
            ClientsButton.Dock = DockStyle.Top;
            ClientsButton.FlatAppearance.BorderSize = 0;
            ClientsButton.FlatStyle = FlatStyle.Flat;
            ClientsButton.ForeColor = Color.WhiteSmoke;
            ClientsButton.Location = new Point(0, 81);
            ClientsButton.Margin = new Padding(5, 6, 5, 6);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(333, 81);
            ClientsButton.TabIndex = 1;
            ClientsButton.Text = "&CLIENTS";
            ClientsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            ClientsButton.UseVisualStyleBackColor = false;
            ClientsButton.Click += ClientsButton_Click;
            // 
            // AppointmentsButton
            // 
            AppointmentsButton.Cursor = Cursors.Hand;
            AppointmentsButton.Dock = DockStyle.Top;
            AppointmentsButton.FlatAppearance.BorderSize = 0;
            AppointmentsButton.FlatStyle = FlatStyle.Flat;
            AppointmentsButton.ForeColor = Color.WhiteSmoke;
            AppointmentsButton.Location = new Point(0, 0);
            AppointmentsButton.Margin = new Padding(5, 6, 5, 6);
            AppointmentsButton.Name = "AppointmentsButton";
            AppointmentsButton.Size = new Size(333, 81);
            AppointmentsButton.TabIndex = 0;
            AppointmentsButton.Text = "&APPOINTMENTS";
            AppointmentsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            AppointmentsButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.Cursor = Cursors.Hand;
            LogOutButton.Dock = DockStyle.Bottom;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.ForeColor = Color.WhiteSmoke;
            LogOutButton.Location = new Point(0, 1213);
            LogOutButton.Margin = new Padding(5, 6, 5, 6);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(333, 81);
            LogOutButton.TabIndex = 5;
            LogOutButton.Text = "LOG &OUT";
            LogOutButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Cursor = Cursors.Hand;
            HelpButton.Dock = DockStyle.Bottom;
            HelpButton.FlatAppearance.BorderSize = 0;
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.ForeColor = Color.WhiteSmoke;
            HelpButton.ImageAlign = ContentAlignment.MiddleRight;
            HelpButton.Location = new Point(0, 1294);
            HelpButton.Margin = new Padding(5, 6, 5, 6);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(333, 81);
            HelpButton.TabIndex = 6;
            HelpButton.Text = "&HELP";
            HelpButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            HelpButton.UseVisualStyleBackColor = false;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(51, 64, 87);
            SidebarPanel.Controls.Add(ButtonPanel);
            SidebarPanel.Controls.Add(UserPanel);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 35);
            SidebarPanel.Margin = new Padding(5, 6, 5, 6);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(333, 1696);
            SidebarPanel.TabIndex = 39;
            // 
            // AdminPanel
            // 
            AdminPanel.Dock = DockStyle.Fill;
            AdminPanel.Location = new Point(2656, 35);
            AdminPanel.Margin = new Padding(5, 6, 5, 6);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(11, 1696);
            AdminPanel.TabIndex = 2;
            // 
            // ScheduleDTabPage
            // 
            ScheduleDTabPage.Controls.Add(scheduleD1);
            ScheduleDTabPage.Location = new Point(4, 34);
            ScheduleDTabPage.Margin = new Padding(3, 4, 3, 4);
            ScheduleDTabPage.Name = "ScheduleDTabPage";
            ScheduleDTabPage.Size = new Size(2315, 1658);
            ScheduleDTabPage.TabIndex = 4;
            ScheduleDTabPage.Text = "Schedule D";
            ScheduleDTabPage.UseVisualStyleBackColor = true;
            // 
            // scheduleD1
            // 
            scheduleD1.BackColor = Color.FromArgb(224, 224, 224);
            scheduleD1.Location = new Point(7, 8);
            scheduleD1.Margin = new Padding(8, 12, 8, 12);
            scheduleD1.Name = "scheduleD1";
            scheduleD1.Size = new Size(1203, 373);
            scheduleD1.TabIndex = 0;
            // 
            // Form1098_ETabPage
            // 
            Form1098_ETabPage.Controls.Add(form1098_E1);
            Form1098_ETabPage.Location = new Point(4, 34);
            Form1098_ETabPage.Margin = new Padding(3, 4, 3, 4);
            Form1098_ETabPage.Name = "Form1098_ETabPage";
            Form1098_ETabPage.Size = new Size(2315, 1658);
            Form1098_ETabPage.TabIndex = 3;
            Form1098_ETabPage.Text = "1098-E";
            Form1098_ETabPage.UseVisualStyleBackColor = true;
            // 
            // form1098_E1
            // 
            form1098_E1.BackColor = Color.FromArgb(224, 224, 224);
            form1098_E1.Location = new Point(7, 8);
            form1098_E1.Margin = new Padding(7, 13, 7, 13);
            form1098_E1.Name = "form1098_E1";
            form1098_E1.Size = new Size(568, 529);
            form1098_E1.TabIndex = 0;
            // 
            // ScheduleK_1TabPage
            // 
            ScheduleK_1TabPage.Controls.Add(scheduleK_11);
            ScheduleK_1TabPage.Location = new Point(4, 34);
            ScheduleK_1TabPage.Margin = new Padding(3, 4, 3, 4);
            ScheduleK_1TabPage.Name = "ScheduleK_1TabPage";
            ScheduleK_1TabPage.Size = new Size(2315, 1658);
            ScheduleK_1TabPage.TabIndex = 2;
            ScheduleK_1TabPage.Text = "ScheduleK-1";
            ScheduleK_1TabPage.UseVisualStyleBackColor = true;
            // 
            // scheduleK_11
            // 
            scheduleK_11.BackColor = Color.FromArgb(224, 224, 224);
            scheduleK_11.Location = new Point(7, 8);
            scheduleK_11.Margin = new Padding(7, 12, 7, 12);
            scheduleK_11.Name = "scheduleK_11";
            scheduleK_11.Size = new Size(1245, 1217);
            scheduleK_11.TabIndex = 0;
            // 
            // FormW2TabPage
            // 
            FormW2TabPage.Controls.Add(w2UserControl1);
            FormW2TabPage.Location = new Point(4, 34);
            FormW2TabPage.Margin = new Padding(5, 6, 5, 6);
            FormW2TabPage.Name = "FormW2TabPage";
            FormW2TabPage.Padding = new Padding(5, 6, 5, 6);
            FormW2TabPage.Size = new Size(2315, 1658);
            FormW2TabPage.TabIndex = 0;
            FormW2TabPage.Text = "Form W2";
            FormW2TabPage.UseVisualStyleBackColor = true;
            // 
            // TaxFormsTabControl
            // 
            TaxFormsTabControl.Controls.Add(FormW2TabPage);
            TaxFormsTabControl.Controls.Add(Form1040TabPage);
            TaxFormsTabControl.Controls.Add(ScheduleK_1TabPage);
            TaxFormsTabControl.Controls.Add(Form1098_ETabPage);
            TaxFormsTabControl.Controls.Add(ScheduleDTabPage);
            TaxFormsTabControl.Dock = DockStyle.Left;
            TaxFormsTabControl.Location = new Point(333, 35);
            TaxFormsTabControl.Margin = new Padding(5, 6, 5, 6);
            TaxFormsTabControl.Name = "TaxFormsTabControl";
            TaxFormsTabControl.SelectedIndex = 0;
            TaxFormsTabControl.Size = new Size(2323, 1696);
            TaxFormsTabControl.TabIndex = 0;
            // 
            // w2UserControl1
            // 
            w2UserControl1.BackColor = Color.FromArgb(224, 224, 224);
            w2UserControl1.Location = new Point(10, 0);
            w2UserControl1.Margin = new Padding(5, 6, 5, 6);
            w2UserControl1.Name = "w2UserControl1";
            w2UserControl1.Size = new Size(2487, 1766);
            w2UserControl1.TabIndex = 0;
            // 
            // Form1040TabPage
            // 
            Form1040TabPage.AutoScroll = true;
            Form1040TabPage.Location = new Point(4, 34);
            Form1040TabPage.Margin = new Padding(5, 6, 5, 6);
            Form1040TabPage.Name = "Form1040TabPage";
            Form1040TabPage.Padding = new Padding(5, 6, 5, 6);
            Form1040TabPage.Size = new Size(2315, 1658);
            Form1040TabPage.TabIndex = 1;
            Form1040TabPage.Text = "Form1040";
            Form1040TabPage.UseVisualStyleBackColor = true;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AdminPanel);
            Controls.Add(TaxFormsTabControl);
            Controls.Add(SidebarPanel);
            Controls.Add(MenuStrip);
            Margin = new Padding(5, 6, 5, 6);
            Name = "DashboardControl";
            Size = new Size(2667, 1731);
            Load += DashboardControl_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPictureBox).EndInit();
            ButtonPanel.ResumeLayout(false);
            SidebarPanel.ResumeLayout(false);
            ScheduleDTabPage.ResumeLayout(false);
            Form1098_ETabPage.ResumeLayout(false);
            ScheduleK_1TabPage.ResumeLayout(false);
            FormW2TabPage.ResumeLayout(false);
            TaxFormsTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button AppointmentsButton;
        public System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button InvoicesButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SearchToolStripTextBox;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.TabPage ScheduleDTabPage;
        private ScheduleD scheduleD1;
        private System.Windows.Forms.TabPage Form1098_ETabPage;
        private Form1098_E form1098_E1;
        private System.Windows.Forms.TabPage ScheduleK_1TabPage;
        private ScheduleK_1 scheduleK_11;
        private System.Windows.Forms.TabPage FormW2TabPage;
        private System.Windows.Forms.TabControl TaxFormsTabControl;
        private ClientsControl clientsControl1;
        private W2UserControl w2UserControl1;
        private TabPage Form1040TabPage;
    }
}
