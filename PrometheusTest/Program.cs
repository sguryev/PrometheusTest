namespace PrometheusTest
{
    using System;
    using System.Threading.Tasks;
    using Prometheus;

    public class Program
    {
        private static readonly Counter TickTock =
            Metrics.CreateCounter("sampleapp_ticks_total", "Just keeps on ticking...");
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Prometheus metrics.");

            var server = new MetricServer("localhost", 9090);
            server.Start();
            
            Console.WriteLine("Starting endless loop.");
            
            while (true)
            {
                TickTock.Inc();
                Console.WriteLine($"TickTock: {TickTock.Value}.");
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}