
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IssueDocumentButton = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.BirthDayLabel.Location = new System.Drawing.Point(596, 109);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(156, 25);
            this.BirthDayLabel.TabIndex = 1;
            this.BirthDayLabel.Text = "дата рождения";
            // 
            // IssuedDocumentsLabel
            // 
            this.IssuedDocumentsLabel.AutoSize = true;
            this.IssuedDocumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IssuedDocumentsLabel.Location = new System.Drawing.Point(34, 146);
            this.IssuedDocumentsLabel.Name = "IssuedDocumentsLabel";
            this.IssuedDocumentsLabel.Size = new System.Drawing.Size(267, 29);
            this.IssuedDocumentsLabel.TabIndex = 2;
            this.IssuedDocumentsLabel.Text = "Выданные документы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.DateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(39, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(369, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // IssueDocumentButton
            // 
            this.IssueDocumentButton.Location = new System.Drawing.Point(39, 22);
            this.IssueDocumentButton.Name = "IssueDocumentButton";
            this.IssueDocumentButton.Size = new System.Drawing.Size(215, 31);
            this.IssueDocumentButton.TabIndex = 4;
            this.IssueDocumentButton.Text = "Выдать документ";
            this.IssueDocumentButton.UseVisualStyleBackColor = true;
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
            // WorkerCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IssueDocumentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IssuedDocumentsLabel);
            this.Controls.Add(this.BirthDayLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Name = "WorkerCardForm";
            this.Text = "WorkerCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.Label IssuedDocumentsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IssueDocumentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    }
}