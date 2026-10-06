using Silva.UI.Desktop.ApiClients;

namespace Silva.UI.Desktop
{
    public partial class AlquilerDetalle : Form
    {
        private readonly AlquilerDto? _editing;

        public AlquilerDetalle()
        {
            this.InitializeComponent();
        }

        public AlquilerDetalle(AlquilerDto alquiler)
            : this()
        {
            _editing = alquiler;
        }

        private void AlquilerDetalle_Load(object sender, EventArgs e)
        {
            if (_editing != null)
            {
                this.Text = "Modificar Alquiler";
                txtInquilino.Text = _editing.Inquilino;
                nudMonto.Value = Math.Min(Math.Max(_editing.MontoAlquiler, nudMonto.Minimum), nudMonto.Maximum);
                dtpInicio.Value = _editing.FechaInicio;
                dtpFin.Value = _editing.FechaFin;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.ValidateAlquiler())
            {
                return;
            }

            try
            {
                AlquilerDto dto = new AlquilerDto()
                {
                    Inquilino = txtInquilino.Text.Trim(),
                    MontoAlquiler = nudMonto.Value,
                    FechaInicio = dtpInicio.Value.Date,
                    FechaFin = dtpFin.Value.Date
                };

                if (_editing == null)
                {
                    await AlquilerApiClient.AddAsync(dto);
                }
                else
                {
                    dto.Id = _editing.Id;
                    await AlquilerApiClient.UpdateAsync(_editing.Id, dto);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Ocurrió un error inesperado al guardar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ejemplo de validación del lado del frontend.
        /// </summary>
        /// <returns></returns>
        private bool ValidateAlquiler()
        {
            bool isValid = true;
            errorProvider.SetError(txtInquilino, string.Empty);
            errorProvider.SetError(nudMonto, string.Empty);
            errorProvider.SetError(dtpInicio, string.Empty);

            if (string.IsNullOrWhiteSpace(txtInquilino.Text))
            {
                isValid = false;
                errorProvider.SetError(txtInquilino, "Inquilino es obligatorio.");
            }
            if (nudMonto.Value < 0 || nudMonto.Value > 1000000)
            {
                isValid = false;
                errorProvider.SetError(nudMonto, "Monto entre 0 y 1.000.000.");
            }
            if (dtpInicio.Value.Date >= dtpFin.Value.Date)
            {
                isValid = false;
                errorProvider.SetError(dtpInicio, "FechaInicio debe ser inferior a FechaFin.");
            }

            return isValid;
        }
    }
}
