
namespace Account_Docs_Workers
{
    partial class AddNewWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWorkerForm));
            this.SaveWorkerButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.BirthDayTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveWorkerButton
            // 
            this.SaveWorkerButton.Location = new System.Drawing.Point(180, 352);
            this.SaveWorkerButton.Name = "SaveWorkerButton";
            this.SaveWorkerButton.Size = new System.Drawing.Size(133, 35);
            this.SaveWorkerButton.TabIndex = 0;
            this.SaveWorkerButton.Text = "Сохранить";
            this.SaveWorkerButton.UseVisualStyleBackColor = true;
            this.SaveWorkerButton.Click += new System.EventHandler(this.SaveWorkerButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(278, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(105, 131);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(278, 26);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(105, 210);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(278, 26);
            this.PatronymicTextBox.TabIndex = 3;
            // 
            // BirthDayTextBox
            // 
            this.BirthDayTextBox.Location = new System.Drawing.Point(105, 287);
            this.BirthDayTextBox.Name = "BirthDayTextBox";
            this.BirthDayTextBox.Size = new System.Drawing.Size(278, 26);
            this.BirthDayTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLabel.Location = new System.Drawing.Point(105, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 25);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SurnameLabel.Location = new System.Drawing.Point(105, 103);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(103, 25);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PatronymicLabel.Location = new System.Drawing.Point(105, 182);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(104, 25);
            this.PatronymicLabel.TabIndex = 7;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BirthDayLabel.Location = new System.Drawing.Point(105, 259);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(161, 25);
            this.BirthDayLabel.TabIndex = 8;
            this.BirthDayLabel.Text = "Дата рождения";
            // 
            // AddNewWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 410);
            this.Controls.Add(this.BirthDayLabel);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BirthDayTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveWorkerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewWorkerForm";
            this.Text = "Информация о новом работнике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveWorkerButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox BirthDayTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label BirthDayLabel;
    }
}