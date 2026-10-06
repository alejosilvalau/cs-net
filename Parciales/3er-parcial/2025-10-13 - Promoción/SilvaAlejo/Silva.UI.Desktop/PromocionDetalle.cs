using Silva.UI.Desktop.ApiClients;

namespace Silva.UI.Desktop
{
    public partial class PromocionDetalle : Form
    {
        public PromocionDetalle()
        {
            this.InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.ValidatePromocion())
            {
                return;
            }

            try
            {
                PromocionDto dto = new PromocionDto()
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descuento = nudDescuento.Value,
                    FechaInicio = dtpInicio.Value.Date,
                    FechaFin = dtpFin.Value.Date
                    // Estado no se expone: servicio lo presetea como Activa.
                };

                await PromocionApiClient.AddAsync(dto);
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
        private bool ValidatePromocion()
        {
            bool isValid = true;
            errorProvider.SetError(txtNombre, string.Empty);
            errorProvider.SetError(nudDescuento, string.Empty);
            errorProvider.SetError(dtpInicio, string.Empty);

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                isValid = false;
                errorProvider.SetError(txtNombre, "Nombre es obligatorio.");
            }
            if (nudDescuento.Value < 1 || nudDescuento.Value > 100)
            {
                isValid = false;
                errorProvider.SetError(nudDescuento, "Descuento entre 1 y 100.");
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
