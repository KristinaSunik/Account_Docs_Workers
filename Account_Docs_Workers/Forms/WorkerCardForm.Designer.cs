
namespace Account_Docs_Workers.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerCardForm));
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.IssuedDocumentsLabel = new System.Windows.Forms.Label();
            this.issuedDocumentsGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDocumentButton = new System.Windows.Forms.Button();
            this.DocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.NamePatronymicLabel = new System.Windows.Forms.Label();
            this.chooseDocumentButton = new System.Windows.Forms.Button();
            this.documentNamesListToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.issuedDocumentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SurNameLabel.Location = new System.Drawing.Point(426, 39);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(158, 36);
            this.SurNameLabel.TabIndex = 0;
            this.SurNameLabel.Text = "Фамилия";
            this.SurNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BirthDayLabel.Location = new System.Drawing.Point(427, 134);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(161, 25);
            this.BirthDayLabel.TabIndex = 1;
            this.BirthDayLabel.Text = "Дата рождения";
            // 
            // IssuedDocumentsLabel
            // 
            this.IssuedDocumentsLabel.AutoSize = true;
            this.IssuedDocumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IssuedDocumentsLabel.Location = new System.Drawing.Point(34, 192);
            this.IssuedDocumentsLabel.Name = "IssuedDocumentsLabel";
            this.IssuedDocumentsLabel.Size = new System.Drawing.Size(219, 25);
            this.IssuedDocumentsLabel.TabIndex = 2;
            this.IssuedDocumentsLabel.Text = "Выданные документы";
            // 
            // issuedDocumentsGridView
            // 
            this.issuedDocumentsGridView.AllowUserToAddRows = false;
            this.issuedDocumentsGridView.AllowUserToDeleteRows = false;
            this.issuedDocumentsGridView.AllowUserToOrderColumns = true;
            this.issuedDocumentsGridView.AllowUserToResizeRows = false;
            this.issuedDocumentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.issuedDocumentsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.issuedDocumentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuedDocumentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateColumn});
            this.issuedDocumentsGridView.Location = new System.Drawing.Point(39, 220);
            this.issuedDocumentsGridView.MultiSelect = false;
            this.issuedDocumentsGridView.Name = "issuedDocumentsGridView";
            this.issuedDocumentsGridView.ReadOnly = true;
            this.issuedDocumentsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.issuedDocumentsGridView.RowTemplate.Height = 28;
            this.issuedDocumentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.issuedDocumentsGridView.Size = new System.Drawing.Size(502, 218);
            this.issuedDocumentsGridView.TabIndex = 3;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 119;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Дата выдачи";
            this.DateColumn.MinimumWidth = 8;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 146;
            // 
            // IssueDocumentButton
            // 
            this.IssueDocumentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IssueDocumentButton.Location = new System.Drawing.Point(39, 84);
            this.IssueDocumentButton.Name = "IssueDocumentButton";
            this.IssueDocumentButton.Size = new System.Drawing.Size(281, 44);
            this.IssueDocumentButton.TabIndex = 4;
            this.IssueDocumentButton.Text = "Выдать документ";
            this.IssueDocumentButton.UseVisualStyleBackColor = true;
            this.IssueDocumentButton.Click += new System.EventHandler(this.IssueDocumentButton_Click);
            // 
            // DocumentNameTextBox
            // 
            this.DocumentNameTextBox.Location = new System.Drawing.Point(39, 39);
            this.DocumentNameTextBox.Name = "DocumentNameTextBox";
            this.DocumentNameTextBox.Size = new System.Drawing.Size(281, 26);
            this.DocumentNameTextBox.TabIndex = 5;
            // 
            // NamePatronymicLabel
            // 
            this.NamePatronymicLabel.AutoSize = true;
            this.NamePatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NamePatronymicLabel.Location = new System.Drawing.Point(427, 90);
            this.NamePatronymicLabel.Name = "NamePatronymicLabel";
            this.NamePatronymicLabel.Size = new System.Drawing.Size(185, 30);
            this.NamePatronymicLabel.TabIndex = 6;
            this.NamePatronymicLabel.Text = "Имя Отчество";
            this.NamePatronymicLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chooseDocumentButton
            // 
            this.chooseDocumentButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDocumentButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chooseDocumentButton.Location = new System.Drawing.Point(326, 35);
            this.chooseDocumentButton.Name = "chooseDocumentButton";
            this.chooseDocumentButton.Size = new System.Drawing.Size(48, 34);
            this.chooseDocumentButton.TabIndex = 7;
            this.chooseDocumentButton.Text = ">>";
            this.chooseDocumentButton.UseVisualStyleBackColor = true;
            this.chooseDocumentButton.Click += new System.EventHandler(this.chooseDocumentButton_Click);
            // 
            // WorkerCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.chooseDocumentButton);
            this.Controls.Add(this.NamePatronymicLabel);
            this.Controls.Add(this.DocumentNameTextBox);
            this.Controls.Add(this.IssueDocumentButton);
            this.Controls.Add(this.issuedDocumentsGridView);
            this.Controls.Add(this.IssuedDocumentsLabel);
            this.Controls.Add(this.BirthDayLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerCardForm";
            this.Text = "Карточка работника";
            ((System.ComponentModel.ISupportInitialize)(this.issuedDocumentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label IssuedDocumentsLabel;
        private System.Windows.Forms.DataGridView issuedDocumentsGridView;
        private System.Windows.Forms.Button IssueDocumentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        public System.Windows.Forms.TextBox DocumentNameTextBox;
        private System.Windows.Forms.Label NamePatronymicLabel;
        private System.Windows.Forms.Button chooseDocumentButton;
        private System.Windows.Forms.ToolTip documentNamesListToolTip;
    }
}