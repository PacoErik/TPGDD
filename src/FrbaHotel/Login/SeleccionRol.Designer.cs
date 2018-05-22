namespace FrbaHotel.Login
{
    partial class SeleccionRol
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
            this.Entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(221, 188);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 2;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseMnemonic = false;
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un rol:";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(37, 62);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(445, 21);
            this.rolesComboBox.TabIndex = 1;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.rolesComboBox_SelectedIndexChanged);
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 232);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRol";
            this.Text = "Seleccion de rol";
            this.Load += new System.EventHandler(this.SeleccionRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rolesComboBox;
    }
}