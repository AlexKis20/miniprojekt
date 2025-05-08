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

        private void bt_nevlistazasa_Click(object sender, RoutedEventArgs e)
        {

            Nevek.Add(tbx_nevek.Text);


        }

        private void bt_nevsorrendezés_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
