namespace Silva.UI.Desktop
{
    partial class PromocionDetalle
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescuento = new Label();
            nudDescuento = new NumericUpDown();
            lblInicio = new Label();
            dtpInicio = new DateTimePicker();
            lblFin = new Label();
            dtpFin = new DateTimePicker();
            lblNota = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 22);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre (*):";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(143, 18);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 31);
            txtNombre.TabIndex = 1;
            //
            // lblDescuento
            //
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(17, 63);
            lblDescuento.Margin = new Padding(4, 0, 4, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(118, 25);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Dto % (1-100):";
            //
            // nudDescuento
            //
            nudDescuento.Location = new Point(143, 60);
            nudDescuento.Margin = new Padding(4, 5, 4, 5);
            nudDescuento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDescuento.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(238, 31);
            nudDescuento.TabIndex = 3;
            nudDescuento.Value = new decimal(new int[] { 25, 0, 0, 0 });
            //
            // lblInicio
            //
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(17, 105);
            lblInicio.Margin = new Padding(4, 0, 4, 0);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(110, 25);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Fecha inicio:";
            //
            // dtpInicio
            //
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(143, 100);
            dtpInicio.Margin = new Padding(4, 5, 4, 5);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(238, 31);
            dtpInicio.TabIndex = 5;
            //
            // lblFin
            //
            lblFin.AutoSize = true;
            lblFin.Location = new Point(17, 147);
            lblFin.Margin = new Padding(4, 0, 4, 0);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(89, 25);
            lblFin.TabIndex = 6;
            lblFin.Text = "Fecha fin:";
            //
            // dtpFin
            //
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(143, 142);
            dtpFin.Margin = new Padding(4, 5, 4, 5);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(238, 31);
            dtpFin.TabIndex = 7;
            //
            // lblNota
            //
            lblNota.AutoSize = true;
            lblNota.Location = new Point(17, 188);
            lblNota.Margin = new Padding(4, 0, 4, 0);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(362, 25);
            lblNota.TabIndex = 8;
            lblNota.Text = "Estado se setea automático como Activa.";
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(190, 228);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(291, 228);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // errorProvider
            //
            errorProvider.ContainerControl = this;
            //
            // PromocionDetalle
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 281);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblNota);
            Controls.Add(dtpFin);
            Controls.Add(lblFin);
            Controls.Add(dtpInicio);
            Controls.Add(lblInicio);
            Controls.Add(nudDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PromocionDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Promoción";
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescuento;
        private NumericUpDown nudDescuento;
        private Label lblInicio;
        private DateTimePicker dtpInicio;
        private Label lblFin;
        private DateTimePicker dtpFin;
        private Label lblNota;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
