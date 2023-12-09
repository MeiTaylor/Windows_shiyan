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

            // 初始状态，设定为计算阶乘
            SetFactorialMode();
        }

        private void SetFactorialMode()
        {
            button1.Text = "计算阶乘";
            label1.Text = "请输入一个整数:";
            label2.Visible = false; // 隐藏第二个输入标签
            textBox2.Visible = false; // 隐藏第二个输入框
            labelResult.Text = string.Empty; // 清空结果标签
        }

        private void SetDifferenceMode()
        {
            button1.Text = "计算数据差值";
            label1.Text = "请输入数据a:";
            label2.Visible = true; // 显示第二个输入标签
            textBox2.Visible = true; // 显示第二个输入框
            labelResult.Text = string.Empty; // 清空结果标签
        }

        private void 阶乘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFactorialMode();
        }

        private void 计算差值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDifferenceMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "计算阶乘")
                {
                    int number = Convert.ToInt32(textBox1.Text); // 确保输入能转换为整数
                    int result = NativeMethods.Factorial(number);
                    labelResult.Text = $"阶乘结果: {result}";
                }
                else if (button1.Text == "计算数据差值")
                {
                    int a = Convert.ToInt32(textBox1.Text); // 确保输入能转换为整数
                    int b = Convert.ToInt32(textBox2.Text); // 确保输入能转换为整数

                    int c_result = NativeMethods.CalculateDifference(a, b);
                    labelResult.Text = $"数据差值: {c_result}";
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"输入格式错误: {fe.Message}");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show($"输入数值过大: {oe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
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
