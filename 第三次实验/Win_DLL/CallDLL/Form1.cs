using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CallDLL
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��ʼ״̬���趨Ϊ����׳�
            SetFactorialMode();
        }

        private void SetFactorialMode()
        {
            button1.Text = "����׳�";
            label1.Text = "������һ������:";
            label2.Visible = false; // ���صڶ��������ǩ
            textBox2.Visible = false; // ���صڶ��������
            labelResult.Text = string.Empty; // ��ս����ǩ
        }

        private void SetDifferenceMode()
        {
            button1.Text = "�������ݲ�ֵ";
            label1.Text = "����������a:";
            label2.Visible = true; // ��ʾ�ڶ��������ǩ
            textBox2.Visible = true; // ��ʾ�ڶ��������
            labelResult.Text = string.Empty; // ��ս����ǩ
        }

        private void �׳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFactorialMode();
        }

        private void �����ֵToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDifferenceMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "����׳�")
                {
                    int number = Convert.ToInt32(textBox1.Text); // ȷ��������ת��Ϊ����
                    int result = NativeMethods.Factorial(number);
                    labelResult.Text = $"�׳˽��: {result}";
                }
                else if (button1.Text == "�������ݲ�ֵ")
                {
                    int a = Convert.ToInt32(textBox1.Text); // ȷ��������ת��Ϊ����
                    int b = Convert.ToInt32(textBox2.Text); // ȷ��������ת��Ϊ����

                    int c_result = NativeMethods.CalculateDifference(a, b);
                    labelResult.Text = $"���ݲ�ֵ: {c_result}";
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"�����ʽ����: {fe.Message}");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show($"������ֵ����: {oe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������: {ex.Message}");
            }
        }



    }




    public static class NativeMethods
    {
        [DllImport(@"E:\study\C_Sharp\Win_DLL\x64\Debug\CreateNewDLL.dll")]
        public extern static int Factorial(int number);

        [DllImport(@"E:\study\C_Sharp\Win_DLL\x64\Debug\CreateNewDLL.dll")]
        public extern static int CalculateDifference(int a, int b);
    }
}
