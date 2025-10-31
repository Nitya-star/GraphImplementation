using System.Text.Json;

// Class GraphPopulater for populating data into the graph
public class GraphPopulater
{
    // Class JsonEdge with properties source, target and time_min
    public class JsonEdge
    {
        public string source { get; set; }
        public string target { get; set; }
        public int time_min { get; set; }
    }

    // Class JsonGraph with properties nodes and edges
    public class JsonGraph
    {
        public List<string> nodes { get; set; }
        public List<JsonEdge> edges { get; set; }
    }

    //  Method LoadGraphFromJson taking filePath parameter and returning a graph containing data
    public static Graph LoadGraphFromJson(string filePath)
    {
        // Checking if the file exists at the given location and if not, then returning an error statement
        if (!File.Exists(filePath))
        {
            Console.WriteLine("JSON file not found!");
            return null;
        }

        // Reading the Json file content and storing it in json variable
        string json = File.ReadAllText(filePath);
        // The string is being converted to JsonGraph object and object is being stored in variable data
        JsonGraph data = JsonSerializer.Deserialize<JsonGraph>(json);

        // Creating a new Graph
        Graph graph = new Graph();

        // Adding nodes to the new graph as in the JSON file
        foreach (var nodeName in data.nodes)
        {
            graph.AddNode(nodeName);
        }

        // Adding edges to the new graph as in the JSON file
        foreach (var edge in data.edges)
        {
            graph.AddEdge(edge.source, edge.target, edge.time_min);
        }

        // Returning the new graph
        return graph;
    }
}
