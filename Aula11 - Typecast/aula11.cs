using System;

class Aula11
{
    static void Main()
    {
        // int n1 = 10;
        // float n2 = n1;   <---------- CONVERSÃO SEGURA

        float n1 = 11.5f;
        int n2 = (int)n1; // TYPECAST

        int vInt = 10;
        short vShort = (short)vInt; // TYPECAST

        Console.WriteLine(vShort);
    }
}