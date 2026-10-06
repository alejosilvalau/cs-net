using Silva.UI.Desktop.ApiClients;

namespace Silva.UI.Desktop
{
    public partial class AlquilerLista : Form
    {
        public AlquilerLista()
        {
            this.InitializeComponent();
        }

        private void AlquilerLista_Load(object sender, EventArgs e)
        {
            if (this.cboEstado.SelectedIndex < 0)
            {
                this.cboEstado.SelectedIndex = 0;
            }
            this.GetByEstadoAndLoad();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.GetByEstadoAndLoad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDetalle detalle = new AlquilerDetalle();
                detalle.ShowDialog();
                this.GetByEstadoAndLoad();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDto? selected = this.SelectedItem();
                if (selected == null)
                {
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Finalizar alquiler de {selected.Inquilino}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                await AlquilerApiClient.FinalizarAsync(selected.Id);
                this.GetByEstadoAndLoad();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private async void GetByEstadoAndLoad()
        {
            try
            {
                string estado = cboEstado.SelectedItem?.ToString() ?? "Activo";
                this.dgvAlquileres.DataSource = null;
                var data = (await AlquilerApiClient.GetByEstadoAsync(estado)).ToList();
                this.dgvAlquileres.DataSource = data;

                btnFinalizar.Enabled = data.Count > 0 && estado == "Activo";
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private AlquilerDto? SelectedItem()
        {
            if (this.dgvAlquileres.SelectedRows.Count > 0)
            {
                return (AlquilerDto)this.dgvAlquileres.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void ProcesarError(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            MessageBox.Show("Ocurrió un error inesperado.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
