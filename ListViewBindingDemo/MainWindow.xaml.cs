using System.Windows;
using System.Windows.Controls;
using SharedData;

namespace Walterlv.Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new EditableViewModel();
            DataContext = vm;
            vm.RunChangingOrder();
        }

        private void OnItemLoaded(object sender, RoutedEventArgs e)
        {
            ((TextBlock) sender).Text = sender.GetHashCode().ToString();
        }
    }
}
