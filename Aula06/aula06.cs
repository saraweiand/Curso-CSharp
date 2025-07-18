using System;

class Aula06
{
    static void Main()
    {
        int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;

        // Console.WriteLine(n1 + ", " + n2 + ", " + n3); - concatenação
        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3); // índices
        Console.WriteLine("\nn1 = {0}\nn2 = {1}\nn3 = {2}\n", n1, n2, n3); // quebra de linha
        Console.WriteLine("\nn1 =\t{0}\nn2 =\t{1}\nn3 =\t{2}\n", n1, n2, n3); // tabulação (espaçamento)
    }
}