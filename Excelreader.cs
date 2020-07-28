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
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance.Implementations;

namespace TCP_UDP_Tool
{
    class Excelreader
    {
        Partner[] partnerarray = new Partner[35];
        string protocol;

        /*
        
        Anpassen dieser zwei Werte, um die veränderte Position in der Excel-Datei zu übernehmen.
        spalteIPADRESS = Spalte in der die IP-Adressen aufgeführt sind.
        spalteIPADRESS = Spalte in der die Ports aufgeführt sind.
        zeileANFANG = Zeile, in der die IP- und Portaufführung beginnt.
        zeilenMAX_ANZAHL = Wie viele Zeilen maximal eingelesen werden müssen. Standard auf 50.

        */

        int spalteIPADRESS = 3;
        int spaltePORT = 5;
        int zeileANFANG = 15;
        int zeilenMAX_ANAZAHL = 50;

        public void startReading(string path)
        {
            zeilenMAX_ANAZAHL += zeileANFANG - 1;

            FileInfo fi = new FileInfo(path);
            using (ExcelPackage excelPackage = new ExcelPackage(fi))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet portsWorksheet = excelPackage.Workbook.Worksheets[0];               

                int counter = 0;
                for (int i = zeileANFANG; i<zeilenMAX_ANAZAHL; i++)
                {                    
                    if (portsWorksheet.Cells[i, 3].Text.ToString() != "")
                    {
                        partnerarray[counter] = new Partner(portsWorksheet.Cells[i, spalteIPADRESS].Text.ToString(), portsWorksheet.Cells[i, spaltePORT].Text.ToString(), protocol);                        
                        counter++;
                    }                    
                }
            }
        }

        public Partner[] retPartnerarray()
        {
            return partnerarray;
        }

        public void setcomboBoxText(string protocol)
        {
            this.protocol = protocol;
        }
    }
}
