class PessoaJuridica : Padrao
{
     //Somos obrigatos a usar o ABSTRATO da classe Padrao // Tenho que utilizar o metodo Herdado colocando minha regra de negocios portanto é override (Sobscrever)
     public override void taxaEmprestimo(double valor)
    {
      Console.WriteLine("Taxa de empréstimo para Pessoa Juridica R$: " + (valor * 0.2));
    }
}