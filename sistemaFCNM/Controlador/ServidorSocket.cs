using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class ServidorSocket
{

    // Incoming data from the client.  
    private string data = null;
    private String addres;
    private int port;
    private Socket listener;
    private Boolean HayConexion = true;




    public ServidorSocket(string addres, int port)
    {
        this.addres = addres;
        this.port = port;

    }
    public string Data
    {
        get
        {
            return data;
        }

    }

    public void StartListening()
    {
        // Data buffer for incoming data.  
        byte[] bytes = new Byte[1024];

        // Establish the local endpoint for the socket.  
        // Dns.GetHostName returns the name of the   
        // host running the application.  
        IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddress = IPAddress.Parse(this.addres);//new IPAddress(134326464); //convertidor ip a decimal http://www.vermiip.es/convertir-ip-decimal/
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, this.port);

        // Create a TCP/IP socket.  
        this.listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        // Bind the socket to the local endpoint and   
        // listen for incoming connections.  
        try
        {
            this.listener.Bind(localEndPoint);
            this.listener.Listen(10);
            // Start listening for connections.  
            while (HayConexion){comunicacionSocket(this.listener, bytes);}
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine("\nPress ENTER to continue...");
        Console.Read();
    }

    private void comunicacionSocket(Socket listener, byte[] bytes)
    {
        Socket handler = listener.Accept();
        this.data = null;
        int bytesRec = handler.Receive(bytes);
        this.data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
        // An incoming connection needs to be processed.  
        // Show the data on the console.  
        Console.WriteLine("Text received : {0}", Data);
        // Echo the data back to the client.  
        byte[] msg = Encoding.ASCII.GetBytes(Data);
        handler.Send(msg);
        handler.Shutdown(SocketShutdown.Both);
        handler.Close();
    }

    public void CerrarConexion()
    {
        this.HayConexion = false;
        this.listener.Close();
    }

}