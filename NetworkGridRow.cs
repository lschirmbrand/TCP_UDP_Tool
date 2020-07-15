using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_UDP_Tool
{
    public class NetworkGridRow
    {

        public Socket clientSocket;
        public Socket serverSocket;
        DataGridViewCellStyle styleSucc = new DataGridViewCellStyle();
        DataGridViewCellStyle styleFail = new DataGridViewCellStyle();
        
        

        public NetworkGridRow(Partner partner, Endpoint endpoint, DataGridViewRow row)
        {
            Partner = partner;
            Endpoint = endpoint;
            Row = row;
            Connected = false;
            styleSucc.BackColor = Color.LimeGreen;
            styleFail.BackColor = Color.Red;
            
        }

        public Partner Partner { get; }
        public Endpoint Endpoint { get; }
        public DataGridViewRow Row { get; }
        public bool Connected { get; set; }
        private Byte[] buffer { get; set; }

        public void ConnectAsServer()
        {
            Row.Cells["Status"].Value = "Connecting...";
            
            //if(Endpoint.mode == Endpoint.modeE.client)
            //{
                if(Endpoint.protocol == Endpoint.protocolE.tcp)
                {
                    startServer();
                }

                else if(Endpoint.protocol == Endpoint.protocolE.udp)
                {
                    throw new NotImplementedException();
                }
            //}
            /*else if(Endpoint.mode == Endpoint.modeE.server)
            {

            }*/
        }

        private void startServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new System.Net.IPEndPoint(IPAddress.Any, Convert.ToInt32(Endpoint.port)));
                serverSocket.Listen(50);
                serverSocket.BeginAccept(AcceptCallbackServer, null);

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

        private void AcceptCallbackServer(IAsyncResult ar)
        {
            clientSocket = serverSocket.EndAccept(ar);
            serverSocket.Close();
        }

        public void ConnectAsClient()
        {
            Row.Cells["Status"].Value = "Connecting...";

            //if (Endpoint.mode == Endpoint.modeE.client)
            //{
                if (Endpoint.protocol == Endpoint.protocolE.tcp)
                {
                    startClient();
                }

                else if (Endpoint.protocol == Endpoint.protocolE.udp)
                {
                    throw new NotImplementedException();
                }
            //}
            /*else if (Endpoint.mode == Endpoint.modeE.server)
            {

            }*/
        }

        public void startClient()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);                
                var endPoint = new IPEndPoint(Partner.ip, Convert.ToInt32(Endpoint.port));                
                clientSocket.BeginConnect(endPoint, ConnectCallbackClient, null);
            }

            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
       

        private void ConnectCallbackClient(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndConnect(ar);
                byte[] buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackClient, null);
                Connected = SocketConnected(clientSocket);
                displayStatus();                
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

        public bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);

            if ((part1 && part2) || !s.Connected)
                return false;
            else
                return true;
        }

        public void displayStatus()
        {
            if(Connected)
            {
                Row.Cells["Status"].Value = "Connected";
                Row.Cells["Status"].Style.BackColor = Color.Green;        
            }
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
