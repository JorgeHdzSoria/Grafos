using EditordeGrafos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EditordeGrafos
{
    public partial class Amplitud : Form
    {
        public Amplitud(Graph graph)
        {
            InitializeComponent();
            BFSInicial(graph);
        }

        public void BFSInicial(Graph graph)
        {
            textBoxBFS.Text = ""; //Iniciar el texto del textbox
            foreach (NodeP node in graph)
            {
                if (!node.Visited)
                {
                    recorridoEnAmplitud(graph, node); //manda llamar la funcion principal
                }
            }
        }

        public void recorridoEnAmplitud(Graph graph, NodeP node)
        {
            Queue<NodeP> queue = new Queue<NodeP>(); //inicializa la cola 
            node.Visited = true; //pone en alto el nodo visitado 
            queue.Enqueue(node); // encola el nodo

            while (queue.Count != 0) // recorre la cola 
            {
                NodeP currentNode = queue.Dequeue(); // el nodo es extraido de la cola 
                textBoxBFS.Text += currentNode.Name.ToString() + " "; // lo imprime en el texbox 
                currentNode.relations = currentNode.relations.OrderBy(r => r.Up.Name).ToList();

                foreach (NodeR r in currentNode.relations)
                {
                    if (!r.Up.Visited)
                    {
                        r.Up.Visited = true;
                        queue.Enqueue(r.Up);
                    }
                }
            }
        }
    }
}
