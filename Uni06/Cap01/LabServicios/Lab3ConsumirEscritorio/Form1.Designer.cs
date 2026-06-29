namespace Lab3ConsumirEscritorio
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvAlumnos = new DataGridView();
            lblApellido = new Label();
            lblNombre = new Label();
            lblLegajo = new Label();
            lblDireccion = new Label();
            lblId = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtLegajo = new TextBox();
            txtDireccion = new TextBox();
            txtId = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(14, 16);
            dgvAlumnos.Margin = new Padding(3, 4, 3, 4);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(869, 333);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(14, 413);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 453);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(14, 493);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(57, 20);
            lblLegajo.TabIndex = 7;
            lblLegajo.Text = "Legajo:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(14, 533);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(14, 373);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(91, 409);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(228, 27);
            txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 449);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(91, 489);
            txtLegajo.Margin = new Padding(3, 4, 3, 4);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(228, 27);
            txtLegajo.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(91, 529);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(228, 27);
            txtDireccion.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(91, 369);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(366, 369);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 40);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(366, 423);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(114, 40);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(366, 476);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 40);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(503, 369);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(114, 40);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(503, 423);
            btnRefrescar.Margin = new Padding(3, 4, 3, 4);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(114, 40);
            btnRefrescar.TabIndex = 15;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 575);
            Controls.Add(dgvAlumnos);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblLegajo);
            Controls.Add(txtLegajo);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnRefrescar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ABMC Alumnos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblLegajo;
        private Label lblDireccion;
        private Label lblId;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtLegajo;
        private TextBox txtDireccion;
        private TextBox txtId;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnRefrescar;
    }
}
