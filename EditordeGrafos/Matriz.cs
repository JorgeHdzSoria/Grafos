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
    public partial class Matriz : Form
    {
        int inf = 10000;
        int regiones = 8;
        public Matriz(int[,] MatrizInicial, int[,] MatrizFinal, string[,] MatrizCaminos)
        {
            InitializeComponent();
            Imprime(MatrizInicial, MatrizFinal, MatrizCaminos);
        }

        private void Imprime(int[,] MatrizInicial, int[,] MatrizFinal, string[,] MatrizCaminos)
        {
            dataGridView1.RowHeadersWidth = 100;
            dataGridView2.RowHeadersWidth = 100;
            dataGridView3.RowHeadersWidth = 100;

            for (int i = 0; i < regiones; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), ToInt(i));
            }
            for (int i = 0; i < regiones; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = ToInt(i);
                for (int k = 0; k < regiones; k++)
                {
                    if (MatrizInicial[i, k] >= inf)
                        dataGridView1.Rows[i].Cells[k].Value = "inf";
                    else
                        dataGridView1.Rows[i].Cells[k].Value = MatrizInicial[i, k];
                }
            }

            //Pasar resultado a las tablas DataGridView2
            for (int i = 0; i < regiones; i++)
            {
                dataGridView2.Columns.Add(i.ToString(), ToInt(i));
            }
            for (int i = 0; i < regiones; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = ToInt(i);
                for (int k = 0; k < regiones; k++)
                {
                    if (MatrizFinal[i, k] >= inf)
                        dataGridView2.Rows[i].Cells[k].Value = "inf";
                    else
                        dataGridView2.Rows[i].Cells[k].Value = MatrizFinal[i, k];
                }
            }

            //Pasar resultado a las tablas DataGridView3
            for (int i = 0; i < regiones; i++)
            {
                dataGridView3.Columns.Add(i.ToString(), ToInt(i));
            }
            for (int i = 0; i < regiones; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].HeaderCell.Value = ToInt(i);
                for (int k = 0; k < regiones; k++)
                {
                    dataGridView3.Rows[i].Cells[k].Value = MatrizCaminos[i, k];
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
    }
}
