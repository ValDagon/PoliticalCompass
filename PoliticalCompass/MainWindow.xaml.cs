using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PoliticalCompass
{
    public partial class MainWindow : Window
    {
        public int Econ;
        public int Auth;
        public int i;
        public int Properties;

        Dictionary<string, string> AllQuestions = new Dictionary<string, string>();


        public MainWindow()
        {
            InitializeComponent();

            i = 0;
            Econ = 0;
            Auth = 0;

            ReadQuestions(@"D:\Programming\Project\PoliticalCompass\authQuestions.txt", "Auth");
            ReadQuestions(@"D:\Programming\Project\PoliticalCompass\econQuestions.txt", "Econ");

            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllQuestions.ElementAt(i).Value == "Auth")
                {
                    Auth -= 2;
                }
                else if (AllQuestions.ElementAt(i).Value == "Econ")
                {
                    Econ -= 2;
                }

                TextBox.Text = AllQuestions.ElementAt(i).Key;
                Label.Content = $"{AllQuestions.Count()} + {i}";
                i += 1;
            }
            catch
            {
                TextBox.Text = "Идёт подсчёт результатов...";
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    sw.Write("");
                    sw.WriteLine($"{Econ}\n{Auth}\n");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllQuestions.ElementAt(i).Value == "Auth")
                {
                    Auth -= 1;
                }
                else if (AllQuestions.ElementAt(i).Value == "Econ")
                {
                    Econ -= 1;
                }

                TextBox.Text = AllQuestions.ElementAt(i).Key;
                Label.Content = $"{AllQuestions.Count()} + {i}";
                i += 1;
            }
            catch
            {
                TextBox.Text = "Идёт подсчёт результатов...";
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    sw.Write("");
                    sw.WriteLine($"{Econ}\n{Auth}\n");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllQuestions.ElementAt(i).Value == "Auth")
                {
                    Auth -= 0;
                }
                else if (AllQuestions.ElementAt(i).Value == "Econ")
                {
                    Econ -= 0;
                }

                TextBox.Text = AllQuestions.ElementAt(i).Key;
                Label.Content = $"{AllQuestions.Count()} + {i}";
                i += 1;
            }
            catch
            {
                TextBox.Text = "Идёт подсчёт результатов...";
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    sw.Write("");
                    sw.WriteLine($"{Econ}\n{Auth}\n");
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllQuestions.ElementAt(i).Value == "Auth")
                {
                    Auth += 1;
                }
                else if (AllQuestions.ElementAt(i).Value == "Econ")
                {
                    Econ += 1;
                }

                TextBox.Text = AllQuestions.ElementAt(i).Key;
                Label.Content = $"{AllQuestions.Count()} + {i}";
                i += 1;
            }
            catch
            {
                TextBox.Text = "Идёт подсчёт результатов...";
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    sw.Write("");
                    sw.WriteLine($"{Econ}\n{Auth}\n");
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AllQuestions.ElementAt(i).Value == "Auth")
                {
                    Auth += 2;
                }
                else if (AllQuestions.ElementAt(i).Value == "Econ")
                {
                    Econ += 2;
                }

                TextBox.Text = AllQuestions.ElementAt(i).Key;
                Label.Content = $"{AllQuestions.Count()} + {i}";
                i += 1;
            }
            catch
            {
                TextBox.Text = "Идёт подсчёт результатов...";
                using (StreamWriter sw = new StreamWriter("result.txt"))
                {
                    sw.Write("");
                    sw.WriteLine($"{Econ}\n{Auth}\n");
                }
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
    }
}
