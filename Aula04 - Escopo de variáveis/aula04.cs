using System;

class Aula04
{
    static int num = 10; // variável global
    static void Main()
    {
        int num2 = 0; // tem o escopo do método MAIN, é uma variável local
        Console.WriteLine(num);
    } // método MAIN finalizado
}