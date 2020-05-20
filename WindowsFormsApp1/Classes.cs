using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GraphTrain
    {
        List<Vertex> IVertexList;
        int[,] IAdjacencyMatrix;
        List<Edge> IRoute;
        int IRouteDistance;

        public GraphTrain()
        {
            this.IVertexList = new List<Vertex>
            {
                new Vertex("Alemania"),
                new Vertex("Holanda")
            };
            this.IRouteDistance = -1;
        }

        public List<Vertex> Graph
        {
            get { return this.IVertexList; }
        }

        public List<Edge> Route
        {
            get { return this.IRoute; }
            set { }
        }

        public int RouteDistance
        {
            get { return this.IRouteDistance; }
        }


    }

    public class Vertex
    {
        List<Edge> IEdges;
        string IName;

        public Vertex (string name)
        {
            this.IName = name;
            this.IEdges = new List<Edge>();
        }

        public string Name
        {
            get { return this.IName; }
        }

        public int GetEdges()
        {
            return IEdges.Count;
        }

        public void AddEdge(Edge _edge)
        {
            IEdges.Add(_edge);
        }

    }

    public class Edge
    {
        double IDistance;
        Vertex IDestination;

        public Edge(double _distance, Vertex _vertexDestination)
        {
            this.IDistance = _distance;
            this.IDestination = _vertexDestination;
        }

        public double Distance
        {
            get { return this.IDistance; }
        }

        public Vertex Destination
        {
            get { return this.IDestination; }
        }
    }

}
