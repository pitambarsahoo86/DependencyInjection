using System;

namespace ComposeWithMetadata
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new CentralContainer();
            container.ComposeComponents();

            var p1_Producer = container.GetProducer("P1");
            p1_Producer.Execute();

            var p2_Producer = container.GetProducer("P2");
            p2_Producer.Execute();

            Console.ReadLine();
        }
    }
}
