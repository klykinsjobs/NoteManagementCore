namespace NoteManagementCore.UI.Forms
{
    partial class ManageUsersForm
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
            ManageUsersTLP = new TableLayoutPanel();
            ContentTLP = new TableLayoutPanel();
            UsersGrid = new DataGridView();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            RoleLabel = new Label();
            RoleComboBox = new ComboBox();
            ControlsTLP = new TableLayoutPanel();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ClearSelectionButton = new Button();
            StatusLabel = new Label();
            ManageUsersTLP.SuspendLayout();
            ContentTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).BeginInit();
            ControlsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // ManageUsersTLP
            // 
            ManageUsersTLP.ColumnCount = 2;
            ManageUsersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            ManageUsersTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ManageUsersTLP.Controls.Add(ContentTLP, 0, 0);
            ManageUsersTLP.Controls.Add(ControlsTLP, 1, 0);
            ManageUsersTLP.Controls.Add(StatusLabel, 0, 1);
            ManageUsersTLP.Dock = DockStyle.Fill;
            ManageUsersTLP.Location = new Point(0, 0);
            ManageUsersTLP.Name = "ManageUsersTLP";
            ManageUsersTLP.RowCount = 2;
            ManageUsersTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            ManageUsersTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            ManageUsersTLP.Size = new Size(784, 411);
            ManageUsersTLP.TabIndex = 0;
            // 
            // ContentTLP
            // 
            ContentTLP.ColumnCount = 1;
            ContentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContentTLP.Controls.Add(UsersGrid, 0, 0);
            ContentTLP.Controls.Add(UsernameLabel, 0, 1);
            ContentTLP.Controls.Add(UsernameTextBox, 0, 2);
            ContentTLP.Controls.Add(PasswordLabel, 0, 3);
            ContentTLP.Controls.Add(PasswordMaskedTextBox, 0, 4);
            ContentTLP.Controls.Add(RoleLabel, 0, 5);
            ContentTLP.Controls.Add(RoleComboBox, 0, 6);
            ContentTLP.Dock = DockStyle.Fill;
            ContentTLP.Location = new Point(3, 3);
            ContentTLP.Name = "ContentTLP";
            ContentTLP.RowCount = 7;
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 36.86105F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5231552F));
            ContentTLP.Size = new Size(582, 343);
            ContentTLP.TabIndex = 2;
            // 
            // UsersGrid
            // 
            UsersGrid.AllowUserToAddRows = false;
            UsersGrid.AllowUserToDeleteRows = false;
            UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGrid.Dock = DockStyle.Fill;
            UsersGrid.Location = new Point(3, 3);
            UsersGrid.MultiSelect = false;
            UsersGrid.Name = "UsersGrid";
            UsersGrid.ReadOnly = true;
            UsersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGrid.Size = new Size(576, 120);
            UsersGrid.TabIndex = 3;
            UsersGrid.SelectionChanged += UsersGrid_SelectionChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Dock = DockStyle.Fill;
            UsernameLabel.Location = new Point(3, 126);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(576, 36);
            UsernameLabel.TabIndex = 12;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Dock = DockStyle.Fill;
            UsernameTextBox.Location = new Point(3, 165);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(576, 23);
            UsernameTextBox.TabIndex = 4;
            UsernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Dock = DockStyle.Fill;
            PasswordLabel.Location = new Point(3, 198);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(576, 36);
            PasswordLabel.TabIndex = 13;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.Dock = DockStyle.Fill;
            PasswordMaskedTextBox.Location = new Point(3, 237);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(576, 23);
            PasswordMaskedTextBox.TabIndex = 5;
            PasswordMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Dock = DockStyle.Fill;
            RoleLabel.Location = new Point(3, 270);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(576, 36);
            RoleLabel.TabIndex = 14;
            RoleLabel.Text = "Role";
            RoleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoleComboBox
            // 
            RoleComboBox.Dock = DockStyle.Fill;
            RoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Location = new Point(3, 309);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(576, 23);
            RoleComboBox.TabIndex = 6;
            // 
            // ControlsTLP
            // 
            ControlsTLP.ColumnCount = 1;
            ControlsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ControlsTLP.Controls.Add(AddButton, 0, 0);
            ControlsTLP.Controls.Add(UpdateButton, 0, 1);
            ControlsTLP.Controls.Add(DeleteButton, 0, 2);
            ControlsTLP.Controls.Add(ClearSelectionButton, 0, 3);
            ControlsTLP.Dock = DockStyle.Fill;
            ControlsTLP.Location = new Point(591, 3);
            ControlsTLP.Name = "ControlsTLP";
            ControlsTLP.RowCount = 4;
            ManageUsersTLP.SetRowSpan(ControlsTLP, 2);
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.Size = new Size(190, 405);
            ControlsTLP.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(184, 95);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Fill;
            UpdateButton.Location = new Point(3, 104);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(184, 95);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Location = new Point(3, 205);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(184, 95);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearSelectionButton
            // 
            ClearSelectionButton.Dock = DockStyle.Fill;
            ClearSelectionButton.Location = new Point(3, 306);
            ClearSelectionButton.Name = "ClearSelectionButton";
            ClearSelectionButton.Size = new Size(184, 96);
            ClearSelectionButton.TabIndex = 10;
            ClearSelectionButton.Text = "Clear Selection";
            ClearSelectionButton.UseVisualStyleBackColor = true;
            ClearSelectionButton.Click += ClearSelectionButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Dock = DockStyle.Fill;
            StatusLabel.Location = new Point(3, 349);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(582, 62);
            StatusLabel.TabIndex = 11;
            StatusLabel.Text = "...";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(ManageUsersTLP);
            Name = "ManageUsersForm";
            Text = "Manage Users";
            ManageUsersTLP.ResumeLayout(false);
            ManageUsersTLP.PerformLayout();
            ContentTLP.ResumeLayout(false);
            ContentTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).EndInit();
            ControlsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ManageUsersTLP;
        private TableLayoutPanel ContentTLP;
        private TableLayoutPanel ControlsTLP;
        private DataGridView UsersGrid;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label RoleLabel;
        private ComboBox RoleComboBox;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearSelectionButton;
        private Label StatusLabel;
    }
}