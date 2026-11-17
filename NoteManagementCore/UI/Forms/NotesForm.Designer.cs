namespace NoteManagementCore.UI.Forms
{
    partial class NotesForm
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
            NotesTLP = new TableLayoutPanel();
            ContentTLP = new TableLayoutPanel();
            NotesGrid = new DataGridView();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            ContentLabel = new Label();
            ContentTextBox = new TextBox();
            ControlsTLP = new TableLayoutPanel();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ClearSelectionButton = new Button();
            StatusLabel = new Label();
            NotesTLP.SuspendLayout();
            ContentTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGrid).BeginInit();
            ControlsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // NotesTLP
            // 
            NotesTLP.ColumnCount = 2;
            NotesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            NotesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NotesTLP.Controls.Add(ContentTLP, 0, 0);
            NotesTLP.Controls.Add(ControlsTLP, 1, 0);
            NotesTLP.Controls.Add(StatusLabel, 0, 1);
            NotesTLP.Dock = DockStyle.Fill;
            NotesTLP.Location = new Point(0, 0);
            NotesTLP.Name = "NotesTLP";
            NotesTLP.RowCount = 2;
            NotesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            NotesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            NotesTLP.Size = new Size(784, 411);
            NotesTLP.TabIndex = 0;
            // 
            // ContentTLP
            // 
            ContentTLP.ColumnCount = 1;
            ContentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContentTLP.Controls.Add(NotesGrid, 0, 0);
            ContentTLP.Controls.Add(TitleLabel, 0, 1);
            ContentTLP.Controls.Add(TitleTextBox, 0, 2);
            ContentTLP.Controls.Add(ContentLabel, 0, 3);
            ContentTLP.Controls.Add(ContentTextBox, 0, 4);
            ContentTLP.Dock = DockStyle.Fill;
            ContentTLP.Location = new Point(3, 3);
            ContentTLP.Name = "ContentTLP";
            ContentTLP.RowCount = 5;
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            ContentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ContentTLP.Size = new Size(582, 343);
            ContentTLP.TabIndex = 1;
            // 
            // NotesGrid
            // 
            NotesGrid.AllowUserToAddRows = false;
            NotesGrid.AllowUserToDeleteRows = false;
            NotesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesGrid.Dock = DockStyle.Fill;
            NotesGrid.Location = new Point(3, 3);
            NotesGrid.MultiSelect = false;
            NotesGrid.Name = "NotesGrid";
            NotesGrid.ReadOnly = true;
            NotesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotesGrid.Size = new Size(576, 108);
            NotesGrid.TabIndex = 3;
            NotesGrid.SelectionChanged += NotesGrid_SelectionChanged;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Location = new Point(3, 114);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(576, 38);
            TitleLabel.TabIndex = 11;
            TitleLabel.Text = "Title:";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.Location = new Point(3, 155);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(576, 23);
            TitleTextBox.TabIndex = 4;
            // 
            // ContentLabel
            // 
            ContentLabel.AutoSize = true;
            ContentLabel.Dock = DockStyle.Fill;
            ContentLabel.Location = new Point(3, 190);
            ContentLabel.Name = "ContentLabel";
            ContentLabel.Size = new Size(576, 38);
            ContentLabel.TabIndex = 12;
            ContentLabel.Text = "Content:";
            ContentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContentTextBox
            // 
            ContentTextBox.Dock = DockStyle.Fill;
            ContentTextBox.Location = new Point(3, 231);
            ContentTextBox.Multiline = true;
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.ScrollBars = ScrollBars.Vertical;
            ContentTextBox.Size = new Size(576, 109);
            ContentTextBox.TabIndex = 5;
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
            NotesTLP.SetRowSpan(ControlsTLP, 2);
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ControlsTLP.Size = new Size(190, 405);
            ControlsTLP.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(184, 95);
            AddButton.TabIndex = 6;
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
            UpdateButton.TabIndex = 7;
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
            DeleteButton.TabIndex = 8;
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
            ClearSelectionButton.TabIndex = 9;
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
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "...";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(NotesTLP);
            Name = "NotesForm";
            Text = "Notes";
            NotesTLP.ResumeLayout(false);
            NotesTLP.PerformLayout();
            ContentTLP.ResumeLayout(false);
            ContentTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGrid).EndInit();
            ControlsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel NotesTLP;
        private TableLayoutPanel ContentTLP;
        private DataGridView NotesGrid;
        private TableLayoutPanel ControlsTLP;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label ContentLabel;
        private TextBox ContentTextBox;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearSelectionButton;
        private Label StatusLabel;
    }
}