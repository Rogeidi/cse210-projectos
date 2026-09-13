using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emp1 = new Emprego();
        emp1._cargo = "Engenheiro de Software";
        emp1._empresa = "Microsoft";
        emp1._anoInicio = 2019;
        emp1._anoFim = 2022;

        Emprego emp2 = new Emprego();
        emp2._cargo = "Gerente de projetos";
        emp2._empresa = "Google";
        emp2._anoInicio = 2022;
        emp2._anoFim = 2025;

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Carlos Silva";

        meuCurriculo._empregos.Add(emp1);
        meuCurriculo._empregos.Add(emp2);

        meuCurriculo.ExibirCurriculo();


    }
}