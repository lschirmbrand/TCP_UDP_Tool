using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TCP_UDP_Tool
{
    class TCPClient
    {
        Socket clientSocket;
        private byte[] buffer;
        private String[] connectionState;



        public void establishConnection(Partner[] partnerarray)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < partnerarray[i].endpoints.Length; j++)
                {
                    try
                    {
                        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        var endPoint = new IPEndPoint(partnerarray[i].ip, Convert.ToInt32(partnerarray[i].endpoints[j].port));    
                        clientSocket.BeginConnect(endPoint, ConnectCallbackClient, null);
                    }

                    catch (SocketException ex)
                    {
                        ShowErrorDialog(ex.Message);
                    }
                }                
            }
        }

        public bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);

            if ((part1 && part2) || !s.Connected)
                return false;
            else
                return true;
        }

        private void ConnectCallbackClient(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackClient, null);                
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

        

        private void ReceiveCallbackClient(IAsyncResult ar)
        {            
            try
            {
                int received = clientSocket.EndReceive(ar);

                if (received == 0)
                {
                    return;
                }


                string message = Encoding.ASCII.GetString(buffer);
               
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackClient, null);
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

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void returnFailedorWorked()
        {
            
        }
    }
}
