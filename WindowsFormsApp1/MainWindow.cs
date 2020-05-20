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
        bool cambio;
        int o, d;
        List<int> enteros;

        public MainWindow()
        {
            InitializeComponent();
            
            this.cambio = false;
            this.enteros = new List<int> { 1, 2, 3 };
            FillComboBox();
        }

        private void FillComboBox()
        {
            foreach (int i in enteros)
            {
                combobox_origin.Items.Add(i);
                combobox_destination.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void combobox_origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (o != 0)
                combobox_destination.Items.Add(o);

            o = (int)combobox_origin.SelectedItem;
            combobox_destination.Items.Remove(o);
        }
    }
}
