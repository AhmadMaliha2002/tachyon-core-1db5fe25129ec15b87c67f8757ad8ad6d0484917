using Abp.Dependency;
using GraphQL;
using GraphQL.Types;
using TACHYON.Queries.Container;

namespace TACHYON.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IDependencyResolver resolver) :
            base(resolver)
        {
            Query = resolver.Resolve<QueryContainer>();
        }
    }
}