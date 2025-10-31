// Class Assignment1 containing the Main method
// We used Dijkstra's Shortest Path Algorithm for finding shortest path as in this case, Dijkstra's algorithm is more efficient.
// Because the time complexity of Dijkstra's algorithm is O(N^2) whereas of Bellman Ford's algorithm is O(N^3).
class Assignment1
{
    static void Main(string[] args)
    {
        // Storing the location of the JSON file
        string jsonPath = "graph_data.json";

        // Providing the location to the LoadGraphFromJson method in GraphPopulater file and storing the returning graph in variable graph
        Graph graph = GraphPopulater.LoadGraphFromJson(jsonPath);
        // If variable graph is null, then gives an error statement
        if (graph == null)
        {
            Console.WriteLine("Could not load graph.");
            return;
        }

        // Telling the user that graph has been stored with dat and then printing it
        Console.WriteLine("Graph successfully loaded!\n");
        graph.PrintGraph();

        // Asking the user for inputing source and target location and reading the input
        Console.Write("\nEnter source location: ");
        string source = Console.ReadLine();

        Console.Write("Enter target location: ");
        string target = Console.ReadLine();

        // Checking if both the source and target given by user exists or not
        var sourceNode = graph.FindNode(source);
        var targetNode = graph.FindNode(target);

        // If any or both nodes doesn't exist, gives an error statement
        if (sourceNode == null || targetNode == null)
        {
            Console.WriteLine("Invalid source or target location.");
            return;
        }

        // Calls Find method in StortestPath file and provides graph, source and target locations to it
        ShortestPath.Find(graph, source, target);
    }
}
