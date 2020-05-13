using System.ComponentModel.Composition;

namespace MefExample
{
    [Export(typeof (IConsumer))]
    internal class Consumer : IConsumer
    {
        [Import(typeof (IProducer))]
        internal IProducer Producer { get; set; }

        public void Consume()
        {
            Producer.Execute();
        }
    }
}