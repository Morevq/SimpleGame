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
    /// Логика взаимодействия для Level3.xaml
    /// </summary>
    public partial class Level3 : Window
    {
        const int X = 93, Y = 20;
        int x = X, y = Y;
        public Level3()
        {
            InitializeComponent();
            Canvas.SetTop(ellipse, y);
            Canvas.SetLeft(ellipse, x);
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
            List<Rectangle> parts = new List<Rectangle>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41, r42, r43, r44, r45, r46, r47, r48, r49, r50, r51, r52, r53, r54, r55, r56, r57, r58, r59, r60, r61, r62, r63, r64, r65, r66, r67, r68, r69, r70, r71, r72 , r73, r74, r75, r76, r77, r78, r79, r80, r81, r82, r83, r84, r85, r86, r87, r88, r89, r90, r91, r92, r93, r94, r95, r96, r97, r98, r99, r100, r101, r102, r103, r104, r105, r106, r107, r108, r109, r110, r111, r112, r113, r114, r115, r116, r117, r118, r119, r120, r121, r122, r123, r124, r125, r126, r127, r128, r129, r130, r131, r132, r133, r134, r135, r136, r137, r138, r139, r140, r141, r142, r143, r144, r145, r146, r147, r148, r149, r150, r151};
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


            for (int i = 0; i < 151; ++i)
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
                /*tb.Text = i + "\n" + x1 + " " + y1 + " " + x2 + " " + y2 + "\n" 
                    + cx1 + " " + cy1 + " " + cx2 + " " + cy2 + "\n"
                    + f.ToString();*/
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
                WindowWin3 window = new WindowWin3();
                window.Show();
                this.Close();
            }
        }
    }
}
