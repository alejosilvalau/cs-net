using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServicios
{
    public partial class Form1 : Form
    {
        private Task<IEnumerable<Alumno>>? _alumnos;
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<Alumno> CargarTabla()
        {
            _alumnos = AlumnoNegocio.GetAll();
            return _alumnos.Result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Alumno>> task = new Task<IEnumerable<Alumno>>(() => CargarTabla());
            task.Start();
            dataGridView1.DataSource = await task;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Alta().ShowDialog();
            button1_Click(sender, e);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || _alumnos == null) { return; }
            int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            await AlumnoNegocio.Delete(_alumnos.Result.ToList()[filaSeleccionada]);
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || _alumnos == null) { return; }
            int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
            new Alta(_alumnos.Result.ToList()[filaSeleccionada]).ShowDialog();
            button1_Click(sender, e);
        }
    }
}
