using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleGame
{
    /// <summary>
    /// Логика взаимодействия для WindowWin.xaml
    /// </summary>
    public partial class WindowWin : Window
    {
        public WindowWin()
        {
            InitializeComponent();
            playMusic();
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
            }
            else if (holst_c == "white")
            {
                holst.Background = new SolidColorBrush(Colors.White);
            }
            else if (holst_c == "yellow")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            }
            else if (holst_c == "green")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            }
            else if (holst_c == "pink")
            {
                holst.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            }
        }

        MediaPlayer mediaPlayer = new MediaPlayer();

        private void playMusic()
        {
            mediaPlayer.Open(new Uri("Queen_We_Are_The_Champions.mp3", UriKind.Relative));
            mediaPlayer.Volume = 0.5;
            mediaPlayer.Play();
        }

        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            WindowOfGame window = new WindowOfGame();
            window.Show();
            mediaPlayer.Stop();
            this.Close();
        }

        private void toMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            mediaPlayer.Stop();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Level1 window = new Level1();
            window.Show();
            mediaPlayer.Stop();
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                Level1 window = new Level1();
                window.Show();
                mediaPlayer.Stop();
                this.Close();
            }
        }
    }
}
