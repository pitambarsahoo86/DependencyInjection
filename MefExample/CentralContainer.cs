using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MefExample
{
    class CentralContainer
    {
        [Import(typeof(IProducer))]
        internal IProducer Producer { get; set; }

        [Import(typeof(IConsumer))]
        internal IConsumer Consumer { get; set; }

        public void ComposeComponents()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());//5 types1. Assembly, TypeCa
            //var typecatalog = new TypeCatalog();
            //var aggregateCatalog = new AggregateCatalog();
            //aggregateCatalog.Catalogs.Add(typecatalog);
            //aggregateCatalog.Catalogs.Add(catalog);
            //var directorycatalog = new DirectoryCatalog("");

            var compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
        }
    }
}
