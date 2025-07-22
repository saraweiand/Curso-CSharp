using System;

class Aula09
{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main()
    {
        // DiasSemana ds = DiasSemana.Domingo;
        // DiasSemana ds = (DiasSemana)3;
        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}