namespace NodeIdIssue;

public class MyThingType : ObjectType<MyThing>
{
    protected override void Configure(IObjectTypeDescriptor<MyThing> descriptor)
    {
        descriptor
            .ImplementsNode()
            .IdField(n => n.Id)
            .ResolveNode(async (context, id) => new MyThing(id, Guid.Parse(id)));
    }
}