using System.Windows;

namespace _2_3lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Status = "User";
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainPage());
            Manager.MainFrame = MainFrame;
        }
    }
}
