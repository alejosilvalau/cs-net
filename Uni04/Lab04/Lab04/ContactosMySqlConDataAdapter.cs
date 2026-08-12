using MySql.Data.MySqlClient;
using System.Data;

namespace Lab04
{
    internal class ContactosMySqlConDataAdapter : Contactos
    {
        protected MySqlDataAdapter adapter;
        protected string connectionString
        {
            get
            {
                return "server=localhost;database=net;uid=root;"; //;pwd=123entre";
            }
        }

        public override DataTable getTabla()
        {
            this.adapter = new MySqlDataAdapter("select * from contactos", this.connectionString);
            DataTable contactos = new DataTable();
            this.adapter.Fill(contactos);
            return contactos;
        }

        public ContactosMySqlConDataAdapter() : base()
        {
            // Insert Command
            this.adapter.InsertCommand = new MySqlCommand("INSERT INTO contactos VALUES(@id, @nombre, @apellido, @email, @telefono)");
            this.adapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            this.adapter.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            this.adapter.InsertCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            this.adapter.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            this.adapter.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            // Update Command
            this.adapter.UpdateCommand = new MySqlCommand("UPDATE contactos SET nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono WHERE id=@id");
            this.adapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            this.adapter.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            this.adapter.UpdateCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            this.adapter.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            this.adapter.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            // Delete Command
            this.adapter.DeleteCommand = new MySqlCommand("DELETE FROM contactos WHERE id=@id");
            this.adapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection Conn = new MySqlConnection(this.connectionString))
            {
                this.adapter.InsertCommand.Connection = Conn;
                this.adapter.UpdateCommand.Connection = Conn;
                this.adapter.DeleteCommand.Connection = Conn;

                this.adapter.Update(this.misContactos);
            }
        }
    }
}
