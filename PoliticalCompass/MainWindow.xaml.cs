using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PoliticalCompass
{
    public partial class MainWindow : Window
    {
        public int Econ;
        public int Auth;
        public byte i;

        Dictionary<string, string> AllQuestions = new Dictionary<string, string>();


        public MainWindow()
        {
            InitializeComponent();
            
            i = 0;
            Econ = 0;
            Auth = 0;

            ReadQuestions("db/authQuestions.txt", "Auth");
            ReadQuestions("db/econQuestions.txt", "Econ");

            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NextQuestion(-2, -2);
            }
            catch
            {
                Result();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                NextQuestion(-1, -1);
            }
            catch
            {
                Result();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                NextQuestion(0, 0);
            }
            catch
            {
                Result();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                NextQuestion(1, 1);
            }
            catch
            {
                Result();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                NextQuestion(2, 2);
            }
            catch
            {
                Result();
            }
        }

        private void ReadQuestions(string path, string TypeQ)
        {
            string temp;
            using (StreamReader sr = new StreamReader($"{path}"))
            {
                while (true)
                {

                    // Читаем строку из файла во временную переменную.
                    temp = sr.ReadLine();

                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;

                    // Добавляем строку в список
                    AllQuestions.Add(temp, TypeQ);
                }
            }
        }

        private void NextQuestion(int auth, int econ)
        {
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth += auth;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ += econ;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;

        }

        private void Result()
        {
            TextBox.Text = "Идёт подсчёт результатов...";
            using (StreamWriter sw = new StreamWriter("db/result.txt"))
            {
                sw.Write("");
                sw.WriteLine($"{Econ}\n{Auth}\n");
            }

            string GraphPath = "runPython.bat";
            if (File.Exists(GraphPath))
                Process.Start(GraphPath);
            else
                MessageBox.Show("Файл не найден");

            this.Close();
        }
    }
}
