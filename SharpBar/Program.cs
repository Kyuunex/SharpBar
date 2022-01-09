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
            Console.Write(",");
            Console.Write("[");
            Console.Write(CPUTemperatureBlock.GetJson());
            Console.Write(",");
            Console.Write(TimeBlock.GetJson());
            Console.WriteLine("]");
            Thread.Sleep(1000);
        }
    }
}

