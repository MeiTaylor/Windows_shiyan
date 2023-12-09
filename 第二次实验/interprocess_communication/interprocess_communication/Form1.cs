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

            richTextBox1.Clear(); // ���richTextBox1

            richTextBox1.AppendText("����ͬ��ͨ�ſ�ʼ������" + "\n" + "\n");


            label4.Text = "ͬ��ͨ��������";
            // ��ȡ�����IP��ַ�����û�����룬����Ĭ��
            string ipAddress = string.IsNullOrWhiteSpace(txtIPAddress.Text) ? "www.sohu.com" : txtIPAddress.Text;

            // ���ý���ͨ����ķ���ִ��ping����
            _processComm.ExecutePingSync(ipAddress);
        }

        private void btnStartAsyncComm_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear(); // ���richTextBox1

            richTextBox1.AppendText("�����첽ͨ�ſ�ʼ~~~" + "\n" + "\n");


            label4.Text = "�첽ͨ��������";
            string ipAddress = string.IsNullOrWhiteSpace(txtIPAddress.Text) ? "www.sohu.com" : txtIPAddress.Text;

            // �����첽����ͨ����ķ���ִ��ping����
            _asyncProcessComm.ExecutePingAsync(ipAddress);
        }
    }
}