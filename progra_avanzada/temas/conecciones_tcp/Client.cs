namespace progra_avanzada.temas;

using System;
using System.Net;
using System.Net.Sockets;

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
            await _client.ConnectAsync(IPAddress.Parse(_host), _port);
            Console.WriteLine("El cliente se inicio correctamente");
        } catch(Exception) { }
    }
}