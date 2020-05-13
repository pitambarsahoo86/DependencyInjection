using System.ComponentModel.Composition;

namespace UseOfPartCreationPolicy
{
    [Export(typeof(IConsumer))]
    internal class Consumer:IConsumer
    {
        [Import(typeof(IProducer))]
        internal IProducer Producer1 { get; set; }

        [Import(typeof(IProducer))]
        internal IProducer Producer2 { get; set; }

        public void Consume()
        {
            Producer1.Execute();
            Producer2.Execute();
        }
    }
}
