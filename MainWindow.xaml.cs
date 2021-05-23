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

namespace _210523_68
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

            //パネルの数
            int panel_num;
            panel_num = int.Parse(txb_panel_num.Text);

            for(int i = 0; i < panel_num; i++)
            {
                for(int j = 0; j < panel_num; j++)
                {
                    Rectangle panel = make_rectangle(panel_num);
                    add_rectangle(panel, panel.Width * i, panel.Height * j);
                }
            }

            
        }

        private Rectangle make_rectangle(int i)
        {
            Rectangle rect = new Rectangle()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = canvas.Width / i,
                Height = canvas.Height / i,
            };

            return rect;
        }

        private void add_rectangle(Rectangle rectangle, double X_point, double Y_point)
        {
            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, X_point);
            Canvas.SetTop(rectangle, Y_point);
        }
    }
}
