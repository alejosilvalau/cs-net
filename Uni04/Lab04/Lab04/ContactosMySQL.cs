using MySql.Data.MySqlClient;
using System.Data;

namespace Lab04
{
    class ContactosMysql : Contactos
    {
        protected string connectionString
        {
            get
            {
                return "server=localhost;database=net;uid=root;"; //;pwd=123entre";
            }
        }

        public override DataTable getTabla()
        {
            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmdSelect = new MySqlCommand("select * from contactos", Conn);
                Conn.Open();
                MySqlDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new DataTable();
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                Conn.Close();
                return contactos;
            }
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                // Insert Command
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO contactos VALUES(@id, @nombre, @apellido, @email, @telefono)", Conn);
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int32);
                cmdInsert.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdInsert.Parameters.Add("@telefono", MySqlDbType.VarChar);

                // Update Command
                MySqlCommand cmdUpdate = new MySqlCommand("UPDATE contactos SET nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono WHERE id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32);
                cmdUpdate.Parameters.Add("@nombre", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@apellido", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@email", MySqlDbType.VarChar);
                cmdUpdate.Parameters.Add("@telefono", MySqlDbType.VarChar);

                // Delete Command
                MySqlCommand cmdDelete = new MySqlCommand("DELETE FROM contactos WHERE id=@id", Conn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32);

                // Get Changes from DataTable
                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);

                Conn.Open();

                // Process Added Rows
                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                // Process Deleted Rows
                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                // Process Modified Rows
                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                Conn.Close();

                this.misContactos.AcceptChanges();
            }
        }
    }
}