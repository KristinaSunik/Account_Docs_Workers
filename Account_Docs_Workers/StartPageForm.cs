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
    public partial class StartPageForm : Form
    {
        public StartPageForm()
        {
            InitializeComponent();
        }

        private void WorkersListButton_Click(object sender, EventArgs e)
        {
            var workersListForm = new WorkerListForm();
            workersListForm.Show();
        }

        private void DocumentsListButton_Click(object sender, EventArgs e)
        {

        }

        private void AddNewWorkerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
