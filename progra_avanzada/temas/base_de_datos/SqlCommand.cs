namespace progra_vanzada.temas;

using System;
using Microsoft.Data.SqlClient;

namespace Databases_1 {
    class Command {
        static void Main(string[] args) {
            string connectionString = "Server=VISHOK;Database=TiendaPCGamers;TrustServerCertificate=True;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString));
            connection.Open();

            // Consulta de tipo INSERT
            string insertQuery = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaID, MarcaID, Imagen, FechaCreacion) VALUES ('ASUS ROG Strix RTX 5090', 'GPU NVIDIA de gama alta.', 2799.99, 8, 1, 1, 'imagenes/rtx5090.jpg', '2025-11-01 12:00:59')";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection));
            int row = cmd.ExecuteNonQuery(); // Devuelve el numero de filas afectadas

            if(row > 0) Console.WriteLine("Producto insertado");
        }
    }
}

namespace Databases_2 {
    class Command {
        static void Main(string[] args) {
            string connectionString = "Server=VISHOK;Database=TiendaPCGamers;TrustServerCertificate=True;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString));
            connection.Open();

            // Consulta de tipo INSERT
            string parameterizedQuery = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock) VALUES (@nombre, @descripcion, @precio, @stock)";

            using (SqlCommand cmd = new SqlCommand(parameterizedQuery, connection)); // Insersion por parametros
            cmd.Parameters.AddWithValue("@nombre", "Logitech MX Master 3");
            cmd.Parameters.AddWithValue("@descripcion", "Mouse inalámbrico ergonómico");
            cmd.Parameters.AddWithValue("@precio", 99.99m);
            cmd.Parameters.AddWithValue("@stock", 15);

            var row = cmd.ExecuteScalar(); // Devuelve la columna de la primera fila

            if(row != null) Console.WriteLine("Producto insertado");
        }
    }
}