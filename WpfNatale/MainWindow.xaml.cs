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

namespace WpfNatale
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

        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            txtN1.IsEnabled = true;
            txtN2.IsEnabled = true;
            txtN3.IsEnabled = true;
            txtN4.IsEnabled = true;
            txtN5.IsEnabled = true;
            txtN6.IsEnabled = true;
            btnCalcola.IsEnabled = true;
        }
        
        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            int Npari = 0;
            int Ndisp = 0;
            int num = int.Parse(txtN1.Text);
            int num2 = int.Parse(txtN2.Text);
            int num3 = int.Parse(txtN3.Text);
            int num4 = int.Parse(txtN4.Text);
            int num5 = int.Parse(txtN5.Text);
            int num6 = int.Parse(txtN6.Text);
            if (num % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            if (num2 % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            if (num3 % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            if (num4 % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            if (num5 % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            if (num6 % 2 == 0)
            {
                Npari++;
            }
            else
            {
                Ndisp++;
            }
            lblRisultato.Content = $"sono stati inseriti {Npari} numeri pari e {Ndisp} numeri dispari";
        }
    }
}