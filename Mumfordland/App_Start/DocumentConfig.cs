using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace Mumfordland
{
    public class DocumentConfig
    {
        public static IDocumentStore DocumentStore { get; private set; }

        public static void CreateRavenDb()
        {
            DocumentStore = new EmbeddableDocumentStore
            {
                ConnectionStringName = "RavenDB",
            };

            DocumentStore.Initialize();
        }
    }
}