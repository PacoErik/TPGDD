namespace FrbaHotel.AbmRol
{
    partial class AbmRol
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
            this.listado = new System.Windows.Forms.Button();
            this.modificacion = new System.Windows.Forms.Button();
            this.baja = new System.Windows.Forms.Button();
            this.alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listado
            // 
            this.listado.Location = new System.Drawing.Point(73, 177);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(141, 23);
            this.listado.TabIndex = 8;
            this.listado.Text = "Listado de roles";
            this.listado.UseVisualStyleBackColor = true;
            this.listado.Click += new System.EventHandler(this.listado_Click);
            // 
            // modificacion
            // 
            this.modificacion.Location = new System.Drawing.Point(73, 129);
            this.modificacion.Name = "modificacion";
            this.modificacion.Size = new System.Drawing.Size(141, 23);
            this.modificacion.TabIndex = 7;
            this.modificacion.Text = "Modificación de rol";
            this.modificacion.UseVisualStyleBackColor = true;
            this.modificacion.Click += new System.EventHandler(this.modificacion_Click);
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(73, 79);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(141, 23);
            this.baja.TabIndex = 6;
            this.baja.Text = "Baja de rol";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(73, 30);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(141, 23);
            this.alta.TabIndex = 5;
            this.alta.Text = "Alta de rol";
            this.alta.UseVisualStyleBackColor = true;
            this.alta.Click += new System.EventHandler(this.alta_Click);
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.modificacion);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.alta);
            this.Name = "AbmRol";
            this.Text = "ABM de Rol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listado;
        private System.Windows.Forms.Button modificacion;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Button alta;
    }
}