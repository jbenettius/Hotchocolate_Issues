namespace NodeIdIssue;

public class MutationType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor.Field<MutationType>(t => t.UpdateThing(default))
            .Type<MyThingType>()
            .Argument("id", a => a.Type<NonNullType<IdType>>().ID());
    }

    public MyThing UpdateThing(Guid id)
    {
        return new MyThing(id.ToString(), id);
    }
}