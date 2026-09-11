namespace SwBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalida = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            lblsubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnSalida);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(293, 967);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.White;
            btnSalida.Dock = DockStyle.Top;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSalida.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnSalida.IconColor = Color.Black;
            btnSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalida.IconSize = 35;
            btnSalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalida.Location = new Point(0, 480);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(293, 50);
            btnSalida.TabIndex = 17;
            btnSalida.Text = "Salida";
            btnSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.White;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 35;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 430);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(293, 50);
            btnReportes.TabIndex = 16;
            btnReportes.Text = "Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.White;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 35;
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(0, 380);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(293, 50);
            btnPrestamos.TabIndex = 15;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.BackColor = Color.White;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 35;
            btnEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.Location = new Point(0, 330);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(293, 50);
            btnEditoriales.TabIndex = 14;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.BackColor = Color.White;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatAppearance.BorderSize = 0;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 35;
            btnAutores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAutores.Location = new Point(0, 280);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(293, 50);
            btnAutores.TabIndex = 13;
            btnAutores.Text = "Autores";
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.White;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 35;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 230);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(293, 50);
            btnUsuarios.TabIndex = 12;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.White;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 35;
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 180);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(293, 50);
            btnLibros.TabIndex = 10;
            btnLibros.Text = "Libros";
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 35;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 130);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(293, 50);
            btnInicio.TabIndex = 10;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.MidnightBlue;
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Controls.Add(lblsubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(293, 130);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblsubtitulo
            // 
            lblsubtitulo.AutoSize = true;
            lblsubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsubtitulo.ForeColor = Color.WhiteSmoke;
            lblsubtitulo.Location = new Point(133, 73);
            lblsubtitulo.Name = "lblsubtitulo";
            lblsubtitulo.Size = new Size(138, 20);
            lblsubtitulo.TabIndex = 1;
            lblsubtitulo.Text = "Sistema De Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(115, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.RoyalBlue;
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(293, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1057, 90);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.Silver;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(293, 917);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(1057, 50);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.Gainsboro;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(293, 90);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1057, 827);
            pnlContenido.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(414, 23);
            label1.Name = "label1";
            label1.Size = new Size(269, 40);
            label1.TabIndex = 2;
            label1.Text = "¡Hola, bienvenido!";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 967);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestión Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Label lblsubtitulo;
        private PictureBox pictureBox1;
        private Button btnEditoria;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnSalida;
        private Label label1;
    }
}
