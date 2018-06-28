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
            this.txtbox_motivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cargar_reserva = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_ingrese_motivo = new System.Windows.Forms.Label();
            this.lbl_cargado_correcto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMotivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_codigo
            // 
            this.txtbox_codigo.Location = new System.Drawing.Point(114, 18);
            this.txtbox_codigo.Name = "txtbox_codigo";
            this.txtbox_codigo.Size = new System.Drawing.Size(158, 20);
            this.txtbox_codigo.TabIndex = 2;
            // 
            // txtbox_motivo
            // 
            this.txtbox_motivo.Enabled = false;
            this.txtbox_motivo.Location = new System.Drawing.Point(60, 142);
            this.txtbox_motivo.MaxLength = 255;
            this.txtbox_motivo.Multiline = true;
            this.txtbox_motivo.Name = "txtbox_motivo";
            this.txtbox_motivo.Size = new System.Drawing.Size(212, 148);
            this.txtbox_motivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo:";
            // 
            // enviar
            // 
            this.enviar.Enabled = false;
            this.enviar.Location = new System.Drawing.Point(197, 305);
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
            this.btn_cargar_reserva.Location = new System.Drawing.Point(173, 67);
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
            this.lbl_error.Location = new System.Drawing.Point(12, 49);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(46, 13);
            this.lbl_error.TabIndex = 10;
            this.lbl_error.Text = "ERROR";
            this.lbl_error.Visible = false;
            // 
            // lbl_ingrese_motivo
            // 
            this.lbl_ingrese_motivo.AutoSize = true;
            this.lbl_ingrese_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_ingrese_motivo.Location = new System.Drawing.Point(57, 123);
            this.lbl_ingrese_motivo.Name = "lbl_ingrese_motivo";
            this.lbl_ingrese_motivo.Size = new System.Drawing.Size(191, 16);
            this.lbl_ingrese_motivo.TabIndex = 11;
            this.lbl_ingrese_motivo.Text = "Ingrese motivo de cancelación";
            this.lbl_ingrese_motivo.Visible = false;
            // 
            // lbl_cargado_correcto
            // 
            this.lbl_cargado_correcto.AutoSize = true;
            this.lbl_cargado_correcto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_cargado_correcto.Location = new System.Drawing.Point(111, 41);
            this.lbl_cargado_correcto.Name = "lbl_cargado_correcto";
            this.lbl_cargado_correcto.Size = new System.Drawing.Size(114, 16);
            this.lbl_cargado_correcto.TabIndex = 12;
            this.lbl_cargado_correcto.Text = "Reserva cargada";
            this.lbl_cargado_correcto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelMotivo
            // 
            this.labelMotivo.AutoSize = true;
            this.labelMotivo.ForeColor = System.Drawing.Color.Red;
            this.labelMotivo.Location = new System.Drawing.Point(57, 110);
            this.labelMotivo.Name = "labelMotivo";
            this.labelMotivo.Size = new System.Drawing.Size(155, 13);
            this.labelMotivo.TabIndex = 14;
            this.labelMotivo.Text = "El motivo no puede estar vacío";
            this.labelMotivo.Visible = false;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.labelMotivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cargado_correcto);
            this.Controls.Add(this.lbl_ingrese_motivo);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cargar_reserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_motivo);
            this.Controls.Add(this.txtbox_codigo);
            this.Name = "CancelarReserva";
            this.Text = "Cancelar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_codigo;
        private System.Windows.Forms.TextBox txtbox_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cargar_reserva;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_ingrese_motivo;
        private System.Windows.Forms.Label lbl_cargado_correcto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMotivo;

    }
}