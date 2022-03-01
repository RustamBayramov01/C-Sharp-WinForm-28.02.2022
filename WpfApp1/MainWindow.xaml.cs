
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Random random = new Random();


        public MainWindow()
        {
            InitializeComponent();


            btn.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 255), (byte)random.Next(1, 111), (byte)random.Next(1, 11)));
            btn1.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 21), (byte)random.Next(1, 222), (byte)random.Next(1, 44)));
            btn2.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 32), (byte)random.Next(1, 213), (byte)random.Next(1, 33)));
            btn3.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 222), (byte)random.Next(1, 123), (byte)random.Next(1, 22)));
            btn4.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 111), (byte)random.Next(1, 231), (byte)random.Next(1, 11)));
            btn5.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 212), (byte)random.Next(1, 211), (byte)random.Next(1, 212)));
            
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 233)));

            if (MouseButton.Left == MouseButton.Left)
            {
                MessageBox.Show(sender.ToString(), "Info");

                if (sender == btn) btn.Background = brush;
                else if (sender == btn1) btn1.Background = brush;
                else if (sender == btn2) btn2.Background = brush;
                else if (sender == btn3) btn3.Background = brush;
                else if (sender == btn4) btn4.Background = brush;
                else if (sender == btn5) btn5.Background = brush; 
            }

        }


        private void btn_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

            this.Title = (sender as Button).Content.ToString();
            this.stackPanel.Children.Remove((sender as Button));
            this.stackPanel1.Children.Remove((sender as Button));

        }
    }


   
}
