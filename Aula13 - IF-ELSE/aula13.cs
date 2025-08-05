using System;

class Aula13
{
    static void Main()
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado;

        Console.WriteLine("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());


        res = n1 + n2 + n3 + n4;

        if (res >= 60)
        {
            resultado = "Aprovado";
        }
        else
        {
            resultado = "Reprovado";
        }

        Console.WriteLine(resultado);
        Console.WriteLine("Soma das notas: {0}", res);
    }
}