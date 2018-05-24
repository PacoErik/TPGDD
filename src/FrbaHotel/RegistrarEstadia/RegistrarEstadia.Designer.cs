namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarEstadia
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
            this.atras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(12, 215);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(62, 34);
            this.atras.TabIndex = 11;
            this.atras.Text = "Atrás";
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrar Check-In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Registrar Check-Out";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atras);
            this.Name = "RegistrarEstadia";
            this.Text = "Registrar estadía";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}