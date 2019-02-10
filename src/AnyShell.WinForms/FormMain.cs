using AnyShell.WinForms.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyShell.WinForms
{
    public partial class FormMain : Form
    {
        const string appDirName = "apps";
        const string appConfigFileName = "config.json";

        Action<string> WriteLog { get; set; }
        string ShellPath { get; set; }
        List<AppInfo> AppInfoList { get; set; }
        int SelectIndex { get; set; }

        AppInfo CurrentAppInfo { get; set; }

        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
            this.btnRun.Click += BtnRun_Click;
            this.listApp.SelectedIndexChanged += ListApp_SelectedIndexChanged;
        }

        private void ListApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectIndex = this.listApp.SelectedIndex;
            if (SelectIndex == -1)
            {
                return;
            }

            if (CurrentAppInfo != null)
            {
                CurrentAppInfo.ChangeLog = null;
            }

            var tmpCurrentAppInfo = this.AppInfoList[SelectIndex];
            this.btnRun.Text = tmpCurrentAppInfo.Runing ? "立即停止" : "立即运行";
            if (tmpCurrentAppInfo.ChangeLog == null)
            {
                tmpCurrentAppInfo.ChangeLog = AnyShellShowWriteLog;
            }

            CurrentAppInfo = tmpCurrentAppInfo;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (CurrentAppInfo == null)
            {
                return;
            }

            if (CurrentAppInfo.Runing)
            {
                CurrentAppInfo.Exit();
            }
            else
            {
                CurrentAppInfo.Run();
            }
            this.btnRun.Text = CurrentAppInfo.Runing ? "立即停止" : "立即运行";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Initi();
            LoadApps();
            Bind();
        }


        void Initi()
        {
            ShellPath = System.AppDomain.CurrentDomain.BaseDirectory;
            WriteLog = (str) =>
            {
                txtLog.Text = str;
                //让文本框获取焦点
                this.txtLog.Focus();
                //设置光标的位置到文本尾
                this.txtLog.Select(this.txtLog.TextLength, 0);
                //滚动到控件光标处
                this.txtLog.ScrollToCaret();
            };
        }

        void Bind()
        {
            foreach (var appInfo in AppInfoList)
            {
                listApp.Items.Add(appInfo.AppName);
            }
        }

        void LoadApps()
        {
            AppInfoList = new List<AppInfo>();

            var allAppBaseDirFullPath = Path.Combine(ShellPath, appDirName);

            var appDirFullPaths = Directory.GetDirectories(allAppBaseDirFullPath);

            foreach (var appDirFullPath in appDirFullPaths)
            {
                //new AppInfo()
                var appConfigPath = Path.Combine(appDirFullPath, appConfigFileName);

                var appConfig = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(appConfigPath, Encoding.UTF8));

                AppInfoList.Add(new AppInfo(appConfig, appDirFullPath));
            }

            AppInfoList = AppInfoList.OrderByDescending(o => o.Config.Index).ToList();
        }

        void AnyShellShowWriteLog(string str)
        {
            Invoke(WriteLog, str);
        }
    }
}
