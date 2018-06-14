namespace FrbaHotel.AbmHabitacion
{
    partial class ModificarHabitacion
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
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelNumeroInvalido = new System.Windows.Forms.Label();
            this.labelPisoInvalido = new System.Windows.Forms.Label();
            this.labelNumeroInvalido2 = new System.Windows.Forms.Label();
            this.checkBoxHabilitada = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDesc.Location = new System.Drawing.Point(24, 151);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(340, 157);
            this.richTextBoxDesc.TabIndex = 73;
            this.richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Descripción:";
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUbicacion.Location = new System.Drawing.Point(198, 36);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(166, 21);
            this.comboBoxUbicacion.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ubicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Piso:";
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(24, 90);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(145, 20);
            this.textBoxPiso.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Numero:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(24, 37);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumero.TabIndex = 64;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(70, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 74;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(235, 327);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 75;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelNumeroInvalido
            // 
            this.labelNumeroInvalido.AutoSize = true;
            this.labelNumeroInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroInvalido.Location = new System.Drawing.Point(21, 60);
            this.labelNumeroInvalido.Name = "labelNumeroInvalido";
            this.labelNumeroInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelNumeroInvalido.TabIndex = 76;
            this.labelNumeroInvalido.Text = "Numero invalido";
            this.labelNumeroInvalido.Visible = false;
            // 
            // labelPisoInvalido
            // 
            this.labelPisoInvalido.AutoSize = true;
            this.labelPisoInvalido.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPisoInvalido.Location = new System.Drawing.Point(21, 113);
            this.labelPisoInvalido.Name = "labelPisoInvalido";
            this.labelPisoInvalido.Size = new System.Drawing.Size(83, 13);
            this.labelPisoInvalido.TabIndex = 77;
            this.labelPisoInvalido.Text = "Numero inválido";
            this.labelPisoInvalido.Visible = false;
            // 
            // labelNumeroInvalido2
            // 
            this.labelNumeroInvalido2.AutoSize = true;
            this.labelNumeroInvalido2.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNumeroInvalido2.Location = new System.Drawing.Point(21, 61);
            this.labelNumeroInvalido2.Name = "labelNumeroInvalido2";
            this.labelNumeroInvalido2.Size = new System.Drawing.Size(178, 13);
            this.labelNumeroInvalido2.TabIndex = 78;
            this.labelNumeroInvalido2.Text = "Hay otra habitación con ese número";
            this.labelNumeroInvalido2.Visible = false;
            // 
            // checkBoxHabilitada
            // 
            this.checkBoxHabilitada.AutoSize = true;
            this.checkBoxHabilitada.Location = new System.Drawing.Point(198, 93);
            this.checkBoxHabilitada.Name = "checkBoxHabilitada";
            this.checkBoxHabilitada.Size = new System.Drawing.Size(73, 17);
            this.checkBoxHabilitada.TabIndex = 79;
            this.checkBoxHabilitada.Text = "Habilitada";
            this.checkBoxHabilitada.UseVisualStyleBackColor = true;
            // 
            // ModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 376);
            this.Controls.Add(this.checkBoxHabilitada);
            this.Controls.Add(this.labelNumeroInvalido2);
            this.Controls.Add(this.labelPisoInvalido);
            this.Controls.Add(this.labelNumeroInvalido);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumero);
            this.Name = "ModificarHabitacion";
            this.Text = "ModificarHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelNumeroInvalido;
        private System.Windows.Forms.Label labelPisoInvalido;
        private System.Windows.Forms.Label labelNumeroInvalido2;
        private System.Windows.Forms.CheckBox checkBoxHabilitada;
    }
}