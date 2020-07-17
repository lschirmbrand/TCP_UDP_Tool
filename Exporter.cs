using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDP_Tool
{
    class Exporter
    {
        internal void startExport(NetworkGridRow[] ngr, string filePath)
        {
            string success = "VALID CONNECTIONS THAT WORKED IN TERMS OF CONNECTION, SENDING AND REVEIVING. \r\n---------------------------------------------------------------------------------\r\n";
            string failed = "FAILED CONNECTIONS THAT FAILED IN TERMS OF CONNECTION, SENDING AND REVEIVING. \r\n---------------------------------------------------------------------------------\r\n"; ;

            for (int i = 0; i < ngr.Length; i++)
            {
                if (ngr[i].Connected == true)
                {
                    success += "VALID: Connection zu: " + ngr[i].Partner.ip + ":" + ngr[i].Endpoint.port + " mit der Protokollart: " + ngr[i].Endpoint.protocol + ".\r\n";
                }

                else if (ngr[i].Connected == false)
                {
                    failed += "FAILED: Connection zu: " + ngr[i].Partner.ip + ":" + ngr[i].Endpoint.port + " mit der Protokollart: " + ngr[i].Endpoint.protocol + ".\r\n";
                }
            }

            success += "\r\n\r\n";
            failed += "\r\n\r\n";
            string textOutput = failed + success;
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            string outputFilename = "Exporter_"+datetime;
            outputFilename = outputFilename.Replace(".", "_");
            outputFilename = outputFilename.Replace(" ", "_");
            outputFilename = outputFilename.Replace(":", "_");
            
            outputFilename += ".txt";
            

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, outputFilename)))
            {               
                outputFile.Write(textOutput);
            }

        }
    }
}  

