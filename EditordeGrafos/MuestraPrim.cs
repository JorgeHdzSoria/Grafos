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
    public partial class MuestraPrim : Form
    {
        public MuestraPrim(Graph graph)
        {
            InitializeComponent();
            PrimInicial(graph);
        }

        public void PrimInicial(Graph graph)
        {
            NodeP nodoInicial = graph.First();
            List<Edge> aristasArbol = new List<Edge>();
            List<NodeP> visitados = new List<NodeP>();
            visitados.Add(nodoInicial);

            while (visitados.Count < graph.Count)
            {
                // Buscar la arista de menor peso
                Edge aristaMenorPeso = null;
                double pesoMinimo = double.MaxValue;
                foreach (NodeP nodo in visitados)
                {
                    foreach (Edge arista in graph.edgesList)
                    {
                        if (!visitados.Contains(arista.Destiny) && arista.Weight < pesoMinimo)
                        {
                            aristaMenorPeso = arista;
                            pesoMinimo = arista.Weight;
                        }
                    }
                }

                // Agregar la arista al árbol de expansión mínimo y marcar el nodo destino como visitado
                if (aristaMenorPeso != null)
                {
                    aristasArbol.Add(aristaMenorPeso);
                    visitados.Add(aristaMenorPeso.Destiny);
                }
                else
                {
                    break; // Salir si no se encontró ninguna arista
                }
            }

            // Mostrar árbol de expansión mínimo y peso
            caminoPrim.Text = "Aristas del árbol de expansión mínimo: " + string.Join(", ", aristasArbol.Select(a => $"({a.Source.Name}, {a.Destiny.Name})")) + Environment.NewLine;
            double pesoTotal = aristasArbol.Sum(a => a.Weight);
            caminoPrim.Text += "Peso total del árbol: " + pesoTotal.ToString();
        }
    }
}
