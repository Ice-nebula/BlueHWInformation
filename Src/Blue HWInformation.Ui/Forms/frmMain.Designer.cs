namespace Blue_HWInformation.Ui.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabc = new System.Windows.Forms.TabControl();
            this.tabCpuInfo = new System.Windows.Forms.TabPage();
            this.cpuInfoUserControl1 = new Blue_HWInformation.Ui.UserControls.CpuInfoUserControl();
            this.tabpageMemoryInfo = new System.Windows.Forms.TabPage();
            this.memoryUserControl1 = new Blue_HWInformation.Ui.UserControls.MemoryInfoUserControl();
            this.tabc.SuspendLayout();
            this.tabCpuInfo.SuspendLayout();
            this.tabpageMemoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tabCpuInfo);
            this.tabc.Controls.Add(this.tabpageMemoryInfo);
            this.tabc.Location = new System.Drawing.Point(0, 0);
            this.tabc.Name = "tabc";
            this.tabc.SelectedIndex = 0;
            this.tabc.Size = new System.Drawing.Size(200, 100);
            this.tabc.TabIndex = 0;
            // 
            // tabCpuInfo
            // 
            this.tabCpuInfo.AccessibleName = "Cpu info";
            this.tabCpuInfo.Controls.Add(this.cpuInfoUserControl1);
            this.tabCpuInfo.Location = new System.Drawing.Point(4, 22);
            this.tabCpuInfo.Name = "tabCpuInfo";
            this.tabCpuInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpuInfo.Size = new System.Drawing.Size(192, 74);
            this.tabCpuInfo.TabIndex = 0;
            this.tabCpuInfo.Text = "Cpu info";
            this.tabCpuInfo.UseVisualStyleBackColor = true;
            // 
            // cpuInfoUserControl1
            // 
            this.cpuInfoUserControl1.AutoSize = true;
            this.cpuInfoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.cpuInfoUserControl1.Name = "cpuInfoUserControl1";
            this.cpuInfoUserControl1.Size = new System.Drawing.Size(300, 300);
            this.cpuInfoUserControl1.TabIndex = 0;
            // 
            // tabpageMemoryInfo
            // 
            this.tabpageMemoryInfo.AccessibleName = "Memory info";
            this.tabpageMemoryInfo.Controls.Add(this.memoryUserControl1);
            this.tabpageMemoryInfo.Location = new System.Drawing.Point(4, 22);
            this.tabpageMemoryInfo.Name = "tabpageMemoryInfo";
            this.tabpageMemoryInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageMemoryInfo.Size = new System.Drawing.Size(192, 74);
            this.tabpageMemoryInfo.TabIndex = 1;
            this.tabpageMemoryInfo.Text = "Memory info";
            this.tabpageMemoryInfo.UseVisualStyleBackColor = true;
            // 
            // memoryUserControl1
            // 
            this.memoryUserControl1.AutoSize = true;
            this.memoryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.memoryUserControl1.Name = "memoryUserControl1";
            this.memoryUserControl1.Size = new System.Drawing.Size(600, 600);
            this.memoryUserControl1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AccessibleName = "Blue HW information";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabc);
            this.Name = "frmMain";
            this.Text = "Blue HW information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabc.ResumeLayout(false);
            this.tabCpuInfo.ResumeLayout(false);
            this.tabCpuInfo.PerformLayout();
            this.tabpageMemoryInfo.ResumeLayout(false);
            this.tabpageMemoryInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tabCpuInfo;
        private System.Windows.Forms.TabPage tabpageMemoryInfo;
        private UserControls.CpuInfoUserControl cpuInfoUserControl1;
        private UserControls.MemoryInfoUserControl memoryUserControl1;
    }
}