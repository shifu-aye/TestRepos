using System;
using System.Windows;
using System.Windows.Input;

namespace WpfClient
{
    public partial class MainWindow : Window
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
            var client = new ServiceReference1.ServiceClient();
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
                        client.CoordR(convertedCoord);
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == _sizeDown)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вниз на 10px {screenPosition}");
                        client.CoordD(convertedCoord);
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.X) == _sizeLeft)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг влево на 10px {screenPosition}");
                        client.CoordL(convertedCoord);
                        _a = false;
                    }
                    if (Convert.ToInt32(screenPosition.Y) == _sizeUp)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вверх на 10px {screenPosition}");
                        client.CoordU(convertedCoord);
                        _a = false;
                    }
                }  
            }
            counterTB.Text = _counter.ToString();
            if ((_counter50 == 50))
            {
                client.SendEmail(_counter);
                client.SendWhatsApp(_counter);
                _counter50 = 1;
                _counter++;
            }
        }

        /// <summary>
        /// Запись в бд
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            var client = new ServiceReference1.ServiceClient();
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
                    client.CoordMouseL(convertedCoord);
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
                    client.CoordMouseR(convertedCoord);
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
                    client.CoordMouseM(convertedCoord);
                }
            }
        }
        
    }
}