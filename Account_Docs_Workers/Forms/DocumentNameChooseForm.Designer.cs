
namespace Account_Docs_Workers.Forms
{
    partial class DocumentNameChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentNameChooseForm));
            this.ChooseNameForDocumentDataGridView = new System.Windows.Forms.DataGridView();
            this.DocumentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNameForDocumentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseNameForDocumentDataGridView
            // 
            this.ChooseNameForDocumentDataGridView.AllowUserToAddRows = false;
            this.ChooseNameForDocumentDataGridView.AllowUserToDeleteRows = false;
            this.ChooseNameForDocumentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseNameForDocumentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentName});
            this.ChooseNameForDocumentDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseNameForDocumentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ChooseNameForDocumentDataGridView.Name = "ChooseNameForDocumentDataGridView";
            this.ChooseNameForDocumentDataGridView.ReadOnly = true;
            this.ChooseNameForDocumentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ChooseNameForDocumentDataGridView.RowTemplate.Height = 28;
            this.ChooseNameForDocumentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChooseNameForDocumentDataGridView.Size = new System.Drawing.Size(536, 357);
            this.ChooseNameForDocumentDataGridView.TabIndex = 0;
            this.ChooseNameForDocumentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DocumentName
            // 
            this.DocumentName.HeaderText = "Наименование документа";
            this.DocumentName.MinimumWidth = 8;
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.ReadOnly = true;
            this.DocumentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DocumentName.Width = 150;
            // 
            // DocumentNameChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 350);
            this.Controls.Add(this.ChooseNameForDocumentDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentNameChooseForm";
            this.Text = "Выберите документ для выдачи";
            ((System.ComponentModel.ISupportInitialize)(this.ChooseNameForDocumentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChooseNameForDocumentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentName;
    }
}