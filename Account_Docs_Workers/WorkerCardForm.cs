using System;
using System.Linq;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class WorkerCardForm : Form
    {
        public static Worker currentWorker;
        public WorkerCardForm(Worker worker)
        {
            currentWorker = worker;
            
            InitializeComponent();
            InitializeMyControls();

            foreach (var document in worker.IssuedDocuments)
            {
                issuedDocumentsGridView.Rows.Add(document.Name, document.DateOfIssue);
            }

            AutoSizeColumns();
        }

        private void InitializeMyControls()
        {
            DocumentNameTextBox.Focus();
            SurNameLabel.Text = $"{currentWorker.Surname}";
            NamePatronymicLabel.Text = $"{currentWorker.Name} {currentWorker.Patronymic}";
            BirthDayLabel.Text = currentWorker.BirthDay.ToShortDateString();
        }

        private void IssueDocumentButton_Click(object sender, EventArgs e)
        {
            if (DocumentNameTextBox.Text == "")
            {
                MessageBox.Show("Введите название документа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(StartPageForm.documents.FirstOrDefault(x => x == DocumentNameTextBox.Text) == null)
                {
                    var result = MessageBox.Show("Добавить документ в список?", "Сохранить?!?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        FileProvider.AddDocumentToFile(StartPageForm.pathDocuments, DocumentNameTextBox.Text);
                        StartPageForm.documents.Add(DocumentNameTextBox.Text);
                    }
                }
                currentWorker.IssuedDocuments.Add(new Document(DocumentNameTextBox.Text));
                FileProvider.SerializeWorker(StartPageForm.pathWorkers, StartPageForm.workers);

                DocumentNameTextBox.Text = "";
                issuedDocumentsGridView.Rows.Add(currentWorker.IssuedDocuments[currentWorker.IssuedDocuments.Count - 1].Name, currentWorker.IssuedDocuments[currentWorker.IssuedDocuments.Count - 1].DateOfIssue);
                AutoSizeColumns();
                Refresh();

                MessageBox.Show("Выдача документа зарегистрирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AutoSizeColumns()
        {
            for (int i = 0; i < issuedDocumentsGridView.Columns.Count; i++)
            {
                issuedDocumentsGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void chooseDocumentButton_Click(object sender, EventArgs e)
        {
            var chooseDocumentName = new DocumentNameChooseForm();
            chooseDocumentName.Show();
        }
    }
}
