using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class GraphTrain
    {
        List<Vertex> IVertexList;
        Bitmap ImagenOriginal;
        Bitmap ImagenModificada;

        public GraphTrain(Bitmap bmp)
        {
            this.IVertexList = new List<Vertex>
            {
                new Vertex("Alemania", new Point(530, 327)),
                new Vertex("Holanda", new Point(1, 1))
            };

            // Alemania 0
            IVertexList[0].AddEdge(new Edge(1000, IVertexList[1]));
            IVertexList[0].AddEdge(new Edge(1000, IVertexList[2]));

            // Holanda 1


            // Bélgica 2



        }

        public void DrawRoutes()
        {
            Graphics.FromImage(ImagenModificada).DrawLine(new Pen(Color.Black, 4), IVertexList[0].Location, IVertexList[2].Location);
            
            foreach (Edge edge in IVertexList[0].GetEdges())
                Graphics.FromImage(ImagenModificada).DrawLine(new Pen(Color.Black, 4), IVertexList[0].Location, edge.Destination.Location);

            Graphics.FromImage(ImagenModificada).FillEllipse(new SolidBrush(Color.Black), IVertexList[0].Location.X - 15, IVertexList[0].Location.Y - 15, 30, 30);
        }


        public List<Vertex> Graph
        {
            get { return this.IVertexList; }
        }

    }

    public class Vertex
    {
        List<Edge> IEdges;
        string IName;
        Point ILocation;

        public Vertex (string name, Point point)
        {
            this.IName = name;
            this.IEdges = new List<Edge>();
            this.ILocation = point;
        }

        public string Name
        {
            get { return this.IName; }
        }

        public List<Edge> GetEdges()
        {
            return IEdges;
        }

        public void AddEdge(Edge _edge)
        {
            IEdges.Add(_edge);
        }

        public Point Location
        {
            get { return this.ILocation; }
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
