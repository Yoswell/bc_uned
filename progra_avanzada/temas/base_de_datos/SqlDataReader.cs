namespace progra_vanzada.temas;

using System;
using Microsoft.Data.SqlClient;

class Reader {
    static void Main(string[] args) {
        string connectionString = "Server=VISHOK;Database=TiendaPCGamers;TrustServerCertificate=True;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString));
        connection.Open();

        // Consulta SELECT
        string selectQuery = "SELECT ProductoID, Nombre, Descripcion, Precio, Stock FROM Productos WHERE Stock > 0";
        using (SqlCommand cmd = new SqlCommand(selectQuery, connection));
        using (SqlDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
                int id = reader.GetInt32(0); // ProductoID
                string nombre = reader.GetString(1); // Nombre
                string descripcion = reader.GetString(2); // Descripcion
                decimal precio = reader.GetDecimal(3); // Precio
                int stock = reader.GetInt32(4); // Stock
            }
        }
    }
}
