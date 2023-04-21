using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class Mapa : Form
    {
        int inf = 10000;
        int regiones = 8;
        int[,] MatrizInicial;
        int[,] MatrizFinal;
        string[,] MatrizCaminos;
        public HashSet<string> destinos;

        //Imagen del mapa
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Arreglar problema del porque no se muestra la imagen
            string rutaImagen = "Resources/skyrim_text.jpeg"; // Modifica la ruta a la imagen

            try
            {
                Bitmap imagen = new Bitmap(rutaImagen);
                pictureBox1.Image = imagen;
            }
            catch (ArgumentException ex)
            {
                // Maneja la excepción aquí
                Console.WriteLine("La imagen no se pudo cargar. Detalles del error: " + ex.Message);
            }
        }

        public Mapa()
        {
            InitializeComponent();
            destinos = new HashSet<string>(); //inicializar HashSet
            InicializaMatrices();
            Floyd();
        }

        private void InicializaMatrices()
        {
            this.MatrizInicial = new int[,]
            {
                { 0, 50, 40, 30, inf, inf, 20, inf},
                { 50, 0, 60, inf, inf, inf, inf, inf},
                { 40, 60, 0, inf, inf, inf, inf, 10},
                { 30, inf, inf, 0, 10, inf, 20, inf},
                { inf, inf, inf, 10, 0, inf, 30, inf},
                { inf, inf, inf, inf, inf, 0, 40, inf},
                { 20, inf, inf, 20, 30, 40, 0, inf},
                { inf, inf, 10, inf, inf, inf, inf, 0},

            };

            this.MatrizFinal = new int[,]
            {
                { 0, 50, 40, 30, inf, inf, 20, inf},
                { 50, 0, 60, inf, inf, inf, inf, inf},
                { 40, 60, 0, inf, inf, inf, inf, 10},
                { 30, inf, inf, 0, 10, inf, 20, inf},
                { inf, inf, inf, 10, 0, inf, 30, inf},
                { inf, inf, inf, inf, inf, 0, 40, inf},
                { 20, inf, inf, 20, 30, 40, 0, inf},
                { inf, inf, 10, inf, inf, inf, inf, 0},
            };

            MatrizCaminos = new string[regiones, regiones];
        }

        private void Floyd()
        {
            for (int k = 0; k < regiones; k++)
            {
                for (int i = 0; i < regiones; i++)
                {
                    for (int j = 0; j < regiones; j++)
                    {
                        if ((MatrizFinal[i, k] < inf) && (MatrizFinal[k, j] < inf) && (i != j) && (i != k) && (k != j) && (MatrizFinal[i, k] + MatrizFinal[k, j] < MatrizFinal[i, j]))
                        {
                            MatrizFinal[i, j] = MatrizFinal[i, k] + MatrizFinal[k, j];
                            string c = ToInt(k);
                            MatrizCaminos[i, j] = MatrizCaminos[i, k] + MatrizCaminos[k, j] + "-" + c;
                        }
                    }
                }
            }
        }

        private string ToInt(int region)
        {
            switch (region)
            {
                case 0:
                    return "Whiterun";
                case 1:
                    return "FalkreathHold";
                case 2:
                    return "TheReach";
                case 3:
                    return "ThePale";
                case 4:
                    return "WinterHold";
                case 5:
                    return "Rift";
                case 6:
                    return "EastMarch";
                case 7:
                    return "Solitude";
            }
            return "-1";
        }
        private int ToString(string region)
        {
            switch (region)
            {
                case "Whiterun":
                    return 0;
                case "FalkreathHold":
                    return 1;
                case "TheReach":
                    return 2;
                case "ThePale":
                    return 3;
                case "WinterHold":
                    return 4;
                case "Rift":
                    return 5;
                case "EastMarch":
                    return 6;
                case "Solitude":
                    return 7;
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Imprimir recorrido
            if (dataGridView1.Rows.Count < 2)
                MessageBox.Show("Elige al menos 2 puntos");
            else if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Elige el punto de partida cambiando la flecha en la tabla de regiones");
            else
            {
                int peso = 0;
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                String current = row.Cells[0].Value.ToString();
                caminoTextBox.Text = "";
                HashSet<string> aux = destinos;
                bool[] visited = new bool[aux.Count];

                for (int i = 0; i < aux.Count - 1; i++)
                {
                    for (int j = 0; j < aux.Count; j++)
                    {
                        if (current == aux.ElementAt(j))
                            visited[j] = true;
                    }

                    caminoTextBox.Text += current + " ";
                    int adyacente = inf;
                    string region = "";

                    for (int j = 0; j < aux.Count; j++)
                    {
                        if (MatrizFinal[ToString(current), ToString(aux.ElementAt(j))] < adyacente && !visited[j])
                        {
                            adyacente = MatrizFinal[ToString(current), ToString(aux.ElementAt(j))];
                            region = aux.ElementAt(j);
                        }
                    }

                    caminoTextBox.Text += MatrizCaminos[ToString(current), ToString(region)] + " Distancia: " + MatrizFinal[ToString(current), ToString(region)] + " ";
                    peso += MatrizFinal[ToString(current), ToString(region)];

                    current = region;
                }
                caminoTextBox.Text += " " + current;

                caminoTextBox.Text += Environment.NewLine + "Distancia final: " + peso.ToString();
            }
        }

        private void ReiniciarTabla()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < destinos.Count(); i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dataGridView1);
                r.Cells[0].Value = destinos.ElementAt(i);
                dataGridView1.Rows.Add(r);
            }
        }

        #region Checks
        private void Whiterun_CheckedChanged(object sender, EventArgs e)
        {
            if (Whiteruners.Checked == true)
                destinos.Add("Whiterun");
            else
                destinos.Remove("Whiterun");
            ReiniciarTabla();
        }
        private void FalkreathHold_CheckedChanged(object sender, EventArgs e)
        {
            if (FalkreathHold.Checked == true)
                destinos.Add("FalkreathHold");
            else
                destinos.Remove("FalkreathHold");
            ReiniciarTabla();
        }
        private void TheReach_CheckedChanged(object sender, EventArgs e)
        {
            if (TheReach.Checked == true)
                destinos.Add("TheReach");
            else
                destinos.Remove("TheReach");
            ReiniciarTabla();
        }

        private void ThePale_CheckedChanged(object sender, EventArgs e)
        {
            if (ThePale.Checked == true)
                destinos.Add("ThePale");
            else
                destinos.Remove("ThePale");
            ReiniciarTabla();
        }

        private void WinterHold_CheckedChanged(object sender, EventArgs e)
        {
            if (WinterHold.Checked == true)
                destinos.Add("WinterHold");
            else
                destinos.Remove("WinterHold");
            ReiniciarTabla();
        }

        private void Rift_CheckedChanged(object sender, EventArgs e)
        {
            if (Rift.Checked == true)
                destinos.Add("Rift");
            else
                destinos.Remove("Rift");
            ReiniciarTabla();
        }

        private void EastMarch_CheckedChanged(object sender, EventArgs e)
        {
            if (EastMarch.Checked == true)
                destinos.Add("EastMarch");
            else
                destinos.Remove("EastMarch");
            ReiniciarTabla();
        }

        private void Solitude_CheckedChanged(object sender, EventArgs e)
        {
            if (Solitude.Checked == true)
                destinos.Add("Solitude");
            else
                destinos.Remove("Solitude");
            ReiniciarTabla();
        }

        #endregion

        //Mostrar matrices
        private void Matriz_Click(object sender, EventArgs e)
        {
            Matriz form = new Matriz(MatrizInicial, MatrizFinal, MatrizCaminos);
            form.ShowDialog();
        }
    }
}