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

    public Server() => 
        this._listener = new TcpListener(IPAddress.Parse(_host), _port); // Inicializacion del servidor

    // Tarea asincrona (Promesa)
    public async Task start() {
        try {
            _listener.Start(); // Inicia el servidor
        } catch(Exception) { }
    }
}