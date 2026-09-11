namespace SwBiblioteca
{
    partial class FrmPrestamos
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
            pnlDatos = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechadevolucion = new Label();
            lblFechaprestamo = new Label();
            cmbLibro = new ComboBox();
            lblLibro = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            pnlLista = new Panel();
            dgvPrestamos = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 70);
            pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(576, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(361, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE PRÉSTAMOS";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(btnCancelar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(btnEditar);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnNuevo);
            pnlDatos.Controls.Add(dtpFechaDevolucion);
            pnlDatos.Controls.Add(dtpFechaPrestamo);
            pnlDatos.Controls.Add(lblFechadevolucion);
            pnlDatos.Controls.Add(lblFechaprestamo);
            pnlDatos.Controls.Add(cmbLibro);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(cmbUsuario);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 70);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 350);
            pnlDatos.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.Location = new Point(1007, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 42);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.Location = new Point(861, 272);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 42);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.Location = new Point(716, 272);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 42);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.Location = new Point(571, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 42);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.Location = new Point(425, 272);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 42);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Checked = false;
            dtpFechaDevolucion.Font = new Font("Segoe UI", 11F);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(684, 194);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(276, 27);
            dtpFechaDevolucion.TabIndex = 10;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Font = new Font("Segoe UI", 11F);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(684, 143);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(276, 27);
            dtpFechaPrestamo.TabIndex = 9;
            // 
            // lblFechadevolucion
            // 
            lblFechadevolucion.AutoSize = true;
            lblFechadevolucion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechadevolucion.Location = new Point(483, 192);
            lblFechadevolucion.Name = "lblFechadevolucion";
            lblFechadevolucion.Size = new Size(173, 25);
            lblFechadevolucion.TabIndex = 8;
            lblFechadevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaprestamo
            // 
            lblFechaprestamo.AutoSize = true;
            lblFechaprestamo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaprestamo.Location = new Point(500, 141);
            lblFechaprestamo.Name = "lblFechaprestamo";
            lblFechaprestamo.Size = new Size(156, 25);
            lblFechaprestamo.TabIndex = 7;
            lblFechaprestamo.Text = "Fecha Préstamo:";
            // 
            // cmbLibro
            // 
            cmbLibro.Font = new Font("Segoe UI", 11F);
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(684, 91);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(276, 28);
            cmbLibro.TabIndex = 6;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(592, 91);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(64, 25);
            lblLibro.TabIndex = 5;
            lblLibro.Text = "Libro:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.Font = new Font("Segoe UI", 11F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(684, 43);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(276, 28);
            cmbUsuario.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(570, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvPrestamos);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 420);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1350, 547);
            pnlLista.TabIndex = 4;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 0);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1350, 547);
            dgvPrestamos.TabIndex = 2;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 967);
            Controls.Add(pnlLista);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrestamos";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private Panel pnlLista;
        private ComboBox cmbUsuario;
        private Label lblUsuario;
        private ComboBox cmbLibro;
        private Label lblLibro;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechadevolucion;
        private Label lblFechaprestamo;
        private DateTimePicker dtpFechaDevolucion;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
    }
}