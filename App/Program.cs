// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;

Console.WriteLine("Hello, World!");

System.Console.WriteLine("blech");

// connect to localhost:12345
var client = new TcpClient("localhost", 12345);