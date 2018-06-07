namespace FrbaHotel.AbmRol
{
    partial class ModificacionRolElegido
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.habilitado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.disponibles = new System.Windows.Forms.DataGridView();
            this.actuales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            // 
            // habilitado
            // 
            this.habilitado.AutoSize = true;
            this.habilitado.Checked = true;
            this.habilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitado.Location = new System.Drawing.Point(15, 32);
            this.habilitado.Name = "habilitado";
            this.habilitado.Size = new System.Drawing.Size(73, 17);
            this.habilitado.TabIndex = 2;
            this.habilitado.Text = "Habilitado";
            this.habilitado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funcionalidades disponibles (click para elegir):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionalidades actuales (click para remover):";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(15, 298);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(380, 298);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Guardar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // disponibles
            // 
            this.disponibles.AllowUserToAddRows = false;
            this.disponibles.AllowUserToDeleteRows = false;
            this.disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disponibles.Location = new System.Drawing.Point(18, 78);
            this.disponibles.Name = "disponibles";
            this.disponibles.ReadOnly = true;
            this.disponibles.Size = new System.Drawing.Size(437, 93);
            this.disponibles.TabIndex = 9;
            this.disponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.disponibles_CellClick);
            // 
            // actuales
            // 
            this.actuales.AllowUserToAddRows = false;
            this.actuales.AllowUserToDeleteRows = false;
            this.actuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actuales.Location = new System.Drawing.Point(15, 190);
            this.actuales.Name = "actuales";
            this.actuales.ReadOnly = true;
            this.actuales.Size = new System.Drawing.Size(437, 93);
            this.actuales.TabIndex = 10;
            this.actuales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actuales_CellClick);
            // 
            // ModificacionRolElegido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.actuales);
            this.Controls.Add(this.disponibles);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.habilitado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionRolElegido";
            this.Text = "Modificación de rol";
            ((System.ComponentModel.ISupportInitialize)(this.disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox habilitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.DataGridView disponibles;
        private System.Windows.Forms.DataGridView actuales;
    }
}