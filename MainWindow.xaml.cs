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

namespace _210522_64
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
            bool inside;

            //左上パネル
            Rectangle rectangle_lettop = make_rectangle();
            add_rectangle(rectangle_lettop, 0, 0);
            Rect rect_lefttop = new Rect(0, 0, rectangle_lettop.Width, rectangle_lettop.Height);
            //右上パネル
            Rectangle rectangle_righttop = make_rectangle();
            add_rectangle(rectangle_righttop, canvas.Width / 2, 0);
            Rect rect_righttop = new Rect(canvas.Width / 2, 0, rectangle_lettop.Width, rectangle_lettop.Height);
            //左下パネル
            Rectangle rectangle_leftbottom = make_rectangle();
            add_rectangle(rectangle_leftbottom, 0, canvas.Height / 2);
            Rect rect_leftbottom = new Rect(0, canvas.Height / 2, rectangle_lettop.Width, rectangle_lettop.Height);
            //右下パネル
            Rectangle rectangle_rightbottom = make_rectangle();
            add_rectangle(rectangle_rightbottom, canvas.Width / 2, canvas.Height / 2);
            Rect rect_rightbottom = new Rect(canvas.Width / 2, canvas.Height / 2, rectangle_lettop.Width, rectangle_lettop.Height);
            //中央パネル
            Rectangle square_center = make_square();
            add_square(square_center, canvas.Width / 2 - square_center.Width / 2, canvas.Height / 2 - square_center.Height / 2);
            Rect sq_center = new Rect(canvas.Width / 2 - square_center.Width / 2, canvas.Height / 2 - square_center.Height / 2, square_center.Width, square_center.Height);

           
            Ellipse circle = new Ellipse()
            {
                //Fill = Brushes.White,
                Stroke = Brushes.Black,
                Width = 50,
                Height = 50,
            };

            if (sq_center.Contains(x, y) == true)
            {
                circle.Fill = Brushes.Orange;
            }
            else if (rect_lefttop.Contains(x,y)==true)
            {
                circle.Fill = Brushes.Green;

            }
            else if (rect_righttop.Contains(x, y) == true)
            {
                circle.Fill = Brushes.Yellow;

            }
            else if (rect_leftbottom.Contains(x, y) == true)
            {
                circle.Fill = Brushes.Red;

            }
            else if (rect_rightbottom.Contains(x, y) == true)
            {
                circle.Fill = Brushes.Blue;

            }


            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, x - circle.Width / 2);
            Canvas.SetTop(circle, y - circle.Height / 2);


            circle = null;
        }

        private Rectangle make_rectangle()
        {
            Rectangle rect = new Rectangle()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = canvas.Width / 2,
                Height = canvas.Height / 2,
            };

            return rect;
        }

        private Rectangle make_square()
        {
            Rectangle square = new Rectangle()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Blue,
                Width = 100,
                Height = 100,
            };

            return square;
        }

        private void add_rectangle(Rectangle rectangle,double X_point,double Y_point)
        {
            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, X_point);
            Canvas.SetTop(rectangle, Y_point);
        }

        private void add_square(Rectangle square, double X_point, double Y_point)
        {
            canvas.Children.Add(square);
            Canvas.SetLeft(square, X_point);
            Canvas.SetTop(square, Y_point);

        }
    }
}
