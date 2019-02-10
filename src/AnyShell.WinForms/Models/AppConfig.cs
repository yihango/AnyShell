using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyShell.WinForms.Models
{
    public class AppConfig
    {

        /// <summary>
        /// 配置文件
        /// </summary>
        public string ConfigFile { get; set; }

        /// <summary>
        /// 启动的应用名称
        /// </summary>
        public string StartAppName { get; set; }

        /// <summary>
        /// 启动参数
        /// </summary>
        public string StartArguments { get; set; }

        /// <summary>
        /// 排序优先级,越大越靠前
        /// </summary>
        public long Index { get; set; }

        /// <summary>
        /// App显示名称
        /// </summary>
        public string DisplayName { get; set; }
    }
}
