using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;  


namespace NETWORKPROGRAMS
{
    class N1
    {
        static void Main(string[] args)
        {                                         // Retrive the Name of HOST  
            string hostName = Dns.GetHostName(); 
            Console.WriteLine(hostName);
                                                   // Get the IPAddress 
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
            Console.ReadKey();
        }
    }
}