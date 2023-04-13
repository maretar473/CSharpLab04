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

namespace CSharpLab04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPrzycisk_Click(object sender, RoutedEventArgs e)
        {
            var oknoDanychWejsciowych = new DaneWejściweOkno();
            oknoDanychWejsciowych.ShowDialog();
            var oknoDanych = new DaneProstokąta(oknoDanychWejsciowych.Szerokosc, oknoDanychWejsciowych.Wysokosc);
            oknoDanych.ShowDialog();
        }
    }
}
