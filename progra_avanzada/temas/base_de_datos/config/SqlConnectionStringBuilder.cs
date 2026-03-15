namespace progra_vanzada.temas;

using Microsoft.Data.SqlClient;

class Config {
    static void Main(string[] args) {
        // Construccion de la ConnectionString usando SqlClient
        var builder = new SqlConnectionStringBuilder();
        builder.DataSource = "DESKTOP-T5BBINC";
        builder.InitialCatalog = "PcGamersDB";
        builder.IntegratedSecurity = true;  // Windows Auth
        builder.TrustServerCertificate = true;
        builder.ConnectTimeout = 30;

        string connectionString = builder.ConnectionString;
    }
}