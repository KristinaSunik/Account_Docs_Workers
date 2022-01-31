
namespace Account_Docs_Workers.Forms
{
    partial class DocumentsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentsListForm));
            this.documentsListDataGridView = new System.Windows.Forms.DataGridView();
            this.DocumentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfIssueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.documentsListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // documentsListDataGridView
            // 
            this.documentsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentNameColumn,
            this.WorkerNameColumn,
            this.DateOfIssueColumn});
            this.documentsListDataGridView.Location = new System.Drawing.Point(-3, 1);
            this.documentsListDataGridView.Name = "documentsListDataGridView";
            this.documentsListDataGridView.ReadOnly = true;
            this.documentsListDataGridView.RowHeadersWidth = 62;
            this.documentsListDataGridView.RowTemplate.Height = 28;
            this.documentsListDataGridView.Size = new System.Drawing.Size(998, 448);
            this.documentsListDataGridView.TabIndex = 0;
            // 
            // DocumentNameColumn
            // 
            this.DocumentNameColumn.HeaderText = "Имя документа";
            this.DocumentNameColumn.MinimumWidth = 8;
            this.DocumentNameColumn.Name = "DocumentNameColumn";
            this.DocumentNameColumn.ReadOnly = true;
            this.DocumentNameColumn.Width = 150;
            // 
            // WorkerNameColumn
            // 
            this.WorkerNameColumn.HeaderText = "Кому выдан";
            this.WorkerNameColumn.MinimumWidth = 8;
            this.WorkerNameColumn.Name = "WorkerNameColumn";
            this.WorkerNameColumn.ReadOnly = true;
            this.WorkerNameColumn.Width = 150;
            // 
            // DateOfIssueColumn
            // 
            this.DateOfIssueColumn.HeaderText = "Дата выдачи";
            this.DateOfIssueColumn.MinimumWidth = 8;
            this.DateOfIssueColumn.Name = "DateOfIssueColumn";
            this.DateOfIssueColumn.ReadOnly = true;
            this.DateOfIssueColumn.Width = 150;
            // 
            // DocumentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.documentsListDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentsListForm";
            this.Text = "Список документов";
            ((System.ComponentModel.ISupportInitialize)(this.documentsListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView documentsListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfIssueColumn;
    }
}