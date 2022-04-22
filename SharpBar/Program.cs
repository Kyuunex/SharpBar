using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;

namespace SharpBar;

class Program
{
    private const int RefreshRate = 1000;
    static void Main(string[] args)
    {
        Console.WriteLine(@"{ ""version"": 1 }");
        Console.WriteLine("[");
        Console.WriteLine("[]");
        
        // no IPv6 | W: down | E: 192.168.1.12 (100 Mbit/s) | CPU: 01% | RAM: 7.1 GiB / 24.1 GiB
        while (true)
        {
            List<Module> blocks = new List<Module>
            {
                CPUTemperatureModule.GetBlock(),
                TimeModule.GetBlock()
            };

            Console.Write(",");
            Console.WriteLine(JsonSerializer.Serialize(blocks));
            
            Thread.Sleep(RefreshRate);
        }
    }
}

