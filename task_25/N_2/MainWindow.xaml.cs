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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace N_2
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
            double min = Convert.ToDouble(minTextBox.Text);
            double max = Convert.ToDouble(maxTextBox.Text);
            double steep = Convert.ToDouble(steepTextBox.Text);
            this.DataContext = new MainViewModel(min, max, steep);
        }
    }

    public class MainViewModel
    {
        public MainViewModel(double min, double max, double steep)
        {
            this.PlotModel = new PlotModel { Title = "График функции" };

            var lineSeries = new LineSeries();
            for (double x = min; x < max; x += steep)
            {
                lineSeries.Points.Add(new DataPoint(x, Math.Pow(x, 2)));
            }
            this.PlotModel.Series.Add(lineSeries);
        }

        public PlotModel PlotModel { get; private set; }
    }
}
