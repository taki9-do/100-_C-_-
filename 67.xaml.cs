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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _210523_67
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void btn_decide_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            int x, y;

            x = int.Parse(txb_X_point.Text);
            y = int.Parse(txb_Y_point.Text);
            //bool inside;

           

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    //"バックスラッシュ\"
                    Ellipse circle_lowright = make_circle();
                    add_circle(circle_lowright, (x - 60) + i * 30, (y - 60) + j * 30);
                    circle_lowright = null;

                    //"/"
                    Ellipse circle_upright = make_circle();
                    add_circle(circle_upright, (x - 60) + i * 30, (y + 60) - j * 30);
                    circle_upright = null;
                }
                
            }

        }

        private Ellipse make_circle()
        {
            Ellipse circle = new Ellipse()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = 10,
                Height = 10,
            };

            return circle;
        }

        private void add_circle(Ellipse circle, double X_point, double Y_point)
        {
            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, X_point - circle.Width / 2);
            Canvas.SetTop(circle, Y_point - circle.Height / 2);
        }
    }
}
