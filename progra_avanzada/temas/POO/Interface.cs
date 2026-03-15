namespace progra_avanzada.temas;

using System;

interface Perona { // Definicion de una nueva interfaz
    void Despierta();
    void Trabaja();
    void Duerme();
}

// Clase que implementa una interfaz, se aplica como una herencia y debe implementar todos los metodos de la interfaz, se usa para cuando un metodo es fundamental y sin el, el programa se cae
class Policia : Perona {
    public void Despierta() => 
        Console.WriteLine("Se despierta a las 7:00 am");

    public void Trabaja() => 
        Console.WriteLine("Trabaja hasta las 5:00 pm");

    public void Duerme() => 
        Console.WriteLine("Se duerme a las 9:00 pm");
}

namespace Example {
    class Interfaces {
        static void Main(string[] args) {
            // Usar interfaces
            Policia policia = new Policia();
            policia.Despierta();
            policia.Trabaja();
            policia.Duerme();
        }
    }
}
