namespace NoteManagementCore.UI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTLP = new TableLayoutPanel();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            LoginButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            LoginTLP.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTLP
            // 
            LoginTLP.ColumnCount = 1;
            LoginTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LoginTLP.Controls.Add(UsernameLabel, 0, 0);
            LoginTLP.Controls.Add(UsernameTextBox, 0, 1);
            LoginTLP.Controls.Add(PasswordLabel, 0, 2);
            LoginTLP.Controls.Add(PasswordMaskedTextBox, 0, 3);
            LoginTLP.Controls.Add(LoginButton, 0, 4);
            LoginTLP.Controls.Add(ShowPasswordCheckBox, 0, 5);
            LoginTLP.Dock = DockStyle.Fill;
            LoginTLP.Location = new Point(0, 0);
            LoginTLP.Name = "LoginTLP";
            LoginTLP.RowCount = 6;
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            LoginTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LoginTLP.Size = new Size(268, 222);
            LoginTLP.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Dock = DockStyle.Fill;
            UsernameLabel.Location = new Point(3, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(262, 33);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username:";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Dock = DockStyle.Fill;
            UsernameTextBox.Location = new Point(3, 36);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(262, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Dock = DockStyle.Fill;
            PasswordLabel.Location = new Point(3, 55);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(262, 33);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            PasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.Dock = DockStyle.Fill;
            PasswordMaskedTextBox.Location = new Point(3, 91);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(262, 23);
            PasswordMaskedTextBox.TabIndex = 4;
            PasswordMaskedTextBox.TextAlign = HorizontalAlignment.Center;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Location = new Point(3, 113);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(262, 60);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.Appearance = Appearance.Button;
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Dock = DockStyle.Fill;
            ShowPasswordCheckBox.Location = new Point(3, 179);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(262, 40);
            ShowPasswordCheckBox.TabIndex = 6;
            ShowPasswordCheckBox.Text = "Show Password?";
            ShowPasswordCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginForm
            // 
            AcceptButton = LoginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 222);
            Controls.Add(LoginTLP);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LoginTLP.ResumeLayout(false);
            LoginTLP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LoginTLP;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Button LoginButton;
        private CheckBox ShowPasswordCheckBox;
    }
}
