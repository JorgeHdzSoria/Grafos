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
    public partial class MuestraKruskal : Form
    {
        public MuestraKruskal(Graph graph)
        {
            InitializeComponent();
            KruskalInicial(graph);
        }

        public void KruskalInicial(Graph graph)
        {
            List<Edge> aristas = graph.edgesList.OrderBy(e => e.Weight).ToList();
            List<NodeP> nodos = graph.ToList();
            List<Edge> aristasArbol = new List<Edge>();
            List<List<NodeP>> componentesConexas = new List<List<NodeP>>();

            foreach (NodeP nodo in nodos)
            {
                componentesConexas.Add(new List<NodeP> { nodo });
            }

            while (aristas.Count > 0 && componentesConexas.Count > 1)
            {
                // Tomar la arista de menor peso
                Edge arista = aristas[0];
                aristas.RemoveAt(0);

                // Encontrar las componentes conexas
                List<NodeP> componente1 = componentesConexas.Find(c => c.Contains(arista.Source));
                List<NodeP> componente2 = componentesConexas.Find(c => c.Contains(arista.Destiny));

                // Unir las componentes
                if (componente1 != componente2)
                {
                    aristasArbol.Add(arista);
                    componente1.AddRange(componente2);
                    componentesConexas.Remove(componente2);
                }
            }

            // Mostrar árbol de expansión mínimo y peso
            caminoKruskalTextBox.Text = "Aristas del árbol de expansión mínimo: " + string.Join(", ", aristasArbol.Select(a => $"({a.Source.Name}, {a.Destiny.Name})")) + Environment.NewLine;
            double pesoTotal = aristasArbol.Sum(a => a.Weight);
            caminoKruskalTextBox.Text += "Peso total del árbol: " + pesoTotal.ToString();
        }
    }
}
