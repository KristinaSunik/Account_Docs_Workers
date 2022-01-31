using System;
using System.Windows.Forms;

namespace Account_Docs_Workers.Forms
{
    public partial class AddNewWorkerForm : Form
    {
        public AddNewWorkerForm()
        {
            InitializeComponent();
        }

        private void SaveWorkerButton_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                DateTime birthDay = CheckDataFromUser(BirthDayTextBox.Text);
                if (birthDay != new DateTime(0))
                {
                    var newWorker = new Worker(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, birthDay);
                   
                    if(StartPageForm.workers.Count != 0)
                    {
                        FileProvider.AddWorkerToFile(StartPageForm.pathWorkers, newWorker);
                        StartPageForm.workers.Add(newWorker);
                    }
                    else
                    {
                        StartPageForm.workers.Add(newWorker);
                        FileProvider.SerializeWorker(StartPageForm.pathWorkers, StartPageForm.workers);
                    }
                    
                    RefreshControls();
                    MessageBox.Show("Работник добавлен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RefreshControls()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            BirthDayTextBox.Text = "";
        }

        private bool CheckInputData()
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Введите имя работника", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (SurnameTextBox.Text == "")
            {
                MessageBox.Show("Введите Фамилию работника", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (PatronymicTextBox.Text == "")
            {
                MessageBox.Show("Введите Отчество работника", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (BirthDayTextBox.Text == "")
            {
                MessageBox.Show("Введите дату рождения работника", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private DateTime CheckDataFromUser(string dataFromUser)
        {
            DateTime birthDay = new DateTime(0);
            dataFromUser = dataFromUser.Replace(" ", "");
            string[] splitedDateFromUser = dataFromUser.Split(',', '.');

            if (splitedDateFromUser.Length == 3)
            {
                try
                {
                    birthDay = TryParseDate(dataFromUser, splitedDateFromUser);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return birthDay;
                }
            }

            return birthDay;
        }

        private static DateTime TryParseDate(string dataFromUser, string[] splitedDateFromUser)
        {
            DateTime birthDay;

            if (int.TryParse(splitedDateFromUser[0], out int date) &&
                int.TryParse(splitedDateFromUser[1], out int month) &&
                int.TryParse(splitedDateFromUser[2], out int year))
            {
                if (date >= 1 && date <= 31)
                {
                    if (month >= 1 && month <= 12)
                    {
                        //больше ста лет навряд ли человеку будет
                        if (year >= DateTime.Now.Year - 100 && year <= DateTime.Now.Year)
                        {
                            if (!DateTime.TryParse(dataFromUser, out birthDay) || birthDay > DateTime.Now)
                            {
                                birthDay = new DateTime(0);
                                MessageBox.Show("Формат даты неверен. Введите в формате dd.dd.dddd" + Environment.NewLine +
                                    "Возможно такой даты просто не существует", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            throw new FormatException
                              ($"Год может быть в диапазоне от {DateTime.Now.Year - 100} до {DateTime.Now.Year}");
                        }
                    }
                    else
                    {
                        throw new FormatException("Месяц может быть в диапазоне от 1 до 12");
                    }
                }
                else
                {
                    throw new FormatException("Число может быть в диапазоне от 1 до 31");
                }
            }
            else
            {
                throw new FormatException("Формат даты должен быть **.**.****");
            }

            return birthDay;
        }
    }
}
