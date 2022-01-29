
namespace Account_Docs_Workers
{
    partial class WorkerCardForm
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.IssuedDocumentsLabel = new System.Windows.Forms.Label();
            this.issuedDocumentsGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDocumentButton = new System.Windows.Forms.Button();
            this.DocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.workerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.workerBirthDayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.issuedDocumentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FullNameLabel.Location = new System.Drawing.Point(682, 24);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(70, 29);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "ФИО";
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BirthDayLabel.Location = new System.Drawing.Point(596, 99);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(161, 25);
            this.BirthDayLabel.TabIndex = 1;
            this.BirthDayLabel.Text = "Дата рождения";
            // 
            // IssuedDocumentsLabel
            // 
            this.IssuedDocumentsLabel.AutoSize = true;
            this.IssuedDocumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IssuedDocumentsLabel.Location = new System.Drawing.Point(34, 157);
            this.IssuedDocumentsLabel.Name = "IssuedDocumentsLabel";
            this.IssuedDocumentsLabel.Size = new System.Drawing.Size(267, 29);
            this.IssuedDocumentsLabel.TabIndex = 2;
            this.IssuedDocumentsLabel.Text = "Выданные документы";
            // 
            // issuedDocumentsGridView
            // 
            this.issuedDocumentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedDocumentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateColumn});
            this.issuedDocumentsGridView.Location = new System.Drawing.Point(39, 189);
            this.issuedDocumentsGridView.Name = "issuedDocumentsGridView";
            this.issuedDocumentsGridView.RowHeadersWidth = 62;
            this.issuedDocumentsGridView.RowTemplate.Height = 28;
            this.issuedDocumentsGridView.Size = new System.Drawing.Size(749, 249);
            this.issuedDocumentsGridView.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 150;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата выдачи";
            this.DateColumn.MinimumWidth = 8;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 150;
            // 
            // IssueDocumentButton
            // 
            this.IssueDocumentButton.Location = new System.Drawing.Point(39, 84);
            this.IssueDocumentButton.Name = "IssueDocumentButton";
            this.IssueDocumentButton.Size = new System.Drawing.Size(215, 31);
            this.IssueDocumentButton.TabIndex = 4;
            this.IssueDocumentButton.Text = "Выдать документ";
            this.IssueDocumentButton.UseVisualStyleBackColor = true;
            this.IssueDocumentButton.Click += new System.EventHandler(this.IssueDocumentButton_Click);
            // 
            // DocumentNameTextBox
            // 
            this.DocumentNameTextBox.Location = new System.Drawing.Point(39, 39);
            this.DocumentNameTextBox.Name = "DocumentNameTextBox";
            this.DocumentNameTextBox.Size = new System.Drawing.Size(215, 26);
            this.DocumentNameTextBox.TabIndex = 5;
            // 
            // workerFullNameTextBox
            // 
            this.workerFullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.workerFullNameTextBox.Location = new System.Drawing.Point(384, 56);
            this.workerFullNameTextBox.Name = "workerFullNameTextBox";
            this.workerFullNameTextBox.ReadOnly = true;
            this.workerFullNameTextBox.Size = new System.Drawing.Size(368, 32);
            this.workerFullNameTextBox.TabIndex = 6;
            // 
            // workerBirthDayTextBox
            // 
            this.workerBirthDayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.workerBirthDayTextBox.Location = new System.Drawing.Point(642, 137);
            this.workerBirthDayTextBox.Name = "workerBirthDayTextBox";
            this.workerBirthDayTextBox.ReadOnly = true;
            this.workerBirthDayTextBox.Size = new System.Drawing.Size(110, 30);
            this.workerBirthDayTextBox.TabIndex = 7;
            // 
            // WorkerCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerBirthDayTextBox);
            this.Controls.Add(this.workerFullNameTextBox);
            this.Controls.Add(this.DocumentNameTextBox);
            this.Controls.Add(this.IssueDocumentButton);
            this.Controls.Add(this.issuedDocumentsGridView);
            this.Controls.Add(this.IssuedDocumentsLabel);
            this.Controls.Add(this.BirthDayLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Name = "WorkerCardForm";
            this.Text = "Карточка работника";
            ((System.ComponentModel.ISupportInitialize)(this.issuedDocumentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label IssuedDocumentsLabel;
        private System.Windows.Forms.DataGridView issuedDocumentsGridView;
        private System.Windows.Forms.Button IssueDocumentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.TextBox DocumentNameTextBox;
        private System.Windows.Forms.TextBox workerFullNameTextBox;
        private System.Windows.Forms.TextBox workerBirthDayTextBox;
    }
}