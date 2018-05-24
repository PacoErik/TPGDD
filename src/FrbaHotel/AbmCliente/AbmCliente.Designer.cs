namespace FrbaHotel.AbmCliente
{
    partial class AbmCliente
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
            this.alta = new System.Windows.Forms.Button();
            this.baja = new System.Windows.Forms.Button();
            this.modificacion = new System.Windows.Forms.Button();
            this.listado = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(68, 30);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(141, 23);
            this.alta.TabIndex = 0;
            this.alta.Text = "Alta de cliente";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.button1_Click);
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(68, 79);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(141, 23);
            this.baja.TabIndex = 1;
            this.baja.Text = "Baja de cliente";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // modificacion
            // 
            this.modificacion.Location = new System.Drawing.Point(68, 129);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(141, 23);
            this.modificacion.TabIndex = 2;
            this.modificacion.Text = "Modificación de cliente";
            this.modificacion.UseVisualStyleBackColor = true;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // listado
            // 
            this.listado.Location = new System.Drawing.Point(68, 177);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(141, 23);
            this.listado.TabIndex = 3;
            this.listado.Text = "Listado de clientes";
            this.listado.UseVisualStyleBackColor = true;
            this.listado.Click += new System.EventHandler(this.listado_Click);
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(12, 215);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(62, 34);
            this.atras.TabIndex = 4;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.alta);
            this.Name = "AbmCliente";
            this.Text = "ABM de Cliente";
            this.Load += new System.EventHandler(this.AbmCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Button modificacion;
        private System.Windows.Forms.Button listado;
        private System.Windows.Forms.Button atras;
    }
}