using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using OfficeOpenXml;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace TCP_UDP_Tool
{
    class Excelreader
    {
        Partner[] partnerarray = new Partner[19];

        public void startReading(string path)
        {
            
            FileInfo fi = new FileInfo(path);
            using (ExcelPackage excelPackage = new ExcelPackage(fi))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet portsWorksheet = excelPackage.Workbook.Worksheets[0];               

                int counter = 0;
                for (int i = 15; i<50; i++)
                {
                    
                    if (portsWorksheet.Cells[i, 3].Text.ToString() != "")
                    {
                        partnerarray[counter] = new Partner(portsWorksheet.Cells[i, 3].Text.ToString(), portsWorksheet.Cells[i, 5].Text.ToString());
                        counter++;
                    }                    
                }
            }
        }

        public Partner[] retPartnerarray()
        {
            return partnerarray;
        }
    }
}
