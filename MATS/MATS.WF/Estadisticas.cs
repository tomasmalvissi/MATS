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
            //int Ay = Convert.ToInt32(txtNotas.Text);
            int Ax = Convert.ToInt32(txtAlum.Text);

            //dgv.ColumnCount = Ay + 1;
            dgv.RowCount = Ax;

            //dgv.Columns[0].Name = "Nombre y Apellido";
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
            

        }
    }
}