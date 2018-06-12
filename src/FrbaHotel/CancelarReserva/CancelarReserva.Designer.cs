namespace FrbaHotel.CancelarReserva
{
    partial class CancelarReserva
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
            this.txtbox_codigo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cargar_reserva = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_ingrese_motivo = new System.Windows.Forms.Label();
            this.lbl_cargado_correcto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(114, 18);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(158, 20);
            this.txtbox_codigo.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 148);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo:";
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(12, 271);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(62, 34);
            this.atras.TabIndex = 6;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(197, 278);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código de reserva:";
            // 
            // btn_cargar_reserva
            // 
            this.btn_cargar_reserva.Location = new System.Drawing.Point(90, 278);
            this.btn_cargar_reserva.Name = "btn_cargar_reserva";
            this.btn_cargar_reserva.Size = new System.Drawing.Size(99, 23);
            this.btn_cargar_reserva.TabIndex = 9;
            this.btn_cargar_reserva.Text = "Cargar reserva";
            this.btn_cargar_reserva.UseVisualStyleBackColor = true;
            this.btn_cargar_reserva.Click += new System.EventHandler(this.btn_cargar_reserva_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(39, 48);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(46, 13);
            this.lbl_error.TabIndex = 10;
            this.lbl_error.Text = "ERROR";
            // 
            // lbl_ingrese_motivo
            // 
            this.lbl_ingrese_motivo.AutoSize = true;
            this.lbl_ingrese_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_ingrese_motivo.Location = new System.Drawing.Point(70, 90);
            this.lbl_ingrese_motivo.Name = "lbl_ingrese_motivo";
            this.lbl_ingrese_motivo.Size = new System.Drawing.Size(191, 16);
            this.lbl_ingrese_motivo.TabIndex = 11;
            this.lbl_ingrese_motivo.Text = "Ingrese motivo de cancelacion";
            // 
            // lbl_cargado_correcto
            // 
            this.lbl_cargado_correcto.AutoSize = true;
            this.lbl_cargado_correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_cargado_correcto.Location = new System.Drawing.Point(70, 74);
            this.lbl_cargado_correcto.Name = "lbl_cargado_correcto";
            this.lbl_cargado_correcto.Size = new System.Drawing.Size(114, 16);
            this.lbl_cargado_correcto.TabIndex = 12;
            this.lbl_cargado_correcto.Text = "Reserva cargada";
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.lbl_cargado_correcto);
            this.Controls.Add(this.lbl_ingrese_motivo);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cargar_reserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtbox_codigo);
            this.Name = "CancelarReserva";
            this.Text = "Cancelar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cargar_reserva;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_ingrese_motivo;
        private System.Windows.Forms.Label lbl_cargado_correcto;

    }
}