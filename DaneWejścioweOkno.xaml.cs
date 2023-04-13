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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class DaneWejściweOkno : Window
    {
        public DaneWejściweOkno()
        {
            InitializeComponent();
        }

        private double szerokosc;
        private double wysokosc;

        public double Szerokosc { get { return szerokosc; } private set { szerokosc = value; } }

        public double Wysokosc { get { return wysokosc; } private set { wysokosc = value; } }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Szerokosc = Double.Parse(txbxSzerokość.Text);
            Wysokosc = double.Parse(txbxWysokość.Text);
            this.Close();
        }
    }
}
