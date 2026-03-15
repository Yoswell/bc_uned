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

            // Colleccion para almacenar la informacion que sera enviada
            using(NetworkStream stream = _client.GetStream()) {
                byte[] data = Encoding.ASCII.GetBytes("SELECT first_name,email,username,password FROM Clientes"); // Se debe de codificar a bytes antes de enviar la consulta
                stream.Write(data);
            }
        } catch(Exception) { }
    }
}