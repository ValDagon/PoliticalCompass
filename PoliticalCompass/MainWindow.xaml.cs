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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Econ { get; set; }
        public int Auth { get; set; }
        public int i { get; set; }
        public int Properties { get; set; }

        //        public List<string> AuthQuestions = new List<string>();
        //        public List<string> EconQuestions = new List<string>();

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
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth -= 2;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ -= 2;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth -= 1;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ -= 1;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth -= 0;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ -= 0;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth += 1;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ += 1;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (AllQuestions.ElementAt(i).Value == "Auth")
            {
                Auth += 2;
            }
            else if (AllQuestions.ElementAt(i).Value == "Econ")
            {
                Econ += 2;
            }

            i += 1;
            TextBox.Text = AllQuestions.ElementAt(i).Key;
        }

        private void ReadQuestions(string path, string TypeQ)
        {
            string temp = "";
            using (StreamReader fs = new StreamReader($"{path}"))
            {
                while (true)
                {

                    // Читаем строку из файла во временную переменную.
                    temp = fs.ReadLine();

                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;

                    // Добавляем строку в список
                    AllQuestions.Add(temp, TypeQ);
                }
            }
        }
    }
}
