using System.Text.Json;

namespace SharpBar;

class Program {         
    static void Main(string[] args)
    {
        Console.WriteLine(@"{ ""version"": 1 }");
        Console.WriteLine("[");
        Console.WriteLine("[]");
        // no IPv6 | W: down | E: 192.168.1.12 (100 Mbit/s) | CPU: 01% | T: 38 °C | RAM: 7.1 GiB / 24.1 GiB
        while (true)
        {
            List<BlankBlock> blocks = new List<BlankBlock>();
            blocks.Add(CPUTemperatureBlock.GetBlock());
            blocks.Add(TimeBlock.GetBlock());
            
            Console.Write(",");
            Console.WriteLine(JsonSerializer.Serialize(blocks));
            Thread.Sleep(1000);
        }
    }
}

