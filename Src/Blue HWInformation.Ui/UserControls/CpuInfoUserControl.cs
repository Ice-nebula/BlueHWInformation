using Blue_HWInformation.Lib.Information;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blue_HWInformation.Ui.UserControls
{
    public partial class CpuInfoUserControl : UserControl
    {
        private HardwareInfo _hardwareInfo;
        public CpuInfoUserControl()
        {
            _hardwareInfo = new HardwareInfo();
            InitializeComponent();
        }

        private void CpuInfoUserControl_Load(object sender, EventArgs e)
        {
            AddCpuToListBoxAsync();
        }

        private async void AddCpuToListBoxAsync()
        {
            try
            {
                var data = await _hardwareInfo.GetCpuInfoAsync();
                lbxCpuInfo.Items.Add($"cpu name : {data.Name}");
                lbxCpuInfo.Items.Add($"Manufacturer : {data.Manufacturer}");
                lbxCpuInfo.Items.Add($"L2CacheSize : {data.L2CacheSize / 1024} mb");
                lbxCpuInfo.Items.Add($"L3CacheSize : {data.L3CacheSize / 1024} mb");
                lbxCpuInfo.Items.Add($"NumberOfCores : {data.NumberOfCores}");
                lbxCpuInfo.Items.Add($"NumberOfLogicalProcessors : {data.NumberOfLogicalProcessors}");
                lbxCpuInfo.Items.Add($"Virtualization Technology enabled: {data.VirtualizationFirmwareEnabled}");
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            } //end catch
        } //end method
    }
}
