using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy.Hosting.Self;

namespace restapi
{
    class Program
    {
        static string url = "http://localhost:80";
        static void Main(string[] args)
        {
            NancyHost host = new NancyHost(new Uri(url));
            host.Start();
            Console.WriteLine("Web server starting on {0}...", url);

            Console.ReadKey();
        }
    }
}
