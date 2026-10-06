namespace Silva.UI.Desktop
{
    partial class AlquilerLista
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
            dgvAlquileres = new DataGridView();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnFiltrar = new Button();
            btnFinalizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            SuspendLayout();
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.AllowUserToAddRows = false;
            dgvAlquileres.AllowUserToDeleteRows = false;
            dgvAlquileres.AllowUserToResizeColumns = false;
            dgvAlquileres.AllowUserToResizeRows = false;
            dgvAlquileres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(14, 50);
            dgvAlquileres.Margin = new Padding(3, 4, 3, 4);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.RowHeadersWidth = 62;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(680, 346);
            dgvAlquileres.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(14, 18);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Finalizado" });
            cboEstado.Location = new Point(72, 14);
            cboEstado.Margin = new Padding(3, 4, 3, 4);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(138, 28);
            cboEstado.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(217, 12);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(134, 30);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Actualizar Filtro";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(517, 406);
            btnFinalizar.Margin = new Padding(3, 4, 3, 4);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(86, 30);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 406);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 30);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AlquilerLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 449);
            Controls.Add(btnAgregar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnFiltrar);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(dgvAlquileres);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AlquilerLista";
            Text = "Alquileres";
            Load += AlquilerLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlquileres;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnFiltrar;
        private Button btnFinalizar;
        private Button btnAgregar;
    }
}
