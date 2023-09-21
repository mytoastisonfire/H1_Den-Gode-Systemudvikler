using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_gode_systemudvikler
{
    internal class DataAnalyzer
    {
        internal byte CountErrorCodes(string[] errorcodes)
        {
            try
            {
                byte numberOfErrorCodes = Convert.ToByte(errorcodes.GetLength(0));
                return numberOfErrorCodes;
            }
            catch(OverflowException ex)
            {
                Debug.WriteLine("There are over 255 error codes, this cannot be handled by the program.");
                throw new ArgumentException ("Too many error codes for a byte", ex);
            }
        }
    }
}
