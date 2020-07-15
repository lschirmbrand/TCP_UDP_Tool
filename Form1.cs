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
using System.Security.Cryptography.Pkcs;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data;

namespace TCP_UDP_Tool
{
    public partial class Form1 : Form
    {
        Partner[] partnerarray = new Partner[18];
        NetworkGridRow[] ngr;
        int numberOfEndpoints = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_import_Click(object sender, EventArgs e)
        {                
            openFileDialog1.InitialDirectory = "c:\\Desktop\\";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Excel-Datei für Import suchen:";
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

            Excelreader excelread = new Excelreader();
            excelread.startReading(filePath);
            this.partnerarray = excelread.retPartnerarray();

            formBuildUp();
        }

        private void formBuildUp()
        {            
            for(int i = 0; i<partnerarray.Length; i++)
            {
                if(partnerarray[i] != null)
                {
                    numberOfEndpoints += partnerarray[i].endpoints.Length;
                }
            }

            ngr = new NetworkGridRow[numberOfEndpoints];            

            dataGV.ColumnCount = 3;
            dataGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGV.ColumnHeadersDefaultCellStyle.Font = new Font(dataGV.Font, FontStyle.Bold);

            dataGV.Name = "Connection-Overview";
            dataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGV.GridColor = Color.Black;
            dataGV.RowHeadersVisible = false;            

            dataGV.Columns[0].Name = "IP-Adress";
            dataGV.Columns[0].Width = 200;
            dataGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGV.Columns[1].Name = "Ports";
            dataGV.Columns[1].Width = 155;
            dataGV.Columns[2].Name = "Status";
            dataGV.Columns[2].Width = 200;
            dataGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            

            int row = 0;

            partnerarray = partnerarray.Where(c => c != null).ToArray();

            for (int i = 0; i<partnerarray.Length; i++)
            {
                for(int j = 0; j<partnerarray[i].endpoints.Length; j++)
                {
                    if (partnerarray[i].endpoints[j] != null)
                    {
                        if (partnerarray[i].endpoints[j].port != null)
                        {
                            dataGV.Rows.Add(1);
                            ngr[row] = new NetworkGridRow(partnerarray[i], partnerarray[i].endpoints[j], dataGV.Rows[row]);

                            dataGV.Rows[row].Cells[0].Value = partnerarray[i].ip;
                            dataGV.Rows[row].Cells[1].Value = partnerarray[i].endpoints[j].port;
                            row++;
                        }                        
                    }
                    else break;
                }
            }
        }       

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if(checkClient.Checked)
            {
                for (int i = 0; i < numberOfEndpoints; i++)
                    ngr[i].ConnectAsClient();
            }
            else
            {
                for (int i = 0; i < numberOfEndpoints; i++)
                    ngr[i].ConnectAsServer();
            }
        }
    }
}
