using System;
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
            string login = "";
            string password = "";

            if (logTB != null && passwordPB != null)
            {
                login = logTB.Text.Trim();
                password = passwordPB.Password.Trim();
            }

            try
            {
                if (login != "" && password != "")
                {
                    client.Authentication1(login, password);

                    MessageBox.Show("Аутентификация прошла успешно!");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.StackTrace);
                logTB.Text = "";
                passwordPB.Password = "";
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