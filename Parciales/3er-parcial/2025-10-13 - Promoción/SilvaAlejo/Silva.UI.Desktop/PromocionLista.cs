using Silva.UI.Desktop.ApiClients;

namespace Silva.UI.Desktop
{
    public partial class PromocionLista : Form
    {
        public PromocionLista()
        {
            this.InitializeComponent();
        }

        private void PromocionLista_Load(object sender, EventArgs e)
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
                PromocionDetalle detalle = new PromocionDetalle();
                detalle.ShowDialog();
                this.GetByEstadoAndLoad();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private async void btnExpirar_Click(object sender, EventArgs e)
        {
            try
            {
                PromocionDto? selected = this.SelectedItem();
                if (selected == null)
                {
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Expirar promoción {selected.Nombre}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                await PromocionApiClient.ExpirarAsync(selected.Id);
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
                string estado = cboEstado.SelectedItem?.ToString() ?? "Activa";
                this.dgvPromociones.DataSource = null;
                var data = (await PromocionApiClient.GetByEstadoAsync(estado)).ToList();
                this.dgvPromociones.DataSource = data;

                btnExpirar.Enabled = data.Count > 0 && estado == "Activa";
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private PromocionDto? SelectedItem()
        {
            if (this.dgvPromociones.SelectedRows.Count > 0)
            {
                return (PromocionDto)this.dgvPromociones.SelectedRows[0].DataBoundItem;
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
