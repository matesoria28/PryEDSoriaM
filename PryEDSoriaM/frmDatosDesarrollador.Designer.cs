namespace PryEDSoriaM
{
    partial class frmDatosDesarrollador
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
            this.lblDatosDesarrollador = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosDesarrollador
            // 
            this.lblDatosDesarrollador.AutoSize = true;
            this.lblDatosDesarrollador.Location = new System.Drawing.Point(113, 244);
            this.lblDatosDesarrollador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosDesarrollador.Name = "lblDatosDesarrollador";
            this.lblDatosDesarrollador.Size = new System.Drawing.Size(219, 80);
            this.lblDatosDesarrollador.TabIndex = 0;
            this.lblDatosDesarrollador.Text = "Carrera: Analista de Sistemas\r\nMateria: Estructura de Datos\r\nDNI Alumno: 43560659" +
    " \r\nNombre Alumno: Mateo Soria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEDSoriaM.Properties.Resources.WhatsApp_Image_2026_05_11_at_20_58_35;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(438, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDatosDesarrollador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosDesarrollador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}