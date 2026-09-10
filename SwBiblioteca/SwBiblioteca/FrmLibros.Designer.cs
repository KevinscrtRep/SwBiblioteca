namespace SwBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscarISBN = new TextBox();
            lblTitulo2 = new Label();
            pnlDatos = new Panel();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAnio = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTitulo3 = new Label();
            lblISBN = new Label();
            pblBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pblBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1378, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(547, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblTitulo2);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1378, 67);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(744, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(512, 14);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(206, 23);
            txtBuscarISBN.TabIndex = 1;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Location = new Point(455, 17);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(32, 15);
            lblTitulo2.TabIndex = 0;
            lblTitulo2.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAnio);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTitulo3);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 127);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1378, 287);
            pnlDatos.TabIndex = 2;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(512, 241);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(307, 23);
            txtExistencias.TabIndex = 13;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(512, 204);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(307, 23);
            txtAnio.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(512, 165);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(307, 23);
            txtCategoria.TabIndex = 11;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(512, 126);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(307, 23);
            cmbEditorial.TabIndex = 10;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(512, 89);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(307, 23);
            cmbAutor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(512, 54);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(307, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(512, 19);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(307, 23);
            txtISBN.TabIndex = 7;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Location = new Point(395, 249);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(64, 15);
            lblExistencias.TabIndex = 6;
            lblExistencias.Text = "Existencias";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(395, 212);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Año";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(395, 173);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(395, 134);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(50, 15);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(395, 97);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // lblTitulo3
            // 
            lblTitulo3.AutoSize = true;
            lblTitulo3.Location = new Point(395, 62);
            lblTitulo3.Name = "lblTitulo3";
            lblTitulo3.Size = new Size(37, 15);
            lblTitulo3.TabIndex = 1;
            lblTitulo3.Text = "Titulo";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(395, 27);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // pblBotones
            // 
            pblBotones.Controls.Add(btnCancelar);
            pblBotones.Controls.Add(btnEliminar);
            pblBotones.Controls.Add(btnEditar);
            pblBotones.Controls.Add(btnGuardar);
            pblBotones.Controls.Add(btnNuevo);
            pblBotones.Location = new Point(280, 432);
            pblBotones.Name = "pblBotones";
            pblBotones.Size = new Size(777, 64);
            pblBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.Location = new Point(614, 9);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 44);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.Location = new Point(475, 9);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.Location = new Point(338, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 44);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.Location = new Point(199, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 44);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.Location = new Point(59, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(123, 44);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(280, 518);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(769, 308);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellDoubleClick += CargarLibroSeleccionado;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 851);
            Controls.Add(dgvLibros);
            Controls.Add(pblBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FormLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pblBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscarISBN;
        private Label lblTitulo2;
        private Panel pnlDatos;
        private Label lblAutor;
        private Label lblTitulo3;
        private Label lblISBN;
        private Label lblExistencias;
        private Label lblAnio;
        private Label lblCategoria;
        private Label lblEditorial;
        private Panel pblBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DataGridView dgvLibros;
        private TextBox txtISBN;
        private TextBox txtTitulo;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
    }
}