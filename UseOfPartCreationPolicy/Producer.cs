using System;
using System.ComponentModel.Composition;

namespace UseOfPartCreationPolicy
{
    [PartCreationPolicy(CreationPolicy.Shared)] // Check by changing the CreationPolicy type
    [Export(typeof(IProducer))]
    internal class Producer : IProducer
    {
        public Producer()
        {
            Console.WriteLine("Producer");
        }
        public void Execute()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
