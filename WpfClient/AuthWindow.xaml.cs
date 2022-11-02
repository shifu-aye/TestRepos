using System.Windows;
using WpfClient.ServiceReference1;

namespace WpfClient
{
    public partial class AuthWindow : Window
    {
        bool isConnected = false;
        private ServiceReference1.ServiceClient client;
        public AuthWindow()
        {
            InitializeComponent();
            this.client = ConnectClient();
        }
        
        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            
            string login = logTB.Text.Trim();
            string password = passwordPB.Password.Trim();

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //client.Authentication1(login, password);

                MessageBox.Show("Аутентификация прошла успешно!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }

        private ServiceClient ConnectClient()
        {
            if(!isConnected)
                return new ServiceReference1.ServiceClient();
            else
            {
                return null;
            }
        }
    }
}
