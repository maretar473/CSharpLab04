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
using System.Windows.Shapes;

namespace CSharpLab04
{
    /// <summary>
    /// Logika interakcji dla klasy DaneProstokąta.xaml
    /// </summary>
    public partial class DaneProstokąta : Window
    {
        public DaneProstokąta()
        {
            InitializeComponent();
        }

        public DaneProstokąta(double i_szer, double i_wys):this()
        {
            lblObwód.Content = i_szer * 2 + i_wys * 2;
            lblPole.Content = i_szer * i_wys;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
