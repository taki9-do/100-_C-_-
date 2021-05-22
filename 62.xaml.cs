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

namespace _210520_62
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

            Ellipse circle = new Ellipse()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = 80,
                Height = 80,
            };

            Rectangle rectangle = new Rectangle()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = circle.Width,
                Height = circle.Height,
            };

            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, x - 50);
            Canvas.SetTop(rectangle, y - 50);

            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, x - 50);
            Canvas.SetTop(circle, y - 50);


            circle = null;
        }

    }
}
