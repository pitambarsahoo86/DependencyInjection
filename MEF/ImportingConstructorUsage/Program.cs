using System;

namespace ImportingConstructorUsage
{
    class Program
    {
        static void Main()
        {
            var centralContainer = new CentralContainer();
            centralContainer.ComposeComponents();

            foreach (var p in centralContainer.Producer)
            {
                p.Value.Execute();
            }

            centralContainer.Consumer.Consume();

            Console.ReadLine();
        }
    }
}
