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

            listView1.Columns.Add("����ʱ��", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("��Ϣ����", 300, HorizontalAlignment.Left);
        }

        // ����DefWndProc�����Դ���WM_COPYDATA��Ϣ
        protected override void DefWndProc(ref Message m)
        {
            // ����Ƿ�ΪWM_COPYDATA��Ϣ
            if (m.Msg == MessageHelper.WM_COPYDATA)
            {
                // ����Ϣ����ת��ΪCOPYDATASTRUCT
                MessageHelper.COPYDATASTRUCT copyData = (MessageHelper.COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(MessageHelper.COPYDATASTRUCT));

                // ��ȡ����ʱ�����Ϣ����
                string receivedTime = DateTime.Now.ToString("HH:mm:ss");
                string receivedMessage = copyData.lpData;

                // ��ListView����ʾ����ʱ�����Ϣ����
                ListViewItem item = new ListViewItem(receivedTime);
                item.SubItems.Add(receivedMessage);
                listView1.Items.Add(item);
            }
            else
            {
                base.DefWndProc(ref m); // ������Ϣ��������
            }
        }
    }
}
