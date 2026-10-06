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
            btnEliminar = new Button();
            btnModificar = new Button();
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
            dgvAlquileres.Location = new Point(14, 14);
            dgvAlquileres.Margin = new Padding(3, 4, 3, 4);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.ReadOnly = true;
            dgvAlquileres.RowHeadersWidth = 62;
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(680, 382);
            dgvAlquileres.TabIndex = 0;
            dgvAlquileres.DoubleClick += dgvAlquileres_DoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(426, 406);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(517, 406);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 30);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(608, 406);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 30);
            btnAgregar.TabIndex = 6;
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
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
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
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}
