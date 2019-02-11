namespace AnyShell.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listApp = new System.Windows.Forms.ListBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnEditConfig = new System.Windows.Forms.Button();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.ckbShowLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listApp
            // 
            this.listApp.FormattingEnabled = true;
            this.listApp.ItemHeight = 12;
            this.listApp.Location = new System.Drawing.Point(10, 16);
            this.listApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listApp.Name = "listApp";
            this.listApp.Size = new System.Drawing.Size(159, 292);
            this.listApp.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(173, 28);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(112, 29);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "立即运行";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnEditConfig
            // 
            this.btnEditConfig.Location = new System.Drawing.Point(173, 72);
            this.btnEditConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditConfig.Name = "btnEditConfig";
            this.btnEditConfig.Size = new System.Drawing.Size(112, 29);
            this.btnEditConfig.TabIndex = 6;
            this.btnEditConfig.Text = "修改配置文件";
            this.btnEditConfig.UseVisualStyleBackColor = true;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(173, 119);
            this.btnOpenDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(112, 29);
            this.btnOpenDir.TabIndex = 7;
            this.btnOpenDir.Text = "打开应用目录";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(173, 166);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(112, 29);
            this.btnClearLog.TabIndex = 10;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckbShowLog);
            this.splitContainer1.Panel1.Controls.Add(this.listApp);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenDir);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditConfig);
            this.splitContainer1.Panel1.Controls.Add(this.btnRun);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(884, 318);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(591, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行日志";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(2, 16);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(587, 300);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // ckbShowLog
            // 
            this.ckbShowLog.AutoSize = true;
            this.ckbShowLog.Location = new System.Drawing.Point(174, 222);
            this.ckbShowLog.Name = "ckbShowLog";
            this.ckbShowLog.Size = new System.Drawing.Size(72, 16);
            this.ckbShowLog.TabIndex = 11;
            this.ckbShowLog.Text = "显示日志";
            this.ckbShowLog.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 318);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "AnyShell";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listApp;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEditConfig;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.CheckBox ckbShowLog;
    }
}

