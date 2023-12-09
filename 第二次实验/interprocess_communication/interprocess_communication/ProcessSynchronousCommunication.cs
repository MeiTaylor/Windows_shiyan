using System;
using System.Diagnostics;

/*
 设置重定向进程文件，再设置不创建新的窗口，且不使用Shell。最后设置属性重定向输入输出流。
（2）设置重定向进程文件名称
（3）设置属性来重定向输入输出流
（4）进程向重定向的输入流中写入数据
（5）进程从输出流中获得数据
 */


public class ProcessSynchronousCommunication
{
    private Process _process;

    // 代表输出接收的委托
    public delegate void OutputReceivedDelegate(string output);
    public event OutputReceivedDelegate OutputReceived;

    public ProcessSynchronousCommunication()
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

    public void ExecutePingSync(string ipAddress)
    {
        _process.StartInfo.Arguments = ipAddress + " -n 10";
        _process.Start();

        string line;
        while ((line = _process.StandardOutput.ReadLine()) != null)
        {
            OutputReceived?.Invoke(line);
        }

        _process.WaitForExit();
        _process.Close();
    }
}
