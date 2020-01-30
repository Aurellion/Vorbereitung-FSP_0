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

namespace Prüfung_FSP_v1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Berechnen_Click(object sender, RoutedEventArgs e)
        {
            double a1, a2, h;
            a1 = Convert.ToDouble(Txt_a1.Text);
            a2 = Convert.ToDouble(Txt_a2.Text);
            h = Convert.ToDouble(Txt_h.Text);

            double Am, Ao, V, hs;
            hs = Math.Sqrt(h * h + Math.Pow(0.5 * (a1 - a2), 2));
            Am = 2 * (a1 + a2) * hs;
            Ao = a1 * a1 + 2 * (a1 + a2) * hs + a2 * a2;            
            V = 1d / 3d * h * (a1 * a1 + a1 * a2 + a2 * a2);

            Tb_am.Text = Math.Round(Am, 3).ToString();
            Tb_ao.Text = Math.Round(Ao, 3).ToString();
            Tb_v.Text = Math.Round(V, 3).ToString();
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (RE.IsVisible)
            {
                RE.Visibility = Visibility.Hidden;
                EL.Visibility = Visibility.Visible;
            }
            else
            {
                RE.Visibility = Visibility.Visible;
                EL.Visibility = Visibility.Hidden;
            }
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (RE.Fill == Brushes.Yellow)
            {
                RE.Fill = Brushes.Green;
                EL.Fill = Brushes.Green;
            }
            else
            {
                RE.Fill = Brushes.Yellow;
                EL.Fill = Brushes.Yellow;
            }
        }

        private void BT_Umkehren_Click(object sender, RoutedEventArgs e)
        {
            string str = TB_Eingabe.Text;
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            TB_Ausgabe.Text = rev;
        }

        private void BT_rnd_Click(object sender, RoutedEventArgs e)
        {
            int a, b = 0;
            Random rnd = new Random();
            a = rnd.Next(10);
            if (a < 2) b = 1;
            else if (a < 7) b = 2;
            else if (a < 10) b = 3;
            TB_rnd.Text = b.ToString();
        }
    }
}
