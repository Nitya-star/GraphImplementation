// Class ShortestPath containing method to find shortest path between two nodes
public class ShortestPath
{
    // Method to find shortest path in a graph from source to target
    public static void Find(Graph graph, string source, string target)
    {
        // Declaring variables
        var minutes = new Dictionary<string, int>();
        var previous = new Dictionary<string, string>();
        var unvisited = new List<string>();

        // Initializing minutes to each node as infinity and adding to unvisited list 
        foreach (var node in graph.Nodes)
        {
            minutes[node.Name] = int.MaxValue;
            unvisited.Add(node.Name);
        }

        minutes[source] = 0;

        while (unvisited.Count > 0)
        {
            // Declaring variables
            string current = null;
            int min = int.MaxValue;

            // Checking for every node in unvisited for the min_time
            foreach (var name in unvisited)
            {
                if (minutes[name] < min)
                {
                    min = minutes[name];
                    current = name;
                }
            }

            if (current == null)
                break;
            // Removing the current node from unvisited list
            unvisited.Remove(current);

            // Stopping if target reached
            if (current == target)
                break;

            // Storing the node from graph which is current
            var node = graph.FindNode(current);
            foreach (var edge in node.Edges)
            {
                // Checking if there is any shortest time than the one we have and if yes, then replacing it
                int newTime = minutes[current] + edge.Weight;
                if (newTime < minutes[edge.Target])
                {
                    minutes[edge.Target] = newTime;
                    previous[edge.Target] = current;
                }
            }
        }

        // If the minutes are still infinity, then telling the user that no path found
        if (minutes[target] == int.MaxValue)
        {
            Console.WriteLine("No path found.");
            return;
        }

        Console.WriteLine($"Shortest time from {source} to {target}: {minutes[target]} minutes");

        // Adding the entire route to the path list
        List<string> path = new List<string>();
        string curr = target;
        // Inserting the target in the list and checking if there is any previous and adding it to the list
        while (curr != null)
        {
            path.Insert(0, curr);              
            if (previous.ContainsKey(curr))    
                curr = previous[curr];
            else
                break;                         
        }
        // Printing the entire path
        Console.WriteLine("Path: " + string.Join(" -> ", path));
    }
}
