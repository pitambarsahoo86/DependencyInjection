using System;

namespace MefExample
{
    class Program
    { 
        static void Main()
        {
            CentralContainer container = new CentralContainer();
            container.ComposeComponents();
            container.Producer.Execute();
            container.Consumer.Consume();
            Console.ReadLine();
        }
    }
}
