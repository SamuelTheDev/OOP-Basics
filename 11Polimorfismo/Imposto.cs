using System;

class Imposto
{
    //Metodos
    // A palavra reservada VIRTUAL no metodo deixa claroq eu pode sofrer possiveis alterações > Ser sobrescrevido
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$" + (salario * 0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$" + (salario * 0.06));
    }
    //As classes que herdarem esses Métodos poderão ter os mesmos alterados por Polimorfismo se algum elemento do método for diferente para a classe Herança especifica
}