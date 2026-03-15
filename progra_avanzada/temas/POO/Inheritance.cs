namespace progra_avanzada.temas;

using System;

class Animal {
    public string Name { get; set; }

    public void Eat() => 
        Console.WriteLine($"{Name} está comiendo");
    public virtual void MakeSound() => 
        Console.WriteLine($"{Name} hace un sonido");
}

// Clase derivada
class Dog : Animal {
    public void Bark() => 
        Console.WriteLine($"{Name} ladra");
    // Override del metodo MakeSound
    public override void MakeSound() => 
        Console.WriteLine($"{Name} ladra: ¡Guau!");
}

// Otra clase derivada
class Cat : Animal {
    public void Meow() => 
        Console.WriteLine($"{Name} maúlla");
    // Override del metodo MakeSound
    public override void MakeSound() => 
        Console.WriteLine($"{Name} maúlla: ¡Miau!");
}

namespace Example {
    class Inheritance {
        static void Main(string[] args) {
            // Crea una instancia de las clases derivadas
            Dog dog = new Dog { Name = "Rex" };
            Cat cat = new Cat { Name = "Whiskers" };

            // Usar métodos heredados
            dog.Eat(); // La clase Dog no tiene el metodo Eat, pero al heredar de Animal, ahora puede usar los metodos de la clase Animal
            dog.MakeSound();
            dog.Bark();

            cat.Eat(); // La clase Cat no tiene el metodo Eat, pero al heredar de Animal, ahora puede usar los metodos de la clase Animal
            cat.MakeSound();
            cat.Meow();
        }
    }
}
