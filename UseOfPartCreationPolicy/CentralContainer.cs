using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace UseOfPartCreationPolicy
{
    class CentralContainer
    {
        [Import(typeof(IProducer))]
        internal IProducer Producer { get; set; }

        [Import(typeof(IConsumer))]
        internal IConsumer Consumer { get; set; }

        public void ComposeComponents()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
        }
    }
}
