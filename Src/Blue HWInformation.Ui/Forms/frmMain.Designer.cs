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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cpuInfoUserControl1 = new Blue_HWInformation.Ui.UserControls.CpuInfoUserControl();
            this.tabc.SuspendLayout();
            this.tabCpuInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tabCpuInfo);
            this.tabc.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cpuInfoUserControl1
            // 
            this.cpuInfoUserControl1.AutoSize = true;
            this.cpuInfoUserControl1.Location = new System.Drawing.Point(0, 0);
            this.cpuInfoUserControl1.Name = "cpuInfoUserControl1";
            this.cpuInfoUserControl1.Size = new System.Drawing.Size(300, 300);
            this.cpuInfoUserControl1.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tabCpuInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.CpuInfoUserControl cpuInfoUserControl1;
    }
}