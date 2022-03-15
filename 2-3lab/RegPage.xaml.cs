using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        private Useros _currentUser = new Useros();
        public RegPage()
        {
            InitializeComponent();
            DataContext = _currentUser;
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
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

            _currentUser.Status = "User";
            Entities.GetContext().Useros.Add(_currentUser);

            Entities.GetContext().SaveChanges();
            MessageBox.Show("Вы успешно зарагистрировались");
            Manager.MainFrame.Navigate(new SalamPage());

            try
            {
                Entities.GetContext().SaveChanges();
                MessageBox.Show("Вы успешно зарагистрировались");
                Manager.MainFrame.Navigate(new SalamPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
