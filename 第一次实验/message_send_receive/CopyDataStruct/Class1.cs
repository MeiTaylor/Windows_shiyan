using System;
using System.Runtime.InteropServices;

namespace CopyDataStruct
{
    public class MessageHelper
    {
        public const int WM_COPYDATA = 0x004A; // WM_COPYDATA消息的消息ID

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;     // 用于传递消息的标识，可以用于区分消息类型
            public int cbData;        // 消息数据的大小，以字节为单位
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;     // 指向消息数据的指针
        }

        // 封装消息数据的辅助方法
        public static COPYDATASTRUCT CreateCopyData(string message, int msgIdentifier = 0)
        {
            COPYDATASTRUCT copyData = new COPYDATASTRUCT();
            copyData.dwData = (IntPtr)msgIdentifier;
            copyData.cbData = (message.Length + 1) * 2; // +1 是为了'\0'字符，*2 是因为.NET的字符串是Unicode的
            copyData.lpData = message;
            return copyData;
        }
    }
}
