﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Level3 window = new Level3();
            window.Show();
            this.Close();
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                WindowOfGame window = new WindowOfGame();
                window.Show();
                this.Close();
            }
        }

        private void Button_Click_oformlenie(object sender, RoutedEventArgs e)
        {
            Oformlenie window = new Oformlenie();
            window.Show();
            this.Close();
        }
    }
}
