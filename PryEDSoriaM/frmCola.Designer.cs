namespace PryEDSoriaM
{
    partial class frmCola
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
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramite3 = new System.Windows.Forms.Label();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.lblCodigo3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstCola = new System.Windows.Forms.ListView();
            this.gbNuevoElemento.SuspendLayout();
            this.gbElementoEliminado.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Location = new System.Drawing.Point(171, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 180);
            this.gbNuevoElemento.TabIndex = 0;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(60, 93);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(134, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(7, 101);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // gbElementoEliminado
            // 
            this.gbElementoEliminado.Controls.Add(this.lblTramite3);
            this.gbElementoEliminado.Controls.Add(this.lblNombre3);
            this.gbElementoEliminado.Controls.Add(this.lblCodigo3);
            this.gbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gbElementoEliminado.Controls.Add(this.lblTramite2);
            this.gbElementoEliminado.Controls.Add(this.lblNombre2);
            this.gbElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gbElementoEliminado.Location = new System.Drawing.Point(377, 12);
            this.gbElementoEliminado.Name = "gbElementoEliminado";
            this.gbElementoEliminado.Size = new System.Drawing.Size(200, 180);
            this.gbElementoEliminado.TabIndex = 0;
            this.gbElementoEliminado.TabStop = false;
            this.gbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramite3
            // 
            this.lblTramite3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite3.Location = new System.Drawing.Point(61, 95);
            this.lblTramite3.Name = "lblTramite3";
            this.lblTramite3.Size = new System.Drawing.Size(124, 23);
            this.lblTramite3.TabIndex = 7;
            this.lblTramite3.Text = "                       ";
            // 
            // lblNombre3
            // 
            this.lblNombre3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre3.Location = new System.Drawing.Point(61, 61);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(124, 23);
            this.lblNombre3.TabIndex = 6;
            this.lblNombre3.Text = "                       ";
            // 
            // lblCodigo3
            // 
            this.lblCodigo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo3.Location = new System.Drawing.Point(61, 22);
            this.lblCodigo3.Name = "lblCodigo3";
            this.lblCodigo3.Size = new System.Drawing.Size(124, 23);
            this.lblCodigo3.TabIndex = 5;
            this.lblCodigo3.Text = "                       ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(10, 101);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2.TabIndex = 2;
            this.lblTramite2.Text = "Tramite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(10, 62);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(10, 29);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 0;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstCola);
            this.groupBox3.Controls.Add(this.dgvCola);
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 193);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(165, 19);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(394, 168);
            this.dgvCola.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEDSoriaM.Properties.Resources.descarga;
            this.pictureBox1.InitialImage = global::PryEDSoriaM.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lstCola
            // 
            this.lstCola.HideSelection = false;
            this.lstCola.Location = new System.Drawing.Point(6, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(147, 168);
            this.lstCola.TabIndex = 1;
            this.lstCola.UseCompatibleStateImageBehavior = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbElementoEliminado.ResumeLayout(false);
            this.gbElementoEliminado.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.GroupBox gbElementoEliminado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite3;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.Label lblCodigo3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListView lstCola;
    }
}