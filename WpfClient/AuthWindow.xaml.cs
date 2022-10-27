using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WpfClient
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            var client = new ServiceReference1.ServiceClient(new System.ServiceModel.InstanceContext(this));
            string login = logTB.Text.Trim();
            string password = passwordPB.Password.Trim();

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите данные!");
            }
            else
            {
                //client.Authentication(login, password);
                MessageBox.Show("Аутентификация прошла успешно!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            
        }
    }
}
