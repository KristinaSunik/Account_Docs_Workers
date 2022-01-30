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
    public partial class AddNewWorkerForm : Form
    {
        public AddNewWorkerForm()
        {
            InitializeComponent();
        }

        private void SaveWorkerButton_Click(object sender, EventArgs e)
        {
            DateTime birthDay;

            if (CheckInputData())
            {
                birthDay = CheckDataFromUser(BirthDayTextBox.Text);
                if (birthDay == new DateTime(0))
                {
                    MessageBox.Show("Формат даты неверен. Введите в формате dd.dd.dddd", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var newWorker = new Worker(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, birthDay);
                    StartPageForm.workers.Add(newWorker);
                    FileProvider.AddWorkerToFile(StartPageForm.path, newWorker);
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
            int date;
            int month;
            int year;
            DateTime birthDay = new DateTime(0);
            dataFromUser = dataFromUser.Replace(" ", "");
            string[] ss = dataFromUser.Split(',', '.');

            if (ss.Length == 3)
            {
                try
                {
                    if (int.TryParse(ss[0], out date) &&
                    int.TryParse(ss[1], out month) &&
                    int.TryParse(ss[2], out year))
                    {
                        if (date >= 1 && date <= 31)
                        {
                            if (month >= 1 && month <= 12)
                            {
                                //больше ста лет навряд ли человеку будет
                                if (year >= DateTime.Now.Year - 100 && year <= DateTime.Now.Year)
                                {
                                    if (DateTime.TryParse(dataFromUser, out birthDay))
                                    {
                                        return birthDay;
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
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return birthDay;
                }
            }

            return birthDay;
        }
    }
}
