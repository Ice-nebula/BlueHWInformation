namespace Blue_HWInformation.Ui.UserControls
{
    partial class CpuInfoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCpuInformation = new System.Windows.Forms.Label();
            this.lbxCpuInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCpuInformation
            // 
            this.lbCpuInformation.AccessibleName = "Cpu information";
            this.lbCpuInformation.AutoSize = true;
            this.lbCpuInformation.Location = new System.Drawing.Point(0, 0);
            this.lbCpuInformation.Name = "lbCpuInformation";
            this.lbCpuInformation.Size = new System.Drawing.Size(80, 13);
            this.lbCpuInformation.TabIndex = 0;
            this.lbCpuInformation.Text = "Cpu information";
            // 
            // lbxCpuInfo
            // 
            this.lbxCpuInfo.AccessibleName = "Cpu information";
            this.lbxCpuInfo.FormattingEnabled = true;
            this.lbxCpuInfo.Location = new System.Drawing.Point(8, 8);
            this.lbxCpuInfo.Name = "lbxCpuInfo";
            this.lbxCpuInfo.Size = new System.Drawing.Size(120, 95);
            this.lbxCpuInfo.TabIndex = 1;
            // 
            // CpuInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbxCpuInfo);
            this.Controls.Add(this.lbCpuInformation);
            this.Name = "CpuInfoUserControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.CpuInfoUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCpuInformation;
        private System.Windows.Forms.ListBox lbxCpuInfo;
    }
}
