namespace progra_avanzada.temas;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.Data.SqlClient;

class Server {
    // Servidor tcp
    private TcpListener _listener;

    // Ip y puerto
    private string _host = "127.0.0.1";
    private int _port = 5000;
    
    // Connection String
    private string _connectionString = "Server=DESKTOP-T5BBINC;Database=PcGamersDB;TrustServerCertificate=True;Integrated Security=True;";

    public Server() =>
        this._listener = new TcpListener(IPAddress.Parse(_host), _port); // Inicializacion del servidor

    // Tarea asincrona (Promesa)
    public async Task Start() {
        try {
            _listener.Start(); // Inicia el servidor

            TcpClient client = await _listener.AcceptTcpClientAsync(); // Recibe la conexion del cliente

            // Colleccion para almacenar la informacion recibida
            using(NetworkStream stream = client.GetStream()) {
                byte[] buffer = new byte[1024]; // 1024 o 4096, sobrara espacio, no hay problema
                int bytesRead = await stream.ReadAsync(buffer); // Se almacena la informacion en el arreglo
                string mensaje = Encoding.UTF8.GetString(buffer); // Se decodifica de bytes a string
                
                // Ejecucion normal de la consulta recivida
                using(SqlConnection connection = new SqlConnection(_connectionString));
                connection.Open();

                using(SqlCommand cmd = new SqlCommand(query, connection));
                using(SqlDataReader reader = cmd.ExecuteReader());
                    List<object> nombres = new();

                    while(reader.Read()) {
                        nombres.Add(reader.GetString(0)); // first_name
                        nombres.Add(reader.GetString(1)); // email
                        nombres.Add(reader.GetString(2)); // username
                        nombres.Add(reader.GetString(3)); // password
                    
                    foreach(var nombre in nombres) Console.WriteLine(nombre);
                }
            }
        } catch(Exception) { }
    }

}