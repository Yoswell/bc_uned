namespace progra_vanzada.temas;

using System.Configuration;

class Config {
    static void Main(string[] args) {
        // Obtener la ConnectionString del archivo app.config
        var conn = ConfigurationManager.ConnectionStrings["MiConnectionSql"].ConnectionString;
    }
}