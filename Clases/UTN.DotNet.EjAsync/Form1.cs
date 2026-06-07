using System.Diagnostics;

namespace UTN.DotNet.EjAsync
{
    public partial class Form1 : Form
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            IniciarMedicion();

            lblResultado1.Text = EjecutarTrabajo();
            lblResultado2.Text = EjecutarTrabajo();
            lblResultado3.Text = EjecutarTrabajo();

            DetenerMedicion();
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            IniciarMedicion();

            lblResultado1.Text = await EjecutarTrabajoAsync();
            lblResultado2.Text = await EjecutarTrabajoAsync();
            lblResultado3.Text = await EjecutarTrabajoAsync();

            DetenerMedicion();
        }

        private async void btnAsyncP_Click(object sender, EventArgs e)
        {
            IniciarMedicion();

            Task<string> trabajo1 = EjecutarTrabajoAsync();
            Task<string> trabajo2 = EjecutarTrabajoAsync();
            Task<string> trabajo3 = EjecutarTrabajoAsync();

            string[] resultados = await Task.WhenAll(trabajo1, trabajo2, trabajo3);

            lblResultado1.Text = resultados[0];
            lblResultado2.Text = resultados[1];
            lblResultado3.Text = resultados[2];

            DetenerMedicion();
        }

        private static string EjecutarTrabajo()
        {
            Thread.Sleep(2000);
            return Guid.NewGuid().ToString();
        }

        private static async Task<string> EjecutarTrabajoAsync()
        {
            await Task.Delay(2000);
            return Guid.NewGuid().ToString();
        }

        private void IniciarMedicion()
        {
            lblResultado1.Text = lblResultado2.Text = lblResultado3.Text = lblTiempoTotal.Text = "--";
            _stopwatch.Restart();
        }

        private void DetenerMedicion()
        {
            _stopwatch.Stop();
            lblTiempoTotal.Text = $"{_stopwatch.ElapsedMilliseconds}ms";
        }
    }
}
