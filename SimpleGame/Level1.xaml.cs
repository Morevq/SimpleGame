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
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleGame
{
    /// <summary>
    /// Логика взаимодействия для Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        const int X = 264, Y = 54;
        int x = X, y = Y;
        public Level1()
        {
            InitializeComponent();
            Canvas.SetTop(ellipse, y);
            Canvas.SetLeft(ellipse, x);
            StreamReader sr = new StreamReader("Oformlenie.txt");
            String line = sr.ReadLine();
            Console.WriteLine(line);
            String holst_c = line;
            line = sr.ReadLine();
            String Shar = line;
            sr.Close();
            if (holst_c == "red")
            {
                canvas.Background = new SolidColorBrush(Color.FromRgb(255, 199, 199));
            }
            else if (holst_c == "white")
            {
                canvas.Background = new SolidColorBrush(Colors.White);
            }
            else if (holst_c == "yellow")
            {
                canvas.Background = new SolidColorBrush(Color.FromRgb(251, 236, 164));
            }
            else if (holst_c == "green")
            {
                canvas.Background = new SolidColorBrush(Color.FromRgb(171, 251, 164));
            }
            else if (holst_c == "pink")
            {
                canvas.Background = new SolidColorBrush(Color.FromRgb(251, 164, 240));
            }
        }

        private bool isCrossed(double ax, double ay, double ax1, double ay1, double bx, double by, double bx1, double by1)
        {
            return ((((ax >= bx && ax <= bx1) || (ax1 >= bx && ax1 <= bx1)) &&
                ((ay >= by && ay <= by1) || (ay1 >= by && ay1 <= by1))) ||
                (((bx >= ax && bx <= ax1) || (bx1 >= ax && bx1 <= ax1)) &&
                ((by >= ay && by <= ay1) || (by1 >= ay && by1 <= ay1)))) ||
                ((((ax >= bx && ax <= bx1) || (ax1 >= bx && ax1 <= bx1)) &&
                ((by >= ay && by <= ay1) || (by1 >= ay && by1 <= ay1))) ||
                (((bx >= ax && bx <= ax1) || (bx1 >= ax && bx1 <= ax1)) &&
                ((ay >= by && ay <= by1) || (ay1 >= by && ay1 <= by1))));
        }



        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            List<Rectangle> parts = new List<Rectangle>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19};
            if (e.Key == Key.Up)
            {
                y -= 5;
                Canvas.SetTop(ellipse, y);
            }
            if (e.Key == Key.Down)
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

            // Верхний левый угол
            double cx1 = Canvas.GetLeft(ellipse);
            double cy1 = Canvas.GetTop(ellipse);

            // Нижний правый угол
            double cx2 = Canvas.GetLeft(ellipse) + ellipse.Width;
            double cy2 = Canvas.GetTop(ellipse) + ellipse.Height;


            for (int i = 0; i < 19; ++i)
            {
                // Верхний левый угол
                double x1 = Canvas.GetLeft(parts[i]);
                double y1 = Canvas.GetTop(parts[i]);

                // Нижний правый угол
                double x2 = Canvas.GetLeft(parts[i]) + parts[i].Width;
                double y2 = Canvas.GetTop(parts[i]) + parts[i].Height;

                bool f = isCrossed(x1, y1, x2, y2, cx1, cy1, cx2, cy2);
                if (f == true)
                {
                    Canvas.SetTop(ellipse, Y);
                    Canvas.SetLeft(ellipse, X);
                    x = X;
                    y = Y;
                }
            }

            // Верхний левый угол
            double px1 = Canvas.GetLeft(present);
            double py1 = Canvas.GetTop(present);

            // Нижний правый угол
            double px2 = Canvas.GetLeft(present) + present.Width;
            double py2 = Canvas.GetTop(present) + present.Height;

            bool func = isCrossed(px1, py1, px2, py2, cx1, cy1, cx2, cy2);
            if (func == true)
            {
                WindowWin1 window = new WindowWin1();
                window.Show();
                this.Close();
            }
        }
    }
}
