using System;

class Gerente : Imposto 
{
    //Metodos
    //sobrescrevendo o MÉTODO dentro da classe imposto >> Tem que colocar a palavra reservada OVERRIDE
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto GERENTE do vale alimentação R$" + (salario * 0.15));
    }
}