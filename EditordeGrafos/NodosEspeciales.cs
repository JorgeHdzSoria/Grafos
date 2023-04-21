using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class NodosEspeciales : Form
    {
        Graph graph;
        public NodosEspeciales(Graph graph)
        {
            this.graph = graph;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Hola Mundo"; //Para probar

            //Colgantes
            foreach(NodeP P in graph)
            {
                if (P.Degree == 1)
                {
                    textBox1.Text += P.Name + "    ";
                }
                
            }

            //Aislados
            foreach (NodeP P in graph)
            {
                if (P.Degree == 0)
                {
                    textBox2.Text += P.Name + "    ";
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
