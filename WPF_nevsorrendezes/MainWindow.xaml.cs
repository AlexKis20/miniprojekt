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

namespace WPF_nevsorrendezes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Nevek = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        

        

        private void bt_nevlistazasa_Click_1(object sender, RoutedEventArgs e)
        {
            if (tbx_nevek.Text != "")
            {
                lb_nevlista.Items.Clear();
                Nevek.Clear();
                string Nevszovegdoboz = tbx_nevek.Text;
                string[] kecske = Nevszovegdoboz.Split(',');
                foreach (string s in kecske)
                {
                    Nevek.Add(s);
                    lb_nevlista.Items.Add(s);

                }
            }
            else
            {
                MessageBox.Show("Kérem adjon meg egy nevet", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void bt_nevsorrendezés_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_nevek.Text != "")
            {
                lb_nevsorrend.Items.Clear();
                Nevek.Clear();
                string Nevszovegdoboz = tbx_nevek.Text;
                string[] kecske = Nevszovegdoboz.Split(',');
                Array.Sort(kecske);
                foreach (string s in kecske)
                {
                    Nevek.Add(s);
                    lb_nevsorrend.Items.Add(s);
                }
                MessageBox.Show("A név lista sorba lett rendezve :) ", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Kérem adjon meg egy nevet", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
