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
    public partial class MemoryInfoUserControl : UserControl
    {
        private HardwareInfo _hardwareInfo;
        public MemoryInfoUserControl()
        {
            _hardwareInfo = new HardwareInfo();
            InitializeComponent();
        }

        private void MemoryInfoUserControl_Load(object sender, EventArgs e)
        {
            GetMemoryInfo();
        }

        private async void GetMemoryInfo()
        {
            try
            {
                var infos = await _hardwareInfo.GetMemoryInfoAsync();
                foreach (var info in infos)
                {
                    lbxMemoryInfo.Items.Add(info.Name);
                    lbxMemoryInfo.Items.Add($"Manufacturer : {info.Manufacturer}");
                    lbxMemoryInfo.Items.Add($"DeviceLocator : {info.DeviceLocator}");
                    lbxMemoryInfo.Items.Add($"Capacity : {info.Capacity} gb");
                    lbxMemoryInfo.Items.Add($"ClockSpeed : {info.ConfiguredClockSpeed} MHz");
                } //end for.each
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error");
            } //end catch
        } //end method
    }
}
