using System;
using System.Collections.Generic;
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
using System.IO;
using System.Windows.Shapes;

namespace SimpleGame
{
    /// <summary>
    /// Interaction logic for Oformlenie.xaml
    /// </summary>
    public partial class Oformlenie : Window
    {
        String old_back;
        String old_shar;

        public Oformlenie()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            Console.WriteLine(line);
            String holst_c = line;
            line = sr.ReadLine();
            String Shar = line;
            sr.Close();
            if (holst_c == "red")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
                back_check.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
                back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 199, 199));
                shar_check.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
                shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            }
            else if (holst_c == "white")
            {
                holst.Background = new SolidColorBrush(Colors.White);
                back_check.Background = new SolidColorBrush(Colors.White);
                back_check.BorderBrush = new SolidColorBrush(Colors.White);
                shar_check.Background = new SolidColorBrush(Colors.White);
                shar_check.BorderBrush = new SolidColorBrush(Colors.White);
            }
            else if (holst_c == "yellow")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
                back_check.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
                back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 236, 164));
                shar_check.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
                shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            }
            else if (holst_c == "green")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
                back_check.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
                back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 251, 164));
                shar_check.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
                shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            }
            else if (holst_c == "pink")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
                back_check.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
                back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 164, 240));
                shar_check.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
                shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine(old_back);
            sw.WriteLine(old_shar);
            sw.Close();
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void safe(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void white_back(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            String Shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine("white");
            sw.WriteLine(Shar);
            sw.Close();
            holst.Background = new SolidColorBrush(Colors.White);
            back_check.Background = new SolidColorBrush(Colors.White);
            back_check.BorderBrush = new SolidColorBrush(Colors.White);
            shar_check.Background = new SolidColorBrush(Colors.White);
            shar_check.BorderBrush = new SolidColorBrush(Colors.White);
        }

        private void red_back(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            String Shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine("red");
            sw.WriteLine(Shar);
            sw.Close();
            holst.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            back_check.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            shar_check.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 199, 199));
        }

        private void yellow_back(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            String Shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine("yellow");
            sw.WriteLine(Shar);
            sw.Close();
            holst.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            back_check.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            shar_check.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 236, 164));
        }

        private void green_back(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            String Shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine("green");
            sw.WriteLine(Shar);
            sw.Close();
            holst.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            back_check.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            shar_check.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(171, 251, 164));
        }

        private void pink_back(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            String Shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine("pink");
            sw.WriteLine(Shar);
            sw.Close();
            holst.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            back_check.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            back_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            shar_check.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            shar_check.BorderBrush = new SolidColorBrush(Color.FromRgb(251, 164, 240));
        }

        private void black_shar(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            String Back = line;
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine(Back);
            sw.WriteLine("black");
            sw.Close();
        }

        private void blue_shar(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            String Back = line;
            old_back = line;
            line = sr.ReadLine();
            old_shar = line;
            sr.Close();
            StreamWriter sw = new StreamWriter("Oformlenie.txt");
            sw.WriteLine(Back);
            sw.WriteLine("blue");
            sw.Close();
        }
    }
}
