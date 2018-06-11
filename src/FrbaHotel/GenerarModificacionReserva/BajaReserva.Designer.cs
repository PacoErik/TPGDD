namespace FrbaHotel.GenerarModificacionReserva
{
    partial class BajaReserva
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
            this.btn_cargarReserva = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txtbox_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cargarReserva
            // 
            this.btn_cargarReserva.Location = new System.Drawing.Point(12, 53);
            this.btn_cargarReserva.Name = "btn_cargarReserva";
            this.btn_cargarReserva.Size = new System.Drawing.Size(121, 23);
            this.btn_cargarReserva.TabIndex = 51;
            this.btn_cargarReserva.Text = "Cargar reserva";
            this.btn_cargarReserva.UseVisualStyleBackColor = true;
            this.btn_cargarReserva.Click += new System.EventHandler(this.btn_cargarReserva_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(166, 248);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 23);
            this.btn_eliminar.TabIndex = 50;
            this.btn_eliminar.Text = "Eliminar reserva";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(12, 27);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(269, 20);
            this.txtbox_codigo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Codigo de reserva";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 159);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "Ingresar texto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BajaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cargarReserva);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txtbox_codigo);
            this.Controls.Add(this.label1);
            this.Name = "BajaReserva";
            this.Text = "BajaReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cargarReserva;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}