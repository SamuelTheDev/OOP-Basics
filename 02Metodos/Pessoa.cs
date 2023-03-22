using System;
// toda classe começa com letra MAIUSCULA
class Pessoa
{
   // MÉTODO 01
   //Parâmentros são passandos no Método em ()
   //Dependendo do parametro se é executado um ou outro
   public void apresentar ()
   {
    Console.WriteLine("Olá");
   }
    // MÉTODO 02
   public void apresentar (string nome)
   {
    Console.WriteLine("Olá " + nome);
   }
    // MÉTODO 03
   public void apresentar (string nome, int idade)
   {
     Console.WriteLine("Olá " + nome + "você tem " + idade + "anos.");
   }
}