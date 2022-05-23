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
    /// Логика взаимодействия для WindowWin.xaml
    /// </summary>
    public partial class WindowWin : Window
    {
        public WindowWin()
        {
            InitializeComponent();
        }

        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            WindowOfGame window = new WindowOfGame();
            window.Show();
            this.Close();
        }

        private void toMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
