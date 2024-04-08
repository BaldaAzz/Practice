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
using N_1.Interfaces;
using N_1.Share;
using N_1.Models;
using Microsoft.Win32;
using System.IO;

namespace N_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        public bool IsFileOpenned = false;
        private string _xmlFilePath;

        public MainWindow()
        {
            InitializeComponent();
            _worker = new XmlDocumentWorker();
        }

        public void PrintFlower(Flower flower)
        {
            textBlockXMLFileContent.Text = "===Flower====" + Environment.NewLine;
            textBlockXMLFileContent.Text += flower?.ToString() ?? "FlowerNotFound";
        }

        private void PrintFlower(List<Flower> flowers)
        {
            textBlockXMLFileContent.Text = "====Flower====" + Environment.NewLine;
            foreach (var flower in flowers)
            {
                textBlockXMLFileContent.Text += flower.ToString();
            }
        }

        private void textBoxDeleteFlowerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFlowerName.Text))
            {
                PrintFlower(_worker.GetAll());
            }
        }

        private void buttonOpenFile_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;

            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintFlower(_worker.GetAll());
            }
        }

        private void buttonFindFlowerName_Click_1(object sender, RoutedEventArgs e)
        {
            var flower = _worker.FindBy(textBoxFlowerName.Text);
            PrintFlower(flower);
        }

        private void buttonDelete_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteFlowerName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteFlowerName.Text))
            {
                _worker.Delete(textBoxDeleteFlowerName.Text);
                PrintFlower(_worker.GetAll());
            }
        }

        private void buttonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            PrintFlower(_worker.GetAll());
        }

        private void buttonExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

