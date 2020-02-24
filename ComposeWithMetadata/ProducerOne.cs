using System;
using System.ComponentModel.Composition;

namespace ComposeWithMetadata
{
    [Export(typeof(IProducer))]
    [ExportMetadata("Type", "P1")]
    public class ProducerOne : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(this.GetType().FullName);
        }
    }
}
