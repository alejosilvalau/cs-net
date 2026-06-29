using Dominio;
using System.Net.Http.Json;
using System.Text.Json;

namespace Lab3ConsumirEscritorio
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5012")
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarAlumnos();
        }

        private List<Alumno> ParseAlumnos(JsonElement[] elementos)
        {
            List<Alumno> alumnos = new();
            foreach (var el in elementos)
            {
                Alumno a = new(
                    el.GetProperty("apellido").GetString()!,
                    el.GetProperty("nombre").GetString()!,
                    el.GetProperty("legajo").GetInt32(),
                    el.GetProperty("direccion").GetString()!
                );
                a.setId(el.GetProperty("id").GetInt32());
                alumnos.Add(a);
            }
            return alumnos;
        }

        private async Task CargarAlumnos()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("alumnos");
                string json = await response.Content.ReadAsStringAsync();
                JsonElement[] elementos = JsonSerializer.Deserialize<JsonElement[]>(json)!;
                dgvAlumnos.DataSource = ParseAlumnos(elementos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtLegajo.Clear();
            txtDireccion.Clear();
            txtId.Focus();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtLegajo.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var alumno = new
                {
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text,
                    Legajo = int.Parse(txtLegajo.Text),
                    Direccion = txtDireccion.Text
                };

                HttpResponseMessage response = await _httpClient.PostAsJsonAsync("alumnos", alumno);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Alumno agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await CargarAlumnos();
                }
                else
                {
                    MessageBox.Show("Error al agregar alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El legajo debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Ingrese el ID del alumno a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtLegajo.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtId.Text);
                Alumno alumno = new Alumno(txtApellido.Text, txtNombre.Text, int.Parse(txtLegajo.Text), txtDireccion.Text);
                alumno.setId(id);

                HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"alumnos/{id}", alumno);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Alumno modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await CargarAlumnos();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Alumno no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error al modificar alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID y el legajo deben ser números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Ingrese el ID del alumno a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtId.Text);

                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el alumno con ID {id}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = await _httpClient.DeleteAsync($"alumnos/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        await CargarAlumnos();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Alumno no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Ingrese el ID del alumno a consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(txtId.Text);
                HttpResponseMessage response = await _httpClient.GetAsync($"alumnos/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JsonElement el = JsonSerializer.Deserialize<JsonElement>(json);

                    txtId.Text = el.GetProperty("id").GetInt32().ToString();
                    txtApellido.Text = el.GetProperty("apellido").GetString();
                    txtNombre.Text = el.GetProperty("nombre").GetString();
                    txtLegajo.Text = el.GetProperty("legajo").GetInt32().ToString();
                    txtDireccion.Text = el.GetProperty("direccion").GetString();
                }
                else
                {
                    MessageBox.Show("Alumno no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            await CargarAlumnos();
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                txtId.Text = dgvAlumnos.CurrentRow.Cells["Id"].Value?.ToString();
                txtApellido.Text = dgvAlumnos.CurrentRow.Cells["Apellido"].Value?.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value?.ToString();
                txtLegajo.Text = dgvAlumnos.CurrentRow.Cells["Legajo"].Value?.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["Direccion"].Value?.ToString();
            }
        }
    }
}
