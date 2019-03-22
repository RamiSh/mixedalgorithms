using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Graph
{
    public class Edge<T>
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public T Value { get; set; }
    }

    public class Vertex
    {
        public int Title { get; set; }
        public List<Edge<int>> Adjacents { get; set; }
    }

    public class Graph
    {
        public List<Vertex> Vertices { get; }

        public Graph(int numberOfVertecis)
        {
            Vertices = new List<Vertex>(numberOfVertecis);

            for (int i = 0; i < numberOfVertecis; i++)
            {
                Vertices.Add(new Vertex { Title = i });
                Vertices[i].Adjacents = new List<Edge<int>>();
            }
        }

        public void AddEdge(int from, int to)
        {
            Vertices[from].Adjacents.Add(new Edge<int>
            {
                From = Vertices[from],
                To = Vertices[to]
            }
            );

            // Vertices[to].Adjacents.Add(new Edge<int>
            // {
            //     From = Vertices[to],
            //     To = Vertices[from]
            // }
            //);
        }

        public bool FindAPath(Vertex source, Vertex Destination)
        {
            var toBeVisited = new Queue<Vertex>();
            toBeVisited.Enqueue(source);

            var visited = new HashSet<int>();

            while (toBeVisited.Count != 0)
            {
                var vertex = toBeVisited.Dequeue();
                visited.Add(vertex.Title);

                foreach (var edge in vertex.Adjacents)
                {
                    if (!visited.Contains(edge.To.Title))
                    {
                        toBeVisited.Enqueue(edge.To);

                        if (edge.To.Title == Destination.Title)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void FindAllPaths(Vertex source, Vertex destination)
        {
            var allPossiblePaths = new List<HashSet<int>>();
            var visited = new HashSet<int>();

            dfs(source, destination, allPossiblePaths, visited);
        }

        public void dfs(Vertex source, Vertex destination, List<HashSet<int>> allPossiblePaths, HashSet<int> visited)
        {
            visited.Add(source.Title);

            // Path has been found
            if (source.Title == destination.Title)
            {
                allPossiblePaths.Add(new HashSet<int>(visited));
            }
            foreach (var edge in source.Adjacents)
            {
                if (!visited.Contains(edge.To.Title))
                {
                    dfs(edge.To, destination, allPossiblePaths, visited);
                    visited.Remove(edge.To.Title);
                }
            }
        }

        public void FindAllBidirectVertices(Vertex start)
        {
            var biDirectuals = new HashSet<Tuple<int, int>>();

            FindAllBidirectVertices(start, null, new HashSet<int>(), biDirectuals);
        }

        private void FindAllBidirectVertices(Vertex start, Vertex parent, HashSet<int> visited, HashSet<Tuple<int, int>> biDirectuals)
        {
            visited.Add(start.Title);

            foreach (var edge in start.Adjacents)
            {
                if (!visited.Contains(edge.To.Title))
                {
                    FindAllBidirectVertices(edge.To, start, visited, biDirectuals);
                }
                else
                {
                    if (parent != null && edge.To.Title == parent.Title)
                    {
                        biDirectuals.Add(new Tuple<int, int>(start.Title, edge.To.Title));
                    }
                }
                //if (parent != null && edge.To.Title != parent.Title)
                //{
                //    visited.Remove(edge.To.Title);
                //}
            }

            visited.Remove(start.Title);
        }
        public HashSet<int> FindPath(Vertex start, Vertex end)
        {
            var allVisited = new List<HashSet<int>>();
            allVisited.Add(new HashSet<int>());
            if (FindPath(start, end, allVisited[0], allVisited))
            {
                return allVisited[0];
            }

            return null;
        }

        private bool FindPath(Vertex start, Vertex end, HashSet<int> visited, List<HashSet<int>> allVisited)
        {
            if (visited.Contains(end.Title))
            {
                return true;
            }

            visited.Add(start.Title);

            var found = false;

            foreach (var edge in start.Adjacents)
            {
                if (!visited.Contains(edge.To.Title))
                {
                    found = FindPath(edge.To, end, visited, allVisited);


                }

            }

            return found;

        }
    }

}
