using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_HWInformation.Lib
{
    internal static class Utils
    {
        public static string StatusToString(bool status)
        {
            if (status == true) return "yes";
            else
            {
                return "no";
            }
        } //end method

        public static double ConvertByteToGb(ulong value)
        {
            return Convert.ToDouble(value / 1024 / 1024 / 1024);
        } //end method
    }
}
