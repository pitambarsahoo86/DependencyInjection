using System;
using System.ComponentModel.Composition;

namespace ImportMultipleParts
{
    [Export(typeof(IProducer))]
    class ProducerTwo : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(this.GetType().FullName);
        }
    }
}
