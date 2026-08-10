using System.Windows.Forms;

namespace AcademiaABM
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            tUsuarios = new ToolStripContainer();
            tAlumnos = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            btnActualizar = new Button();
            btnSalir = new Button();
            tsUsuarios = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tUsuarios.ContentPanel.SuspendLayout();
            tUsuarios.TopToolStripPanel.SuspendLayout();
            tUsuarios.SuspendLayout();
            tAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tsUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // tUsuarios
            // 
            // 
            // tUsuarios.ContentPanel
            // 
            tUsuarios.ContentPanel.Controls.Add(tAlumnos);
            tUsuarios.ContentPanel.Size = new Size(800, 423);
            tUsuarios.Dock = DockStyle.Fill;
            tUsuarios.Location = new Point(0, 0);
            tUsuarios.Name = "tUsuarios";
            tUsuarios.Size = new Size(800, 450);
            tUsuarios.TabIndex = 0;
            tUsuarios.Text = "toolStripContainer1";
            // 
            // tUsuarios.TopToolStripPanel
            // 
            tUsuarios.TopToolStripPanel.Controls.Add(tsUsuarios);
            // 
            // tAlumnos
            // 
            tAlumnos.ColumnCount = 2;
            tAlumnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tAlumnos.ColumnStyles.Add(new ColumnStyle());
            tAlumnos.Controls.Add(dgvUsuarios, 0, 0);
            tAlumnos.Controls.Add(btnActualizar, 0, 1);
            tAlumnos.Controls.Add(btnSalir, 1, 1);
            tAlumnos.Dock = DockStyle.Fill;
            tAlumnos.Location = new Point(0, 0);
            tAlumnos.Name = "tAlumnos";
            tAlumnos.RowCount = 2;
            tAlumnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tAlumnos.RowStyles.Add(new RowStyle());
            tAlumnos.Size = new Size(800, 423);
            tAlumnos.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tAlumnos.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(794, 382);
            dgvUsuarios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(603, 391);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(703, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsUsuarios
            // 
            tsUsuarios.Dock = DockStyle.None;
            tsUsuarios.ImageScalingSize = new Size(20, 20);
            tsUsuarios.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbEliminar });
            tsUsuarios.Location = new Point(7, 0);
            tsUsuarios.Name = "tsUsuarios";
            tsUsuarios.Size = new Size(139, 27);
            tsUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(29, 24);
            tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(29, 24);
            tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(29, 24);
            tsbEliminar.Text = "Eliminar";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tUsuarios);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            tUsuarios.ContentPanel.ResumeLayout(false);
            tUsuarios.TopToolStripPanel.ResumeLayout(false);
            tUsuarios.TopToolStripPanel.PerformLayout();
            tUsuarios.ResumeLayout(false);
            tUsuarios.PerformLayout();
            tAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tsUsuarios.ResumeLayout(false);
            tsUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tUsuarios;
        private TableLayoutPanel tAlumnos;
        private ToolStrip tsUsuarios;
        private DataGridView dgvUsuarios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
    }
}
