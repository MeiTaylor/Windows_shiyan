using System.Windows.Forms;

namespace interprocess_communication
{
    public partial class Form1 : Form
    {

        private ProcessSynchronousCommunication _processComm;
        private ProcessAsynchronousCommunication _asyncProcessComm;

        public Form1()
        {
            InitializeComponent();

            _processComm = new ProcessSynchronousCommunication();

            _processComm.OutputReceived += UpdateRichTextBox;


            _asyncProcessComm = new ProcessAsynchronousCommunication();

            _asyncProcessComm.OutputReceived += UpdateRichTextBox;
        }



        private void UpdateRichTextBox(string output)
        {
            if (this.InvokeRequired) 
            {
                this.Invoke(new Action<string>(UpdateRichTextBox), new object[] { output }); 
                return;
            }
            richTextBox1.AppendText(output + "\n");
        }





        private void btnStartSyncComm_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear(); // 清空richTextBox1

            richTextBox1.AppendText("进程同步通信开始！！！" + "\n" + "\n");


            label4.Text = "同步通信输出结果";
            // 获取输入的IP地址，如果没有输入，就是默认
            string ipAddress = string.IsNullOrWhiteSpace(txtIPAddress.Text) ? "www.sohu.com" : txtIPAddress.Text;

            // 调用进程通信类的方法执行ping命令
            _processComm.ExecutePingSync(ipAddress);
        }

        private void btnStartAsyncComm_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear(); // 清空richTextBox1

            richTextBox1.AppendText("进程异步通信开始~~~" + "\n" + "\n");


            label4.Text = "异步通信输出结果";
            string ipAddress = string.IsNullOrWhiteSpace(txtIPAddress.Text) ? "www.sohu.com" : txtIPAddress.Text;

            // 调用异步进程通信类的方法执行ping命令
            _asyncProcessComm.ExecutePingAsync(ipAddress);
        }
    }
}