namespace progra_vanzada.temas;

using Microsoft.Extensions.Configuration;

class Config {
    private static IConfiguration _configuration;
    static void Main(string[] args) {
        // Obtener la ConnectionString del archivo appsettings.json
        string connectionString1 = _configuration.GetConnectionString("MiConnectionSql");
    }
}