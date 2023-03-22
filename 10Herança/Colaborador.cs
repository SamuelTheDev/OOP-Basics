using System;
// Criando a Herança, o colabador tem acesso aos metodos e atributos dele, desde q nao sejam privados
class Colaborador : Pessoa
{
    //Atributos
    private double salario;

    //Construtor
    public Colaborador(string nome, int idade, double salario)
    {
      this.nome = nome;
      this.idade = idade;
      this.salario = salario;

      mensagemPessoa();
      mensagemColaborador();
    }

    //Metodo
    private void mensagemColaborador()
    {
        Console.WriteLine("Salario: " + salario);
    }
}