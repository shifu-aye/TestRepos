﻿using System;
using System.ServiceModel;

namespace ConsoleHOST
{
    internal class Program
    {
        //todo: Изменить на WCF Web Api
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
