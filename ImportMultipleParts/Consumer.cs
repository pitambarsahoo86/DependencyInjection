using System.ComponentModel.Composition;

namespace ImportMultipleParts
{
    internal class Consumer
    {
        [Import(typeof(IProducer))]
        internal IProducer Producer { get; set; }

        public void Consume()
        {
            Producer.Execute();
        }
    }
}
