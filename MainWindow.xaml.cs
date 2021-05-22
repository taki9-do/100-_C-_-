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

namespace _210522_63
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


            Line line_X = new Line()
            {
                Fill = Brushes.Black,
                Stroke = Brushes.Black,
                X1 = canvas.Width / 2,
                Y1 = 0,
                X2 = canvas.Width / 2,
                Y2 = canvas.Height,
            };

            Line line_Y = new Line()
            {
                Fill = Brushes.Black,
                Stroke = Brushes.Black,
                X1 = 0,
                Y1 = canvas.Height / 2,
                X2 = canvas.Width,
                Y2 = canvas.Height / 2,
            };

            canvas.Children.Add(line_X);
            canvas.Children.Add(line_Y);

            Ellipse circle = new Ellipse()
            {
                //Fill = Brushes.White,
                Stroke = Brushes.Black,
                Width = 50,
                Height = 50,
            };

            if (x <= 300 && y < 200)
            {
                circle.Fill = Brushes.Green;
            }
            else if (x > 300 &&   y <= 200)
            {
                circle.Fill = Brushes.Yellow;
            }
            else if(x < 300 && y >= 200 )
            {
                circle.Fill = Brushes.Red;
            }
            else if (x >= 300 && y >= 200 )
            {
                circle.Fill = Brushes.Blue;
            }

            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, x - circle.Width/2);
            Canvas.SetTop(circle, y - circle.Height/2);


            circle = null;
        }
    }
}
