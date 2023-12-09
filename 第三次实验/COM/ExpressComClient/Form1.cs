using System.Linq.Expressions;



namespace ExpressComClient
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private dynamic expressComObject;
        private void InitializeComObject()
        {
            Guid clsid = new Guid("6F304CC0-E3E2-48D6-A831-7C4CF269F3FB"); 
            Type comType = Type.GetTypeFromCLSID(clsid);
            expressComObject = Activator.CreateInstance(comType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (expressComObject == null)
                InitializeComObject();

            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);

            // 使用动态类型调用方法
            dynamic dyComObject = expressComObject;
            lblResult.Text = dyComObject.Minus(number1, number2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (expressComObject == null)
                InitializeComObject();

            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);

            // 使用动态类型调用方法
            dynamic dyComObject = expressComObject;
            lblResult.Text = dyComObject.Divide(number1, number2);
        }



    }






}