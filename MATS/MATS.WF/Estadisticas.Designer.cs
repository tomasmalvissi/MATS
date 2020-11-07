namespace MATS.WF
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnConfir = new System.Windows.Forms.Button();
            this.btnProm = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnModa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Proporcion = new System.Windows.Forms.Button();
            this.lbl_proporcion = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mediana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alumno,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4,
            this.Promedio,
            this.Mediana,
            this.Moda});
            this.dgv.Location = new System.Drawing.Point(12, 110);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(531, 273);
            this.dgv.TabIndex = 4;
            // 
            // btnConfir
            // 
            this.btnConfir.Location = new System.Drawing.Point(277, 63);
            this.btnConfir.Name = "btnConfir";
            this.btnConfir.Size = new System.Drawing.Size(75, 23);
            this.btnConfir.TabIndex = 3;
            this.btnConfir.Text = "Confirmar";
            this.btnConfir.UseVisualStyleBackColor = true;
            this.btnConfir.Click += new System.EventHandler(this.btnConfir_Click);
            // 
            // btnProm
            // 
            this.btnProm.Location = new System.Drawing.Point(599, 120);
            this.btnProm.Name = "btnProm";
            this.btnProm.Size = new System.Drawing.Size(75, 23);
            this.btnProm.TabIndex = 5;
            this.btnProm.Text = "Promedio";
            this.btnProm.UseVisualStyleBackColor = true;
            this.btnProm.Click += new System.EventHandler(this.btnProm_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(716, 120);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 23);
            this.btnMediana.TabIndex = 6;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnModa
            // 
            this.btnModa.Location = new System.Drawing.Point(599, 177);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(75, 23);
            this.btnModa.TabIndex = 7;
            this.btnModa.Text = "Moda";
            this.btnModa.UseVisualStyleBackColor = true;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese cantidad alumnos";
            // 
            // txtAlum
            // 
            this.txtAlum.Location = new System.Drawing.Point(155, 65);
            this.txtAlum.Name = "txtAlum";
            this.txtAlum.Size = new System.Drawing.Size(100, 20);
            this.txtAlum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "PROMEDIO, MEDIANA y MODA";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Total,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Promedio2});
            this.dgv2.Location = new System.Drawing.Point(12, 399);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv2.Size = new System.Drawing.Size(531, 48);
            this.dgv2.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nota1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nota3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nota4";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Promedio2
            // 
            this.Promedio2.HeaderText = "Promedio";
            this.Promedio2.Name = "Promedio2";
            this.Promedio2.ReadOnly = true;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(561, 286);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(271, 185);
            this.grafico.TabIndex = 13;
            this.grafico.Text = "chart";
            // 
            // Proporcion
            // 
            this.Proporcion.Location = new System.Drawing.Point(716, 171);
            this.Proporcion.Name = "Proporcion";
            this.Proporcion.Size = new System.Drawing.Size(75, 35);
            this.Proporcion.TabIndex = 14;
            this.Proporcion.Text = "Proporcion Aprobados";
            this.Proporcion.UseVisualStyleBackColor = true;
            this.Proporcion.Click += new System.EventHandler(this.Proporcion_Click);
            // 
            // lbl_proporcion
            // 
            this.lbl_proporcion.AutoSize = true;
            this.lbl_proporcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proporcion.Location = new System.Drawing.Point(572, 225);
            this.lbl_proporcion.Name = "lbl_proporcion";
            this.lbl_proporcion.Size = new System.Drawing.Size(58, 15);
            this.lbl_proporcion.TabIndex = 15;
            this.lbl_proporcion.Text = "Alumnos:";
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota1";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "Nota2";
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.HeaderText = "Nota3";
            this.Nota3.Name = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.HeaderText = "Nota4";
            this.Nota4.Name = "Nota4";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            // 
            // Mediana
            // 
            this.Mediana.HeaderText = "Mediana";
            this.Mediana.Name = "Mediana";
            this.Mediana.ReadOnly = true;
            // 
            // Moda
            // 
            this.Moda.HeaderText = "Moda";
            this.Moda.Name = "Moda";
            this.Moda.ReadOnly = true;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 497);
            this.Controls.Add(this.lbl_proporcion);
            this.Controls.Add(this.Proporcion);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.btnProm);
            this.Controls.Add(this.btnConfir);
            this.Controls.Add(this.dgv);
            this.Name = "Estadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnConfir;
        private System.Windows.Forms.Button btnProm;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Button btnModa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button Proporcion;
        private System.Windows.Forms.Label lbl_proporcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mediana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moda;
    }
}

