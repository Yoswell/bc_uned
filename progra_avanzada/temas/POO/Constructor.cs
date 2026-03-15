namespace progra_avanzada.temas;

using System;

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public static int Count { get; private set; }

    // Inicializacion de atributos al iniciar el programa
    public Person() {  // Deben tener el mismo nombre de la clase
        Name = "Desconocido";
        Age = 0;
        Count++;
    }

    // Inicializacion de atributos al crear un objeto
    public Person(string name, int age) { // Deben tener el mismo nombre de la clase
        Name = name;
        Age = age;
        Count++;
    }
}
