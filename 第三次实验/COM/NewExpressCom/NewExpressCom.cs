using System.Runtime.InteropServices;




namespace NewExpressCom
{


    // 定义COM接口IExpress
    [Guid("36BA4D1A-C6A0-4834-BBA0-6A5B127D4EDE")]  
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IExpress
    {
        string Minus(int a, int b);
        string Divide(int a, int b);
    }

    // 实现COM接口IExpress
    [Guid("6F304CC0-E3E2-48D6-A831-7C4CF269F3FB"), ComVisible(true)] 
    public class ExpressImpl : IExpress
    {
        public string Minus(int a, int b)
        {
            return $"{a - b} = {a} - {b}";
        }

        public string Divide(int a, int b)
        {
            if (b == 0) return "除零错误";
            return $"{a / b} = {a} / {b}";
        }
    }
}
