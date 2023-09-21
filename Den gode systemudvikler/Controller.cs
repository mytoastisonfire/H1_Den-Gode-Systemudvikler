using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_gode_systemudvikler
{
    internal class Controller
    {
        public void Start()
        {
            byte numberOfErrorCodes;
            FileReading fileReading = new FileReading();
            string[] errorCodes = fileReading.FileReader().Split('\n');

            try
            {
                DataAnalyzer dataAnalyzer = new DataAnalyzer();
                numberOfErrorCodes = dataAnalyzer.CountErrorCodes(errorCodes);
            }
            catch (Exception ex)
            {
                Console.ReadLine();

                throw ex;
            }
            
            
            View view = new View();
            view.GUI(numberOfErrorCodes);
        }
    }
}
