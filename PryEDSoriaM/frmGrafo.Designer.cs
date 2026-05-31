namespace PryEDSoriaM
{
    partial class frmGrafo
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
            this.gbCargarDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.gbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPrecioResultado = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gbListarViajes = new System.Windows.Forms.GroupBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbCargarDatos.SuspendLayout();
            this.gbConsultaDatos.SuspendLayout();
            this.gbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargarDatos
            // 
            this.gbCargarDatos.Controls.Add(this.txtPrecio);
            this.gbCargarDatos.Controls.Add(this.cmbDestino);
            this.gbCargarDatos.Controls.Add(this.cmbOrigen);
            this.gbCargarDatos.Controls.Add(this.btnCargar);
            this.gbCargarDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargarDatos.Controls.Add(this.lblPrecio);
            this.gbCargarDatos.Controls.Add(this.lblDestino);
            this.gbCargarDatos.Controls.Add(this.lblOrigen);
            this.gbCargarDatos.Location = new System.Drawing.Point(194, 12);
            this.gbCargarDatos.Name = "gbCargarDatos";
            this.gbCargarDatos.Size = new System.Drawing.Size(288, 204);
            this.gbCargarDatos.TabIndex = 0;
            this.gbCargarDatos.TabStop = false;
            this.gbCargarDatos.Text = "Carga de Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(204, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(65, 58);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(204, 21);
            this.cmbDestino.TabIndex = 6;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(65, 17);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(204, 21);
            this.cmbOrigen.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(165, 152);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(117, 37);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(6, 152);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(118, 36);
            this.btnBorrarTodo.TabIndex = 3;
            this.btnBorrarTodo.Text = "Borrar todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 109);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 66);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(7, 25);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // gbConsultaDatos
            // 
            this.gbConsultaDatos.Controls.Add(this.cmbDestino2);
            this.gbConsultaDatos.Controls.Add(this.cmbOrigen2);
            this.gbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gbConsultaDatos.Controls.Add(this.lblPrecioResultado);
            this.gbConsultaDatos.Controls.Add(this.lblPrecio2);
            this.gbConsultaDatos.Controls.Add(this.lblDestino2);
            this.gbConsultaDatos.Controls.Add(this.lblOrigen2);
            this.gbConsultaDatos.Location = new System.Drawing.Point(488, 12);
            this.gbConsultaDatos.Name = "gbConsultaDatos";
            this.gbConsultaDatos.Size = new System.Drawing.Size(279, 204);
            this.gbConsultaDatos.TabIndex = 1;
            this.gbConsultaDatos.TabStop = false;
            this.gbConsultaDatos.Text = "Consulta de Datos";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(59, 63);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(199, 21);
            this.cmbDestino2.TabIndex = 7;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(59, 21);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(199, 21);
            this.cmbOrigen2.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(150, 152);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 37);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(11, 152);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 36);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
//            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPrecioResultado
            // 
            this.lblPrecioResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioResultado.Location = new System.Drawing.Point(59, 105);
            this.lblPrecioResultado.Name = "lblPrecioResultado";
            this.lblPrecioResultado.Size = new System.Drawing.Size(199, 23);
            this.lblPrecioResultado.TabIndex = 3;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(8, 112);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AccessibleDescription = "";
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(7, 71);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(46, 13);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AccessibleDescription = "";
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(7, 30);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gbListarViajes
            // 
            this.gbListarViajes.Controls.Add(this.cmbHasta);
            this.gbListarViajes.Controls.Add(this.cmbDesde);
            this.gbListarViajes.Controls.Add(this.btnVerViajes);
            this.gbListarViajes.Controls.Add(this.btnListarOrigenes);
            this.gbListarViajes.Controls.Add(this.btnListarDestinos);
            this.gbListarViajes.Controls.Add(this.lblHasta);
            this.gbListarViajes.Controls.Add(this.lblDesde);
            this.gbListarViajes.Controls.Add(this.dgvGrafo);
            this.gbListarViajes.Location = new System.Drawing.Point(12, 222);
            this.gbListarViajes.Name = "gbListarViajes";
            this.gbListarViajes.Size = new System.Drawing.Size(755, 268);
            this.gbListarViajes.TabIndex = 2;
            this.gbListarViajes.TabStop = false;
            this.gbListarViajes.Text = "Listar Viajes ....";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(376, 21);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 8;
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(55, 19);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 7;
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(626, 19);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(108, 23);
            this.btnVerViajes.TabIndex = 6;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(503, 19);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(108, 23);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(182, 18);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(98, 23);
            this.btnListarDestinos.TabIndex = 4;
            this.btnListarDestinos.Text = "Listar Destino";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(331, 27);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(8, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvGrafo.Location = new System.Drawing.Point(6, 60);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(743, 202);
            this.dgvGrafo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Origen";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cordoba";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mendoza";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Santa fe";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Buenos Aires";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salta";
            this.Column6.Name = "Column6";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PryEDSoriaM.Properties.Resources.grafo_recorridos;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 502);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbListarViajes);
            this.Controls.Add(this.gbConsultaDatos);
            this.Controls.Add(this.gbCargarDatos);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.gbCargarDatos.ResumeLayout(false);
            this.gbCargarDatos.PerformLayout();
            this.gbConsultaDatos.ResumeLayout(false);
            this.gbConsultaDatos.PerformLayout();
            this.gbListarViajes.ResumeLayout(false);
            this.gbListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargarDatos;
        private System.Windows.Forms.GroupBox gbConsultaDatos;
        private System.Windows.Forms.GroupBox gbListarViajes;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPrecioResultado;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.ComboBox cmbOrigen2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}