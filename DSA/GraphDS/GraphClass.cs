namespace DSA.GraphDS;

public class GraphClass
{
    public GraphClass()
    {

    }

    public void DepthFirst(Dictionary<string, List<string>> graph)
    {
        foreach (var item in graph)
        {
            Console.WriteLine(item);
        }

    }



}