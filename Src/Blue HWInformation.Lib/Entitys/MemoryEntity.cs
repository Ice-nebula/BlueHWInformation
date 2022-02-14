using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_HWInformation.Lib.Entitys
{
   public class MemoryEntity
    {
        private string _bankLabel;
        private double _capacity;
        private uint _configuredClockSpeed;
        private string _manufacturer;
        private string _name;
private string _deviceLocator;
        public string BankLabel { get => _bankLabel; set => _bankLabel = value; }
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Name { get => _name; set => _name = value; }
        public double Capacity { get => _capacity; set => _capacity = value; }
        public string DeviceLocator { get => _deviceLocator; set => _deviceLocator = value; }
        public uint ConfiguredClockSpeed { get => _configuredClockSpeed; set => _configuredClockSpeed = value; }
    }
}
