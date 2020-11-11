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

namespace Lastif
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(X.Text);
                double y = double.Parse(Y.Text);
                double c;
                if(x*y>0)
                {
                    c = (Math.Sinh(x) +y)* (Math.Sinh(x) + y) -   Math.Sqrt(Math.Sin(x)*y);
                }
                else if (x*y<0)
                {
                    c = (Math.Sinh(x) + y) * (Math.Sinh(x) + y) + Math.Sqrt(Math.Abs(Math.Sin(x) * y));
                }
                else
                {
                    c = (Math.Sinh(x) + y) * (Math.Sinh(x) + y) + 1;
                }
                Result.Text = String.Format("c={0:F2}",c);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
