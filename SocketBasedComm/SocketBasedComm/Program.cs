using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        StartServer();
    }

    static void StartServer()
    {
        int port = 8888; // Replace with the desired port number
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Replace with the Master EA's IP address

        try
        {
            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();

            Console.WriteLine("Waiting for connections...");
            TcpClient client = listener.AcceptTcpClient();

            Console.WriteLine($"Connection established with: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

            NetworkStream stream = client.GetStream();

            string message = "Hello from Master EA!";
            byte[] data = Encoding.UTF8.GetBytes(message);

            stream.Write(data, 0, data.Length);

            Console.WriteLine("Message sent.");

            stream.Close();
            client.Close();
            listener.Stop();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
