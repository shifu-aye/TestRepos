using System;
using System.Windows;
using System.Windows.Input;
using WpfClient.ServiceReference1;

namespace WpfClient
{
    public partial class MainWindow : Window, ServiceReference1.IServiceCallback
    {
        bool _a = false;
        bool _enabled = false;
        int _sizeRight;
        int _sizeLeft;
        int _sizeUp;
        int _sizeDown;
        int _counter = 0;
        int _counter50 = 0;

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
            if (_enabled == true)
            {
                var windowPosition = Mouse.GetPosition(this);
                var screenPosition = this.PointToScreen(windowPosition);
                string convertedCoord = Convert.ToString(screenPosition);
 
                this.Title = String.Format("{0} --- {1}", windowPosition, screenPosition);

                if (_a == true)
                {
                    if (Convert.ToInt32(screenPosition.X) == _sizeRight)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вправо на 10px {screenPosition}");
                        client.CoordR(new WpfClient.ServiceReference1.CoordRRequest(convertedCoord));
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == _sizeDown)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вниз на 10px {screenPosition}");
                        client.CoordD(new WpfClient.ServiceReference1.CoordDRequest(convertedCoord));
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.X) == _sizeLeft)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг влево на 10px {screenPosition}");
                        client.CoordL(new WpfClient.ServiceReference1.CoordLRequest(convertedCoord));
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == _sizeUp)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вверх на 10px {screenPosition}");
                        client.CoordU(new WpfClient.ServiceReference1.CoordURequest(convertedCoord));
                        _a = false;
                    }
                }  
            }
            counterTB.Text = _counter.ToString();
            if ((_counter50 == 50))
            {
                client.SendEmail(new WpfClient.ServiceReference1.SendEmailRequest(_counter));
                client.SendWhatsApp(new WpfClient.ServiceReference1.SendWhatsAppRequest(_counter));
                _counter50 = 1;
                _counter++;
            }
        }

        private void recordBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_enabled != true)
            {
                _enabled = true;
                
                recordBtn.Content = "Остановить запись";
            }
            else
            {
                _enabled = false;
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

            if (_enabled == true)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    _counter++;
                    _counter50++;
                    _a = true;
                    _sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    _sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    _sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    _sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Левая кнопка нажата на {screenPosition}");
                    client.CoordMouseL(new WpfClient.ServiceReference1.CoordMouseLRequest(convertedCoord));
                }
                else if (e.RightButton == MouseButtonState.Pressed)
                {
                    _counter++;
                    _counter50++;
                    _a = true;
                    _sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    _sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    _sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    _sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Правая кнопка нажата на {screenPosition}");
                    client.CoordMouseR(new WpfClient.ServiceReference1.CoordMouseRRequest(convertedCoord));
                }
                else if (e.MiddleButton == MouseButtonState.Pressed)
                {
                    _counter++;
                    _counter50++;
                    _a = true;
                    _sizeRight = Convert.ToInt32(screenPosition.X) + 10;
                    _sizeLeft = Convert.ToInt32(screenPosition.X) - 10;
                    _sizeUp = Convert.ToInt32(screenPosition.Y) - 10;
                    _sizeDown = Convert.ToInt32(screenPosition.Y) + 10;
                    MessageBox.Show($"Средняя кнопка нажата на {screenPosition}");
                    client.CoordMouseM(new WpfClient.ServiceReference1.CoordMouseMRequest(convertedCoord));
                }
            }
        }
        
        public void MessageCallBack(MessageCallBack request)
        {
            throw new NotImplementedException();
        }
    }
}