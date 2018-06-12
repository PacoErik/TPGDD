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
            this.checkin = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(83, 66);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(121, 23);
            this.checkin.TabIndex = 12;
            this.checkin.Text = "Registrar Check-In";
            this.checkin.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(83, 143);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(121, 23);
            this.checkout.TabIndex = 13;
            this.checkout.Text = "Registrar Check-Out";
            this.checkout.UseVisualStyleBackColor = true;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(12, 226);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 14;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // RegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Name = "RegistrarEstadia";
            this.Text = "Registrar estadía";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button volver;
    }
}