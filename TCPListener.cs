using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_UDP_Tool
{
    class TCPListener
    {

        Socket serverSocket;
        Socket clientSocket;

        public void startListenforRequests(Partner[] partnerarray)
        {
            for(int i = 0; i<partnerarray.Length; i++)
            {
                for(int j = 0; j<partnerarray[i].endpoints.Length; j++)
                {
                    try
                    {
                        serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        serverSocket.Bind(new System.Net.IPEndPoint(IPAddress.Any, Convert.ToInt32(partnerarray[i].endpoints[j].port)));
                        serverSocket.Listen(50);
                        serverSocket.BeginAccept(AcceptCallbackServerAuto, null);

                    }

                    catch (SocketException ex)
                    {
                        ShowErrorDialog(ex.Message);
                    }
                    catch (ObjectDisposedException ex)
                    {
                        ShowErrorDialog(ex.Message);
                    }
                }
            }            
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AcceptCallbackServerAuto(IAsyncResult ar)
        {
            //clientSocket = serverSocket.EndAccept(AR);            
            serverSocket.Close();
        }

        public void getClient(Socket client)
        {
            this.clientSocket = client;
        }
    }
}
