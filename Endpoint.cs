using System;

public class Endpoint
{
        
    public enum protocolE
    {
        tcp = 0,
        udp = 1
    }
    public enum modeE
    {
        client = 0,
        server = 1
    }
    public string port;
    public protocolE protocol;
    public modeE mode;    

    public Endpoint(string port, string protocol, string mode)
    {
        this.port = port;
        if (protocol == "tcp")
        {
            this.protocol = protocolE.tcp;
        }
        else this.protocol = protocolE.udp;
        if (mode == "client")
        {
            this.mode = modeE.client;
        }
        else this.mode = modeE.server;
    }

}