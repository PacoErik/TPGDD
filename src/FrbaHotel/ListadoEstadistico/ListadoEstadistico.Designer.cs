namespace FrbaHotel.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trimestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoDeListado = new System.Windows.Forms.ComboBox();
            this.listar = new System.Windows.Forms.Button();
            this.resultados = new System.Windows.Forms.DataGridView();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // anio
            // 
            this.anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anio.FormattingEnabled = true;
            this.anio.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.anio.Location = new System.Drawing.Point(48, 10);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(57, 21);
            this.anio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre:";
            // 
            // trimestre
            // 
            this.trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimestre.FormattingEnabled = true;
            this.trimestre.Items.AddRange(new object[] {
            "Primer",
            "Segundo",
            "Tercer",
            "Cuarto"});
            this.trimestre.Location = new System.Drawing.Point(71, 37);
            this.trimestre.Name = "trimestre";
            this.trimestre.Size = new System.Drawing.Size(163, 21);
            this.trimestre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // tipoDeListado
            // 
            this.tipoDeListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDeListado.FormattingEnabled = true;
            this.tipoDeListado.Items.AddRange(new object[] {
            "HOTELES CON MAYOR CANTIDAD DE RESERVAS CANCELADAS",
            "HOTELES CON MAYOR CANTIDAD DE CONSUMIBLES FACTURADOS",
            "HOTELES CON MAYOR CANTIDAD DE DIAS FUERA DE SERVICIO",
            "HABITACIONES CON MAYOR CANTIDAD DE DIAS Y VECES QUE FUERON OCUPADAS",
            "CLIENTES CON MAYOR CANTIDAD DE PUNTOS"});
            this.tipoDeListado.Location = new System.Drawing.Point(48, 64);
            this.tipoDeListado.Name = "tipoDeListado";
            this.tipoDeListado.Size = new System.Drawing.Size(549, 21);
            this.tipoDeListado.TabIndex = 5;
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(503, 5);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(94, 48);
            this.listar.TabIndex = 6;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // resultados
            // 
            this.resultados.AllowUserToAddRows = false;
            this.resultados.AllowUserToDeleteRows = false;
            this.resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultados.Location = new System.Drawing.Point(16, 95);
            this.resultados.Name = "resultados";
            this.resultados.ReadOnly = true;
            this.resultados.Size = new System.Drawing.Size(581, 197);
            this.resultados.TabIndex = 7;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(284, 298);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 8;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 333);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.tipoDeListado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trimestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado estadístico";
            ((System.ComponentModel.ISupportInitialize)(this.resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoDeListado;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.DataGridView resultados;
        private System.Windows.Forms.Button volver;
    }
}