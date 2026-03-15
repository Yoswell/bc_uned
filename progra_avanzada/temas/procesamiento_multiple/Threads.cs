namespace progra_avanzada.temas;

using System;
using System.Threading;

class ThreadsExample {
    static void Main(string[] args) {
        // Llamar el metodo ImprimirNumero dento de un hilo
        Thread thread1 = new Thread(ImprimirNumero("Proceso N1"));
        thread1.Start();

        Thread thread2 = new Thread(ImprimirNumero("Proceso N2"));
        thread2.Start();

        // Delay que retrasa la ejecucion del metodo
        Thread.Sleep(100);

        // Esperar hasta que terminen ambos procesos, puede finalizar el Proceso N2 de primero, asi son los hilos, inician igual, pero puede que no terminen igual
        thread1.Join();
        thread2.Join();
    }

    static void ImprimirNumero(string name) {
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"{name}: {i}");
            Thread.Sleep(100); // Delay para visualmente ver como es que se imprimen los numeros
        }
    }
}
