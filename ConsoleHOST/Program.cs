using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ConsoleHOST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Test.Service)))
            {
                host.Open();
                Console.WriteLine("Хост запущен!");
                
                Console.ReadLine();
            }
        }
    }
}
