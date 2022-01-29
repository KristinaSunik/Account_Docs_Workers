
namespace Account_Docs_Workers
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.WorkersListButton = new System.Windows.Forms.Button();
            this.DocumentsListButton = new System.Windows.Forms.Button();
            this.AddNewWorkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkersListButton
            // 
            this.WorkersListButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WorkersListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WorkersListButton.Location = new System.Drawing.Point(35, 50);
            this.WorkersListButton.Name = "WorkersListButton";
            this.WorkersListButton.Size = new System.Drawing.Size(484, 45);
            this.WorkersListButton.TabIndex = 0;
            this.WorkersListButton.Text = "Список работников";
            this.WorkersListButton.UseVisualStyleBackColor = false;
            // 
            // DocumentsListButton
            // 
            this.DocumentsListButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DocumentsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DocumentsListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DocumentsListButton.Location = new System.Drawing.Point(35, 145);
            this.DocumentsListButton.Name = "DocumentsListButton";
            this.DocumentsListButton.Size = new System.Drawing.Size(484, 45);
            this.DocumentsListButton.TabIndex = 1;
            this.DocumentsListButton.Text = "Список документов";
            this.DocumentsListButton.UseVisualStyleBackColor = false;
            // 
            // AddNewWorkerButton
            // 
            this.AddNewWorkerButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddNewWorkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddNewWorkerButton.Location = new System.Drawing.Point(35, 290);
            this.AddNewWorkerButton.Name = "AddNewWorkerButton";
            this.AddNewWorkerButton.Size = new System.Drawing.Size(484, 45);
            this.AddNewWorkerButton.TabIndex = 2;
            this.AddNewWorkerButton.Text = "Добавить нового работника";
            this.AddNewWorkerButton.UseVisualStyleBackColor = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(580, 426);
            this.Controls.Add(this.AddNewWorkerButton);
            this.Controls.Add(this.DocumentsListButton);
            this.Controls.Add(this.WorkersListButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "Работники и выданные документы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkersListButton;
        private System.Windows.Forms.Button DocumentsListButton;
        private System.Windows.Forms.Button AddNewWorkerButton;
    }
}

