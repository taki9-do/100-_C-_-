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

namespace _210520_61
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

            int X_point = 200;
            int Y_point = 100;

            Rectangle rectangle = new Rectangle()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = 200,
                Height = 200,
            };

            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, X_point);
            Canvas.SetTop(rectangle, Y_point);

            Ellipse circle = new Ellipse()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = rectangle.Width,
                Height = rectangle.Height,
            };

            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, X_point);
            Canvas.SetTop(circle, Y_point);
        }
    }
}
