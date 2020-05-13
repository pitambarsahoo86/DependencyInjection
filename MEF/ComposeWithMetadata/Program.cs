using System;

namespace ComposeWithMetadata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new CentralContainer();
            container.ComposeComponents();

            IProducer p1Producer = container.GetProducer("P1");
            p1Producer.Execute();

            IProducer p2Producer = container.GetProducer("P2");
            p2Producer.Execute();

            Console.ReadLine();
        }
    }
}