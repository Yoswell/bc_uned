namespace progra_avanzada.temas;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Client {
    // Cliente tcp
    private TcpClient _client;

    // Ip y puerto
    private string _host = "127.0.0.1";
    private int _port = 5000;

    public Client() =>
        this._client = new TcpClient();  // Inicializacion del cliente

    // Tarea asincrona (Promesa)
    public async Task start() {
        try {
            await _client.ConnectAsync(IPAddress.Parse(_host), _port); // Inicia la conexcion con el servidor

            Cliente _cliente = new Cliente(602340265, "Julian", "uyyuq8817282hjAan"); // Instancia de un nuevo objeto, proceso de log in

            // Colleccion para almacenar la informacion que sera enviada
            using(NetworkStream stream = _client.GetStream()) {
                string json = JsonSerializer.Serialize(_cliente); // La informacion se debe serializar a json para anviarla como objeto
                byte[] data = Encoding.ASCII.GetBytes(json); // Se debe de codificar a bytes antes de enviar la informacion
                await stream.WriteAsync(data);
            }
        } catch(Exception) { }
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