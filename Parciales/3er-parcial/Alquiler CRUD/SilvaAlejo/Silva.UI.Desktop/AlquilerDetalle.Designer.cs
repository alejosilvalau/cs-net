namespace Silva.UI.Desktop
{
    partial class AlquilerDetalle
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
            lblInquilino = new Label();
            txtInquilino = new TextBox();
            lblMonto = new Label();
            nudMonto = new NumericUpDown();
            lblInicio = new Label();
            dtpInicio = new DateTimePicker();
            lblFin = new Label();
            dtpFin = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblInquilino
            // 
            lblInquilino.AutoSize = true;
            lblInquilino.Location = new Point(14, 18);
            lblInquilino.Name = "lblInquilino";
            lblInquilino.Size = new Size(90, 20);
            lblInquilino.TabIndex = 0;
            lblInquilino.Text = "Inquilino (*):";
            // 
            // txtInquilino
            // 
            txtInquilino.Location = new Point(128, 13);
            txtInquilino.Margin = new Padding(3, 4, 3, 4);
            txtInquilino.Name = "txtInquilino";
            txtInquilino.Size = new Size(203, 27);
            txtInquilino.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(14, 50);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(105, 20);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto (0-1M):";
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Location = new Point(128, 47);
            nudMonto.Margin = new Padding(3, 4, 3, 4);
            nudMonto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(202, 27);
            nudMonto.TabIndex = 3;
            nudMonto.Value = new decimal(new int[] { 430000, 0, 0, 0 });
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(14, 84);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(90, 20);
            lblInicio.TabIndex = 4;
            lblInicio.Text = "Fecha inicio:";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(128, 79);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(203, 27);
            dtpInicio.TabIndex = 5;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(14, 118);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(71, 20);
            lblFin.TabIndex = 6;
            lblFin.Text = "Fecha fin:";
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(128, 113);
            dtpFin.Margin = new Padding(3, 4, 3, 4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(203, 27);
            dtpFin.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(152, 152);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 152);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AlquilerDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 195);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFin);
            Controls.Add(lblFin);
            Controls.Add(dtpInicio);
            Controls.Add(lblInicio);
            Controls.Add(nudMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtInquilino);
            Controls.Add(lblInquilino);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlquilerDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar Alquiler";
            Load += AlquilerDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInquilino;
        private TextBox txtInquilino;
        private Label lblMonto;
        private NumericUpDown nudMonto;
        private Label lblInicio;
        private DateTimePicker dtpInicio;
        private Label lblFin;
        private DateTimePicker dtpFin;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
