namespace Silva.UI.Desktop
{
    partial class PromocionLista
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
            dgvPromociones = new DataGridView();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnFiltrar = new Button();
            btnExpirar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            SuspendLayout();
            //
            // dgvPromociones
            //
            dgvPromociones.AllowUserToAddRows = false;
            dgvPromociones.AllowUserToDeleteRows = false;
            dgvPromociones.AllowUserToResizeColumns = false;
            dgvPromociones.AllowUserToResizeRows = false;
            dgvPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Location = new Point(17, 62);
            dgvPromociones.Margin = new Padding(4, 5, 4, 5);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.ReadOnly = true;
            dgvPromociones.RowHeadersWidth = 62;
            dgvPromociones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromociones.Size = new Size(850, 433);
            dgvPromociones.TabIndex = 0;
            //
            // lblEstado
            //
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(17, 22);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 25);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado:";
            //
            // cboEstado
            //
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activa", "Expirada" });
            cboEstado.Location = new Point(90, 18);
            cboEstado.Margin = new Padding(4, 5, 4, 5);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(171, 33);
            cboEstado.TabIndex = 2;
            //
            // btnFiltrar
            //
            btnFiltrar.Location = new Point(271, 15);
            btnFiltrar.Margin = new Padding(4, 5, 4, 5);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(107, 38);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            //
            // btnExpirar
            //
            btnExpirar.Location = new Point(646, 508);
            btnExpirar.Margin = new Padding(4, 5, 4, 5);
            btnExpirar.Name = "btnExpirar";
            btnExpirar.Size = new Size(107, 38);
            btnExpirar.TabIndex = 4;
            btnExpirar.Text = "Expirar";
            btnExpirar.UseVisualStyleBackColor = true;
            btnExpirar.Click += btnExpirar_Click;
            //
            // btnAgregar
            //
            btnAgregar.Location = new Point(760, 508);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 38);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            //
            // PromocionLista
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(btnAgregar);
            Controls.Add(btnExpirar);
            Controls.Add(btnFiltrar);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(dgvPromociones);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PromocionLista";
            Text = "Promociones";
            Load += PromocionLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPromociones;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnFiltrar;
        private Button btnExpirar;
        private Button btnAgregar;
    }
}
