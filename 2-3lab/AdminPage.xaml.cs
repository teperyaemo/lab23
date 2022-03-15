using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            DG.ItemsSource = Entities.GetContext().Useros.ToList();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Status = "User";
            Manager.MainFrame.Navigate(new MainPage());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Entities.GetContext().SaveChanges();
        }
    }
}
