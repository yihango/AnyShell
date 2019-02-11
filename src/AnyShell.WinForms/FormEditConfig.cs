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
    public partial class FormEditConfig : Form
    {
        public string ConfigPath { get; private set; }

        public FormEditConfig(string configPath)
        {
            InitializeComponent();

            this.ConfigPath = configPath;
            this.btnSaveChange.Click += BtnSaveChange_Click;


            this.txtConfig.Text = File.ReadAllText(this.ConfigPath, Encoding.UTF8);
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(this.ConfigPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var buffer = Encoding.UTF8.GetBytes(this.txtConfig.Text);
                fs.Write(buffer, 0, buffer.Length);
            }

            this.Close();
        }
    }
}
