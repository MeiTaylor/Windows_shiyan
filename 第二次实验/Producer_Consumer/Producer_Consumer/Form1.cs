using YourNamespace;
using System.Threading;
using System.Windows.Forms;

namespace Producer_Consumer
{
    public partial class Form1 : Form
    {
        private Producer producer1;
        private Producer producer2;
        private Producer producer3;
        private Producer producer4;
        private Consumer consumer1;
        private Consumer consumer2;
        private SharedResources sharedResources = new SharedResources(); // ������Դ

        public Form1()
        {
            InitializeComponent();

            producer1 = new Producer(1, sharedResources);
            producer1.Produced += UpdateProducerListView;  // �����¼�

            producer2 = new Producer(2, sharedResources);
            producer2.Produced += UpdateProducerListView;  // �����¼�

            producer3 = new Producer(3, sharedResources);
            producer3.Produced += UpdateProducerListView;  // �����¼�

            producer4 = new Producer(4, sharedResources);
            producer4.Produced += UpdateProducerListView;  // �����¼�

            consumer1 = new Consumer(sharedResources, data => UpdateConsumerListView(1, data));
            consumer2 = new Consumer(sharedResources, data => UpdateConsumerListView(2, data));

            sharedResources.DataChanged += RefreshTxtAllProducer; // �����¼�
        }

        // ����������UI�ķ���
        private void UpdateProducerListView(int id, int data)
        {
            // ʹ��Invokeȷ���̰߳�ȫ
            if (listViewProducer.InvokeRequired)
            {
                listViewProducer.Invoke(new Action<int, int>(UpdateProducerListView), id, data);
            }
            else
            {
                listViewProducer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                string displayText = $"������{id}������{data}        ";

                ListViewItem item = new ListViewItem(displayText);
                listViewProducer.Items.Add(item);

            }
        }


        // ����������UI�ķ���
        private void UpdateConsumerListView(int id, string data) // �������data�������͸�Ϊstring
        {
            RichTextBox targetTextBox = id == 1 ? txtConsumer1 : txtConsumer2; // �����ΪRichTextBox

            if (targetTextBox.InvokeRequired)
            {
                targetTextBox.Invoke(new Action<int, string>(UpdateConsumerListView), id, data); // ����Ҳ��Ҫ��Ϊ<string>
            }
            else
            {
                targetTextBox.AppendText($"������{id}�����ˣ�{data}\n");
            }
        }


        private void RefreshTxtAllProducer()
        {
            if (txtAllProducer.InvokeRequired)
            {
                txtAllProducer.Invoke(new Action(RefreshTxtAllProducer));
            }
            else
            {
                txtAllProducer.Clear();
                lock (sharedResources.DataQueue)
                {
                    foreach (var item in sharedResources.DataQueue)
                    {
                        txtAllProducer.AppendText($"{item}    ");
                    }
                }
            }
        }



        private void btnProducer1_Click(object sender, EventArgs e)
        {
            ToggleProducer(producer1, btnProducer1, "1");
        }

        private void btnProducer2_Click(object sender, EventArgs e)
        {
            ToggleProducer(producer2, btnProducer2, "2");
        }

        private void btnProducer3_Click(object sender, EventArgs e)
        {
            ToggleProducer(producer3, btnProducer3, "3");
        }

        private void btnProducer4_Click(object sender, EventArgs e)
        {
            ToggleProducer(producer4, btnProducer4, "4");
        }

        private void ToggleProducer(Producer producer, Button button, string id)
        {
            if (producer.IsProducing)
            {
                producer.StopProducing();
                button.Text = $"��ʼ����{id}";
            }
            else
            {
                producer.StartProducing();
                button.Text = $"��ͣ����{id}";
                Thread thread = new Thread(new ThreadStart(producer.ProduceData));
                thread.Start();
            }
        }


        private void StartOrToggleConsumer(Consumer consumer, CheckBox associatedCheckBox)
        {
            if (associatedCheckBox.Checked)
            {
                if (consumer.IsConsuming)
                {
                    consumer.StopConsuming();
                    btnConsumer.Text = "��ʼ����";
                }
                else
                {
                    consumer.StartConsuming();
                    btnConsumer.Text = "��ͣ����";
                    Thread consumeThread = new Thread(consumer.ConsumeData);
                    consumeThread.Start();
                }
            }
        }



        private void btnConsumer_Click(object sender, EventArgs e)
        {
            lock (sharedResources.DataQueue)
            {
                if (sharedResources.DataQueue.Count == 0)
                {
                    MessageBox.Show("������ԴΪ�գ������������ݣ�", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  
                }
            }

            StartOrToggleConsumer(consumer1, checkBox1);
            StartOrToggleConsumer(consumer2, checkBox2);
        }



    }
}
