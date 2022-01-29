
using System.Collections.Generic;

namespace Account_Docs_Workers
{
    public partial class WorkerListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.workerListDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workerListDataGridView
            // 
            this.workerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.PatronymicColumn});
            this.workerListDataGridView.Location = new System.Drawing.Point(-1, 12);
            this.workerListDataGridView.Name = "workerListDataGridView";
            this.workerListDataGridView.RowHeadersWidth = 62;
            this.workerListDataGridView.RowTemplate.Height = 28;
            this.workerListDataGridView.Size = new System.Drawing.Size(794, 426);
            this.workerListDataGridView.TabIndex = 0;
            this.workerListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workerListDataGridView_CellContentClick);
            // 
            // NameColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 150;
            // 
            // SurnameColumn
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SurnameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 8;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 150;
            // 
            // PatronymicColumn
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PatronymicColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatronymicColumn.HeaderText = "Отчество";
            this.PatronymicColumn.MinimumWidth = 8;
            this.PatronymicColumn.Name = "PatronymicColumn";
            this.PatronymicColumn.Width = 150;
            // 
            // WorkerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerListDataGridView);
            this.Name = "WorkerListForm";
            this.Text = "WorkerList";
            ((System.ComponentModel.ISupportInitialize)(this.workerListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workerListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicColumn;
    }
}