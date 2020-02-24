using System.ComponentModel.Composition;

namespace ImportingConstructorUsage
{
    [Export(typeof(IConsumer))]
    internal class Consumer : IConsumer
    {
        internal IProducer Producer { get; private set; }

        [ImportingConstructor]
        internal Consumer([Import]IProducer producer)
        {
            Producer = producer;
        }

        public void Consume()
        {
            Producer.Execute();
        }
    }
}