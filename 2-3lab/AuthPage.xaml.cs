using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        private Useros _currentUser = new Useros();
        private Useros us = new Useros();
        public AuthPage()
        {
            InitializeComponent();
            DataContext = _currentUser;
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        { 
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentUser.Login))
                errors.AppendLine("Введите Логин");

            if (string.IsNullOrWhiteSpace(_currentUser.Password))
                errors.AppendLine("Введите Пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            us = Entities.GetContext().Useros.First(p => p.Password == _currentUser.Password && p.Login == _currentUser.Login);
            if (us.Status == "Admin")
            {
                Manager.MainFrame.Navigate(new AdminPage());
            }
            else if (us.Status == "User")
            {
                Manager.MainFrame.Navigate(new SalamPage());
            }
            else MessageBox.Show("неверно введены данные");
            
        }
    }
}
