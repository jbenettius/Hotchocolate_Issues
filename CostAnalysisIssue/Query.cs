namespace CostAnalysisIssue;

public class Query
{
    public IEnumerable<MyThing> GetMyThings(string id)
    {
        return Enumerable.Range(0, 1001).Select(_ =>
        {
            var id = Guid.NewGuid();
            return new MyThing(id.ToString(), id);
        });
    }
}