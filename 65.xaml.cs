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

namespace _210523_65
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

            //横の〇
            for(int i = 0; i < 5; i++)
            {
                Ellipse circle_X = make_circle();
                add_circle(circle_X, (x - 60) + i * 30, y);
            }

            //縦の〇
            for(int i = 0; i < 5; i++)
            {
                Ellipse circle_Y = make_circle();
                add_circle(circle_Y, x, (y - 60) + i * 30);
            }

            //Ellipse circle = make_circle();
            //add_circle(circle, x, y);
            

            //canvas.Children.Add(circle);
            //Canvas.SetLeft(circle, x - circle.Width / 2);
            //Canvas.SetTop(circle, y - circle.Height / 2);


            //circle = null;

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
            Canvas.SetLeft(circle, X_point-circle.Width/2);
            Canvas.SetTop(circle, Y_point-circle.Height/2);
        }
    }
}
