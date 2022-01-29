using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class WorkerCardForm : Form
    {
        private Worker currentWorker;
        public WorkerCardForm(Worker worker)
        {
            currentWorker = worker;
            
            InitializeComponent();
            InitializeMyControl();

            foreach (var document in worker.IssuedDocuments)
            {
                issuedDocumentsGridView.Rows.Add(document.name, document.dateOfIssue);
            }
        }

        private void InitializeMyControl()
        { 
            workerFullNameTextBox.Text = $"{currentWorker.Surname} {currentWorker.Name} {currentWorker.Patronymic}";
            workerBirthDayTextBox.Text = currentWorker.BirthDay.ToShortDateString();
        }

        private void IssueDocumentButton_Click(object sender, EventArgs e)
        {
            if (DocumentNameTextBox.Text == "")
            {
                MessageBox.Show("Введите название документа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                currentWorker.IssuedDocuments.Add(new Document(DocumentNameTextBox.Text));
                FileProvider.SerializeWorker(WorkerListForm.path, WorkerListForm.workers);
                DocumentNameTextBox.Text = "";
                MessageBox.Show("Выдача документа зарегистрирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
