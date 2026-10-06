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
            this.LoadAndRefresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDetalle detalle = new AlquilerDetalle();
                detalle.ShowDialog();
                this.LoadAndRefresh();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDto? selected = this.SelectedItem();
                if (selected == null)
                {
                    return;
                }

                AlquilerDetalle detalle = new AlquilerDetalle(selected);
                detalle.ShowDialog();
                this.LoadAndRefresh();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDto? selected = this.SelectedItem();
                if (selected == null)
                {
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Eliminar alquiler de {selected.Inquilino}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                await AlquilerApiClient.DeleteAsync(selected.Id);
                this.LoadAndRefresh();
            }
            catch (Exception ex)
            {
                this.ProcesarError(ex);
            }
        }

        private void dgvAlquileres_DoubleClick(object sender, EventArgs e)
        {
            this.btnModificar_Click(sender, e);
        }

        private async void LoadAndRefresh()
        {
            try
            {
                this.dgvAlquileres.DataSource = null;
                var data = (await AlquilerApiClient.GetAllAsync()).ToList();
                this.dgvAlquileres.DataSource = data;

                bool hasSelection = data.Count > 0;
                btnModificar.Enabled = hasSelection;
                btnEliminar.Enabled = hasSelection;
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
