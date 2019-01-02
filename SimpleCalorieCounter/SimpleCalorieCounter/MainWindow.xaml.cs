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
using ClassLibrary1;

namespace SimpleCalorieCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProgramSession _programSession;

        public MainWindow()
        {
            InitializeComponent();

            _programSession = new ProgramSession();

            DataContext = _programSession;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _programSession.NewProduct.Name = txtbx.Text;
            txtbx.Clear();
        }
    }
}
