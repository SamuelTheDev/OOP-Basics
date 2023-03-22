
using System;
class Aluno
{
    // Atributos
    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    //Mensagem
    public void mensagem()
    {
        Console.WriteLine("Informa a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informa a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é " + media());
    }
}