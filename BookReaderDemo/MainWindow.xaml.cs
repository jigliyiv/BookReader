using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace BookReaderDemo
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

        private void ListOfContent_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var key = ListOfContent.SelectedValue;
            string path = @"..\..\Pages\" + key.ToString() + ".xaml";
            if (File.Exists(path))
            {
                reader.Document = (FlowDocument)XamlReader.Load(File.OpenRead(path));
            }
            else
            {
                MessageBox.Show("Такой страницы нет!");
            }
            
        }
    }
}
