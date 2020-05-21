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

        public GraphTrain()
        {
            this.IVertexList = new List<Vertex>
            {
                new Vertex("España", new Point(100, 537)),  //0
                new Vertex("Francia", new Point(201, 354)), //1
                new Vertex("Italia", new Point(419, 456)),  //2
                new Vertex("Belgica", new Point(263, 228)), //3
                new Vertex("Austria", new Point(506, 331)), //4
                new Vertex("Grecia", new Point(659, 578)),  //5
                new Vertex("Rumania", new Point(753, 381)), //6
                new Vertex("Polonia", new Point(646, 231)), //7
                new Vertex("Alemania", new Point(412, 177)), //8
                new Vertex("Dinamarca", new Point(375, 16)), //9
            };

            // España 0
            IVertexList[0].AddEdge(new Edge(800, IVertexList[1]));

            // Francia 1
            IVertexList[1].AddEdge(new Edge(800, IVertexList[0]));
            IVertexList[1].AddEdge(new Edge(956, IVertexList[2]));
            IVertexList[1].AddEdge(new Edge(503, IVertexList[3]));

            // Italia 2
            IVertexList[2].AddEdge(new Edge(800, IVertexList[1]));
            IVertexList[2].AddEdge(new Edge(646, IVertexList[4]));

            //Belgica 3
            IVertexList[3].AddEdge(new Edge(503, IVertexList[1]));
            IVertexList[3].AddEdge(new Edge(426, IVertexList[8]));

            //Austria 4
            IVertexList[4].AddEdge(new Edge(646, IVertexList[2]));
            IVertexList[4].AddEdge(new Edge(1105, IVertexList[5]));
            IVertexList[4].AddEdge(new Edge(590, IVertexList[7]));
            IVertexList[4].AddEdge(new Edge(502, IVertexList[8]));

            //Grecia 5
            IVertexList[5].AddEdge(new Edge(1105, IVertexList[4]));
            IVertexList[5].AddEdge(new Edge(805, IVertexList[6]));

            //Rumania 6
            IVertexList[6].AddEdge(new Edge(805, IVertexList[5]));
            IVertexList[6].AddEdge(new Edge(787, IVertexList[7]));

            //Polonia 7
            IVertexList[7].AddEdge(new Edge(590, IVertexList[4]));
            IVertexList[7].AddEdge(new Edge(787, IVertexList[6]));
            IVertexList[7].AddEdge(new Edge(606, IVertexList[8]));

            //Alemania 8
            IVertexList[8].AddEdge(new Edge(426, IVertexList[3]));
            IVertexList[8].AddEdge(new Edge(502, IVertexList[4]));
            IVertexList[8].AddEdge(new Edge(606, IVertexList[7]));
            IVertexList[8].AddEdge(new Edge(570, IVertexList[9]));

            //Dinamarca 9
            IVertexList[9].AddEdge(new Edge(570, IVertexList[8]));
        }


        public List<Vertex> VertexList
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

        public override string ToString()
        {
            return this.IName;
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

    public class Dijkstra
    {
        List<Vertex> Selections;
        List<DijkstraElement> VD;
        GraphTrain Graph;
        Vertex InitialVertex;
        Vertex v_d;


        public void DijkstraAlgorithm(GraphTrain graph, Vertex initialVertex)
        {
            this.Selections = new List<Vertex>();
            this.VD = new List<DijkstraElement>();
            this.Graph = graph;
            this.InitialVertex = initialVertex;

            ClearDijkstra();

            foreach (Vertex v in Graph.VertexList)
            {
                if (v.Name != InitialVertex.Name)
                    VD.Add(new DijkstraElement(v, false, Double.MaxValue));
                else
                    VD.Add(new DijkstraElement(v, false, 0, v));    
            }

            while(!IsSolution())
            {
                v_d = SelectDefinitve();
                if(v_d == null)
                {
                    break;
                }
                UpdateVD();
                Selections.Add(v_d);
            }
        }

        public void ClearDijkstra()
        {
            VD.Clear();
            Selections.Clear();
        }

        public Vertex SelectDefinitve()
        {
            Vertex temp = null;
            double wtemp =  Double.MaxValue;
            foreach(DijkstraElement element in VD)
            {
                if(element.definitive == false)
                {
                    if(element.weight < wtemp)
                    {
                        temp = element.ID;
                        wtemp = element.weight;
                    }
                }
            }
            return temp;
        }

        public void UpdateVD()
        {
            double totalWeight;
            DijkstraElement origen =  null;
            DijkstraElement destino =  null;
            foreach (Edge edge in v_d.GetEdges())
            {
                foreach(DijkstraElement element in VD)
                {
                    if(element.ID.Name == v_d.Name)
                    {
                        origen = element;
                    }
                    if(element.ID.Name == edge.Destination.Name)
                    {
                        destino = element;
                    }
                }
                if(destino.definitive == false)
                {
                    totalWeight = origen.weight + edge.Distance;
                    if(totalWeight < destino.weight)
                    {
                        destino.weight = totalWeight;
                        destino.P = v_d;
                    }
                }
            }
        }

        public bool IsSolution()
        {
            foreach(Vertex v in Selections)
            {
                foreach(DijkstraElement d in VD)
                {
                    if(d.ID.Name == v.Name)
                    {
                        d.definitive = true;
                    }
                }
            }
            foreach (DijkstraElement d in VD)
                if (d.definitive == false)
                    return false;
            return true;
        }

        public List<Vertex> GetList(Vertex destination)
        {
            List<Vertex> path = new List<Vertex> { destination };
            Vertex temp = destination;

            while(temp.Name != InitialVertex.Name)
            {
                temp = GetP(temp);
                path.Add(temp);
            }

            path.Reverse();
            return path;
        }

        public Vertex GetP(Vertex vertex)
        {
            foreach(DijkstraElement d in VD)
            {
                if(d.ID.Name == vertex.Name)
                {
                    return d.P;
                }
            }
            return null;
        }

    }
    public class DijkstraElement
    {
        public Vertex P { set; get; }
        public Vertex ID { set; get; }
        public bool definitive { set; get; }
        public double weight { set; get; }

        public DijkstraElement(Vertex ID, bool definitive, double weight, Vertex P = null)
        {
            this.ID = ID;
            this.definitive = definitive;
            this.weight = weight;
            this.P = P;
        }

    }

}
