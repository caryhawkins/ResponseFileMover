using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponseFileMover
{
  
    public class SimpleFileMove
    {
        static void main()
        {
            string sourceFile = @"C:\IF_TEST\Z_orderD\OOWL_PH_ORDER_DOWN.RESP";
            string destinationfile = @"C:\IF_TEST\Z_orderD\bak\OOWL_PH_ORDER_DOWN"+ DateTime.Now.ToString("dd_MM_YYYY_hhmm") + ".RESP";
            string source2 = @"C:\IF_TEST\Z_orderD\OOWL_PH_ORDER_DOWN";
            string destination2 = @"C:\IF_TEST\Z_orderD\bak\OOWL_PH_ORDER_DOWN"+ DateTime.Now.ToString("dd_MM_YYYY_hhmm") + ".COMPL";

            //Check if Response file exists
           if (File.Exists(sourceFile))
            {
            //Move Response file to a new location with date in name
            System.IO.File.Move(sourceFile, destinationfile);
           }
           //Check if Compl file exists
           if (File.Exists(source2))
            {
               //Move Compl file to new location with date in name
                System.IO.File.Move(source2, destination2);
            }

        }
    }
}
