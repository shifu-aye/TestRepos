using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfClient
{
    public partial class MainWindow : Window
    {
        bool a = false;
        bool enabled = false;
        int sizeRight;
        int sizeLeft;
        int sizeUp;
        int sizeDown;
        int counter = 0;
        int counter50 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Перемещение мышки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWin_MouseMove(object sender, MouseEventArgs e)
        {
            var client = new ServiceReference1.ServiceClient(new System.ServiceModel.InstanceContext(this));
            if (enabled == true)
            {
                var windowPosition = Mouse.GetPosition(this);
                var screenPosition = this.PointToScreen(windowPosition);
                string convertedCoord = Convert.ToString(screenPosition);
 
                this.Title = String.Format("{0} --- {1}", windowPosition, screenPosition);

                if (a == true)
                {
                    if (Convert.ToInt32(screenPosition.X) == sizeRight)
                    {
                        counter++;
                        counter50++;
                        MessageBox.Show($"сдвиг вправо на 10px {screenPosition}");
                        client.CoordR(convertedCoord);
                        a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == sizeDown)
                    {
                        counter++;
                        counter50++;
                        MessageBox.Show($"сдвиг вниз на 10px {screenPosition}");
                        client.CoordD(convertedCoord);
                        a = false;
                    }
                    if (Convert.ToInt32(screenPosition.X) == sizeLeft)
                    {
                        counter++;
                        counter50++;
                        MessageBox.Show($"сдвиг влево на 10px {screenPosition}");
                        client.CoordL(convertedCoord);
                        a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == sizeUp)
                    {
                        counter++;
                        counter50++;
                        MessageBox.Show($"сдвиг вверх на 10px {screenPosition}");
                        client.CoordU(convertedCoord);
                        a = false;
                    }
                }  
            }
            counterTB.Text = counter.ToString();
            if ((counter50 == 50))
            {
                client.SendEmail(counter);
                client.SendWhatsApp(counter);
                counter50 = 1;
                counter++;
            }
        }

        private void recordBtn_Click(object sender, RoutedEventArgs e)
        {
            if(enabled != true)
            {
                enabled = true;
                
                recordBtn.Content = "Остановить запись";
            }
            else
            {
                enabled = false;
                recordBtn.Content = "Запустить запись";
            }
        }
        /// <summary>
        /// Нажатие мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var client = new ServiceReference1.ServiceClient(new System.ServiceModel.InstanceContext(this));
            var windowPosition = Mouse.GetPosition(this);
            var screenPosition = this.PointToScreen(windowPosition);
            string convertedCoord = Convert.ToString(screenPosition);

            if (enabled == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    counter++;
                    counter50++;
                    a = true;
                    sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Левая кнопка нажата на {screenPosition}");
                    client.CoordMouseL(convertedCoord);
                }
                else if (e.RightButton == MouseButtonState.Pressed)
                {
                    counter++;
                    counter50++;
                    a = true;
                    sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Правая кнопка нажата на {screenPosition}");
                    client.CoordMouseR(convertedCoord);
                }
                else if (e.MiddleButton == MouseButtonState.Pressed)
                {
                    counter++;
                    counter50++;
                    a = true;
                    sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Средняя кнопка нажата на {screenPosition}");
                    client.CoordMouseM(convertedCoord);
                }
            }
        }
    }
}