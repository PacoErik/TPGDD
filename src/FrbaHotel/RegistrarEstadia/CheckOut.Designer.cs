namespace FrbaHotel.RegistrarEstadia
{
    partial class CheckOut
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFormaDePago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumeroVacio = new System.Windows.Forms.Label();
            this.labelNombreVacio = new System.Windows.Forms.Label();
            this.labelNombreInvalido = new System.Windows.Forms.Label();
            this.labelTarjetaInvalida = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCostoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEstadia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.dataGridViewConsumibles = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.tarjeta = new System.Windows.Forms.TextBox();
            this.propietario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forma de pago:";
            // 
            // comboBoxFormaDePago
            // 
            this.comboBoxFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaDePago.FormattingEnabled = true;
            this.comboBoxFormaDePago.Location = new System.Drawing.Point(28, 60);
            this.comboBoxFormaDePago.Name = "comboBoxFormaDePago";
            this.comboBoxFormaDePago.Size = new System.Drawing.Size(187, 21);
            this.comboBoxFormaDePago.TabIndex = 5;
            this.comboBoxFormaDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaDePago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero de tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre del propietario de la tarjeta:";
            // 
            // labelNumeroVacio
            // 
            this.labelNumeroVacio.AutoSize = true;
            this.labelNumeroVacio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroVacio.Location = new System.Drawing.Point(22, 151);
            this.labelNumeroVacio.Name = "labelNumeroVacio";
            this.labelNumeroVacio.Size = new System.Drawing.Size(80, 13);
            this.labelNumeroVacio.TabIndex = 13;
            this.labelNumeroVacio.Text = "Ingrese numero";
            this.labelNumeroVacio.Visible = false;
            // 
            // labelNombreVacio
            // 
            this.labelNombreVacio.AutoSize = true;
            this.labelNombreVacio.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreVacio.Location = new System.Drawing.Point(25, 208);
            this.labelNombreVacio.Name = "labelNombreVacio";
            this.labelNombreVacio.Size = new System.Drawing.Size(80, 13);
            this.labelNombreVacio.TabIndex = 14;
            this.labelNombreVacio.Text = "Ingrese numero";
            this.labelNombreVacio.Visible = false;
            // 
            // labelNombreInvalido
            // 
            this.labelNombreInvalido.AutoSize = true;
            this.labelNombreInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNombreInvalido.Location = new System.Drawing.Point(28, 208);
            this.labelNombreInvalido.Name = "labelNombreInvalido";
            this.labelNombreInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNombreInvalido.TabIndex = 17;
            this.labelNombreInvalido.Text = "Nombre invalido";
            this.labelNombreInvalido.Visible = false;
            // 
            // labelTarjetaInvalida
            // 
            this.labelTarjetaInvalida.AutoSize = true;
            this.labelTarjetaInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTarjetaInvalida.Location = new System.Drawing.Point(25, 151);
            this.labelTarjetaInvalida.Name = "labelTarjetaInvalida";
            this.labelTarjetaInvalida.Size = new System.Drawing.Size(130, 13);
            this.labelTarjetaInvalida.TabIndex = 18;
            this.labelTarjetaInvalida.Text = "Numero de tarjeta invalido";
            this.labelTarjetaInvalida.Visible = false;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Enabled = false;
            this.textBoxFecha.Location = new System.Drawing.Point(260, 38);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(202, 20);
            this.textBoxFecha.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Costo total:";
            // 
            // textBoxCostoTotal
            // 
            this.textBoxCostoTotal.Enabled = false;
            this.textBoxCostoTotal.Location = new System.Drawing.Point(260, 89);
            this.textBoxCostoTotal.Name = "textBoxCostoTotal";
            this.textBoxCostoTotal.ReadOnly = true;
            this.textBoxCostoTotal.Size = new System.Drawing.Size(202, 20);
            this.textBoxCostoTotal.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Estadia:";
            // 
            // textBoxEstadia
            // 
            this.textBoxEstadia.Enabled = false;
            this.textBoxEstadia.Location = new System.Drawing.Point(260, 135);
            this.textBoxEstadia.Name = "textBoxEstadia";
            this.textBoxEstadia.ReadOnly = true;
            this.textBoxEstadia.Size = new System.Drawing.Size(202, 20);
            this.textBoxEstadia.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cliente:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Location = new System.Drawing.Point(260, 185);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(202, 20);
            this.textBoxCliente.TabIndex = 26;
            // 
            // dataGridViewConsumibles
            // 
            this.dataGridViewConsumibles.AllowUserToAddRows = false;
            this.dataGridViewConsumibles.AllowUserToDeleteRows = false;
            this.dataGridViewConsumibles.AllowUserToOrderColumns = true;
            this.dataGridViewConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumibles.Location = new System.Drawing.Point(31, 251);
            this.dataGridViewConsumibles.Name = "dataGridViewConsumibles";
            this.dataGridViewConsumibles.ReadOnly = true;
            this.dataGridViewConsumibles.Size = new System.Drawing.Size(431, 150);
            this.dataGridViewConsumibles.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Consumibles:";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.Location = new System.Drawing.Point(212, 419);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(90, 26);
            this.buttonFinalizar.TabIndex = 30;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // tarjeta
            // 
            this.tarjeta.Location = new System.Drawing.Point(25, 128);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            this.tarjeta.Size = new System.Drawing.Size(190, 20);
            this.tarjeta.TabIndex = 31;
            // 
            // propietario
            // 
            this.propietario.Location = new System.Drawing.Point(25, 185);
            this.propietario.Name = "propietario";
            this.propietario.ReadOnly = true;
            this.propietario.Size = new System.Drawing.Size(190, 20);
            this.propietario.TabIndex = 32;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 457);
            this.Controls.Add(this.propietario);
            this.Controls.Add(this.tarjeta);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewConsumibles);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxEstadia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCostoTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.labelTarjetaInvalida);
            this.Controls.Add(this.labelNombreInvalido);
            this.Controls.Add(this.labelNombreVacio);
            this.Controls.Add(this.labelNumeroVacio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFormaDePago);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFormaDePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumeroVacio;
        private System.Windows.Forms.Label labelNombreVacio;
        private System.Windows.Forms.Label labelNombreInvalido;
        private System.Windows.Forms.Label labelTarjetaInvalida;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCostoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEstadia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.DataGridView dataGridViewConsumibles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.TextBox tarjeta;
        private System.Windows.Forms.TextBox propietario;
    }
}