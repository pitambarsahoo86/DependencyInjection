using System;
using System.ComponentModel.Composition;

namespace MefExample
{
    [Export(typeof(IProducer))]
    internal class Producer : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(this.GetType().FullName);
            Console.WriteLine(this.GetHashCode());
        }
    }
}
