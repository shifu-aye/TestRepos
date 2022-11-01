using System;
using System.Web.UI.WebControls;
using System.Windows;
using WpfClient.ServiceReference1;

namespace WpfClient
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window, ServiceReference1.IServiceCallback
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
                MessageBox.Show("Введите данные!");
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
                return new ServiceReference1.ServiceClient(new System.ServiceModel.InstanceContext(this));
            else
            {
                return null;
            }
        }

        public void MessageCallBack(string message)
        {
            throw new NotImplementedException();
        }
    }
}
