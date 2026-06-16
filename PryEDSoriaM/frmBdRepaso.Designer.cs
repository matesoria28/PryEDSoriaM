namespace PryEDSoriaM
{
    partial class frmBdRepaso
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
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblOperacionesBD = new System.Windows.Forms.Label();
            this.cmbOperacionesBD = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvOperacionesBD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionesBD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(21, 21);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(219, 13);
            this.lblOperaciones.TabIndex = 0;
            this.lblOperaciones.Text = "Operaciones a Realizar en la Base de Datos:";
            // 
            // lblOperacionesBD
            // 
            this.lblOperacionesBD.BackColor = System.Drawing.SystemColors.Control;
            this.lblOperacionesBD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperacionesBD.Location = new System.Drawing.Point(13, 53);
            this.lblOperacionesBD.Name = "lblOperacionesBD";
            this.lblOperacionesBD.Size = new System.Drawing.Size(646, 91);
            this.lblOperacionesBD.TabIndex = 1;
            // 
            // cmbOperacionesBD
            // 
            this.cmbOperacionesBD.FormattingEnabled = true;
            this.cmbOperacionesBD.Location = new System.Drawing.Point(261, 16);
            this.cmbOperacionesBD.Name = "cmbOperacionesBD";
            this.cmbOperacionesBD.Size = new System.Drawing.Size(241, 21);
            this.cmbOperacionesBD.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(524, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(135, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvOperacionesBD
            // 
            this.dgvOperacionesBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacionesBD.Location = new System.Drawing.Point(12, 156);
            this.dgvOperacionesBD.Name = "dgvOperacionesBD";
            this.dgvOperacionesBD.Size = new System.Drawing.Size(647, 211);
            this.dgvOperacionesBD.TabIndex = 4;
            // 
            // frmBdRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 379);
            this.Controls.Add(this.dgvOperacionesBD);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacionesBD);
            this.Controls.Add(this.lblOperacionesBD);
            this.Controls.Add(this.lblOperaciones);
            this.Name = "frmBdRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            this.Load += new System.EventHandler(this.frmBdRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionesBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblOperacionesBD;
        private System.Windows.Forms.ComboBox cmbOperacionesBD;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvOperacionesBD;
    }
}