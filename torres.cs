using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nomOrigen, string nomDestino, string nomAuxiliar)
    {
        if (n == 1)
        {
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco 1 de {nomOrigen} a {nomDestino}");
            return;
        }

        MoverDiscos(n - 1, origen, auxiliar, destino, nomOrigen, nomAuxiliar, nomDestino);

        destino.Push(origen.Pop());
        Console.WriteLine($"Mover disco {n} de {nomOrigen} a {nomDestino}");

        MoverDiscos(n - 1, auxiliar, destino, origen, nomAuxiliar, nomDestino, nomOrigen);
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        MoverDiscos(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}
