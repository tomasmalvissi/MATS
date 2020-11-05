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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mediana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfir = new System.Windows.Forms.Button();
            this.btnProm = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnModa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlum = new System.Windows.Forms.TextBox();
            this.lbl_prom = new System.Windows.Forms.Label();
            this.lbl_mediana = new System.Windows.Forms.Label();
            this.lbl_moda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.dgv.Size = new System.Drawing.Size(531, 316);
            this.dgv.TabIndex = 4;
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
            // 
            // Mediana
            // 
            this.Mediana.HeaderText = "Mediana";
            this.Mediana.Name = "Mediana";
            // 
            // Moda
            // 
            this.Moda.HeaderText = "Moda";
            this.Moda.Name = "Moda";
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
            this.btnProm.Location = new System.Drawing.Point(549, 141);
            this.btnProm.Name = "btnProm";
            this.btnProm.Size = new System.Drawing.Size(75, 23);
            this.btnProm.TabIndex = 5;
            this.btnProm.Text = "Promedio";
            this.btnProm.UseVisualStyleBackColor = true;
            this.btnProm.Click += new System.EventHandler(this.btnProm_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(549, 229);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(75, 23);
            this.btnMediana.TabIndex = 6;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnModa
            // 
            this.btnModa.Location = new System.Drawing.Point(549, 313);
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
            // lbl_prom
            // 
            this.lbl_prom.AutoSize = true;
            this.lbl_prom.Location = new System.Drawing.Point(559, 179);
            this.lbl_prom.Name = "lbl_prom";
            this.lbl_prom.Size = new System.Drawing.Size(51, 13);
            this.lbl_prom.TabIndex = 8;
            this.lbl_prom.Text = "Promedio";
            // 
            // lbl_mediana
            // 
            this.lbl_mediana.AutoSize = true;
            this.lbl_mediana.Location = new System.Drawing.Point(559, 267);
            this.lbl_mediana.Name = "lbl_mediana";
            this.lbl_mediana.Size = new System.Drawing.Size(48, 13);
            this.lbl_mediana.TabIndex = 9;
            this.lbl_mediana.Text = "Mediana";
            // 
            // lbl_moda
            // 
            this.lbl_moda.AutoSize = true;
            this.lbl_moda.Location = new System.Drawing.Point(573, 348);
            this.lbl_moda.Name = "lbl_moda";
            this.lbl_moda.Size = new System.Drawing.Size(34, 13);
            this.lbl_moda.TabIndex = 10;
            this.lbl_moda.Text = "Moda";
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
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_moda);
            this.Controls.Add(this.lbl_mediana);
            this.Controls.Add(this.lbl_prom);
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
        private System.Windows.Forms.Label lbl_prom;
        private System.Windows.Forms.Label lbl_mediana;
        private System.Windows.Forms.Label lbl_moda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mediana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moda;
        private System.Windows.Forms.Label label2;
    }
}

