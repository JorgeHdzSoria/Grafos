using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class MuestraEuler : Form
    {
            List<Edge> arcosList = new List<Edge>();
            List<NodeP> nodosList = new List<NodeP>();

            public MuestraEuler(Graph graph)
            {
                InitializeComponent();
                graph.UnselectAllEdges();

                if (graph.Count > 1){
                    if (graph.EdgeIsDirected) //Para grafo dirigido
                        Dirigido(graph);
                    else
                        NoDirigido(graph); //Para grafo no dirigido
                }
                else{
                    status.Text = "No tiene circuito ni camino";
                }

            }

            public void NoDirigido(Graph graph)
            {
                string output;
                graph.UnselectAllEdges();
                int opt = 2; //Circuit o camino

                //Marcar nodos impares
                int nodoImpar1 = 0;
                int nodoImpar2 = 0;

                for (int i = 0; i < graph.Count(); i++)
                {
                    if (graph[i].Degree % 2 != 0)
                    {
                        opt--;
                    break;
                    }
                }

            //Circuito
                if (opt == 2) {
                    status.Text = "Es circuito: ";
                    Circuito(graph, arcosList, graph.First(), graph.First(), false, nodosList);
                    output = Output(nodosList);
                    textBox1.Text = output;
                }

            //Camino
            else
            {
                    int cont = 0;
                    for (int i = 0; i < graph.Count(); i++)
                    {
                        if (graph[i].Degree % 2 != 0)
                        {
                            cont++;
                            if (cont == 1)
                                nodoImpar1 = i;
                            else if (cont == 2)
                                nodoImpar2 = i;
                            else
                                break;
                        }
                    }

                    if (cont != 2)
                        opt--;

                    if (opt == 1){
                        status.Text = "Es camino: ";
                        Camino(graph, arcosList, graph[nodoImpar1], nodosList);
                        output = Output(nodosList);
                        textBox1.Text = output;
                    }
                    else {
                        status.Text = "No tiene circuito ni camino";
                    }
                }
            }

            public void Dirigido(Graph graph)
            {
                string output;
                graph.UnselectAllEdges();
                int opt = 2;
                int nodoImpar1 = 0;
                int nodoImpar2 = 0;


                for (int i = 0; i < graph.Count(); i++)
                {
                    if (graph[i].DegreeEx != graph[i].DegreeIn)
                    {
                        opt--;
                        break;
                    }
                }
                if (opt == 2)
                {
                    status.Text = "Es circuito: ";
                    Circuito(graph, arcosList, graph.First(), graph.First(), false, nodosList);
                    output = Output(nodosList);
                    textBox1.Text = output;
                }

                else 
                {
                    int cont = 0;
                    for (int i = 0; i < graph.Count(); i++)
                    {
                        if (graph[i].DegreeIn == graph[i].DegreeEx - 1)
                        {
                            cont++;
                            nodoImpar1 = i;
                        }
                        else if (graph[i].DegreeIn == graph[i].DegreeEx + 1)
                        {
                            cont++;
                            nodoImpar2 = i;
                        }
                    }

                    if (cont != 2)
                        opt--;

                    if (opt == 1)
                    {
                        status.Text = "Es camino: ";
                        Camino(graph, arcosList, graph[nodoImpar1], nodosList);
                        output = Output(nodosList);
                        textBox1.Text = output;
                    }

                    else
                    {
                        status.Text = "No tiene circuito ni camino";
                    }
                }
            }

            private void Camino(Graph graph, List<Edge> circuito, NodeP actual, List<NodeP> Aux)
            {
                Edge arco = new Edge();
                Aux.Add(actual);

                // Se ordenan las relaciones alfabéticamente
                actual.relations.Sort((r1, r2) => r1.Up.Name.CompareTo(r2.Up.Name)); //Agregue esta parte porque sin ella, aunque se mostraba el camino o circuito, este no respetaba el orden alfabetico

                foreach (NodeR r in actual.relations)
                {
                    arco = graph.GetEdge(actual, r.Up);
                    if (!arco.Visited)
                    {
                        arco.Visited = true;
                        circuito.Add(arco);
                        Camino(graph, circuito, r.Up, Aux);
                        if (circuito.Count != graph.edgesList.Count)
                        {
                            circuito.Remove(arco);
                            Aux.RemoveAt(Aux.Count - 1);
                            arco.Visited = false;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

            private bool Circuito(Graph graph, List<Edge> circuito, NodeP inicial, NodeP actual, bool stat, List<NodeP> Aux)
            {
                Edge arco = new Edge();
                Aux.Add(actual);

                // Se ordenan las relaciones alfabéticamente
                actual.relations.Sort((r1, r2) => r1.Up.Name.CompareTo(r2.Up.Name)); //Agregue esta parte porque sin ella, aunque se mostraba el camino o circuito, este no respetaba el orden alfabetico

                foreach (NodeR r in actual.relations)
                {
                    arco = graph.GetEdge(actual, r.Up);
                    if (!arco.Visited)
                    {
                        arco.Visited = true;
                        circuito.Add(arco);
                        stat = Circuito(graph, circuito, inicial, r.Up, stat, Aux);
                        if (circuito.Count != graph.edgesList.Count){
                            circuito.Remove(arco);
                            Aux.RemoveAt(Aux.Count - 1);
                            arco.Visited = false;
                            stat = false;
                        }
                        else{
                            if (!stat){
                                circuito.Remove(arco);
                                Aux.Remove(actual);
                                arco.Visited = false;
                            }
                            return stat;
                        }
                    }
                }

                if (actual == inicial)
                    stat = true;
                else
                    Aux.Remove(actual);

                return stat;
            }

            private string Output(List<NodeP> Nodos)
            {
                string output = "";
                foreach (NodeP node in Nodos)
                {
                    output += node.Name + " ";
                }
                return output;
            }

            //Esta parte la reutilice para facilitar el ordenamiento y no hacerlo repetitivo
            public int ConvierteLetra(string letra)
            {

                int Num = 0;

                if (letra == "A")
                {
                    Num = 0;
                }
                else if (letra == "B")
                {
                    Num = 1;
                }
                else if (letra == "C")
                {
                    Num = 2;
                }
                else if (letra == "D")
                {
                    Num = 3;
                }
                else if (letra == "E")
                {
                    Num = 4;
                }
                else if (letra == "F")
                {
                    Num = 5;
                }
                else if (letra == "G")
                {
                    Num = 6;
                }
                else if (letra == "H")
                {
                    Num = 7;
                }
                else if (letra == "I")
                {
                    Num = 8;
                }
                else if (letra == "J")
                {
                    Num = 9;
                }
                else if (letra == "K")
                {
                    Num = 10;
                }
                else if (letra == "L")
                {
                    Num = 11;
                }
                else if (letra == "M")
                {
                    Num = 12;
                }
                else if (letra == "N")
                {
                    Num = 13;
                }
                else if (letra == "O")
                {
                    Num = 14;
                }
                else if (letra == "P")
                {
                    Num = 15;
                }
                else if (letra == "Q")
                {
                    Num = 16;
                }
                else if (letra == "R")
                {
                    Num = 17;
                }
                else if (letra == "S")
                {
                    Num = 18;
                }
                else if (letra == "T")
                {
                    Num = 19;
                }
                else if (letra == "U")
                {
                    Num = 20;
                }
                else if (letra == "V")
                {
                    Num = 21;
                }
                else if (letra == "W")
                {
                    Num = 22;
                }
                else if (letra == "X")
                {
                    Num = 23;
                }
                else if (letra == "Y")
                {
                    Num = 24;
                }
                else if (letra == "Z")
                {
                    Num = 25;
                }
                return Num;

            }
    }  
}
