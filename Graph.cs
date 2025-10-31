// Class Graph for creating a graph with nodes and edges
public class Graph
{
    // Class Edge having variables Target and Weight and a constructor
    public class Edge
    {
        // declaring variables
        public string Target;
        public int Weight;

        // Constructor Edge initializing target and weight
        public Edge(string target, int weight)
        {
            Target = target;
            Weight = weight;
        }
    }

    // Class Node having variable Name and constructor Node
    public class Node
    {
        // Declaring variables
        public string Name;
        // Creating a List of Edges
        public List<Edge> Edges = new List<Edge>();

        // For ShortestPath Algorithm
        public int Distance = int.MaxValue;
        public string Previous = null;

        // Constructor Node initializing name
        public Node(string name)
        {
            Name = name;
        }
    }

    // Creating a list of Nodes
    public List<Node> Nodes = new List<Node>();

    // Method to add nodes to the graph
    public void AddNode(string name)
    {
        if (FindNode(name) == null)
            Nodes.Add(new Node(name));
    }

    // Method to find nodes in the graph
    public Node FindNode(string name)
    {
        return Nodes.Find(n => n.Name == name);
    }

    // Method to add edges to the graph
    public void AddEdge(string source, string target, int weight)
    {
        // Checking if the source node exists, if not adding it
        Node src = FindNode(source);
        if (src == null)
        {
            src = new Node(source);
            Nodes.Add(src);
        }

        // Checking if the target node exists, if not adding it
        Node tgt = FindNode(target);
        if (tgt == null)
        {
            tgt = new Node(target);
            Nodes.Add(tgt);
        }

        // Adding the new edge with some weight
        src.Edges.Add(new Edge(target, weight));
    }

    // Printing the graph in the format:
    // Source node -> Nodes it is connected to with (Weight)
    public void PrintGraph()
    {
        // Looping through each node in the graph
        foreach (var node in Nodes)
        {
            Console.Write(node.Name + " -> ");
            // Looping through each edge the particular node is directly connected to
            foreach (var edge in node.Edges)
                Console.Write(edge.Target + "(" + edge.Weight + ")  ");
            Console.WriteLine();
        }
    }
}
