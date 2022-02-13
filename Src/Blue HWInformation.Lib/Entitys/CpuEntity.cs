using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_HWInformation.Lib.Entitys
{
    public class CpuEntity
    {
        private uint _l2CacheSize;
        private uint _l3CacheSize;
        private string _manufacturer;
        private string _name;
        private uint _numberOfCores;
        private uint _numberOfLogicalProcessors;
        private string _virtualizationFirmwareEnabled;
        public uint L2CacheSize { get => _l2CacheSize; set => _l2CacheSize = value; }
        public uint L3CacheSize { get => _l3CacheSize; set => _l3CacheSize = value; }
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Name { get => _name; set => _name = value; }
        public uint NumberOfCores { get => _numberOfCores; set => _numberOfCores = value; }
        public uint NumberOfLogicalProcessors { get => _numberOfLogicalProcessors; set => _numberOfLogicalProcessors = value; }
        public string VirtualizationFirmwareEnabled { get => _virtualizationFirmwareEnabled; set => _virtualizationFirmwareEnabled = value; }
    }
   
}
