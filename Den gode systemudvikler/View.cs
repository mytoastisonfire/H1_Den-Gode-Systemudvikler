using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_gode_systemudvikler
{
    internal class View
    {
        internal void GUI(byte numberOfErrorCodes)
        {
            try
            {
                Console.WriteLine("There are " + numberOfErrorCodes + " error codes on file");
            }
            catch(ArgumentNullException ex)
            {
                Debug.WriteLine("numberOfErrorCodes cannot be null!");
                throw new ArgumentNullException("numberOfErrorCodes cannot be null!", ex);
            }
            finally 
            {
                Console.WriteLine("Everything has been handled!");
                Console.ReadLine();
            }
        }
    }
}
