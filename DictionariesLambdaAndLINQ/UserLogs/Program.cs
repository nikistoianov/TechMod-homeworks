using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UserLogs
{
    class Program
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            //string input = "IP=192.23.30.40 message='Hello&derps.' user=destroyer";
            string input = "IP=FE80:0000:0000:0000:0202:B3FF:FE1E:8329 message='Hey&son' user=mother";

            var users = new Dictionary<string, Dictionary<IPAddress, int>>();

            while (input != "end")
            {
                string[] arr = input.Split();
                var ipString = arr[0].Substring(3);
                IPAddress ip = IPAddress.Parse(ipString);
                Console.WriteLine(ip.ToString());
                input = Console.ReadLine();
            }
        }
    }
}
