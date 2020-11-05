using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATS.WF
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        public void CtorTabla()
        {
            int Ax = Convert.ToInt32(txtAlum.Text);
            dgv.RowCount = Ax;
        }

        private void btnConfir_Click(object sender, EventArgs e)
        {
            CtorTabla();
        }

        private void btnProm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                decimal v1 = int.Parse(dr.Cells[1].Value.ToString());
                decimal v2 = int.Parse(dr.Cells[2].Value.ToString());
                decimal v3 = int.Parse(dr.Cells[3].Value.ToString());
                decimal v4 = int.Parse(dr.Cells[4].Value.ToString());

                dr.Cells[5].Value = ((v1 + v2 + v3 + v4) / 4);
            }
        }
        private void btnMediana_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                int tamaño = 4;
                int[] mediana = new int[tamaño];

                mediana[0] = int.Parse(dr.Cells[1].Value.ToString());
                mediana[1] = int.Parse(dr.Cells[2].Value.ToString());
                mediana[2] = int.Parse(dr.Cells[3].Value.ToString());
                mediana[3] = int.Parse(dr.Cells[4].Value.ToString());

                Array.Sort(mediana);
                tamaño = tamaño / 2;
                decimal res = (Convert.ToDecimal(mediana[tamaño - 1] + mediana[tamaño]) / 2);
                dr.Cells[6].Value = res;
            }
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                int contador = 0;
                int posicion = 0;
                int numero = 0;
                int contador2 = 0;
                int mayor = 0;
                int posicionmayor = 0;
                int[] aux = new int[4];
                int[] moda = new int[4];

                moda[0] = int.Parse(dr.Cells[1].Value.ToString());
                moda[1] = int.Parse(dr.Cells[2].Value.ToString());
                moda[2] = int.Parse(dr.Cells[3].Value.ToString());
                moda[3] = int.Parse(dr.Cells[4].Value.ToString());

                for (contador = 0; contador < 4; contador++) //rellenamos array auxiliar con todos 0
                {
                    aux[contador] = 0;
                }

                for (contador = 0; contador < 4; contador++)   //recorro valores buscando repeticiones y guardo en auxiliar segun la posicion
                {
                    numero = moda[contador];    //guardo el numero de cada posicion
                    posicion = contador;
                    for (contador2 = contador; contador2 < 4; contador2++)
                    {
                        if (moda[contador2] == numero) aux[posicion]++; //recorro el array y comparo con el numero q guarde 
                    }                                   //sumo +1 en la posicion cada vez q encuentro el numero    
                }

                mayor = aux[0]; //guarde en aux la cantidad de veces q se repite el numero y le asigno ese valor a "mayor"
                posicionmayor = 0;
                for (contador = 0; contador < 4; contador++) //recorro aux y comparo
                {
                    if (aux[contador] > mayor)  //si algun elemento del array es mayor que la variable "mayor"
                    {
                        posicionmayor = contador; //le asigno la posicion del numero mayor a una variable "posicionmayor"
                        mayor = aux[contador];
                    }
                }
                dr.Cells[7].Value = moda[posicionmayor]; //muestro el arreglo "moda" con la posicion donde esta el numero repetido
            }
        }
    }
}