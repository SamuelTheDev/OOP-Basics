using System;

class Pessoa
{
    //atributos // Protected > A classe q cria e a classe que herda pode usar
    protected string nome;
    protected int idade;

    //Metodo
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
          Console.WriteLine("Idade: " + idade);
    }

}