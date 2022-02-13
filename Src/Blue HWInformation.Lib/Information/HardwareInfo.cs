using Blue_HWInformation.Lib.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Blue_HWInformation.Lib.Information
{
    public class HardwareInfo
    {

        public async Task<CpuEntity> GetCpuInfoAsync()
        {
            return await Task.Run(() =>
            {
                ManagementObjectSearcher query = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_Processor");
                var entity = new CpuEntity();
                foreach (var data in query.Get())
                {
                    entity.L2CacheSize = (uint)data.GetPropertyValue("L2CacheSize");
                    entity.L3CacheSize = (uint)data.GetPropertyValue("L3CacheSize");
                    entity.Name = (string)data.GetPropertyValue("Name");
                    entity.Manufacturer = (string)data.GetPropertyValue("Manufacturer");
                    entity.NumberOfCores = (uint)data.GetPropertyValue("NumberOfCores");
                    entity.NumberOfLogicalProcessors = (uint)data.GetPropertyValue("NumberOfLogicalProcessors");
                    entity.VirtualizationFirmwareEnabled = Utils.StatusToString((bool)data.GetPropertyValue("VirtualizationFirmwareEnabled"));
                    } //end for.each
                return entity;

            });

        }
    }
}
