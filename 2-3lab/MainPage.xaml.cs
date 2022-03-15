using System.Windows;
using System.Windows.Controls;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AuthPage());
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RegPage());
        }
    }
}
