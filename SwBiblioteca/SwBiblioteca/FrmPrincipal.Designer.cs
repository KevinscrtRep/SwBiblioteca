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
            btnSalida = new Button();
            btnReportes = new Button();
            btnPrestamos = new Button();
            btnEditoriales = new Button();
            btnAutores = new Button();
            btnUsuarios = new Button();
            btnLibros = new Button();
            btnInicio = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            lblsubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlMenu.Size = new Size(293, 582);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalida
            // 
            btnSalida.Dock = DockStyle.Top;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalida.ForeColor = Color.Black;
            btnSalida.Location = new Point(0, 480);
            btnSalida.Margin = new Padding(10, 0, 10, 0);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(293, 50);
            btnSalida.TabIndex = 8;
            btnSalida.Text = "Salida";
            btnSalida.TextAlign = ContentAlignment.MiddleLeft;
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.Black;
            btnReportes.Location = new Point(0, 430);
            btnReportes.Margin = new Padding(10, 0, 10, 0);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(293, 50);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.ForeColor = Color.Black;
            btnPrestamos.Location = new Point(0, 380);
            btnPrestamos.Margin = new Padding(10, 0, 10, 0);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(293, 50);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnEditoriales
            // 
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.ForeColor = Color.Black;
            btnEditoriales.Location = new Point(0, 330);
            btnEditoriales.Margin = new Padding(10, 0, 10, 0);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(293, 50);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.ForeColor = Color.Black;
            btnAutores.Location = new Point(0, 280);
            btnAutores.Margin = new Padding(10, 0, 10, 0);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(293, 50);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleLeft;
            btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(0, 230);
            btnUsuarios.Margin = new Padding(10, 0, 10, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(293, 50);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.ForeColor = Color.Black;
            btnLibros.Location = new Point(0, 180);
            btnLibros.Margin = new Padding(10, 0, 10, 0);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(293, 50);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(0, 130);
            btnInicio.Margin = new Padding(10, 0, 10, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(293, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += this.btnInicio_Click;
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
            pnlSuperior.BackColor = Color.LightBlue;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(293, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(783, 90);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.Silver;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(293, 532);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(783, 50);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.Gainsboro;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(293, 90);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(783, 442);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 582);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestión Biblioteca";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnInicio;
        private Button btnEditoriales;
        private Button btnAutores;
        private Button btnUsuarios;
        private Button btnLibros;
        private Button btnSalida;
        private Button btnReportes;
        private Button btnPrestamos;
    }
}
