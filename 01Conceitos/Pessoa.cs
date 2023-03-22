// Classe é um molde > Algo abstrato > Não estou especificando o que a Pessoa é
class Pessoa 
{
 // Atributos > Caracteristicas que pessoas pode ter
 public string? nome;
 public int idade;

 // Métodos/ Funções 
 // Public > Ter acesso em qualquer classe
 // Void > Nulo > Quando não quer armazenar, guardar em uma variável ou fazer um calculo. Somente exibir na tela
 public void mensagem()
 {
    Console.WriteLine("Olá " + nome + "Voce tem " + idade + " anos");
 }
}