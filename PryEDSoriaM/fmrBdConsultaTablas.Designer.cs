namespace PryEDSoriaM
{
    partial class fmrBdConsultaTablas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbTablaBd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(685, 364);
            this.dgvDatos.TabIndex = 0;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(267, 402);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(133, 13);
            this.lblTabla.TabIndex = 1;
            this.lblTabla.Text = "Tabla de la base de datos:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(581, 394);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(113, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbTablaBd
            // 
            this.cmbTablaBd.FormattingEnabled = true;
            this.cmbTablaBd.Items.AddRange(new object[] {
            "Autor",
            "Idioma",
            "Libro",
            "Pais"});
            this.cmbTablaBd.Location = new System.Drawing.Point(406, 394);
            this.cmbTablaBd.Name = "cmbTablaBd";
            this.cmbTablaBd.Size = new System.Drawing.Size(155, 21);
            this.cmbTablaBd.TabIndex = 3;
            // 
            // fmrBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 427);
            this.Controls.Add(this.cmbTablaBd);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvDatos);
            this.Name = "fmrBdConsultaTablas";
            this.Text = "Consulta de un tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbTablaBd;
    }
}