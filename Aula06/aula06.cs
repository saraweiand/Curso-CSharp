using System;

class Aula06
{
    static void Main()
    {
        // int n1, n2, n3;
        // n1 = 10; n2 = 20; n3 = 30;

        // Console.WriteLine(n1 + ", " + n2 + ", " + n3); - concatenação
        // Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3); // índices
        // Console.WriteLine("\nn1 = {0}\nn2 = {1}\nn3 = {2}\n", n1, n2, n3); // quebra de linha
        // Console.WriteLine("\nn1 =\t{0}\nn2 =\t{1}\nn3 =\t{2}\n", n1, n2, n3); // tabulação (espaçamento)

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto........:{0, 15}", produto); // 15 significa o espaçamento
        Console.WriteLine("Valor de compra:{0, 15:c}", valorCompra); // monetário
        Console.WriteLine("Lucro..........:{0, 15:p}", lucro); // porcentagem
        Console.WriteLine("Valor de venda.:{0, 15:c}", valorVenda);
    }
}