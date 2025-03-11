using System.Net;
using System.Net.Sockets;

internal class Program
{
    private static void Main(string[] args)
    {
        var port = GeneratePort();

        var tcpListener = new TcpListener(IPAddress.Any, port);

        tcpListener.Start();

        Console.WriteLine($"Server has Started at port: {port}");

        Console.ReadLine();
    }

    private static int GeneratePort()
    {
        return (int)new Random().NextInt64(5000, 10000);
    }
}