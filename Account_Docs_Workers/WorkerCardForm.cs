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
                DocumentNameTextBox.Text = "";
                MessageBox.Show("Выдача документа зарегистрирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
