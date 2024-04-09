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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.UsersButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.InvoicesButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.clientsControl1 = new TaxApp_v2.Admin_User_Controls.ClientsControl();
            this.ScheduleDTabPage = new System.Windows.Forms.TabPage();
            this.scheduleD1 = new ScheduleD();
            this.Form1098_ETabPage = new System.Windows.Forms.TabPage();
            this.form1098_E1 = new Form1098_E();
            this.ScheduleK_1TabPage = new System.Windows.Forms.TabPage();
            this.scheduleK_11 = new ScheduleK_1();
            this.Form1040TabPage = new System.Windows.Forms.TabPage();
            this.form10401 = new Form1040();
            this.FormW2TabPage = new System.Windows.Forms.TabPage();
            this.TaxFormsTabControl = new System.Windows.Forms.TabControl();
            this.MenuStrip.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SidebarPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.ScheduleDTabPage.SuspendLayout();
            this.Form1098_ETabPage.SuspendLayout();
            this.ScheduleK_1TabPage.SuspendLayout();
            this.Form1040TabPage.SuspendLayout();
            this.FormW2TabPage.SuspendLayout();
            this.TaxFormsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.SearchToolStripTextBox});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(1600, 25);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.NewToolStripMenuItem.Text = "New";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.fullscreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SearchToolStripTextBox
            // 
            this.SearchToolStripTextBox.Name = "SearchToolStripTextBox";
            this.SearchToolStripTextBox.Size = new System.Drawing.Size(135, 23);
            this.SearchToolStripTextBox.Text = "Search";
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.UsernameLabel);
            this.UserPanel.Controls.Add(this.UserPictureBox);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(200, 160);
            this.UserPanel.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameLabel.Location = new System.Drawing.Point(0, 116);
            this.UsernameLabel.MaximumSize = new System.Drawing.Size(200, 21);
            this.UsernameLabel.MinimumSize = new System.Drawing.Size(200, 21);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(200, 21);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(0, 48);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(200, 65);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 29;
            this.UserPictureBox.TabStop = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.UsersButton);
            this.ButtonPanel.Controls.Add(this.EmployeesButton);
            this.ButtonPanel.Controls.Add(this.InvoicesButton);
            this.ButtonPanel.Controls.Add(this.ClientsButton);
            this.ButtonPanel.Controls.Add(this.AppointmentsButton);
            this.ButtonPanel.Controls.Add(this.LogOutButton);
            this.ButtonPanel.Controls.Add(this.HelpButton);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 160);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(200, 715);
            this.ButtonPanel.TabIndex = 30;
            // 
            // UsersButton
            // 
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsersButton.Location = new System.Drawing.Point(0, 168);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(200, 42);
            this.UsersButton.TabIndex = 3;
            this.UsersButton.Text = "&USERS";
            this.UsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UsersButton.UseVisualStyleBackColor = false;
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeesButton.Location = new System.Drawing.Point(0, 126);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(200, 42);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "&EMPLOYEES";
            this.EmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EmployeesButton.UseVisualStyleBackColor = false;
            // 
            // InvoicesButton
            // 
            this.InvoicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoicesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InvoicesButton.FlatAppearance.BorderSize = 0;
            this.InvoicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoicesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InvoicesButton.Location = new System.Drawing.Point(0, 84);
            this.InvoicesButton.Name = "InvoicesButton";
            this.InvoicesButton.Size = new System.Drawing.Size(200, 42);
            this.InvoicesButton.TabIndex = 4;
            this.InvoicesButton.Text = "&INVOICES";
            this.InvoicesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.InvoicesButton.UseVisualStyleBackColor = false;
            // 
            // ClientsButton
            // 
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientsButton.Location = new System.Drawing.Point(0, 42);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(200, 42);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "&CLIENTS";
            this.ClientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ClientsButton.UseVisualStyleBackColor = false;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppointmentsButton.FlatAppearance.BorderSize = 0;
            this.AppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppointmentsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AppointmentsButton.Location = new System.Drawing.Point(0, 0);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(200, 42);
            this.AppointmentsButton.TabIndex = 0;
            this.AppointmentsButton.Text = "&APPOINTMENTS";
            this.AppointmentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AppointmentsButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutButton.Location = new System.Drawing.Point(0, 631);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(200, 42);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "LOG &OUT";
            this.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelpButton.Location = new System.Drawing.Point(0, 673);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(200, 42);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "&HELP";
            this.HelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HelpButton.UseVisualStyleBackColor = false;
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.SidebarPanel.Controls.Add(this.ButtonPanel);
            this.SidebarPanel.Controls.Add(this.UserPanel);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 25);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(200, 875);
            this.SidebarPanel.TabIndex = 39;
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.clientsControl1);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Location = new System.Drawing.Point(1594, 25);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(6, 875);
            this.AdminPanel.TabIndex = 2;
            // 
            // clientsControl1
            // 
            this.clientsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsControl1.Location = new System.Drawing.Point(0, 0);
            this.clientsControl1.Margin = new System.Windows.Forms.Padding(2);
            this.clientsControl1.Name = "clientsControl1";
            this.clientsControl1.Size = new System.Drawing.Size(6, 875);
            this.clientsControl1.TabIndex = 7;
            // 
            // ScheduleDTabPage
            // 
            this.ScheduleDTabPage.Controls.Add(this.scheduleD1);
            this.ScheduleDTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScheduleDTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleDTabPage.Name = "ScheduleDTabPage";
            this.ScheduleDTabPage.Size = new System.Drawing.Size(1386, 849);
            this.ScheduleDTabPage.TabIndex = 4;
            this.ScheduleDTabPage.Text = "Schedule D";
            this.ScheduleDTabPage.UseVisualStyleBackColor = true;
            // 
            // scheduleD1
            // 
            this.scheduleD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scheduleD1.Location = new System.Drawing.Point(4, 4);
            this.scheduleD1.Name = "scheduleD1";
            this.scheduleD1.Size = new System.Drawing.Size(722, 194);
            this.scheduleD1.TabIndex = 0;
            // 
            // Form1098_ETabPage
            // 
            this.Form1098_ETabPage.Controls.Add(this.form1098_E1);
            this.Form1098_ETabPage.Location = new System.Drawing.Point(4, 22);
            this.Form1098_ETabPage.Margin = new System.Windows.Forms.Padding(2);
            this.Form1098_ETabPage.Name = "Form1098_ETabPage";
            this.Form1098_ETabPage.Size = new System.Drawing.Size(1386, 849);
            this.Form1098_ETabPage.TabIndex = 3;
            this.Form1098_ETabPage.Text = "1098-E";
            this.Form1098_ETabPage.UseVisualStyleBackColor = true;
            // 
            // form1098_E1
            // 
            this.form1098_E1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.form1098_E1.Location = new System.Drawing.Point(4, 4);
            this.form1098_E1.Name = "form1098_E1";
            this.form1098_E1.Size = new System.Drawing.Size(341, 275);
            this.form1098_E1.TabIndex = 0;
            // 
            // ScheduleK_1TabPage
            // 
            this.ScheduleK_1TabPage.Controls.Add(this.scheduleK_11);
            this.ScheduleK_1TabPage.Location = new System.Drawing.Point(4, 22);
            this.ScheduleK_1TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ScheduleK_1TabPage.Name = "ScheduleK_1TabPage";
            this.ScheduleK_1TabPage.Size = new System.Drawing.Size(1386, 849);
            this.ScheduleK_1TabPage.TabIndex = 2;
            this.ScheduleK_1TabPage.Text = "ScheduleK-1";
            this.ScheduleK_1TabPage.UseVisualStyleBackColor = true;
            // 
            // scheduleK_11
            // 
            this.scheduleK_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scheduleK_11.Location = new System.Drawing.Point(4, 4);
            this.scheduleK_11.Name = "scheduleK_11";
            this.scheduleK_11.Size = new System.Drawing.Size(747, 633);
            this.scheduleK_11.TabIndex = 0;
            // 
            // Form1040TabPage
            // 
            this.Form1040TabPage.AutoScroll = true;
            this.Form1040TabPage.Controls.Add(this.form10401);
            this.Form1040TabPage.Location = new System.Drawing.Point(4, 22);
            this.Form1040TabPage.Name = "Form1040TabPage";
            this.Form1040TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Form1040TabPage.Size = new System.Drawing.Size(1386, 849);
            this.Form1040TabPage.TabIndex = 1;
            this.Form1040TabPage.Text = "Form1040";
            this.Form1040TabPage.UseVisualStyleBackColor = true;
            // 
            // form10401
            // 
            this.form10401.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.form10401.Location = new System.Drawing.Point(7, 7);
            this.form10401.Name = "form10401";
            this.form10401.Size = new System.Drawing.Size(785, 884);
            this.form10401.TabIndex = 0;
            // 
            // FormW2TabPage
            // 
            this.FormW2TabPage.Controls.Add(this.w2UserControl1);
            this.FormW2TabPage.Location = new System.Drawing.Point(4, 22);
            this.FormW2TabPage.Name = "FormW2TabPage";
            this.FormW2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FormW2TabPage.Size = new System.Drawing.Size(1386, 849);
            this.FormW2TabPage.TabIndex = 0;
            this.FormW2TabPage.Text = "Form W2";
            this.FormW2TabPage.UseVisualStyleBackColor = true;
            // 
            // TaxFormsTabControl
            // 
            this.TaxFormsTabControl.Controls.Add(this.FormW2TabPage);
            this.TaxFormsTabControl.Controls.Add(this.Form1040TabPage);
            this.TaxFormsTabControl.Controls.Add(this.ScheduleK_1TabPage);
            this.TaxFormsTabControl.Controls.Add(this.Form1098_ETabPage);
            this.TaxFormsTabControl.Controls.Add(this.ScheduleDTabPage);
            this.TaxFormsTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TaxFormsTabControl.Location = new System.Drawing.Point(200, 25);
            this.TaxFormsTabControl.Name = "TaxFormsTabControl";
            this.TaxFormsTabControl.SelectedIndex = 0;
            this.TaxFormsTabControl.Size = new System.Drawing.Size(1394, 875);
            this.TaxFormsTabControl.TabIndex = 0;
            // 
            // w2UserControl1
            // 
            this.w2UserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.w2UserControl1.Location = new System.Drawing.Point(7, 7);
            this.w2UserControl1.Name = "w2UserControl1";
            this.w2UserControl1.Size = new System.Drawing.Size(995, 612);
            this.w2UserControl1.TabIndex = 0;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.TaxFormsTabControl);
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.MenuStrip);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1600, 900);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.SidebarPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.ScheduleDTabPage.ResumeLayout(false);
            this.Form1098_ETabPage.ResumeLayout(false);
            this.ScheduleK_1TabPage.ResumeLayout(false);
            this.Form1040TabPage.ResumeLayout(false);
            this.FormW2TabPage.ResumeLayout(false);
            this.TaxFormsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage Form1040TabPage;
        private System.Windows.Forms.TabPage FormW2TabPage;
        private System.Windows.Forms.TabControl TaxFormsTabControl;
        private ClientsControl clientsControl1;
        private Form1040 form10401;
        private W2UserControl w2UserControl1;
    }
}
