//Atividade HorasExtas Italo Trancoso Lopes

using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Decimal HorasExtras;
        Decimal TotalHorasExtras; 
        Decimal salariobase; //salario definido
        Decimal salariohr; //valor recebido por hora trabalhada
        Decimal HrsTrabalhadas; //horas trabalhadas
        Decimal VlHrExtra; //valor de cada hora extra
        Decimal SalarioTotal;
    
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow; 
        salariohr = PedirValor("Quanto você ganha por hora trabalhada?: R$  ");
        HrsTrabalhadas = PedirValor("Quantas horas você trabalha?:   ");
        HorasExtras = PedirValor("E agora, quantas horas extras você fez?: ");
        Console.ResetColor();

            salariobase = salariohr * HrsTrabalhadas;
            VlHrExtra = salariohr * 1.40m;
            TotalHorasExtras = VlHrExtra * HorasExtras;
            SalarioTotal = salariobase + TotalHorasExtras;

        MostrarResultados(salariobase, TotalHorasExtras, SalarioTotal);
    }
    static Decimal PedirValor(string mensagem)
    {
        Console.Write(mensagem);
        return Convert.ToDecimal(Console.ReadLine());
    }
    static void MostrarResultados(Decimal salariobase, Decimal totalHorasExtras, Decimal SalarioTotal)
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Seu salario base é: R$ {salariobase}");
        Console.WriteLine($"O seu valor de horas extras é: R$ {totalHorasExtras} ");
        Console.WriteLine($"Seu salario Total é: R$ {SalarioTotal}");
        Console.ResetColor();
    }
}