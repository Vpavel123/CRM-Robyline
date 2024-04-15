using CRM_Robyline.Model;
using CRM_Robyline.Service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRM_Robyline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationService.Inst.OnNavigate += (p) => { PageSwap.Children.Clear(); PageSwap.Children.Add(p); };
            NavigationService.Inst.PageControl(new UserControlDataTable());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService.Inst.PageControl(new UserControlDataTable());
        }
    }
}