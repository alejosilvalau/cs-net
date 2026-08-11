using System;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable("Empresas");
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True;";

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myConn);

            myConn.Open();
            myAdapter.Fill(dtEmpresas);
            myConn.Close();

            Console.WriteLine("Listado de Empresas: ");
            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idEmpresa = rowEmpresa["CustomerID"].ToString();
                string nombreEmpresa = rowEmpresa["CompanyName"].ToString();
                Console.WriteLine($"ID: {idEmpresa}, Nombre: {nombreEmpresa}");
            }

            Console.WriteLine("\nEscriba el CustomerID que desea modificar: ");
            string? customId = Console.ReadLine();

            DataRow[] RWEmpresas = dtEmpresas.Select($"CustomerID = '{customId}'");
            if (RWEmpresas.Length != 1)
            {
                Console.WriteLine("No se encontró la empresa con el CustomerID proporcionado.");
                Console.ReadLine();
                return;
            }

            DataRow RowMiEmpresa = RWEmpresas[0];
            string NombreActual = RowMiEmpresa["CompanyName"].ToString();
            Console.WriteLine($"Nombre actual: {NombreActual}");
            Console.WriteLine("Escriba el nuevo nombre: ");
            string? NuevoNombre = Console.ReadLine();

            RowMiEmpresa.BeginEdit();
            RowMiEmpresa["CompanyName"] = NuevoNombre;
            RowMiEmpresa.EndEdit();

            SqlCommand UpdCommand = new SqlCommand();
            UpdCommand.Connection = myConn;
            UpdCommand.CommandText = "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            UpdCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            UpdCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            myAdapter.UpdateCommand = UpdCommand;
            myAdapter.Update(dtEmpresas);
        }
    }
}
