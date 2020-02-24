using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace ComposeWithMetadata
{
    class CentralContainer
    {
        [ImportMany(typeof(IProducer))]
        internal IEnumerable<Lazy<IProducer,IMetadataInfo>> Producers { get; set; }   

        public void ComposeComponents()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
        }

        public IProducer GetProducer(string metadataInfo)
        {
            IProducer producer = null;
            foreach (var prod in Producers)
            {
                if (prod.Metadata.Type != metadataInfo)
                {
                    continue;
                }
                producer = prod.Value;
                break;
            }
            return producer;
        }
    }
}
