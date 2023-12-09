using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CopyDataStruct;

namespace FormReceiverB
{
    public partial class ReceiverB : Form
    {
        public ReceiverB()
        {
            InitializeComponent();

            listView1.Columns.Add("接收时间", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("消息内容", 300, HorizontalAlignment.Left);
        }

        // 重载DefWndProc方法以处理WM_COPYDATA消息
        protected override void DefWndProc(ref Message m)
        {
            // 检查是否为WM_COPYDATA消息
            if (m.Msg == MessageHelper.WM_COPYDATA)
            {
                // 将消息数据转换为COPYDATASTRUCT
                MessageHelper.COPYDATASTRUCT copyData = (MessageHelper.COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(MessageHelper.COPYDATASTRUCT));

                // 获取接收时间和消息内容
                string receivedTime = DateTime.Now.ToString("HH:mm:ss");
                string receivedMessage = copyData.lpData;

                // 在ListView中显示接收时间和消息内容
                ListViewItem item = new ListViewItem(receivedTime);
                item.SubItems.Add(receivedMessage);
                listView1.Items.Add(item);
            }
            else
            {
                base.DefWndProc(ref m); // 其他消息正常处理
            }
        }
    }
}
