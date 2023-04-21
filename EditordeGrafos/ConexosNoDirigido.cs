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
    public partial class ConexosNoDirigido : Form
    {

        public ConexosNoDirigido(Graph graph)
        {
            InitializeComponent();
            MostrarRecorrido(graph);
        }

        public void MostrarRecorrido(Graph graph)
        {
            List<NodeP> raices = new List<NodeP>();
            int maxGrado = -1;
            // Encontrar nodo raíz o raíces
            foreach (NodeP nodo in graph)
            {
                if (nodo.Degree > maxGrado)
                {
                    raices.Clear();
                    raices.Add(nodo);
                    maxGrado = nodo.Degree;
                }
                else if (nodo.Degree == maxGrado)
                {
                    raices.Add(nodo);
                }
            }
            // Mostrar raíces
            string raicesStr = "Raíces: ";
            foreach (NodeP raiz in raices)
            {
                raicesStr += raiz.Name + " ";
            }
            NodoInicial.Text = raicesStr;
            // Recorrer árbol y componentes conexos
            foreach (NodeP raiz in raices)
            {
                if (!raiz.Visited)
                {
                    string recorrido = "Recorrido para componente conexo con raíz " + raiz.Name + ": ";
                    DFSRecursivo(raiz, graph, ref recorrido);
                    NodoInicial.Text += Environment.NewLine + recorrido;
                }
            }
        }

        public void DFSRecursivo(NodeP nodo, Graph graph, ref string recorrido)
        {
            nodo.Visited = true;

            recorrido += nodo.Name + " ";

            foreach (NodeR R in nodo.relations)
            {
                NodeP vecino = R.Up;
                if (!vecino.Visited)
                {
                    DFSRecursivo(vecino, graph, ref recorrido);
                }
            }
        }
    }


}

