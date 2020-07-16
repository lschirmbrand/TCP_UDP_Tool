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
    public partial class GUI : Form
    {
        Partner[] partnerarray = new Partner[18];
        NetworkGridRow[] ngr;
        CheckBox[] checkbox; 
        int numberOfEndpoints = 0;        

        public GUI()
        {
            InitializeComponent();
            label_stop.Visible = false;
            btn_Run.Enabled = false;
            btn_Run_Selected.Enabled = false;
            btn_Stop.Visible = false;
            btn_export.Enabled = false;
            pick_protocol.SelectedItem = "tcp";
        }

        private void bnt_import_Click(object sender, EventArgs e)
        {
            bnt_import.Enabled = false;
            txt_Instruction.Visible = false;
            btn_Run_Selected.Enabled = false;
            openFileDialog1.InitialDirectory = "c:\\Desktop\\";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Excel-Datei für Import suchen:";
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

            Excelreader excelread = new Excelreader();
            excelread.setcomboBoxText(pick_protocol.Text);
            excelread.startReading(filePath);
            this.partnerarray = excelread.retPartnerarray();
            checkbox = new CheckBox[partnerarray.Length];
            btn_Run_Selected.Enabled = true;
            btn_Run.Enabled = true;
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

            dataGV.ColumnCount = 4;
            dataGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGV.ColumnHeadersDefaultCellStyle.Font = new Font(dataGV.Font, FontStyle.Bold);

            dataGV.Name = "Connection-Overview";
            dataGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGV.GridColor = Color.Black;
            dataGV.RowHeadersVisible = false;

            dataGV.Columns[0].Name = "";
            dataGV.Columns[0].Width = 50;
            dataGV.Columns[0].ReadOnly = true;
            dataGV.Columns[1].Name = "IP-Address";
            dataGV.Columns[1].Width = 200;
            dataGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGV.Columns[2].Name = "Ports";
            dataGV.Columns[2].Width = 125;
            dataGV.Columns[3].Name = "Status";
            dataGV.Columns[3].Width = 140;
            dataGV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            

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
                            if(!(i==partnerarray.Length-1 && j==partnerarray[i].endpoints.Length-1))dataGV.Rows.Add(1);

                            ngr[row] = new NetworkGridRow(partnerarray[i], partnerarray[i].endpoints[j], dataGV.Rows[row]);


                            checkbox[i] = new CheckBox();
                            checkbox[i].Location = new Point(20, i*50+50);

                            dataGV.Rows[row].Cells[0].Value = row;
                            dataGV.Rows[row].Cells["IP-Address"].Value = partnerarray[i].ip;
                            dataGV.Rows[row].Cells["Ports"].Value = partnerarray[i].endpoints[j].port;
                            row++;
                            //break;
                        }                        
                    }
                    else break;
                }
            }

            
            dataGV.Visible = true;
        }       

        private void btn_Run_Click(object sender, EventArgs e)
        {
            btn_Run.Visible = false;
            label_run.Visible = false;
            btn_Stop.Visible = true;
            label_stop.Visible = true;
            
            if (checkClient.Checked == true)
            {
                for (int i = 0; i < dataGV.Rows.Count - 1; i++)
                    ngr[i].ConnectAsClient();
            }
            if(checkClient.Checked == false)
            {
                for (int i = 0; i < dataGV.Rows.Count - 1; i++)
                    ngr[i].ConnectAsServer();
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<numberOfEndpoints; i++)
            {
                ngr[i].stopAllConnections();
                btn_Run_Selected.Enabled = false;
                btn_export.Enabled = true;
                btn_Stop.Visible = false;
                label_stop.Text = "Stopped.";
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Ordner für den Export auswählen";
            folderBrowserDialog.ShowDialog();
            string filePath = folderBrowserDialog.SelectedPath;           

            Exporter export = new Exporter();
            export.startExport(ngr, filePath);
        }

        private void btn_Run_Selected_Click(object sender, EventArgs e)
        {
            btn_Stop.Visible = true;

            for (int i = 0; i < ngr.Length; i++)
            {
                if (checkClient.Checked == false)
                {
                    if (dataGV.Rows[i].Cells[1].Selected == true)
                        ngr[i].startManuelServer();
                }
                else
                {
                    if (dataGV.Rows[i].Cells[0].Selected == true)
                        ngr[i].startManuelClient();
                }                
            }
        }
    }
}
