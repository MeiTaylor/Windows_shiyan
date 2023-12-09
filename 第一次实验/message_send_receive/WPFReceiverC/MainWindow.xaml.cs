using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using CopyDataStruct;


namespace WPFReceiverC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ReceiverC : Window
    {
        public ReceiverC()
        {
            InitializeComponent();
        }


        // 添加窗口加载完成后的事件处理
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            // 设置钩子，监听窗口消息
            HwndSource source = HwndSource.FromHwnd(new WindowInteropHelper(this).Handle);
            source.AddHook(WndProc);
        }

        // 消息处理函数
        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            // 检查是否为WM_COPYDATA消息
            if (msg == MessageHelper.WM_COPYDATA)
            {
                // 将消息数据转换为COPYDATASTRUCT
                MessageHelper.COPYDATASTRUCT copyData = (MessageHelper.COPYDATASTRUCT)Marshal.PtrToStructure(lParam, typeof(MessageHelper.COPYDATASTRUCT));

                // 获取接收时间和消息内容
                string receivedTime = DateTime.Now.ToString("HH:mm:ss");
                string receivedMessage = copyData.lpData;

                // 在ListView中显示接收时间和消息内容
                listView1.Items.Add(new { ReceivedTime = receivedTime, MessageContent = receivedMessage });

                handled = true;
            }

            return IntPtr.Zero;
        }

    }
}
