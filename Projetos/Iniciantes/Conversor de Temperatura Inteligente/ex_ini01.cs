using System;

class Ex_ini01
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            char escolha;
            float temperatura;
            float res = 0;
            char outra_temp;

            Console.WriteLine("Para qual temperatura você gostaria de converter?");
            Console.WriteLine("A = Celsius");
            Console.WriteLine("B = Fahrenheit");
            Console.WriteLine("C = Kelvin");

            Console.Write("Escolha: ");
            escolha = char.ToUpper(Console.ReadLine()[0]); // lê como string e pega o primeiro caractere

            Console.Write("Temperatura em Celsius que será convertida: ");
            temperatura = float.Parse(Console.ReadLine()); // lê como string e converte para float

            switch (escolha)
            {
                case 'A':
                    Console.WriteLine("A temperatura em Celsius é de {0} °C", temperatura);
                    break;
                case 'B':
                    res = (temperatura * 9 / 5) + 32;
                    Console.WriteLine("A temperatura em Fahrenheit é de {0} °F", res);
                    break;
                case 'C':
                    res = temperatura + (float)273.15;
                    Console.WriteLine("A temperatura em Kelvin é de {0} K", res);
                    break;
                default:
                    Console.WriteLine("Opção incorreta!");
                    break;
            }

            Console.Write("\nCalcular outra temperatura S/N? ");
            outra_temp = char.ToUpper(Console.ReadLine()[0]);
            continuar = (outra_temp == 'S');
            Console.Clear();
        }

        Console.Write("Fim do programa.");
    }
}