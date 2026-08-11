using System.Data;
using System.Data.OleDb;

namespace Lab02
{
    public class ManejadorArchivoTxt : ManejadorArchivo
    {
        protected string connectionString
        {
            // en este connection string:
            // HDR=Yes          : indica que el primer registro contiene los encabezados (nombres) de las columnas, no datos.
            // FMT=CSVDelimited : indica que el los campos están delimitados por un caracter ,
            // la arroba es para evitar tener que usar \\ para escribir la barra invertida en el string
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Alejo\OneDrive\Escritorio\Job\NET\cs-net\Uni04\Lab02\Lab02\bin\Debug\net8.0;" +
                       "Extended Properties='text;HDR=Yes;FMT=Delimited'";
            }
        }

        public override DataTable GetTabla()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdSelect = new OleDbCommand("select * from agenda.txt", Conn);
                Conn.Open();
                OleDbDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                Conn.Close();
                return contactos;
            }
        }

        public override void AplicaCambios()
        {
            using (OleDbConnection Conn = new OleDbConnection(connectionString))
            {
                OleDbCommand cmdInsert = new OleDbCommand("insert into agenda.txt values(@id, @nombre, @apellido, @email, @telefono)", Conn);
                cmdInsert.Parameters.Add("@id", OleDbType.Integer);
                cmdInsert.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@email", OleDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdUpdate = new OleDbCommand(
                    "update agenda.txt set nombre=@nombre, apellido=@apellido, e-mail=@email, telefono=@telefono where id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", OleDbType.Integer);
                cmdUpdate.Parameters.Add("@nombre", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", OleDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", OleDbType.VarChar);

                OleDbCommand cmdDelete = new OleDbCommand("delete from agenda.txt where id=@id", Conn);
                cmdDelete.Parameters.Add("@id", OleDbType.Integer);

                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);

                Conn.Open();

                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["e-mail"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["e-mail"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}