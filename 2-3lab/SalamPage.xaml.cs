using System.Windows;
using System.Windows.Controls;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для SalamPage.xaml
    /// </summary>
    public partial class SalamPage : Page
    {
        public SalamPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Status = "User";
            Manager.MainFrame.Navigate(new MainPage());
        }
    }
}
