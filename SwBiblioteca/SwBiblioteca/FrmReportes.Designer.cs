namespace SwBiblioteca
{
    partial class FrmReportes
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
            pnlOpciones = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            panel1 = new Panel();
            dgvReportes = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlOpciones.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
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
            pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(576, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(332, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE REPORTES";
            // 
            // pnlOpciones
            // 
            pnlOpciones.BackColor = Color.WhiteSmoke;
            pnlOpciones.Controls.Add(btnLimpiar);
            pnlOpciones.Controls.Add(btnGenerar);
            pnlOpciones.Controls.Add(cmbTipoReporte);
            pnlOpciones.Controls.Add(lblTipoReporte);
            pnlOpciones.Dock = DockStyle.Top;
            pnlOpciones.Location = new Point(0, 70);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(1350, 238);
            pnlOpciones.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.BackgroundImageLayout = ImageLayout.None;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 30;
            btnLimpiar.Location = new Point(746, 121);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(202, 56);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.White;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerar.IconSize = 30;
            btnGenerar.Location = new Point(520, 121);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(202, 56);
            btnGenerar.TabIndex = 13;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 11F);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(602, 45);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(346, 28);
            cmbTipoReporte.TabIndex = 6;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(406, 45);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(161, 25);
            lblTipoReporte.TabIndex = 5;
            lblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvReportes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 659);
            panel1.TabIndex = 5;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 0);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1350, 659);
            dgvReportes.TabIndex = 3;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 967);
            Controls.Add(panel1);
            Controls.Add(pnlOpciones);
            Controls.Add(pnlTitulo);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReportes";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlOpciones;
        private ComboBox cmbTipoReporte;
        private Label lblTipoReporte;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private Panel panel1;
        private DataGridView dgvReportes;
    }
}