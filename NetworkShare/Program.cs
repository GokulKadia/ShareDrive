using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NetworkShare
{
    public class Program
    {       
      
        static void Main(string[] args)
        {
            test();
        }
       
        public static void test()
        {
            //NetworkDrive.DisconnectNetworkDrive("N", true);
            NetworkDrive.MapNetworkDrive("N", @"\\100.106.148.15\Share","Wyse@123","Administrator");
            var dirs = Directory.GetDirectories("N:"); // got many nice directories...
            //NetworkDrive.DisconnectNetworkDrive("N", true);
            Console.ReadLine();
        }
    }
}
