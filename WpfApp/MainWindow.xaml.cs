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
using WpfApp.Views;

namespace WpfApp
{
    /// <inheritdoc cref="Window" />
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMenuAbout(object sender, RoutedEventArgs e)
        {
            var parent = (Window)MainWindowDockPanel.Parent;
            MessageBox.Show(parent,  $"{parent.Title}", parent.Title, MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void OnMenuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnMenuDataDownload(object sender, RoutedEventArgs e)
        {
            MainWindowContentControl.Content = new DataDownloadView();
        }
    }
}
