using System;
using System.Net;
namespace Nett
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostname = "instagram.com";
            string message = "IP адреса для домена " + hostname + "\n";
            IPHostEntry entry = Dns.GetHostEntry(hostname);
            foreach (IPAddress a in entry.AddressList)
                message += "  --> " + a.ToString() + "\n";
            Console.WriteLine(message);
        }
    }
}
