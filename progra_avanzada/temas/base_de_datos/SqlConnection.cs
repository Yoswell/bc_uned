namespace progra_vanzada.temas;

using System;
using Microsoft.Data.SqlClient;

class Connection {
    static void Main(string[] args) { // Ejemplos de parámetros que puede contener la Connection String
        /*
            Server=DESKTOP-T5BBINC,1433;           // Servidor y puerto
            Database=PcGamersDB;                   // Base de datos
            Username=miUsuario;                    // Usuario SQL
            Password=miContraseña;                 // Contraseña
            TrustServerCertificate=True;           // Certificado SSL
            Integrated Security=False;             // No usar Windows Auth
            Connection Timeout=30;                 // Timeout en segundos
            Pooling=true;                          // Usar connection pooling
            Min Pool Size=5;                       // Mínimo de conexiones
            Max Pool Size=100;                     // Máximo de conexiones
            MultipleActiveResultSets=true;         // Múltiples resultados
            Encrypt=true;                          // Encriptar conexión
        */

        string connectionString = "Server=VISHOK;Database=TiendaPCGamers;TrustServerCertificate=True;Integrated Security=True;";
        
        // Forma tradicional de manejar conexiones (requiere Dispose o Close manual)
        SqlConnection conn_1 = new SqlConnection(connectionString);
        conn_1.Open(); // Inicia la conexion
        conn_1.Close(); // Cierra la conexion
        
        // Forma moderna usando 'using' (automático Dispose)
        using (SqlConnection conn_2 = new SqlConnection(connectionString));
        conn_2.Open();
    }
}
