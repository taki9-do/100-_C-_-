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

namespace _210515_60
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int X, Y;

        public MainWindow()
        {

            InitializeComponent();

            this.SizeToContent = SizeToContent.WidthAndHeight;

        }

        private void btn_decide_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            X = X_pointing(Txb_Xpoint.Text);
            Y = Y_pointing(Txb_Ypoint.Text);

            Ellipse circle = new Ellipse()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = 100,
                Height = 100,
            };

            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, X-50);
            Canvas.SetTop(circle, Y-50);


            circle = null;
            
        }

        private int X_pointing(string input_X)
        {
            int output_X = int.Parse(input_X);
            return output_X;
        }

        private int Y_pointing(string input_Y)
        {
            int output_Y = int.Parse(input_Y);
            return output_Y;
        }
    }
}
