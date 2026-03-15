namespace progra_avanzada.temas;

using System;
using System.Net;
using System.Net.Sockets;

class Server {
    // Servidor tcp
    private TcpListener _listener;

    // Ip y puerto
    private string _host = "127.0.0.1";
    private int _port = 5000;

    // Lista de clientes conectados
    private List<TcpClient> _clientes = new List<TcpClient>();

    public Server() => 
        this._listener = new TcpListener(IPAddress.Parse(_host), _port); // Inicializacion del servidor

    // Tarea asincrona (Promesa)
    public async Task Start() {
        try {
            _listener.Start(); // Inicia el servidor

            while (true) {
                var client = await _listener.AcceptTcpClientAsync(); // Recibe la conexion del cliente
                _clientes.Add(client);

                Console.WriteLine($"Cliente conectado. Total: {_clientes.Count}"); // Contador de clientes
                
                _ = Task.Run(() => {
                    // Colleccion para almacenar la informacion recibida
                    using(NetworkStream stream = client.GetStream()) {
                        byte[] buffer = new byte[1024]; // 1024 o 4096, sobrara espacio, no hay problema
                        int bytesRead = await stream.ReadAsync(buffer); // Se almacena la informacion en el arreglo

                        string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        var cliente = JsonSerializer.Deserialize<Cliente>(json);

                        Console.WriteLine($"Cliente con Id: {cliente?.Id} y nombre de usuario: {cliente?.Username} se logueo corretamente");
                    }
                });
            }
        } catch (Exception) { }
    }
}

class Cliente {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public Cliente(int id, string username, string password) {
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }
}