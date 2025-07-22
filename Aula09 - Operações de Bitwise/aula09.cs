using System;

class Aula09
{
    static void Main()
    {
        int num = 10;
        int num2 = 10;
        int num3 = 2;

        num <<= 1;
        num2 >>= 1;
        num3 <<= 2;

        Console.WriteLine(num);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}



// Bitwise para a esquerda DOBRA o valor (<<)
// Bitwise para a direita REDUZ pela metade o valor (>>)