using System.Windows;

namespace AboutDisneyWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }

        private void handleButtonClick(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).ExtraText = "Clicking the button revealed this text";
        }
    }
}
