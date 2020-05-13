using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace ImportingConstructorUsage
{
    class CentralContainer
    {
        [ImportMany(typeof(IProducer))]
        internal IEnumerable<Lazy<IProducer>> Producer { get; set; }

        [Import(typeof(IConsumer))]
        public IConsumer Consumer { get; set; }

        public void ComposeComponents()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
        }
    }
}
