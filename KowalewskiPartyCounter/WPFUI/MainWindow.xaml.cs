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
using MVVM.ViewModels;
using MVVM.Model;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _mainViewModel;
        }

        private void OnClick_AddProszePanstwa(object sender, RoutedEventArgs e)
        {
            _mainViewModel.AddProszePanstwa();
        }

        private void OnClick_AddMianowicie(object sender, RoutedEventArgs e)
        {
            _mainViewModel.AddMianowicie();
        }

        private void OnClick_SubtractProszePanstwa(object sender, RoutedEventArgs e)
            => _mainViewModel.SubtractProszePanstwa();

        private void OnClick_SubtractMianowicie(object sender, RoutedEventArgs e)
            => _mainViewModel.SubtractMianowicie();
    }
}
