using System;
using System.Diagnostics;


/*
2、进程间异步通信
重定向实现进程异步通信：
（1）设置重定向进程文件名称
（2）设置属性来重定向输入输出流
（3）设置处理输出数据的回调函数
（4）进程向重定向的输入流中写入数据
（5）进程从输出流中获得数据
（6）回调函数处理获得的数据
 */

public class ProcessAsynchronousCommunication
{
    private Process _process;

    // 代表输出接收的委托
    public delegate void OutputReceivedDelegate(string output);
    public event OutputReceivedDelegate OutputReceived;

    public ProcessAsynchronousCommunication()
    {
        _process = new Process();

        _process.StartInfo.FileName = "ping.exe";

        _process.StartInfo.UseShellExecute = false;
        _process.StartInfo.RedirectStandardOutput = true;
        _process.StartInfo.RedirectStandardInput = true;
        _process.StartInfo.CreateNoWindow = true;

        _process.OutputDataReceived += (sender, e) =>
        {
            if (e.Data != null)
            {
                OutputReceived?.Invoke(e.Data);
            }
        };
    }

    public void ExecutePingAsync(string ipAddress)
    {
        _process.StartInfo.Arguments = ipAddress + " -n 10";
        _process.Start();

        _process.BeginOutputReadLine();
    }
}
