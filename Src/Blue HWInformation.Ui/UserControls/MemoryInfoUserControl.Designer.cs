namespace Blue_HWInformation.Ui.UserControls
{
    partial class MemoryInfoUserControl
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
            this.lbMemoryInfo = new System.Windows.Forms.Label();
            this.lbxMemoryInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMemoryInfo
            // 
            this.lbMemoryInfo.AccessibleName = "Memory info";
            this.lbMemoryInfo.AutoSize = true;
            this.lbMemoryInfo.Location = new System.Drawing.Point(0, 0);
            this.lbMemoryInfo.Name = "lbMemoryInfo";
            this.lbMemoryInfo.Size = new System.Drawing.Size(64, 13);
            this.lbMemoryInfo.TabIndex = 0;
            this.lbMemoryInfo.Text = "Memory info";
            // 
            // lbxMemoryInfo
            // 
            this.lbxMemoryInfo.AccessibleName = "Memory info";
            this.lbxMemoryInfo.FormattingEnabled = true;
            this.lbxMemoryInfo.Location = new System.Drawing.Point(8, 8);
            this.lbxMemoryInfo.Name = "lbxMemoryInfo";
            this.lbxMemoryInfo.Size = new System.Drawing.Size(120, 95);
            this.lbxMemoryInfo.TabIndex = 1;
            // 
            // MemoryInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbxMemoryInfo);
            this.Controls.Add(this.lbMemoryInfo);
            this.Name = "MemoryInfoUserControl";
            this.Size = new System.Drawing.Size(600, 600);
            this.Load += new System.EventHandler(this.MemoryInfoUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemoryInfo;
        private System.Windows.Forms.ListBox lbxMemoryInfo;
    }
}
