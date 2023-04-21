using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace EditordeGrafos
{
    public partial class MuestraDFS : Form
    {
        public MuestraDFS(Graph graph)
        {
            InitializeComponent();
            DFSInicial(graph);
        }

        public void DFSInicial(Graph graph)
        {
            NodoInicial.Text = ""; //Iniciar el texto del textbox
            int numRaices = 0;
            for (int i = 0; i < graph.Count; i++)
            {
                if (!graph[i].Visited)
                {
                    numRaices++;
                    NodoInicial.Text += "Raiz(" + graph[i].Name.ToString() + ") ";
                    DFSRecursivo(graph[i], graph);
                }
            }

            if (numRaices > 1)
            {
                NodoInicial.Text = "Bosque con " + numRaices + " raíces: " + NodoInicial.Text;
            }
        }

        public void DFSRecursivo(NodeP nodo, Graph graph)
        {
            nodo.Visited = true;

            NodoInicial.Text += nodo.Name.ToString() + " ";

            List<NodeR> adyacentesOrdenados = nodo.relations.OrderBy(r => r.Up.Name).ToList();

            foreach (NodeR R in adyacentesOrdenados)
            {
                if (!R.Up.Visited)
                {
                    DFSRecursivo(R.Up, graph);
                }
            }
        }
    }
}