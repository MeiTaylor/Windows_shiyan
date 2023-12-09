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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test1
{
    public partial class MainWindow : Window
    {
        private TemperatureSensor tempSensor = new TemperatureSensor();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bindAddClothesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!tempSensor.IsBound(TempSensor_OnTemperatureChange_AddClothes))
            {
                tempSensor.OnTemperatureChange += TempSensor_OnTemperatureChange_AddClothes;
                
                UpdateBoundEventsList();
                MessageBox.Show("成功绑定‘建议加衣’事件！");
            }
            else
            {
                MessageBox.Show("‘建议加衣’事件已经绑定！");
            }
        }

        private void unbindAddClothesBtn_Click(object sender, RoutedEventArgs e)
        {
            tempSensor.OnTemperatureChange -= TempSensor_OnTemperatureChange_AddClothes;
            MessageBox.Show("成功解绑‘建议加衣’事件！");

            UpdateBoundEventsList();
        }

        private void bindRemoveClothesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!tempSensor.IsBound(TempSensor_OnTemperatureChange_RemoveClothes))
            {
                tempSensor.OnTemperatureChange += TempSensor_OnTemperatureChange_RemoveClothes;
                MessageBox.Show("成功绑定‘建议脱衣’事件！");
                UpdateBoundEventsList();
            }
            else
            {
                MessageBox.Show("‘建议脱衣’事件已经绑定！");
            }
        }

        private void unbindRemoveClothesBtn_Click(object sender, RoutedEventArgs e)
        {
            tempSensor.OnTemperatureChange -= TempSensor_OnTemperatureChange_RemoveClothes;
            MessageBox.Show("成功解绑‘建议脱衣’事件！");

            UpdateBoundEventsList();


        }

        private void TempSensor_OnTemperatureChange_AddClothes(object sender, TemperatureEventArgs e)
        {
            if (e.Temperature < 26)
            {
                eventText.Text = "天气冷，建议加衣！";

                string imagePath = "E:\\study\\Windows\\test1\\天冷加衣.jpeg";

                // 创建一个新的 BitmapImage
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.EndInit();

                // 设置 Image 控件的 Source 属性来显示图片
                eventImage.Source = bitmap;

            }
        }

        private void TempSensor_OnTemperatureChange_RemoveClothes(object sender, TemperatureEventArgs e)
        {
            if (e.Temperature > 25)
            {
                eventText.Text = "天气热，建议脱衣！";

                string imagePath = "E:\\study\\Windows\\test1\\天热脱衣.png";

                // 创建一个新的 BitmapImage
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.EndInit();

                // 设置 Image 控件的 Source 属性来显示图片
                eventImage.Source = bitmap;

            }
        }

        private void triggerEventBtn_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int currentTemperature = rnd.Next(10, 35); // 模拟10°C到35°C的随机温度
            temperatureText.Text = $"{currentTemperature}°C";
            tempSensor.ChangeTemperature(currentTemperature);
        }

        private void UpdateBoundEventsList()
        {
            boundEventsListBox.Items.Clear();
            if (tempSensor.IsBound(TempSensor_OnTemperatureChange_AddClothes))
            {
                boundEventsListBox.Items.Add("建议加衣");
            }
            if (tempSensor.IsBound(TempSensor_OnTemperatureChange_RemoveClothes))
            {
                boundEventsListBox.Items.Add("建议脱衣");
            }
        }
    }

    public class TemperatureEventArgs : EventArgs
    {
        public int Temperature { get; set; }
        public TemperatureEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureSensor
    {
        public delegate void TemperatureChangeHandler(object sender, TemperatureEventArgs e);
        public event TemperatureChangeHandler OnTemperatureChange;

        public void ChangeTemperature(int newTemperature)
        {
            OnTemperatureChange?.Invoke(this, new TemperatureEventArgs(newTemperature));
        }


        public bool IsBound(TemperatureChangeHandler handler)
        {
            return OnTemperatureChange != null && OnTemperatureChange.GetInvocationList().Contains(handler);
        }
    }
}
