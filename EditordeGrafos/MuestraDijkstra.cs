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
    public partial class MuestraDijkstra : Form
    {
        public MuestraDijkstra(Graph graph)
        {
            InitializeComponent();
            DijkstraInicial(graph);
        }

        public void DijkstraInicial(Graph graph)
        {
            caminoDijkstra.Text = ""; //inicializar TextBox

            // Inicializar distancias de los nodos como infinitos
            // Inicializar nodos previos como null
            // Inicializar nodos visitados
            List<double> distancias = new List<double>();
            List<NodeP> nodosPrevios = new List<NodeP>();
            List<bool> visitados = new List<bool>();
            for (int i = 0; i < graph.Count; i++)
            {
                distancias.Add(double.MaxValue);
                nodosPrevios.Add(null);
                visitados.Add(false);
            }
            distancias[0] = 0;

            while (visitados.Contains(false))
            {
                // Encontrar nodo no visitado con menor distancia
                NodeP nodoActual = null;
                double distanciaMinima = double.MaxValue;
                for (int i = 0; i < graph.Count; i++)
                {
                    if (!visitados[i] && distancias[i] < distanciaMinima)
                    {
                        nodoActual = graph[i];
                        distanciaMinima = distancias[i];
                    }
                }

                // Marcar nodo actual como visitado
                visitados[graph.IndexOf(nodoActual)] = true;

                // Actualizar distancias de nodos adyacentes
                foreach (NodeR arista in nodoActual.relations)
                {
                    NodeP nodoAdyacente = arista.Up;
                    foreach (Edge edge in graph.edgesList)
                    {
                        if (edge.Source == nodoActual && edge.Destiny == nodoAdyacente)
                        {
                            double distanciaHastaAdyacente = distancias[graph.IndexOf(nodoActual)] + edge.Weight;
                            if (distanciaHastaAdyacente < distancias[graph.IndexOf(nodoAdyacente)])
                            {
                                distancias[graph.IndexOf(nodoAdyacente)] = distanciaHastaAdyacente;
                                nodosPrevios[graph.IndexOf(nodoAdyacente)] = nodoActual;
                            }
                        }
                    }
                }
            }

            // Mostrar camino de Dijkstra y peso total del camino mínimo
            int indiceUltimoNodo = graph.Count - 1;
            if (nodosPrevios[indiceUltimoNodo] == null)
            {
                caminoDijkstra.Text = "No hay camino desde el primer nodo hasta el último";
            }
            else
            {
                Stack<NodeP> camino = new Stack<NodeP>();
                camino.Push(graph[indiceUltimoNodo]);
                NodeP nodoPrevio = nodosPrevios[indiceUltimoNodo];
                while (nodoPrevio != null)
                {
                    camino.Push(nodoPrevio);
                    nodoPrevio = nodosPrevios[graph.IndexOf(nodoPrevio)];
                }
                caminoDijkstra.Text = "Camino de Dijkstra: " + string.Join(" -> ", camino.Select(nodo => nodo.Name)) + Environment.NewLine;
                caminoDijkstra.Text += "Peso total del camino mínimo: " + distancias[indiceUltimoNodo].ToString();
            }
        }
    }
}