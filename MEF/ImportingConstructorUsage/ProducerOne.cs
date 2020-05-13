using System;
using System.ComponentModel.Composition;

namespace ImportingConstructorUsage 
{
    [Export(typeof(IProducer))]
    internal class ProducerOne : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(this.GetType().FullName);
        }
    }
}
