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

namespace N_1
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
            label1.Content = "Hello " + textBox1.Text;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            aboutApp AbApp = new aboutApp();
            AbApp.ShowDialog();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
