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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StackPanelTest stackPanelTest = new StackPanelTest();
            stackPanelTest.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BindingScreen bindingScreen = new BindingScreen();
            bindingScreen.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RespondChanges respondScreen = new RespondChanges();
            respondScreen.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ConverterScreen converterScreen = new ConverterScreen();
            converterScreen.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ProductView productView = new ProductView();
            ProductViewModel viewModel = new ProductViewModel();
            productView.DataContext = viewModel;
            productView.Show();
        }
    }
}
