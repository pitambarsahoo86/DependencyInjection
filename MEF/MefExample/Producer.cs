using System;
using System.ComponentModel.Composition;

namespace MefExample
{
    [Export(typeof (IProducer))]
    internal class Producer : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(GetType().FullName);
            Console.WriteLine(GetHashCode());
        }
    }
}