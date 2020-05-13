using System;
using System.ComponentModel.Composition;

namespace ComposeWithMetadata
{
    [Export(typeof (IProducer))]
    [ExportMetadata("Type", "P2")]
    public class ProducerTwo : IProducer
    {
        public void Execute()
        {
            Console.WriteLine(GetType().FullName);
        }
    }
}