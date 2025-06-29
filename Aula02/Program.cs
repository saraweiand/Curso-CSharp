using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sara");
            if (args.Length > 0) // vídeo aula ensinou a utilizar .GetLength(0), mas essa forma não é mais utilizada
            {
                Console.WriteLine(args[0]); // vídeo aula ensinou a utilizar .getValue(0), mas essa forma não é mais utilizada
            }
        }
    }
}