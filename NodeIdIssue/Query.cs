namespace NodeIdIssue;

public class Query
{
    public MyThing GetMyThing(string id)
    {
        return new MyThing(id, Guid.Parse(id));
    }
}