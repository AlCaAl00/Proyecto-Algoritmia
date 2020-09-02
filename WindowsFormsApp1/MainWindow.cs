using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        GraphTrain Graph;
        Vertex InitialVertex;
        Vertex DestinationVertex;
        Bitmap ImagenOriginal;
        Bitmap Temp;
        Dijkstra Dijkstra;

        public MainWindow()
        {
            InitializeComponent();
            this.Graph = new GraphTrain();
            this.ImagenOriginal = new Bitmap(pictureBox1.Image);
            this.Temp = new Bitmap(pictureBox1.Image);
            this.Dijkstra = new Dijkstra();
            FillComboBox();
        }

        private void FillComboBox()
        {
            foreach(Vertex v in Graph.VertexList)
            {
                combobox_origin.Items.Add(v);
                combobox_destination.Items.Add(v);
            }
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            InitialVertex = (Vertex)combobox_origin.SelectedItem;
            DestinationVertex = (Vertex)combobox_destination.SelectedItem;
            Dijkstra.DijkstraAlgorithm(Graph, InitialVertex);
            List<Vertex> ListTemp = Dijkstra.GetList(DestinationVertex);

            for(int i = 0; i < ListTemp.Count-1; i++)
            {
                Graphics.FromImage(Temp).DrawLine(new Pen(Color.Orange, 4), ListTemp[i].Location, ListTemp[i + 1].Location);
            }

            pictureBox1.Image = Temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImagenOriginal;
            Temp = new Bitmap(pictureBox1.Image);
            
        }
    }
}
