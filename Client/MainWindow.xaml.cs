using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;
using System.Windows.Input;
using ServiceReference1;
using TestModel.Context;
using Test;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
        ApplicationContext _db = new();

        public MainWindow()
        {
            InitializeComponent();

            _db.Database.EnsureCreated();

            _db.Users.Load();

            DataContext = _db.Users.Local.ToObservableCollection();
        }

        private void MainWindow_OnMouseMove(object sender, MouseEventArgs e)
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
                        client.CoordRAsync(convertedCoord);
                        _a = false;
                    }

                    if (Convert.ToInt32(screenPosition.Y) == _sizeDown)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вниз на 10px {screenPosition}");
                        client.CoordDAsync(convertedCoord);
                        _a = false;
                    }

                    if (Convert.ToInt32(screenPosition.X) == _sizeLeft)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг влево на 10px {screenPosition}");
                        client.CoordLAsync(convertedCoord);
                        _a = false;
                    }

                    if (Convert.ToInt32(screenPosition.Y) == _sizeUp)
                    {
                        _counter++;
                        _counter50++;
                        MessageBox.Show($"сдвиг вверх на 10px {screenPosition}");
                        client.CoordUAsync(convertedCoord);
                        _a = false;
                    }

                    counterTB.Text = _counter.ToString();
                    if ((_counter50 == 50))
                    {
                        client.SendEmailAsync(_counter);
                        client.SendWhatsAppAsync(_counter);
                        _counter50 = 1;
                        _counter++;
                    }
                }
            }
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
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
                    client.CoordMouseLAsync(convertedCoord);
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
                    client.CoordMouseRAsync(convertedCoord);
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
                    client.CoordMouseMAsync(convertedCoord);
                }
            }
        }

        private void RecordBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (_enabled != true)
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

        public void MessageCallBack(string message)
        {
            
        }
    }
}
