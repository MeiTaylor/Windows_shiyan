using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CopyDataStruct;

namespace FormSenderA
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, ref MessageHelper.COPYDATASTRUCT lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string targetAppName = textBox2.Text;

            SendMessageToApp(message, targetAppName);
        }

        private void SendMessageToApp(string message, string targetAppName)
        {
            IntPtr targetWnd = FindWindow(null, targetAppName);
            if (targetWnd == IntPtr.Zero)
            {
                MessageBox.Show($"ÕÒ²»µ½´°¿Ú {targetAppName}");
                return;
            }

            MessageHelper.COPYDATASTRUCT copyData = MessageHelper.CreateCopyData(message);
            SendMessage(targetWnd, MessageHelper.WM_COPYDATA, this.Handle, ref copyData);
        }
    }
}
