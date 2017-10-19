using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using SharedData;

namespace Walterlv.Demo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            var vm = new EditableViewModel();
            DataContext = vm;
            vm.RunChangingOrder();
        }

        private void OnItemLoaded(object sender, RoutedEventArgs e)
        {
            ((TextBlock)sender).Text = sender.GetHashCode().ToString();
        }
    }
}
