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
using System.Windows.Shapes;

namespace SimpleGame
{
    /// <summary>
    /// Логика взаимодействия для WindowOfGame.xaml
    /// </summary>
    public partial class WindowOfGame : Window
    {
        int x = 10, y = 10;
        public WindowOfGame()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                y -= 5;
                Canvas.SetTop(ellipse, y);
            }
            if(e.Key == Key.Down)
            {
                y += 5;
                Canvas.SetTop(ellipse, y);
            }
            if (e.Key == Key.Right)
            {
                x += 5;
                Canvas.SetLeft(ellipse, x);
            }
            if (e.Key == Key.Left)
            {
                x -= 5;
                Canvas.SetLeft(ellipse, x);
            }
        }
        
    }
}
