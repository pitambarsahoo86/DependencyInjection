using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace ImportMultipleParts
{
    class CentralContainer
    {
        [ImportMany(typeof(IProducer))]
        internal IEnumerable<Lazy<IProducer>> Producer { get; set; }

        public void ComposeComponents()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
        }
    }
}
