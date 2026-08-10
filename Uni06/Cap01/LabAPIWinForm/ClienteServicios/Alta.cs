using Entidades;
using Negocio;
using System;
using System.Windows.Forms;

namespace ClienteServicios
{
    public partial class Alta : Form
    {
        public Alta() { InitializeComponent(); }

        public Alta(Alumno alumnoModificar)
        {
            InitializeComponent();
            button1.Text = "Modificar";
            textBox1.Text = alumnoModificar.DNI;
            textBox1.Enabled = false;
            textBox2.Text = alumnoModificar.ApellidoNombre;
            textBox3.Text = alumnoModificar.Email;
            dateTimePicker1.Value = alumnoModificar.FechaNacimiento;
            numericUpDown1.Value = alumnoModificar.NotaPromedio;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            Alumno a = new Alumno();
            a.DNI = textBox1.Text;
            a.ApellidoNombre = textBox2.Text;
            a.Email = textBox3.Text;
            a.FechaNacimiento = dateTimePicker1.Value;
            a.NotaPromedio = Convert.ToDecimal(numericUpDown1.Text);

            if (button1.Text == "Modificar") { await AlumnoNegocio.Update(a); }
            else { await AlumnoNegocio.Add(a); }

            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
