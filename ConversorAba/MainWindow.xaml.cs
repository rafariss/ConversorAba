using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConversorAba
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

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbAbatrack.Content = tbAbatrack.Text;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            string aba = tbAbatrack.Text;
            int toBase = 16;
            long valorint = long.Parse(aba);
            lbSerial.Content =  Convert.ToString(valorint, toBase);
            string hexa1 = Convert.ToString(valorint, toBase);
            string hexa = hexa1.TrimStart();
            if(hexa.Length > 8 && hexa.Length < 10)
            {
                string parte1 = hexa.Substring(0, 5);
                string parte2 = hexa.Substring(5, 4);

                string part1_conv = parte1.Substring(3, 2);
                string part2_conv = parte2.Substring(0, 4);

                int dec1 = Convert.ToInt32(part1_conv, toBase);
                int dec2 = Convert.ToInt32(part2_conv, toBase);

                lbWiegand.Content = dec1 + "-" + dec2;

            }
            if (hexa.Length >= 10)
            {
                string parte1 = hexa.Substring(0, 6);
                string parte2 = hexa.Substring(6, 4);

                string part1_conv = parte1.Substring(4, 2);
                string part2_conv = parte2.Substring(0, 4);

                int dec1 = Convert.ToInt32(part1_conv, toBase);
                int dec2 = Convert.ToInt32(part2_conv, toBase);

                lbWiegand.Content = dec1 + "-" + dec2;


            }
            else
            {
                string parte1 = hexa.Substring(0, 2);
                string parte2 = hexa.Substring(2, 4);

                string part1_conv = parte1.Substring(0, 2);
                string part2_conv = parte2.Substring(0, 4);

                int dec1 = Convert.ToInt32(part1_conv, toBase);
                int dec2 = Convert.ToInt32(part2_conv, toBase);

                lbWiegand.Content = dec1 + "-" + dec2;
            }
           









        }
    }
}
