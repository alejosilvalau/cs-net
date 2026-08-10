using Models;
using System.Reflection;

namespace AcademiaABM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            // 1. Limpiar e inicializar la grilla
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();

            // 2. Definir las 5 columnas estructurales
            dgvUsuarios.Columns.Add("nombreColumna", "Nombre Columna");
            dgvUsuarios.Columns.Add("cabecera", "Cabecera");
            dgvUsuarios.Columns.Add("origenDatos", "Origen de datos");
            dgvUsuarios.Columns.Add("tipoColumna", "Tipo Columna");
            dgvUsuarios.Columns.Add("valor", "Valor");

            var usuarios = new List<Usuario>
    {
        new Usuario { DNI = "12345678", ApellidoNombre = "Juan Pérez", Email = "juan.perez@email.com", FechaNacimiento = new DateTime(1990, 1, 1), NotaPromedio = 8.5m },
        new Usuario { DNI = "87654321", ApellidoNombre = "María Gómez", Email = "maria.gomez@email.com", FechaNacimiento = new DateTime(1992, 5, 15), NotaPromedio = 9.2m },
        new Usuario { DNI = "11223344", ApellidoNombre = "Carlos López", Email = "carlos.lopez@email.com", FechaNacimiento = new DateTime(1988, 10, 30), NotaPromedio = 7.8m }
    };

            // 3. Obtener las propiedades del objeto Usuario vía Reflection
            PropertyInfo[] propiedades = typeof(Usuario).GetProperties();

            // 4. Recorrer cada usuario y volcar cada propiedad como una fila
            foreach (var usuario in usuarios)
            {
                foreach (var prop in propiedades)
                {
                    string nombreProp = prop.Name;
                    object valorRaw = prop.GetValue(usuario);

                    // Formato visual para los valores
                    string valorFormateado = valorRaw switch
                    {
                        DateTime dt => dt.ToString("dd/MM/yyyy"),
                        _ => valorRaw?.ToString() ?? ""
                    };

                    // Determinar el tipo de columna (Texto, Check, etc.)
                    string tipoCol = prop.PropertyType == typeof(bool) ? "Check" : "Texto";

                    // Agregar la fila a la grilla
                    dgvUsuarios.Rows.Add(
                        nombreProp.ToLower(), // Nombre Columna (ej: dni)
                        nombreProp,           // Cabecera (ej: DNI)
                        nombreProp,           // Origen de datos (ej: DNI)
                        tipoCol,              // Tipo Columna (Texto / Check)
                        valorFormateado       // Valor real guardado en el objeto
                    );
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
