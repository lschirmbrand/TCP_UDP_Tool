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
        public bool stopped = false;
        Byte[] buffer = new Byte[9];
        public string messagereceived;

        public NetworkGridRow(Partner partner, Endpoint endpoint, DataGridViewRow row)
        {
            Partner = partner;
            Endpoint = endpoint;
            Row = row;
            Connected = false;            
        }

        public Partner Partner { get; }
        public Endpoint Endpoint { get; }
        public DataGridViewRow Row { get; }
        public bool Connected { get; set; }

        public void ConnectAsClient()
        {
            Row.Cells["Status"].Value = "Connecting...";
            Row.Cells["Status"].Style.BackColor = Color.Orange;

            //if (Endpoint.mode == Endpoint.modeE.client)
            //{
                if (Endpoint.protocol == Endpoint.protocolE.tcp)
                {
                    startClientTCP();
                }

                else if (Endpoint.protocol == Endpoint.protocolE.udp)
                {
                    startClientUDP();
                }
            //}
            //else if (Endpoint.mode == Endpoint.modeE.server)
            //{

            //}
        }


        public void ConnectAsServer()
        {
            Row.Cells["Status"].Value = "Connecting...";
            Row.Cells["Status"].Style.BackColor = Color.Orange;

            //if(Endpoint.mode == Endpoint.modeE.client)
            //{
            if (Endpoint.protocol == Endpoint.protocolE.tcp)
                {
                    startServerTCP();
                }

                else if(Endpoint.protocol == Endpoint.protocolE.udp)
                {
                    throw new NotImplementedException();
                }
            //}
            //else if(Endpoint.mode == Endpoint.modeE.server)
            //{

            //}
        }

        private void startServerTCP()
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
            var sendData = Encoding.ASCII.GetBytes("Connected");
            clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallbackTCP, null);
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackTCP, null); //CRASHZEILE
            serverSocket.BeginAccept(AcceptCallbackServer, null);
            
        }

        private void SendCallbackTCP(IAsyncResult ar)
        {
            try
            {
                //((Socket)ar.AsyncState)
                clientSocket.EndSend(ar);

            }
            catch (SocketException ex)
            {
                retryClientTCP();
            }
        }


        private void ReceiveCallbackTCP(IAsyncResult ar)
        {
            try
            {
                int received = clientSocket.EndReceive(ar);

                if (received == 0)
                {
                    return;
                }
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackTCP, null);
                string message = Encoding.ASCII.GetString(buffer);

                if (message == "Connected")
                {
                    Row.Cells["Status"].Value = message;
                    Row.Cells["Status"].Style.BackColor = Color.LimeGreen;                    
                    if (clientSocket != null) clientSocket.Close();
                    if (serverSocket != null) serverSocket.Close();
                }

            }

            catch (SocketException ex)
            {
                retryClientTCP();
            }
            catch (ObjectDisposedException ex)
            {
                retryClientTCP();
            }
        }

           

        public void startClientTCP()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);                
                var endPoint = new IPEndPoint(Partner.ip, Convert.ToInt32(Endpoint.port));              
                clientSocket.BeginConnect(endPoint, ConnectCallbackClientTCP, null);                
            }

            catch (SocketException ex)
            {
                retryClientTCP();
            }
        }
       

        private void ConnectCallbackClientTCP(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndConnect(ar);                
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallbackTCP, null);
                var sendData = Encoding.ASCII.GetBytes("Connected");
                clientSocket.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallbackTCP, null);
            }

            catch (SocketException ex)
            {
                retryClientTCP();
            }

            catch (ObjectDisposedException ex)
            {
                retryClientTCP();
            }
        }     
        

        

        public bool SocketConnectedTCP(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);

            if ((part1 && part2) || !s.Connected)
                return false;
            else
                return true;
        }

        private void retryClientTCP()
        {
            if (!stopped)
            {
                startClientTCP();
            }
        }


        public void startClientUDP()
        {
            UdpClient udpClient = new UdpClient();

            try 
            {
                udpClient.Connect(Partner.ip, Convert.ToInt32(Endpoint.port));            
            }

            catch
            {

            }
        }

        /*public void displayStatus()
        {
            if(Connected)
            {
                //Row.Cells["Status"].Value = "Connected";
                Row.Cells["Status"].Style.BackColor = Color.LimeGreen;        
            }
            else
            {
                Row.Cells["Status"].Value = "Failed";
                Row.Cells["Status"].Style.BackColor = Color.Red;
            }
        }*/

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        


        public void stopAllConnections()
        {
            this.stopped = true;
            
            if (clientSocket != null)
                clientSocket = null;
            if (serverSocket != null)
                serverSocket = null;
            if (Convert.ToString(Row.Cells["Status"].Value) != "Connected")
            {
                Row.Cells["Status"].Value = "stopped/Failed";
                Row.Cells["Status"].Style.BackColor = Color.Red;
            }
        }
    }
}
