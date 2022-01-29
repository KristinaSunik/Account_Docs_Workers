using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Account_Docs_Workers
{
    static class Program
    {
        public static List<Worker> workers = new List<Worker>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartPage());
        }

        private static void Init()
        {
            string path = Directory.GetCurrentDirectory() + "Workers_Documents.xml";
            workers.Add(new Worker("Кристина", "Шуканова", "Олеговна", new DateTime(1988, 9, 14)));
            workers.Add(new Worker("Никифороов", "Андрей", "Алексеевич", new DateTime(1985, 10, 25)));
            workers.Add(new Worker("Иванов", "Иван", "Иванович", new DateTime(1980, 2, 7)));

            FileProvider.SerializeWorker(path, workers);
            Worker.AddWorkersToList(workers, path);
        }
    }
}
