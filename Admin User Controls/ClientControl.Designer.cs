namespace TaxApp_v2.Admin_User_Controls
{
    partial class ClientControl
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
            components = new System.ComponentModel.Container();
            savingsRadioButton = new RadioButton();
            checkingRadioButton = new RadioButton();
            client_idLabel = new Label();
            client_idTextBox = new TextBox();
            first_nameLabel = new Label();
            first_nameTextBox = new TextBox();
            middle_nameLabel = new Label();
            middle_nameTextBox = new TextBox();
            last_nameLabel = new Label();
            last_nameTextBox = new TextBox();
            suffixLabel = new Label();
            suffixTextBox = new TextBox();
            ssnLabel = new Label();
            ssnTextBox = new TextBox();
            birth_dateLabel = new Label();
            birth_dateDateTimePicker = new DateTimePicker();
            home_phoneLabel = new Label();
            home_phoneTextBox = new TextBox();
            mobile_phoneLabel = new Label();
            mobile_phoneTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            address_line1Label = new Label();
            address_line1TextBox = new TextBox();
            address_line2Label = new Label();
            address_line2TextBox = new TextBox();
            cityLabel = new Label();
            cityTextBox = new TextBox();
            stateLabel = new Label();
            stateTextBox = new TextBox();
            zipLabel = new Label();
            zipTextBox = new TextBox();
            occupationLabel = new Label();
            occupationTextBox = new TextBox();
            routing_numberLabel = new Label();
            routing_numberTextBox = new TextBox();
            account_numberLabel = new Label();
            account_numberTextBox = new TextBox();
            user_idLabel = new Label();
            user_idTextBox = new TextBox();
            DeleteButton = new Button();
            CreateNewButton = new Button();
            RefreshButton = new Button();
            SaveButton = new Button();
            clientTitleLabel = new Label();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            accountTypePanel = new Panel();
            ClientDataGridView = new DataGridView();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suffixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ssnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            homePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobilePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressLine1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressLine2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            occupationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            routingNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            savingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            TaxFormsButton = new Button();
            accountTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // savingsRadioButton
            // 
            savingsRadioButton.AutoSize = true;
            savingsRadioButton.Location = new Point(15, 25);
            savingsRadioButton.Name = "savingsRadioButton";
            savingsRadioButton.Size = new Size(65, 19);
            savingsRadioButton.TabIndex = 102;
            savingsRadioButton.TabStop = true;
            savingsRadioButton.Text = "Savings";
            savingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkingRadioButton
            // 
            checkingRadioButton.AutoSize = true;
            checkingRadioButton.Location = new Point(15, 4);
            checkingRadioButton.Name = "checkingRadioButton";
            checkingRadioButton.Size = new Size(75, 19);
            checkingRadioButton.TabIndex = 101;
            checkingRadioButton.TabStop = true;
            checkingRadioButton.Text = "Checking";
            checkingRadioButton.UseVisualStyleBackColor = true;
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new Point(23, 260);
            client_idLabel.Margin = new Padding(2, 0, 2, 0);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new Size(55, 15);
            client_idLabel.TabIndex = 61;
            client_idLabel.Text = "Client ID:";
            // 
            // client_idTextBox
            // 
            client_idTextBox.Location = new Point(127, 258);
            client_idTextBox.Margin = new Padding(2);
            client_idTextBox.Name = "client_idTextBox";
            client_idTextBox.ReadOnly = true;
            client_idTextBox.Size = new Size(156, 23);
            client_idTextBox.TabIndex = 62;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new Point(23, 284);
            first_nameLabel.Margin = new Padding(2, 0, 2, 0);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new Size(67, 15);
            first_nameLabel.TabIndex = 63;
            first_nameLabel.Text = "First Name:";
            // 
            // first_nameTextBox
            // 
            first_nameTextBox.Location = new Point(127, 282);
            first_nameTextBox.Margin = new Padding(2);
            first_nameTextBox.Name = "first_nameTextBox";
            first_nameTextBox.Size = new Size(156, 23);
            first_nameTextBox.TabIndex = 64;
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new Point(23, 308);
            middle_nameLabel.Margin = new Padding(2, 0, 2, 0);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new Size(82, 15);
            middle_nameLabel.TabIndex = 65;
            middle_nameLabel.Text = "Middle Name:";
            // 
            // middle_nameTextBox
            // 
            middle_nameTextBox.Location = new Point(127, 306);
            middle_nameTextBox.Margin = new Padding(2);
            middle_nameTextBox.Name = "middle_nameTextBox";
            middle_nameTextBox.Size = new Size(156, 23);
            middle_nameTextBox.TabIndex = 66;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new Point(23, 332);
            last_nameLabel.Margin = new Padding(2, 0, 2, 0);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new Size(66, 15);
            last_nameLabel.TabIndex = 67;
            last_nameLabel.Text = "Last Name:";
            // 
            // last_nameTextBox
            // 
            last_nameTextBox.Location = new Point(127, 330);
            last_nameTextBox.Margin = new Padding(2);
            last_nameTextBox.Name = "last_nameTextBox";
            last_nameTextBox.Size = new Size(156, 23);
            last_nameTextBox.TabIndex = 68;
            // 
            // suffixLabel
            // 
            suffixLabel.AutoSize = true;
            suffixLabel.Location = new Point(23, 356);
            suffixLabel.Margin = new Padding(2, 0, 2, 0);
            suffixLabel.Name = "suffixLabel";
            suffixLabel.Size = new Size(40, 15);
            suffixLabel.TabIndex = 69;
            suffixLabel.Text = "Suffix:";
            // 
            // suffixTextBox
            // 
            suffixTextBox.Location = new Point(127, 354);
            suffixTextBox.Margin = new Padding(2);
            suffixTextBox.Name = "suffixTextBox";
            suffixTextBox.Size = new Size(156, 23);
            suffixTextBox.TabIndex = 70;
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new Point(313, 260);
            ssnLabel.Margin = new Padding(2, 0, 2, 0);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new Size(31, 15);
            ssnLabel.TabIndex = 71;
            ssnLabel.Text = "SSN:";
            // 
            // ssnTextBox
            // 
            ssnTextBox.Location = new Point(417, 258);
            ssnTextBox.Margin = new Padding(2);
            ssnTextBox.Name = "ssnTextBox";
            ssnTextBox.Size = new Size(156, 23);
            ssnTextBox.TabIndex = 72;
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new Point(313, 285);
            birth_dateLabel.Margin = new Padding(2, 0, 2, 0);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new Size(62, 15);
            birth_dateLabel.TabIndex = 73;
            birth_dateLabel.Text = "Birth Date:";
            // 
            // birth_dateDateTimePicker
            // 
            birth_dateDateTimePicker.Format = DateTimePickerFormat.Short;
            birth_dateDateTimePicker.Location = new Point(417, 282);
            birth_dateDateTimePicker.Margin = new Padding(2);
            birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            birth_dateDateTimePicker.Size = new Size(156, 23);
            birth_dateDateTimePicker.TabIndex = 74;
            // 
            // home_phoneLabel
            // 
            home_phoneLabel.AutoSize = true;
            home_phoneLabel.Location = new Point(313, 308);
            home_phoneLabel.Margin = new Padding(2, 0, 2, 0);
            home_phoneLabel.Name = "home_phoneLabel";
            home_phoneLabel.Size = new Size(80, 15);
            home_phoneLabel.TabIndex = 75;
            home_phoneLabel.Text = "Home Phone:";
            // 
            // home_phoneTextBox
            // 
            home_phoneTextBox.Location = new Point(417, 306);
            home_phoneTextBox.Margin = new Padding(2);
            home_phoneTextBox.Name = "home_phoneTextBox";
            home_phoneTextBox.Size = new Size(156, 23);
            home_phoneTextBox.TabIndex = 76;
            // 
            // mobile_phoneLabel
            // 
            mobile_phoneLabel.AutoSize = true;
            mobile_phoneLabel.Location = new Point(313, 332);
            mobile_phoneLabel.Margin = new Padding(2, 0, 2, 0);
            mobile_phoneLabel.Name = "mobile_phoneLabel";
            mobile_phoneLabel.Size = new Size(84, 15);
            mobile_phoneLabel.TabIndex = 77;
            mobile_phoneLabel.Text = "Mobile Phone:";
            // 
            // mobile_phoneTextBox
            // 
            mobile_phoneTextBox.Location = new Point(417, 330);
            mobile_phoneTextBox.Margin = new Padding(2);
            mobile_phoneTextBox.Name = "mobile_phoneTextBox";
            mobile_phoneTextBox.Size = new Size(156, 23);
            mobile_phoneTextBox.TabIndex = 78;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(313, 356);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 79;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(417, 354);
            emailTextBox.Margin = new Padding(2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(156, 23);
            emailTextBox.TabIndex = 80;
            // 
            // address_line1Label
            // 
            address_line1Label.AutoSize = true;
            address_line1Label.Location = new Point(602, 260);
            address_line1Label.Margin = new Padding(2, 0, 2, 0);
            address_line1Label.Name = "address_line1Label";
            address_line1Label.Size = new Size(86, 15);
            address_line1Label.TabIndex = 81;
            address_line1Label.Text = "Address Line 1:";
            // 
            // address_line1TextBox
            // 
            address_line1TextBox.Location = new Point(706, 258);
            address_line1TextBox.Margin = new Padding(2);
            address_line1TextBox.Name = "address_line1TextBox";
            address_line1TextBox.Size = new Size(156, 23);
            address_line1TextBox.TabIndex = 82;
            // 
            // address_line2Label
            // 
            address_line2Label.AutoSize = true;
            address_line2Label.Location = new Point(602, 284);
            address_line2Label.Margin = new Padding(2, 0, 2, 0);
            address_line2Label.Name = "address_line2Label";
            address_line2Label.Size = new Size(86, 15);
            address_line2Label.TabIndex = 83;
            address_line2Label.Text = "Address Line 2:";
            // 
            // address_line2TextBox
            // 
            address_line2TextBox.Location = new Point(706, 282);
            address_line2TextBox.Margin = new Padding(2);
            address_line2TextBox.Name = "address_line2TextBox";
            address_line2TextBox.Size = new Size(156, 23);
            address_line2TextBox.TabIndex = 84;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(602, 308);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 85;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(706, 306);
            cityTextBox.Margin = new Padding(2);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(156, 23);
            cityTextBox.TabIndex = 86;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(602, 332);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(36, 15);
            stateLabel.TabIndex = 87;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(706, 330);
            stateTextBox.Margin = new Padding(2);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(156, 23);
            stateTextBox.TabIndex = 88;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new Point(602, 356);
            zipLabel.Margin = new Padding(2, 0, 2, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(27, 15);
            zipLabel.TabIndex = 89;
            zipLabel.Text = "ZIP:";
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(706, 354);
            zipTextBox.Margin = new Padding(2);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(156, 23);
            zipTextBox.TabIndex = 90;
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new Point(928, 260);
            occupationLabel.Margin = new Padding(2, 0, 2, 0);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new Size(72, 15);
            occupationLabel.TabIndex = 91;
            occupationLabel.Text = "Occupation:";
            // 
            // occupationTextBox
            // 
            occupationTextBox.Location = new Point(1032, 258);
            occupationTextBox.Margin = new Padding(2);
            occupationTextBox.Name = "occupationTextBox";
            occupationTextBox.Size = new Size(156, 23);
            occupationTextBox.TabIndex = 92;
            // 
            // routing_numberLabel
            // 
            routing_numberLabel.AutoSize = true;
            routing_numberLabel.Location = new Point(928, 284);
            routing_numberLabel.Margin = new Padding(2, 0, 2, 0);
            routing_numberLabel.Name = "routing_numberLabel";
            routing_numberLabel.Size = new Size(99, 15);
            routing_numberLabel.TabIndex = 93;
            routing_numberLabel.Text = "Routing Number:";
            // 
            // routing_numberTextBox
            // 
            routing_numberTextBox.Location = new Point(1032, 282);
            routing_numberTextBox.Margin = new Padding(2);
            routing_numberTextBox.Name = "routing_numberTextBox";
            routing_numberTextBox.Size = new Size(156, 23);
            routing_numberTextBox.TabIndex = 94;
            // 
            // account_numberLabel
            // 
            account_numberLabel.AutoSize = true;
            account_numberLabel.Location = new Point(928, 308);
            account_numberLabel.Margin = new Padding(2, 0, 2, 0);
            account_numberLabel.Name = "account_numberLabel";
            account_numberLabel.Size = new Size(102, 15);
            account_numberLabel.TabIndex = 95;
            account_numberLabel.Text = "Account Number:";
            // 
            // account_numberTextBox
            // 
            account_numberTextBox.Location = new Point(1032, 306);
            account_numberTextBox.Margin = new Padding(2);
            account_numberTextBox.Name = "account_numberTextBox";
            account_numberTextBox.Size = new Size(156, 23);
            account_numberTextBox.TabIndex = 96;
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new Point(928, 379);
            user_idLabel.Margin = new Padding(2, 0, 2, 0);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new Size(47, 15);
            user_idLabel.TabIndex = 99;
            user_idLabel.Text = "User ID:";
            // 
            // user_idTextBox
            // 
            user_idTextBox.Location = new Point(1032, 376);
            user_idTextBox.Margin = new Padding(2);
            user_idTextBox.Name = "user_idTextBox";
            user_idTextBox.ReadOnly = true;
            user_idTextBox.Size = new Size(156, 23);
            user_idTextBox.TabIndex = 100;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(519, 429);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 26);
            DeleteButton.TabIndex = 60;
            DeleteButton.Text = "&Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CreateNewButton
            // 
            CreateNewButton.Location = new Point(426, 429);
            CreateNewButton.Margin = new Padding(3, 4, 3, 4);
            CreateNewButton.Name = "CreateNewButton";
            CreateNewButton.Size = new Size(87, 26);
            CreateNewButton.TabIndex = 57;
            CreateNewButton.Text = "&Create New";
            CreateNewButton.UseVisualStyleBackColor = true;
            CreateNewButton.Click += CreateNewButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(706, 429);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(87, 26);
            RefreshButton.TabIndex = 56;
            RefreshButton.Text = "&Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(613, 429);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(87, 26);
            SaveButton.TabIndex = 55;
            SaveButton.Text = "&Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // clientTitleLabel
            // 
            clientTitleLabel.AutoSize = true;
            clientTitleLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientTitleLabel.Location = new Point(3, 4);
            clientTitleLabel.Margin = new Padding(3, 4, 3, 4);
            clientTitleLabel.Name = "clientTitleLabel";
            clientTitleLabel.Size = new Size(113, 36);
            clientTitleLabel.TabIndex = 105;
            clientTitleLabel.Text = "Clients";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(24, 50);
            searchLabel.Margin = new Padding(3, 4, 3, 4);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(45, 15);
            searchLabel.TabIndex = 103;
            searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(81, 48);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(254, 23);
            searchTextBox.TabIndex = 104;
            // 
            // accountTypePanel
            // 
            accountTypePanel.Controls.Add(savingsRadioButton);
            accountTypePanel.Controls.Add(checkingRadioButton);
            accountTypePanel.Location = new Point(1032, 329);
            accountTypePanel.Name = "accountTypePanel";
            accountTypePanel.Size = new Size(93, 48);
            accountTypePanel.TabIndex = 106;
            // 
            // ClientDataGridView
            // 
            ClientDataGridView.AllowUserToAddRows = false;
            ClientDataGridView.AllowUserToDeleteRows = false;
            ClientDataGridView.AllowUserToResizeRows = false;
            ClientDataGridView.AutoGenerateColumns = false;
            ClientDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            ClientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, ssnDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, homePhoneDataGridViewTextBoxColumn, mobilePhoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressLine1DataGridViewTextBoxColumn, addressLine2DataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, zipDataGridViewTextBoxColumn, occupationDataGridViewTextBoxColumn, routingNumberDataGridViewTextBoxColumn, accountNumberDataGridViewTextBoxColumn, checkingDataGridViewTextBoxColumn, savingsDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn });
            ClientDataGridView.DataSource = clientBindingSource;
            ClientDataGridView.Location = new Point(3, 85);
            ClientDataGridView.Name = "ClientDataGridView";
            ClientDataGridView.Size = new Size(1217, 150);
            ClientDataGridView.TabIndex = 107;
            ClientDataGridView.CellClick += ClientDataGridView_CellClick;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.Width = 5;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 5;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.Width = 5;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 5;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            suffixDataGridViewTextBoxColumn.Width = 5;
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            ssnDataGridViewTextBoxColumn.DataPropertyName = "Ssn";
            ssnDataGridViewTextBoxColumn.HeaderText = "Ssn";
            ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            ssnDataGridViewTextBoxColumn.Width = 5;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.Width = 5;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            homePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone";
            homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            homePhoneDataGridViewTextBoxColumn.Width = 5;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.HeaderText = "MobilePhone";
            mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            mobilePhoneDataGridViewTextBoxColumn.Width = 5;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 5;
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            addressLine1DataGridViewTextBoxColumn.Width = 5;
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            addressLine2DataGridViewTextBoxColumn.Width = 5;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.Width = 5;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.Width = 5;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            zipDataGridViewTextBoxColumn.HeaderText = "Zip";
            zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            zipDataGridViewTextBoxColumn.Width = 5;
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            occupationDataGridViewTextBoxColumn.Width = 5;
            // 
            // routingNumberDataGridViewTextBoxColumn
            // 
            routingNumberDataGridViewTextBoxColumn.DataPropertyName = "RoutingNumber";
            routingNumberDataGridViewTextBoxColumn.HeaderText = "RoutingNumber";
            routingNumberDataGridViewTextBoxColumn.Name = "routingNumberDataGridViewTextBoxColumn";
            routingNumberDataGridViewTextBoxColumn.Width = 5;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            accountNumberDataGridViewTextBoxColumn.Width = 5;
            // 
            // checkingDataGridViewTextBoxColumn
            // 
            checkingDataGridViewTextBoxColumn.DataPropertyName = "Checking";
            checkingDataGridViewTextBoxColumn.HeaderText = "Checking";
            checkingDataGridViewTextBoxColumn.Name = "checkingDataGridViewTextBoxColumn";
            checkingDataGridViewTextBoxColumn.Width = 5;
            // 
            // savingsDataGridViewTextBoxColumn
            // 
            savingsDataGridViewTextBoxColumn.DataPropertyName = "Savings";
            savingsDataGridViewTextBoxColumn.HeaderText = "Savings";
            savingsDataGridViewTextBoxColumn.Name = "savingsDataGridViewTextBoxColumn";
            savingsDataGridViewTextBoxColumn.Width = 5;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 5;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Models.DataLayer.Client);
            // 
            // TaxFormsButton
            // 
            TaxFormsButton.Location = new Point(973, 429);
            TaxFormsButton.Margin = new Padding(3, 4, 3, 4);
            TaxFormsButton.Name = "TaxFormsButton";
            TaxFormsButton.Size = new Size(115, 26);
            TaxFormsButton.TabIndex = 108;
            TaxFormsButton.Text = "&Access Tax Forms";
            TaxFormsButton.UseVisualStyleBackColor = true;
            TaxFormsButton.Click += TaxFormsButton_Click;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TaxFormsButton);
            Controls.Add(ClientDataGridView);
            Controls.Add(accountTypePanel);
            Controls.Add(clientTitleLabel);
            Controls.Add(searchLabel);
            Controls.Add(searchTextBox);
            Controls.Add(client_idLabel);
            Controls.Add(client_idTextBox);
            Controls.Add(first_nameLabel);
            Controls.Add(first_nameTextBox);
            Controls.Add(middle_nameLabel);
            Controls.Add(middle_nameTextBox);
            Controls.Add(last_nameLabel);
            Controls.Add(last_nameTextBox);
            Controls.Add(suffixLabel);
            Controls.Add(suffixTextBox);
            Controls.Add(ssnLabel);
            Controls.Add(ssnTextBox);
            Controls.Add(birth_dateLabel);
            Controls.Add(birth_dateDateTimePicker);
            Controls.Add(home_phoneLabel);
            Controls.Add(home_phoneTextBox);
            Controls.Add(mobile_phoneLabel);
            Controls.Add(mobile_phoneTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(address_line1Label);
            Controls.Add(address_line1TextBox);
            Controls.Add(address_line2Label);
            Controls.Add(address_line2TextBox);
            Controls.Add(cityLabel);
            Controls.Add(cityTextBox);
            Controls.Add(stateLabel);
            Controls.Add(stateTextBox);
            Controls.Add(zipLabel);
            Controls.Add(zipTextBox);
            Controls.Add(occupationLabel);
            Controls.Add(occupationTextBox);
            Controls.Add(routing_numberLabel);
            Controls.Add(routing_numberTextBox);
            Controls.Add(account_numberLabel);
            Controls.Add(account_numberTextBox);
            Controls.Add(user_idLabel);
            Controls.Add(user_idTextBox);
            Controls.Add(DeleteButton);
            Controls.Add(CreateNewButton);
            Controls.Add(RefreshButton);
            Controls.Add(SaveButton);
            Name = "ClientControl";
            Size = new Size(1223, 459);
            accountTypePanel.ResumeLayout(false);
            accountTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton savingsRadioButton;
        private RadioButton checkingRadioButton;
        private Label client_idLabel;
        private TextBox client_idTextBox;
        private Label first_nameLabel;
        private TextBox first_nameTextBox;
        private Label middle_nameLabel;
        private TextBox middle_nameTextBox;
        private Label last_nameLabel;
        private TextBox last_nameTextBox;
        private Label suffixLabel;
        private TextBox suffixTextBox;
        private Label ssnLabel;
        private TextBox ssnTextBox;
        private Label birth_dateLabel;
        private DateTimePicker birth_dateDateTimePicker;
        private Label home_phoneLabel;
        private TextBox home_phoneTextBox;
        private Label mobile_phoneLabel;
        private TextBox mobile_phoneTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label address_line1Label;
        private TextBox address_line1TextBox;
        private Label address_line2Label;
        private TextBox address_line2TextBox;
        private Label cityLabel;
        private TextBox cityTextBox;
        private Label stateLabel;
        private TextBox stateTextBox;
        private Label zipLabel;
        private TextBox zipTextBox;
        private Label occupationLabel;
        private TextBox occupationTextBox;
        private Label routing_numberLabel;
        private TextBox routing_numberTextBox;
        private Label account_numberLabel;
        private TextBox account_numberTextBox;
        private Label user_idLabel;
        private TextBox user_idTextBox;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button ReadButton;
        private Button CreateNewButton;
        private Button RefreshButton;
        private Button SaveButton;
        private Label clientTitleLabel;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Panel accountTypePanel;
        private DataGridView ClientDataGridView;
        private BindingSource clientBindingSource;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn routingNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn savingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private Button TaxFormsButton;
    }
}
