using HotChocolate.Types.Pagination;

namespace CostAnalysisIssue;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(f => f.GetMyThings(""))
            .UsePaging(options: new PagingOptions() { MaxPageSize = 10000 })
            .Argument("id", a => a.Type<NonNullType<IdType>>());
    }
}