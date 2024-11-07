namespace NodeIdIssue;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(f => f.GetMyThing(""))
            .Type<MyThingType>()
            .Argument("id", a => a.Type<NonNullType<IdType>>());
    }
}