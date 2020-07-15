using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDP_Tool
{
    public class Partner
    {
        public IPAddress ip;
        public Endpoint[] endpoints = new Endpoint[25];

        public Partner()
        {

        }

        public Partner(string IP, string portsstring)
        {
            this.ip = IPAddress.Parse(IP);
            String[] portssplit = stringSplitter(portsstring);            

            for(int i = 0; i<portssplit.Length; i++)
            {
                endpoints[i] = new Endpoint(portssplit[i], "tcp", "client");
            }

            endpoints = endpoints.Where(c => c != null).ToArray();  
        }

        public string[] stringSplitter(string ports)
        {
            String[] portsSplit = ports.Split(';');
            for(int i = 0; i<portsSplit.Length; i++)
            {
                if (portsSplit[i].Contains("-"))
                {
                    string[] temp = portsSplit[i].Split('-');
                    portsSplit[i] = null;
                    int diff = Convert.ToInt32(temp[1]) - Convert.ToInt32(temp[0]);
                    int[] tempPorts = new int[diff+1];

                    for(int k = 0; k<diff+1; k++)
                    {
                        tempPorts[k] = (Convert.ToInt32(temp[0]) + k);
                    }

                    Array.Resize(ref portsSplit, portsSplit.Length + diff);
                    int counter = 0;
                    for(int j = 0; j<portsSplit.Length; j++)
                    {
                        if(portsSplit[j] == null)
                        {
                            portsSplit[j] = Convert.ToString(tempPorts[counter]);                                                       
                            counter++;
                        }

                        //portsSplit[j].Replace(" ", string.Empty);                        

                        if (counter == tempPorts.Length)
                        {
                            break;
                        }
                        
                    }                   

                }
                if (portsSplit[i] == "") portsSplit[i] = null;
            }
            return portsSplit;
        }
    }
}
