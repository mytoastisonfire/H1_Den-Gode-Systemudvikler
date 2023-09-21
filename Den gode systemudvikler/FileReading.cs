using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_gode_systemudvikler
{
    internal class FileReading
    {
        internal string FileReader() 
        {
            string path = "C:\\Users\\zbc23matlc\\Desktop\\Skole\\H1\\Objekt orienteret programering\\Den gode systemudvikler\\logdata.txt";
            try
            {
                return File.ReadAllText(path) ;
            }
            catch(Exception ex) 
            {
                throw new ArgumentException("An exception has occurred.", ex);
            }
            finally
            {
                Console.WriteLine("Everything has been handled!");
            }
        }
    }
}
