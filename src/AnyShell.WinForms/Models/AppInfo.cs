using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyShell.WinForms.Models
{
    public class AppInfo
    {
        public string AppName { get; private set; }

        public string RootPath { get; private set; }

        public Process Process { get; private set; }

        public System.IO.StreamWriter Input { get; private set; }

        public AppConfig Config { get; private set; }

        public StringBuilder Logs { get; private set; }

        public bool ReadLog { get; set; }

        public Action<string> ChangeLog { get; set; }

        public bool Runing { get; set; }

        public AppInfo(AppConfig config, string rootPath, bool readLog = true)
        {
            Config = config;
            RootPath = rootPath;
            if (!string.IsNullOrWhiteSpace(config.DisplayName))
            {
                AppName = config.DisplayName;
            }
            else
            {
                AppName = System.IO.Path.GetDirectoryName(rootPath);
            }
            this.Config.StartAppName = Config.StartAppName.Replace("{AppPath}", this.RootPath)
                .Replace("\\", "/");
            this.Config.StartArguments = Config.StartArguments.Replace("{AppPath}", this.RootPath)
                .Replace("\\", "/");

            ReadLog = readLog;
            Logs = new StringBuilder();
        }


        public void Run()
        {
            if (Process != null)
            {
                return;
            }

            Runing = true;

            Process = new Process();
            Process.StartInfo.FileName = this.Config.StartAppName;
            Process.StartInfo.Arguments = this.Config.StartArguments;// 启动参数
            Process.StartInfo.WorkingDirectory = this.RootPath;// 工作路径

            // 自定义 shell
            Process.StartInfo.UseShellExecute = false;
            // 避免显示原始窗口
            Process.StartInfo.CreateNoWindow = true;
            // 重定向标准输入（原来是 CON）
            Process.StartInfo.RedirectStandardInput = true;
            // 重定向标准输出
            Process.StartInfo.RedirectStandardOutput = true;
            // 数据接收事件（标准输出重定向至此）
            Process.OutputDataReceived += new DataReceivedEventHandler(OutputDataReceived);

            // 开始启动
            Process.Start();

            // 重定向输入
            Input = Process.StandardInput;
            // 开始监控输出（异步读取）
            Process.BeginOutputReadLine();

            UpdateLog(string.Format("程序开始运行: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        }


        public void Exit()
        {
            if (!Runing)
            {
                return;
            }

            // 释放资源
            try
            {
                Input?.Dispose();
                Process?.Kill();

                // 
                UpdateLog(string.Format("程序结束运行: {0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch (Exception)
            {

            }
            Input = null;
            Process = null;
            // 修改状态
            Runing = false;


        }


        public void ClearLogs()
        {
            Logs?.Clear();
        }


        void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (ReadLog)
            {
                UpdateLog(e.Data);
            }
        }

        public void UpdateLog(string logStr)
        {
            Logs?.AppendLine(logStr);
            ChangeLog?.Invoke(Logs.ToString());
        }
    }
}
